create database csdlnc_pa1
go

USE csdlnc_pa1
GO

/*==============================================================*/
/* Table: KHACHHANG                                             */
/*==============================================================*/
CREATE TABLE KHACHHANG (
   MakH                CHAR(10)						NOT NULL,
   Ho				   NVARCHAR(30)					NOT NULL,
   Ten                 NVARCHAR(30)					NOT NULL,
   Ngsinh              DATE								NULL,
   SoNha			   CHAR(20)						NOT NULL,	
   Duong			   NVARCHAR(30)					NOT NULL,
   Phuong			   NVARCHAR(30)						NULL,
   Quan			       NVARCHAR(20)					NOT NULL,
   TPho			       NVARCHAR(30)						NULL,
   DienThoai		   CHAR(12)					    NOT NULL,
   CONSTRAINT PK_KHACHHANG PRIMARY KEY (MakH)
)
GO

/*==============================================================*/
/* Table: HOADON                                                */
/*==============================================================*/
CREATE TABLE HOADON (
   MaHD                CHAR(10)						NOT NULL,
   MaKH				   CHAR(10)						NOT NULL,
   NgayLap             DATE							NOT NULL,
   TongTien            MONEY							NULL,
   CONSTRAINT PK_HOADON PRIMARY KEY (MaHD)
)
GO

/*==============================================================*/
/* Table: CT_HOADON                                             */
/*==============================================================*/
CREATE TABLE CT_HOADON (
   MaHD                CHAR(10)						NOT NULL,
   MaSP				   CHAR(8)						NOT NULL,
   SoLuong             INT							NOT NULL,
   GiaBan              MONEY						NOT NULL CHECK (GiaBan > 0),
   GiaGiam			   MONEY						NOT NULL DEFAULT 0 CHECK (GiaGiam >= 0),	
   ThanhTien		   MONEY							NULL,
   CONSTRAINT PK_CT_HOADON PRIMARY KEY (MaHD, MaSP)
)
GO

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
