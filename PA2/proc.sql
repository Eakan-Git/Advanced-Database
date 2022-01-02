USE Hoayeuthuong
go
create or alter proc checkTK
@username varchar(30),
@password char(30)
as
begin
       if exists(select TK_ID from TAIKHOAN where TK_USERNAME=@username and TK_PASSWORD=@password and TK_STATUS=1)
            begin
                select TK_ID, TK_ROLE from TAIKHOAN where TK_USERNAME=@username and TK_PASSWORD=@password
            end
       else
			begin
				print('Not existed or being locked')
				return
			end
end

go
create or alter proc checklistDangGiao
@offset int,
@fetch int
as
select ID_DH as N'Mã Đơn', SDT_NHAN as N'SĐT Nhận', TEN_NHAN as N'Tên Người Nhận', 
DIACHI_NHAN N'Địa Chỉ Người Nhận', XUAT_GTGT as 'Xuất GTGT', THOIGIANDATHANG as N'Ngày Đặt', GIAGIAM as N'Giá Giảm', PHUPHI as N'Phụ Phí', THANHTIEN as N'Thành Tiền' 
from DONHANG where TINHTRANG=N'Đang Giao'
order by THOIGIANDATHANG ASC
OFFSET @offset rows
fetch next @fetch rows only;

go 

create or alter proc checklistDangXuLy
@offset int,
@fetch int
as
select ID_DH as N'Mã Đơn', SDT_NHAN as N'SĐT Nhận', TEN_NHAN as N'Tên Người Nhận', 
DIACHI_NHAN N'Địa Chỉ Người Nhận', XUAT_GTGT as 'Xuất GTGT', THOIGIANDATHANG as N'Ngày Đặt', GIAGIAM as N'Giá Giảm', PHUPHI as N'Phụ Phí', THANHTIEN as N'Thành Tiền' 
from DONHANG where TINHTRANG=N'Đang Xử Lí'
order by THOIGIANDATHANG ASC
OFFSET @offset rows
fetch next @fetch rows only;

exec checklistDangGiao 0, 20
exec checklistDangXuLy 0, 20

--update DONHANG SET THOIGIANNHANHANG = null WHERE TINHTRANG != N'Đã giao'
--update THANHTOAN set TRANGTHAI = 1 WHERE ID_DH in (SELECT ID_DH FROM DONHANG WHERE TINHTRANG = N'Đang giao') and THANHTOAN_TYPE = 1

--select * from DONHANG where ID_DH = 147
go
create or alter proc updateProfile
@ten nvarchar(50),
@sdt char(10),
@diachi nvarchar(50),
@email varchar(30),
@id int
as
begin tran
        if exists(select* from TAIKHOAN where TK_SDT=@sdt and TK_ID != @id)
            begin 
                raiserror(N'Số điện thoại này đã tồn tại',0,1);
                commit
                return -1
            end
        if exists(select * from TAIKHOAN where TK_EMAIL=@email and TK_ID != @id)
            begin
                raiserror(N'Địa chỉ email này đã tồn tại',0,1);
                commit
                return -1
            end
        else
            begin
                update TAIKHOAN
                set HOTEN = @ten, TK_SDT= @sdt, TK_DIACHI = @diachi, TK_EMAIL = @email
                where TK_ID = @id
                commit 
            end
go

create or alter proc xemThongTinSanPhamKhongHinhAnh
@offset int,
@rows int
as
begin
	select SP_ID as N'Mã Số', SP_TEN as N'Tên Sản Phẩm', SP_GIAGOC as N'Giá Gốc', SP_GIABAN as N'Giá Bán', SP_STATUS as N'Đang Kinh Doanh'
	from SANPHAM
	order by SP_ID
	offset @offset rows
	fetch next @rows rows only
end

--exec xemThongTinSanPhamKhongHinhAnh 0, 10
go
create or alter proc xemThongTinSanPham
@ID int
as
begin
	select SP_ID, SP_TEN, SP_MOTA, SP_GIAGOC, SP_GIABAN, SP_HINHANH
	from SANPHAM
	where SP_ID = @ID
end

--exec xemThongTinSanPham 12
go
create or alter proc SuaSP
@SP_ID int,
@SP_TEN nvarchar(30),
@SP_GIAGOC float,
@SP_GIABAN float,
@SP_HINHANH image,
@SP_MOTA nvarchar(100)
as
begin
    update SANPHAM
    set SP_TEN=@SP_TEN,SP_GIAGOC=@SP_GIAGOC,SP_GIABAN=@SP_GIABAN,SP_HINHANH=@SP_HINHANH,SP_MOTA=@SP_MOTA
    where SP_ID=@SP_ID
end

