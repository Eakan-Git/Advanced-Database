create database HoaYeuThuong
go

use HoaYeuThuong
go

/*==============================================================*/
/* Table: CHINHANH                                              */
/*==============================================================*/
create table CHINHANH 
(
   CN_ID                integer identity(1,1)          not null,
   CN_TEN               nvarchar(50)                   not null,
   CN_DIACHI            nvarchar(50)                   not null
);

alter table CHINHANH
   add constraint PK_CHINHANH primary key (CN_ID);

/*==============================================================*/
/* Table: CHITIETDONHANG                                        */
/*==============================================================*/
create table CHITIETDONHANG 
(
   ID_DH                integer                        not null,
   SP_ID                integer                        not null,
   SOLUONG              integer                        not null,
   GIABAN               money		                   not null
);

alter table CHITIETDONHANG
   add constraint PK_CHITIETDONHANG primary key clustered (ID_DH, SP_ID);

/*==============================================================*/
/* Table: CHITIETGIOHANG                                        */
/*==============================================================*/
create table CHITIETGIOHANG 
(
   TK_ID                integer                        not null,
   SP_ID                integer                        not null,
   SOLUONG              integer                        not null
);

alter table CHITIETGIOHANG
   add constraint PK_CHITIETGIOHANG primary key clustered (TK_ID, SP_ID);

/*==============================================================*/
/* Table: DONHANG                                               */
/*==============================================================*/
create table DONHANG 
(
   ID_DH                integer identity(1,1)          not null,
   VOUCHER_ID           integer                        null,
   TK_ID                integer                        not null,
   SDT_DAT              char(10)                       not null,
   TEN_DAT              nvarchar(50)                   not null,
   DIACHI_DAT           nvarchar(50)                   not null,
   SDT_NHAN             char(10)                       not null,
   TEN_NHAN             nvarchar(50)                   not null,
   DIACHI_NHAN          nvarchar(50)                   not null,
   ANDANH               bit							   not null,
   LOINHAN              nvarchar(100)                  null,
   NOTE                 nvarchar(100)                  null,
   XUAT_GTGT            bit						       not null,
   PHUPHI               money						   not null,
   THOIGIANDATHANG      date                           not null,
   THOIGIANNHANHANG     date                           not null,
   TINHTRANG            nvarchar(50)                   not null,
   TONGTIEN             money						   not null
);

alter table DONHANG
   add constraint PK_DONHANG primary key (ID_DH);

/*==============================================================*/
/* Table: KHACHHANG                                             */
/*==============================================================*/
create table KHACHHANG 
(
   TK_ID                integer                        not null
);

alter table KHACHHANG
   add constraint PK_KHACHHANG primary key clustered (TK_ID);

/*==============================================================*/
/* Table: NHANVIEN                                              */
/*==============================================================*/
create table NHANVIEN 
(
   TK_ID                integer                        not null,
   CN_ID                integer                        not null
);

alter table NHANVIEN
   add constraint PK_NHANVIEN primary key clustered (TK_ID);

/*==============================================================*/
/* Table: SANPHAM                                               */
/*==============================================================*/
create table SANPHAM 
(
   SP_ID                integer identity(1,1)       not null,
   SP_TEN				nvarchar(50)                not null,
   SP_GIAGOC            float                       not null,
   SP_GIABAN            float                       not null,
   SP_HINHANH           image						null,
   SP_MOTA			    nvarchar(100)               null,
   SP_STATUS            bit                         not null
);

alter table SANPHAM
   add constraint PK_SANPHAM primary key (SP_ID);

/*==============================================================*/
/* Table: TAIKHOAN                                              */
/*==============================================================*/
create table TAIKHOAN 
(
   TK_ID                integer identity(1,1)          not null,
   TK_USERNAME          varchar(30)                    not null,
   TK_PASSWORD          varchar(30)                       not null,
   TK_STATUS            bit							   not null,
   TK_ROLE              integer                        not null,
   TK_EMAIL             varchar(50)                    null,
   TK_CMND              char(9)                        null,
   TK_DIACHI            nvarchar(50)                   not null,
   TK_SDT               char(10)                       not null
);

alter table TAIKHOAN
   add constraint PK_TAIKHOAN primary key (TK_ID);

/*==============================================================*/
/* Table: THANHTOAN                                             */
/*==============================================================*/
create table THANHTOAN 
(
   TT_ID                integer identity(1,1)     not null,
   ID_DH                integer                   not null,
   THANHTOAN_TYPE       bit                       not null,
   TRANGTHAI            bit                       not null
);

alter table THANHTOAN
   add constraint PK_THANHTOAN primary key (TT_ID);

/*==============================================================*/
/* Table: VOUCHER                                               */
/*==============================================================*/
create table VOUCHER 
(
   VOUCHER_ID           integer identity(1,1)          not null,
   VOUCHER_PERCENT      float                          not null,
   VOUCHER_VALIDATED    date                           not null,
   USED                 bit						       not null,
   VOUCHER_MASUDUNG     varchar(20)                    not null
);

alter table VOUCHER
   add constraint PK_VOUCHER primary key (VOUCHER_ID);

alter table CHITIETDONHANG
   add constraint FK_CHITIETD_CHITIETDO_DONHANG foreign key (ID_DH)
      references DONHANG (ID_DH)

alter table CHITIETDONHANG
   add constraint FK_CHITIETD_CHITIETDO_SANPHAM foreign key (SP_ID)
      references SANPHAM (SP_ID)

alter table CHITIETGIOHANG
   add constraint FK_CHITIETG_CHITIETGI_KHACHHAN foreign key (TK_ID)
      references KHACHHANG (TK_ID)

alter table CHITIETGIOHANG
   add constraint FK_CHITIETG_CHITIETGI_SANPHAM foreign key (SP_ID)
      references SANPHAM (SP_ID)

alter table DONHANG
   add constraint FK_DONHANG_DONHANG_V_VOUCHER foreign key (VOUCHER_ID)
      references VOUCHER (VOUCHER_ID)

alter table DONHANG
   add constraint FK_DONHANG_KHACHHANG_KHACHHAN foreign key (TK_ID)
      references KHACHHANG (TK_ID)

alter table KHACHHANG
   add constraint FK_KHACHHAN_INCLUDE2_TAIKHOAN foreign key (TK_ID)
      references TAIKHOAN (TK_ID)

alter table NHANVIEN
   add constraint FK_NHANVIEN_CHINHANH__CHINHANH foreign key (CN_ID)
      references CHINHANH (CN_ID)

alter table NHANVIEN
   add constraint FK_NHANVIEN_INCLUDE_TAIKHOAN foreign key (TK_ID)
      references TAIKHOAN (TK_ID)

alter table THANHTOAN
   add constraint FK_THANHTOA_DONHANG_T_DONHANG foreign key (ID_DH)
      references DONHANG (ID_DH)

