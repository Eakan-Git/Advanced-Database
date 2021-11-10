create database csdlnc_pa1
go

use csdlnc_pa1
go

/*==============================================================*/
/* Table: KHACHHANG                                             */
/*==============================================================*/
create table KHACHHANG (
   MakH                char(10)						not null,
   Ho				   nvarchar(30)					not null,
   Ten                 nvarchar(30)					not null,
   Ngsinh              date								null,
   SoNha			   char(20)						not null,	
   Duong			   nvarchar(30)					not null,
   Phuong			   nvarchar(30)						null,
   Quan			       nvarchar(20)					not null,
   TPho			       nvarchar(30)					not null,
   DienThoai		   char(12)					    not null,
   constraint PK_KHACHHANG primary key (MakH)
)
go

/*==============================================================*/
/* Table: HOADON                                                */
/*==============================================================*/
create table HOADON (
   MaHD                char(10)						not null,
   MaKH				   char(10)						not null,
   NgayLap             date							not null,
   TongTien            money						not null,
   constraint PK_HOADON primary key (MaHD)
)
go

/*==============================================================*/
/* Table: CT_HOADON                                             */
/*==============================================================*/
create table CT_HOADON (
   MaHD                char(10)						not null,
   MaSP				   char(8)						not null,
   SoLuong             int							not null,
   GiaBan              money						not null check (GiaBan > 0),
   GiaGiam			   money						not null default 0 check (GiaGiam >= 0),	
   ThanhTien		   money						not null,
   constraint PK_CT_HOADON primary key (MaHD, MaSP)
)
go

/*==============================================================*/
/* Table: SANPHAM                                               */
/*==============================================================*/
create table SANPHAM (
   MaSP                char(8)							not null,
   TenSP			   nvarchar(30)						not null,
   SoLuongTon          int								not null check (SoLuongTon >= 0),
   Mota				   nvarchar(50)							null,
   Gia				   money							not null check (Gia > 0),	
   constraint PK_SANPHAM primary key (MaSP)
)
go

/*Foreign key*/
alter table dbo.HOADON
   add constraint FK_HOADON_CUA_KHACHHANG foreign key (MaKH)
      references KHACHHANG (MaKH)
go

alter table dbo.CT_HOADON 
   add constraint FK_CT_MA_HOADON foreign key (MaHD)
      references HOADON (MaHD)
go

alter table dbo.CT_HOADON 
   add constraint FK_SANPHAM_TRONG_HOADON foreign key (MaSP)
      references SANPHAM (MaSP)
go

/*Function*/
--
--CTHD = (Số lượng * (Giá bán-Giá giảm))
--
create function fn_ThanhTienCTHD (@SoLuong int, @GiaBan MONEY, @GiaGiam MONEY)
returns money
BEGIN
	IF EXISTS (SELECT (@GiaBan-@GiaGiam) WHERE  (@GiaBan-@GiaGiam) < 0)
		begin
			RETURN 0
		END
	RETURN (SELECT @SoLuong*(@GiaBan-@GiaGiam))
END
go

--
--Create function: Giá bán sp tại thời điểm bán = giá gốc sản phẩm + @giá trị tăng/giảm
--
create function fn_GiaBanSP (@MaSP char(8), @GiaTriTang money)
returns money
BEGIN
	RETURN (SELECT SANPHAM.Gia + @GiaTriTang from SANPHAM where SANPHAM.MaSP = @MaSP)
END
go

--
--Creat function: Tổng tiền trong Hóa Đơn
--
create function fn_TongTienHD (@MaHD char(10))
returns money
BEGIN
	IF NOT EXISTS (SELECT * FROM CT_HOADON WHERE CT_HOADON.MaHD = @MaHD)
	RETURN 0
	RETURN (SELECT sum(CT_HOADON.ThanhTien) from CT_HOADON where CT_HOADON.MaHD = @MaHD GROUP BY CT_HOADON.MaHD)
END
go

/*Trigger*/
/* Thành tiền CTHD: CTHD = (Số lượng * (Giá bán-Giá giảm))
					T	X	S
CT_HOADON:			-	-	+(Số lượng, giá bán, giá giảm)
*/
create trigger trg_CTHD_Update_SL on dbo.CT_HOADON
for update
as
begin
	if exists (select I.SoLuong from Inserted I
		where I.SoLuong <= 0)
	begin
		raiserror(N'Số lượng sản phẩm được update không hợp lệ.', 15, 1)
		rollback transaction
	end