--select * from TAIKHOAN
go
create or alter proc ThemSP
@SP_TEN nvarchar(30),
@SP_GIAGOC float,
@SP_GIABAN float,
@SP_HINHANH image,
@SP_MOTA nvarchar(100),
@SP_STATUS bit
as
begin
       insert into SANPHAM(SP_TEN,SP_GIAGOC,SP_GIABAN,SP_HINHANH,SP_MOTA,SP_STATUS)
       values (@SP_TEN, @SP_GIAGOC, @SP_GIABAN, @SP_HINHANH,@SP_MOTA, @SP_STATUS)
end
go

create or alter proc nvTimSP
@SP_TEN nvarchar(50)
as
begin
	select SP_ID as N'Mã Số', SP_TEN as N'Tên Sản Phẩm', SP_GIAGOC as N'Giá Gốc', SP_GIABAN as N'Giá Bán', SP_STATUS as N'Đang Kinh Doanh'
	from SANPHAM
	where SP_TEN like '%' + @SP_TEN + '%'
end

--exec nvTimSP 'Eakan'
go

--select * from TAIKHOAN
create or alter proc xemDanhSachNhanVien
@offset int,
@rows int
as
begin
	select TK.TK_ID as N'Mã Số', HOTEN as N'Họ Và Tên', CN.CN_DIACHI as N'Chi Nhánh', TK_CMND as N'CMND', TK_SDT as N'Số Điện Thoại', TK_STATUS as N'Hoạt Động'
	from TAIKHOAN TK, NHANVIEN NV, CHINHANH CN
	where TK.TK_ID = NV.TK_ID and NV.CN_ID = CN.CN_ID and TK.TK_ROLE = 1
	order by TK.TK_ID
	offset @offset rows
	fetch next @rows rows only
end
go
--exec xemDanhSachNhanVien 0, 10

create or alter proc xemThongTinNhanVien
@ID int
as
begin
	select tk.TK_ID, HOTEN, nv.CN_ID, TK_SDT, TK_DIACHI, TK_EMAIL, TK_CMND
	from TAIKHOAN tk, NHANVIEN nv
	where tk.TK_ID = @ID and tk.TK_ID = nv.TK_ID
end

go
--exec xemThongTinNhanVien 500

--select CN_ID, CN_DIACHI from CHINHANH where CN_ID = 1
create or alter proc timKiemNhanVien
@CMND char(9)
as
begin
	select TK.TK_ID as N'Mã Số', HOTEN as N'Họ Và Tên', CN.CN_DIACHI as N'Chi Nhánh', TK_CMND as N'CMND', TK_SDT as N'Số Điện Thoại', TK_STATUS as N'Hoạt Động'
	from TAIKHOAN TK, NHANVIEN NV, CHINHANH CN
	where TK.TK_ID = NV.TK_ID and NV.CN_ID = CN.CN_ID and TK.TK_CMND = @CMND and TK.TK_ROLE = 1
end
go
--exec timKiemNhanVien 372061574

create or alter proc updateNV
@ID int,
@HOTEN nvarchar(50),
@SDT char(10),
@DIACHI nvarchar(50),
@EMAIL varchar(50),
@CMND char(9),
@CN_ID int
as
begin
	update TAIKHOAN set HOTEN=@HOTEN,TK_SDT=@SDT,TK_DIACHI=@DIACHI,TK_EMAIL=@EMAIL,TK_CMND=@CMND
	where TK_ID = @ID
	update NHANVIEN set CN_ID = @CN_ID
	where TK_ID = @ID
end

go
create or alter proc khachHangXemSP
@offset int,
@rows int
as
begin
	select SP_TEN as N'Tên Sản Phẩm', SP_GIABAN as N'Giá', SP_MOTA as N'Mô Tả'
	from SANPHAM
	where SP_STATUS = 1
	order by SP_TEN
	offset @offset rows
	fetch next @rows rows only
end
go
--exec khachHangXemSP 0, 10
--select * from TAIKHOAN

create or alter proc khachHangXemSP_CoHinh
@SP_TEN nvarchar(50)
as
begin
	select SP_TEN, SP_GIAGOC, SP_GIABAN, SP_MOTA, SP_HINHANH
	from SANPHAM
	where SP_TEN = @SP_TEN
end
go

create or alter proc khachHangXemSP_CoHinh_TrongCart
@SP_TEN nvarchar(50)
as
begin
	select SP_TEN, SP_GIABAN, SP_HINHANH
	from SANPHAM
	where SP_TEN = @SP_TEN
end
go

create or alter proc khachHangTimSP
@SP_TEN nvarchar(50)
as
begin
	select SP_TEN as N'Tên Sản Phẩm', SP_GIAGOC as N'Giá Gốc',SP_GIABAN as N'Giá', SP_MOTA as N'Mô Tả'
	from SANPHAM
	where SP_STATUS = 1
	and SP_TEN like '%' + @SP_TEN + '%'
