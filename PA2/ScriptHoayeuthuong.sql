go
create database Hoayeuthuong
go 
use Hoayeuthuong

--drop database Hoayeuthuong
go
--Tạo table Đơn hàng
create table DONHANG(
	DH_ID int not null identity(1,1) primary key,
	SDT_DAT char(12) not null,
	TEN_DAT nvarchar(30) null,
	DIACHI_DAT nvarchar(30) not null,
	SDT_NHAN char(12) not null,
	TEN_NHAN nvarchar(30) null,
	DIACHI_NhAN nvarchar(30) not null,
	ANDANH bit not null,
	LOINHAN nvarchar(30) null,
	NOTE nvarchar(30) null,
	XUAT_GTGT float null,
	THOIGIANLAODONG Datetime not null,
	VOUCHER_ID int null,
	PHUPHI money null,
	THOIGIANDATHANG datetime not null,
	TINHTRANG nvarchar(20) not null,
	TONGTIEN money not null
)
go
--Tạo table Khách hàng
create table KHACHHANG(
	KH_ID int not null identity(1,1) primary key,
	KH_TEN nvarchar(30) null,
	KH_EMAIL char(30) null,
	KH_CMND int null,
	KH_DIACHI nvarchar(30) null,
	KH_SDT char(12) not null,
)
go 
--Tạo table Tài Khoản
create table TAIKHOAN(
	TK_ID int not null identity(1,1) primary key,
	TK_USERNAME varchar(20) not null unique,
	TK_PASSWORD char(30) not null,
	TK_STATUS bit not null,
	TK_ROLE int not null,
)
go 
--Tạo table Nhân Viên
create table NHANVIEN(
	NV_ID int not null identity(1,1) primary key,
	NV_TEN nvarchar(20) not null,
	NV_EMAIL char(30) not null,
	NV_CMND int not null,
	NV_DIACHI nvarchar(30) not null,
	NV_SDT int not null,
	NV_LUONGCUNG float null,
)
go
--Tạo table Chi Nhánh 
create table CHINHANH(
	CN_ID int not null identity(1,1) primary key,
	CN_DIACHI nvarchar(30) not null
)
go
--Tạo table Chấm Công 
create table CHAMCONG(
	NGAY datetime not null,
	GIOVAO datetime not null,
	GIORA datetime not null
)
go
--Tạo table Sản Phẩm
create table SANPHAM(
	SP_ID int not null identity(1,1) primary key,
	SP_TEN nvarchar(20) not null,
	SP_GIAGOC float not null,
	SP_GIABAN float not null,
	SP_HINHANH image null,
	SP_STATUS bit not null
)
go
--Tạo table Chi Tiết Đơn Hàng
create table CTDH(
	DH_ID int not null identity(1,1),
	SP_ID int not null identity(1,1),
	SL int not null,
	GIABAN float not null,
	primary key (DH_ID,SP_ID)
)
go
--Tạo table Giỏ Hàng
create table GIOHANG(
	GH_ID int not null identity(1,1) primary key,
)
go
--Tạo table Chi Tiết Giỏ Hàng
create table CTGH(
	GH_ID int not null identity(1,1),
	SP_ID int not null identity(1,1),
	SL int not null,
	primary key(GH_ID,SP_ID)
)
go
--Tạo table Danh Mục Sản Phẩm
create table DM_SP(
	SP_ID int not null identity(1,1),
	DM_ID int not null identity(1,1),
	primary key (SP_ID,DM_ID)
)
go
--Tạo table Danh Mục
create table DANHMUC(
	DM_ID int not null identity(1,1) primary key,
	DM_TEN nvarchar(20) null,
)
go
--Tạo table Danh Mục Chung
create table DANHMUCCHUNG(
	DMCHUNG_ID int not null identity(1,1) primary key,
	DMCHUNG_TEN nvarchar(20) not null
)
go
--Tạo table Voucher
create table VOUCHER(
	VOUCHER_ID int not null identity(1,1) primary key,
	VOUCHER_DK nvarchar(100) null,
	VOUCHER_DISCOUNTPER	float not null,
	VOUCHER_VALIDATED datetime not null,
	USED bit not null,
	VOUCHER_MASUDUNG char(20) not null
)
go
--Tạo table Thanh Toán
create table THANHTOAN(
	TT_ID int not null identity(1,1) primary key,
	THANHTOAN_TYPE bit not null,
	TRANGTHAI nvarchar(10) not null
)