end

create trigger trg_CTHD_Update_Gia on dbo.CT_HOADON
for update
as
begin
	if exists (select I.GiaBan, I.GiaGiam from Inserted I
		where I.GiaBan <= 0 or I.GiaGiam < 0)
	begin
		raiserror(N'Giá sản phẩm được update không hợp lệ.', 15, 1)
		rollback transaction
	end
end

create trigger trg_CTHD on dbo.CT_HOADON
for update
as
begin 
	--với mỗi lần cập nhật số lượng, giá bán hay giá giảm thì thành tiền sẽ được cập nhật lại
	update dbo.CT_HOADON 
	set dbo.CT_HOADON.ThanhTien = dbo.fn_ThanhTienCTHD((SELECT Inserted.SoLuong from Inserted), 
										(SELECT Inserted.GiaBan from Inserted), 
										(SELECT Inserted.GiaGiam from Inserted))
	WHERE (SELECT Inserted.maHD FROM inserted) = dbo.CT_HOADON.MaHD 
	AND (SELECT Inserted.maSp FROM inserted) = dbo.CT_HOADON.MaSP
end
go

/* Tổng tiền (mahd) = sum (ThanhTien) cthd(mahd)
					T	X	S
CT_HOADON:			+	+	+
*/
create trigger trg_Them_CTHD on dbo.CT_HOADON
after insert
as
begin 
	update dbo.HOADON 
	set dbo.HOADON.TongTien = dbo.HOADON.TongTien + (select(ThanhTien) from Inserted where Inserted.MaHD = dbo.HOADON.MaHD)
end
go

create trigger trg_XOA_CTHD on dbo.CT_HOADON
after delete
as
begin 
	update dbo.HOADON 
	set dbo.HOADON.TongTien = dbo.HOADON.TongTien - (select(ThanhTien) from deleted where deleted.MaHD = dbo.HOADON.MaHD)
end
go

create trigger trg_TongTien_HD on dbo.CT_HOADON
for update
as
begin 
	update dbo.HOADON 
	set dbo.HOADON.TongTien = dbo.fn_TongTienHD(inserted.MaHD) from inserted
end
go

--select * from CT_HOADON
-- cau a: cac hoa don lap trong nam 2020
SELECT * 
FROM HoaDon hd 
WHERE YEAR(hd.NgayLap) = 2020
--cau b: cac khach hang o TPHCM
SELECT *
FROM KhachHang kh 
WHERE kh.Tpho LIKE  N'Hồ Chí Minh'
--cau c: cac san pham co gia tu … den …	
SELECT *
FROM SanPham sp
WHERE sp.Gia between 100 and 9000
--cau d: cac san pham co so luong ton kho <100
SELECT *
FROM SanPham sp
WHERE sp.SoLuongTon < 100
-- cau e: san pham co so luong ban ra nhieu nhat:
SELECT ct1.MASP, sp.TENSP 
FROM CT_HoaDon ct1, HOADON hd1, SANPHAM sp 
WHERE ct1.MAHD = hd1.MAHD and sp.MASP = ct1.MASP GROUP BY ct1.MASP, sp.TENSP HAVING sum(ct1.SoLuong) >= ALL ( SELECT sum(ct.SoLuong) FROM CT_HoaDon ct, HOADON hd WHERE ct.MAHD = hd.MAHD GROUP BY ct.MASP ) 
-- cau f: sản phẩm có doanh thu cao nhất 
SELECT ct1.MASP, sp.TENSP 
FROM CT_HoaDon ct1, HOADON hd1, SANPHAM sp 
WHERE ct1.MAHD = hd1.MAHD and sp.MASP = ct1.MASP GROUP BY ct1.MASP, sp.TENSP HAVING sum(ct1.GiaBan*ct1.SoLuong) >= ALL ( SELECT sum(ct.GiaBan*ct.SoLuong) FROM CT_HoaDon ct, HOADON hd WHERE ct.MAHD = hd.MAHD GROUP BY ct.MASP )