end
go

create or alter proc top10product
as
select top(10) SANPHAM.SP_TEN as N'Tên Sản Phẩm', SP_GIAGOC as N'Giá Gốc',SP_GIABAN as N'Giá', SP_MOTA as N'Mô Tả', sum(SOLUONG) as N'Đã Bán'
from CHITIETDONHANG join SANPHAM
on CHITIETDONHANG.SP_ID = SANPHAM.SP_ID
where SP_STATUS = 1
group by SANPHAM.SP_TEN, SP_GIAGOC, SP_GIABAN, SP_MOTA
order by sum(SOLUONG) DESC
go
--exec top10product

create or alter proc taoAccKhachHang
@username varchar(30),
@password varchar(30),
@hoten nvarchar(50),
@email varchar(50),
@cmnd char(9),
@diachi nvarchar(50),
@sdt char(10)
as
begin
	declare @TK_ID int
	insert into TAIKHOAN(TK_USERNAME,TK_PASSWORD,HOTEN, TK_STATUS, TK_ROLE,TK_EMAIL,TK_CMND,TK_DIACHI,TK_SDT) 
	values (@username,@password,@hoten,1,0,@email,@cmnd,@diachi,@sdt)
	set @TK_ID = (select TK_ID from TAIKHOAN where TK_SDT = @sdt)
	insert into KHACHHANG(TK_ID)
	values(@TK_ID)
end
go

create or alter proc KH_XemChiTiet_GH
@taikhoanid int
as
begin
    select SP_Ten as N'Tên Sản Phẩm',SP_GIABAN as N'Giá Bán',CHITIETGIOHANG.SOLUONG  as N'Số Lượng'
	from SANPHAM join CHITIETGIOHANG 
	on SANPHAM.SP_ID=CHITIETGIOHANG.SP_ID and CHITIETGIOHANG.TK_ID=@taikhoanid
end
go

--exec KH_XemChiTiet_GH 12
---------------------------------------------------------------
create or alter proc KH_Them_SP_Vao_GH
@TK_ID int,
@SP_TEN nvarchar(50)
as
begin
	declare @SP_ID int
	set @SP_ID = (select SP_ID from SANPHAM where SP_TEN = @SP_TEN)
	insert into CHITIETGIOHANG(TK_ID, SP_ID, SOLUONG)
	values (@TK_ID, @SP_ID, 1)
end
go
--exec KH_Them_SP_Vao_GH 10003, N'100% yêu em'
--insert into CHITIETGIOHANG(TK_ID, SP_ID, SOLUONG)
--	values (10002, 1, 1)
create or alter proc KiemTra_SP_GH
@TK_ID int,
@SP_TEN nvarchar(50)
as
begin
	declare @SP_ID int
	set @SP_ID = (select SP_ID from SANPHAM where SP_TEN = @SP_TEN)
	select SP_ID
	from CHITIETGIOHANG where SP_ID = @SP_ID and TK_ID = @TK_ID
end
go
--exec KiemTra_SP_GH 10003, N'100% yêu em'
--select * from TAIKHOAN

create or alter proc KH_XemDanhSach_DH
@TK_ID int
as
begin
	select ID_DH as N'Mã Đơn', TEN_DAT as N'Người Đặt', TEN_NHAN as N'Người Nhận', THOIGIANDATHANG as N'Ngày Đặt', THOIGIANNHANHANG as N'Ngày Nhận', TINHTRANG as N'Tình Trạng', THANHTIEN as N'Thành Tiền'
	from DONHANG where TK_ID = @TK_ID
end
--exec KH_XemDanhSach_DH 1
go
create OR ALTER proc ThanhTien_GioHang
@KH_ID int
as 
BEGIN
declare @GioHangTongTien MONEY
SET @GioHangTongTien = (SELECT SUM(sp.SP_GIABAN*gh.SOLUONG) FROM SANPHAM sp JOIN CHITIETGIOHANG gh ON sp.SP_ID = gh.SP_ID WHERE gh.TK_ID = @KH_ID)
RETURN @GioHangTongTien
END
GO
--Test
create or alter proc ThanhTien_GioHang_Run
@ID int
as
begin
	DECLARE @return_value int
	EXEC @return_value  = ThanhTien_GioHang @ID
	SELECT    'ThanhTien' = @return_value
end
--exec ThanhTien_GioHang_Run 1
go

create or alter proc updatesoluongSPGH
@tkid int,
@ten nvarchar(50),
@soluong int
as
begin
	declare @spid int
	set @spid = (select SP_ID from SANPHAM where SP_TEN = @ten)
	update CHITIETGIOHANG
	set SOLUONG=@soluong
	where TK_ID=@tkid and SP_ID=@spid