--Tạo khoá ngoại DONHANG.KH_ID -> KHACHHANG.KH_ID
alter table DONHANG
	add constraint FK_DONHANG_KH_ID_KHACHHANG_KH_ID foreign key (KH_ID)
	references KHACHHANG(KH_ID)
go
--Tạo khóa ngoại DONHANG.VOUCHER_ID -> VOUCHER.VOUCHER_ID
alter table DONHANG
	add constraint FK_DONHANG_VOUCHER_ID_VOUCHER_VOUCHER_ID foreign key (VOUCHER_ID)
	references VOUCHER(VOUCHER_ID)
go
--Tạo khóa ngoại DONHANG.TT_ID -> THANHTOAN.TT_ID
alter table DONHANG
	add constraint FK_DONHANG_TT_ID_THANHTOAN_TT_ID foreign key (TT_ID)
	references THANHTOAN(TT_ID)
go
--Tạo khóa ngoại KHACHHANG.TK_ID -> TAIKHOAN.TK_ID
alter table KHACHHANG
	add constraint FK_KHACHHANG_TK_ID_TAIKHOAN_TK_ID foreign key (TK_ID)
	references TAIKHOAN(TK_ID)
go
--Tạo khóa ngoại GIOHANG.KH_ID -> KHACHHANG.KH_ID
alter table GIOHANG
	add constraint FK_GIOHANG_KH_ID_KHACHHANG_KH_ID foreign key (KH_ID)
	references KHACHHANG(KH_ID)
go
--Tạo khóa ngoại CTGH.GH_ID -> GIOHANG.GH_ID
alter table CTGH
	add constraint FK_CTGH_GH_ID_GIOHANG_GH_ID foreign key(GH_ID)
	references GIOHANG(GH_ID)
go
--Tạo khóa ngoại CTGH.SP_ID -> SANPHAM.SP_ID
alter table CTGH
	add constraint FK_CTGH_SP_ID_SANPHAM_SP_ID foreign key(SP_ID)
	references SANPHAM(SP_ID)
go
--Tạo khóa ngoại CTDH.DH_ID -> DONHANG.DH_ID
alter table CTDH
	add constraint FK_CTDH_DH_ID_DONHANG_DH_ID foreign key (DH_ID)
	references DONHANG(DH_ID)
--Tạo khóa ngoại CTDH.SP_ID -> SANPHAM.SP_ID
alter table CTDH
	add constraint FK_CTDH_SP_ID_SANPHAM_SP_ID foreign key (SP_ID)
	references SANPHAM(SP_ID)
go
--Tạo khóa ngoại DM_SP.SP_ID -> SANPHAM.SP_ID
alter table DM_SP
	add constraint FK_DM_SP_SP_ID_SANPHAM_SP_ID foreign key (SP_ID)
	references SANPHAM(SP_ID)
go
--Tạo khóa ngoại DM_SP.DM_ID -> DANHMUC.DM_ID
alter table DM_SP
	add constraint FK_DM_SP_DM_ID_DANHMUC_DM_ID foreign key (DM_ID)
	references DANHMUC(DM_ID)
go
--Tạo khóa ngoại DANHMUC.DMCHUNG_ID -> DANHMUCCHUNG.DMCHUNG_ID
alter table DANHMUC
	add constraint FK_DANHMUC_DMCHUNG_ID_DANHMUCCHUNG_DMCHUNG_ID foreign key(DMCHUNG_ID)
	references DANHMUCCHUNG(DMCHUNG_ID)
go
--Tạo khóa ngoại NHANVIEN.TK_ID -> TAIKHOAN.TK_ID
alter table NHANVIEN
	add constraint FK_NHANVIEN_TK_ID_TAIKHOAN_TK_ID foreign key (TK_ID)
	references TAIKHOAN(TK_ID)
go
--Tạo khóa ngoại CHAMCONG.NV_ID -> NHANVIEN.NV_ID
alter table CHAMCONG
	add constraint FK_CHAMCONG_NV_ID_NHANVIEN_NV_ID foreign key (NV_ID)
	references NHANVIEN(NV_ID)