end
go

create or alter proc xoasanphamGH
@tkid int,
@ten nvarchar(50)
as
begin
	declare @spid int
	set @spid = (select SP_ID from SANPHAM where SP_TEN = @ten)
	delete from CHITIETGIOHANG where TK_ID=@tkid and SP_ID=@spid
end
--select * from DONHANG
go
create or alter proc KH_Xem_DH
@ID_DH int
as
begin
	select dh.*, tt.THANHTOAN_TYPE, tt.TRANGTHAI from DONHANG dh, THANHTOAN tt
	where dh.ID_DH = @ID_DH and dh.ID_DH = tt.ID_DH
end
go
--exec KH_Xem_DH 14667

create or alter proc NV_XemDanhSach_KH
@offset int,
@rows int
as
begin
	select TK.TK_ID as N'Mã Số', HOTEN as N'Họ Và Tên', TK_SDT as N'Số Điện Thoại', TK_CMND as N'CMND',TK_STATUS as N'Hoạt Động'
	from TAIKHOAN TK, KHACHHANG KH
	where TK.TK_ID = KH.TK_ID and TK.TK_ROLE = 0
	order by TK.TK_ID
	offset @offset rows
	fetch next @rows rows only
end
go
--exec NV_XemDanhSach_KH 10, 10

create or alter proc NV_XemThongTin_KH
@ID int
as
begin
	select TK_ID, HOTEN, TK_SDT, TK_DIACHI, TK_EMAIL, TK_CMND
	from TAIKHOAN
	where TK_ID = @ID and TK_ROLE = 0
end
go

--exec NV_XemThongTin_KH 501

create or alter proc timKiemKhachHang
@SDT char(10)
as
begin
	select TK.TK_ID as N'Mã Số', HOTEN as N'Họ Và Tên', TK_SDT as N'Số Điện Thoại', TK_CMND as N'CMND',TK_STATUS as N'Hoạt Động'
	from TAIKHOAN TK, KHACHHANG KH
	where TK.TK_ID = KH.TK_ID and TK.TK_ROLE = 0 and TK_SDT = @SDT
end
go
--exec timKiemNhanVien 372061574

create or alter proc updateKH
@ID int,
@HOTEN nvarchar(50),
@SDT char(10),
@DIACHI nvarchar(50),
@EMAIL varchar(50),
@CMND char(9)
as
begin
	update TAIKHOAN set HOTEN=@HOTEN,TK_SDT=@SDT,TK_DIACHI=@DIACHI,TK_EMAIL=@EMAIL,TK_CMND=@CMND
	where TK_ID = @ID
end
go

create or alter proc checklistDH
@offset int,
@fetch int,
@TINHTRANG nvarchar(50)
as
begin
	select ID_DH as N'Mã Đơn', SDT_DAT as N'SĐT Đặt', TEN_DAT as N'Người Đặt', THOIGIANDATHANG as N'Ngày Đặt', THOIGIANNHANHANG as N'Ngày Nhận', THANHTIEN as N'Thành Tiền'
	from DONHANG where TINHTRANG=@TINHTRANG
	order by ID_DH
	OFFSET @offset rows
	fetch next @fetch rows only
end
go
--exec checklistDH 0, 10, N'Đang giao'

create or alter proc NV_TimKiem_DH_Theo_SDTDAT
@SDT char(10)
as
begin
	select ID_DH as N'Mã Đơn', SDT_DAT as N'SĐT Đặt', TEN_DAT as N'Người Đặt', THOIGIANDATHANG as N'Ngày Đặt', THOIGIANNHANHANG as N'Ngày Nhận', TINHTRANG as N'Tình Trạng',THANHTIEN as N'Thành Tiền'
	from DONHANG where SDT_DAT = @SDT
end
go
--exec NV_TimKiem_DH_Theo_SDTDAT '015489628 '

--select * from TAIKHOAN

create or alter proc Xem_SP_DH
@ID_DH int
as
begin
	select tk.HOTEN,tk.TK_SDT
	from DONHANG dh, TAIKHOAN tk
	where dh.ID_DH = @ID_DH and tk.TK_ID = dh.TK_ID

	select ctdh.SP_ID as N'Mã Sản Phẩm',sp.SP_TEN as N'Tên Sản Phẩm', ctdh.GIABAN as N'Giá',ctdh.SOLUONG as N'Số Lượng', ctdh.TONGTIEN as N'Tổng Tiền'
	from DONHANG dh, CHITIETDONHANG ctdh, SANPHAM sp
	where dh.ID_DH = @ID_DH and dh.ID_DH = ctdh.ID_DH and ctdh.SP_ID = sp.SP_ID
end

--exec Xem_SP_DH 68