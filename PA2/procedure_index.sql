/*==============================================================*/
/* DBMS name:      Sybase SQL Anywhere 12                       */
/* Created on:     12/30/2021 11:02:55 PM                       */
/*==============================================================*/


drop procedure if exists CHINHANH_DELETEPROCEDURE;

drop procedure if exists CHINHANH_INSERTPROCEDURE;

drop procedure if exists CHINHANH_SELECTPROCEDURE;

drop procedure if exists CHINHANH_UPDATEPROCEDURE;

drop procedure if exists CHITIETDONHANG_DELETEPROCEDURE;

drop procedure if exists CHITIETDONHANG_INSERTPROCEDURE;

drop procedure if exists CHITIETDONHANG_SELECTPROCEDURE;

drop procedure if exists CHITIETDONHANG_UPDATEPROCEDURE;

drop procedure if exists CHITIETGIOHANG_DELETEPROCEDURE;

drop procedure if exists CHITIETGIOHANG_INSERTPROCEDURE;

drop procedure if exists CHITIETGIOHANG_SELECTPROCEDURE;

drop procedure if exists CHITIETGIOHANG_UPDATEPROCEDURE;

drop procedure if exists DONHANG_DELETEPROCEDURE;

drop procedure if exists DONHANG_INSERTPROCEDURE;

drop procedure if exists DONHANG_SELECTPROCEDURE;

drop procedure if exists DONHANG_UPDATEPROCEDURE;

drop procedure if exists KHACHHANG_DELETEPROCEDURE;

drop procedure if exists KHACHHANG_INSERTPROCEDURE;

drop procedure if exists KHACHHANG_SELECTPROCEDURE;

drop procedure if exists KHACHHANG_UPDATEPROCEDURE;

drop procedure if exists NHANVIEN_DELETEPROCEDURE;

drop procedure if exists NHANVIEN_INSERTPROCEDURE;

drop procedure if exists NHANVIEN_SELECTPROCEDURE;

drop procedure if exists NHANVIEN_UPDATEPROCEDURE;

drop procedure if exists SANPHAM_DELETEPROCEDURE;

drop procedure if exists SANPHAM_INSERTPROCEDURE;

drop procedure if exists SANPHAM_SELECTPROCEDURE;

drop procedure if exists SANPHAM_UPDATEPROCEDURE;

drop procedure if exists TAIKHOAN_DELETEPROCEDURE;

drop procedure if exists TAIKHOAN_INSERTPROCEDURE;

drop procedure if exists TAIKHOAN_SELECTPROCEDURE;

drop procedure if exists TAIKHOAN_UPDATEPROCEDURE;

drop procedure if exists THANHTOAN_DELETEPROCEDURE;

drop procedure if exists THANHTOAN_INSERTPROCEDURE;

drop procedure if exists THANHTOAN_SELECTPROCEDURE;

drop procedure if exists THANHTOAN_UPDATEPROCEDURE;

drop procedure if exists VOUCHER_DELETEPROCEDURE;

drop procedure if exists VOUCHER_INSERTPROCEDURE;

drop procedure if exists VOUCHER_SELECTPROCEDURE;

drop procedure if exists VOUCHER_UPDATEPROCEDURE;

drop index if exists CHINHANH.CHINHANH_PK;

drop index if exists CHITIETDONHANG.CHITIETDONHANG2_FK;

drop index if exists CHITIETDONHANG.CHITIETDONHANG_FK;

drop index if exists CHITIETDONHANG.CHITIETDONHANG_PK;

drop index if exists CHITIETGIOHANG.CHITIETGIOHANG2_FK;

drop index if exists CHITIETGIOHANG.CHITIETGIOHANG_FK;

drop index if exists CHITIETGIOHANG.CHITIETGIOHANG_PK;

drop index if exists DONHANG.DONHANG_VOUCHER_FK;

drop index if exists DONHANG.KHACHHANG_DONHANG_FK;

drop index if exists DONHANG.DONHANG_PK;

drop index if exists KHACHHANG.KHACHHANG_PK;

drop index if exists NHANVIEN.CHINHANH_NHANVIEN_FK;

drop index if exists NHANVIEN.NHANVIEN_PK;

drop index if exists SANPHAM.SANPHAM_PK;

drop index if exists TAIKHOAN.TAIKHOAN_PK;

drop index if exists THANHTOAN.DONHANG_THANHTOAN_FK;

drop index if exists THANHTOAN.THANHTOAN_PK;

drop index if exists VOUCHER.VOUCHER_PK;

/*==============================================================*/
/* Index: CHINHANH_PK                                           */
/*==============================================================*/
create unique index CHINHANH_PK on CHINHANH (
CN_ID ASC
);

/*==============================================================*/
/* Index: CHITIETDONHANG_PK                                     */
/*==============================================================*/
create unique clustered index CHITIETDONHANG_PK on CHITIETDONHANG (
ID_DH ASC,
SP_ID ASC
);

/*==============================================================*/
/* Index: CHITIETDONHANG_FK                                     */
/*==============================================================*/
create index CHITIETDONHANG_FK on CHITIETDONHANG (
ID_DH ASC
);

/*==============================================================*/
/* Index: CHITIETDONHANG2_FK                                    */
/*==============================================================*/
create index CHITIETDONHANG2_FK on CHITIETDONHANG (
SP_ID ASC
);

/*==============================================================*/
/* Index: CHITIETGIOHANG_PK                                     */
/*==============================================================*/
create unique clustered index CHITIETGIOHANG_PK on CHITIETGIOHANG (
TK_ID ASC,
SP_ID ASC
);

/*==============================================================*/
/* Index: CHITIETGIOHANG_FK                                     */
/*==============================================================*/
create index CHITIETGIOHANG_FK on CHITIETGIOHANG (
TK_ID ASC
);

/*==============================================================*/
/* Index: CHITIETGIOHANG2_FK                                    */
/*==============================================================*/
create index CHITIETGIOHANG2_FK on CHITIETGIOHANG (
SP_ID ASC
);

/*==============================================================*/
/* Index: DONHANG_PK                                            */
/*==============================================================*/
create unique index DONHANG_PK on DONHANG (
ID_DH ASC
);

/*==============================================================*/
/* Index: KHACHHANG_DONHANG_FK                                  */
/*==============================================================*/
create index KHACHHANG_DONHANG_FK on DONHANG (
TK_ID ASC
);

/*==============================================================*/
/* Index: DONHANG_VOUCHER_FK                                    */
/*==============================================================*/
create index DONHANG_VOUCHER_FK on DONHANG (
VOUCHER_ID ASC
);

/*==============================================================*/
/* Index: KHACHHANG_PK                                          */
/*==============================================================*/
create unique clustered index KHACHHANG_PK on KHACHHANG (
TK_ID ASC
);

/*==============================================================*/
/* Index: NHANVIEN_PK                                           */
/*==============================================================*/
create unique clustered index NHANVIEN_PK on NHANVIEN (
TK_ID ASC
);

/*==============================================================*/
/* Index: CHINHANH_NHANVIEN_FK                                  */
/*==============================================================*/
create index CHINHANH_NHANVIEN_FK on NHANVIEN (
CN_ID ASC
);

/*==============================================================*/
/* Index: SANPHAM_PK                                            */
/*==============================================================*/
create unique index SANPHAM_PK on SANPHAM (
SP_ID ASC
);

/*==============================================================*/
/* Index: TAIKHOAN_PK                                           */
/*==============================================================*/
create unique index TAIKHOAN_PK on TAIKHOAN (
TK_ID ASC
);

/*==============================================================*/
/* Index: THANHTOAN_PK                                          */
/*==============================================================*/
create unique index THANHTOAN_PK on THANHTOAN (
TT_ID ASC
);

/*==============================================================*/
/* Index: DONHANG_THANHTOAN_FK                                  */
/*==============================================================*/
create index DONHANG_THANHTOAN_FK on THANHTOAN (
ID_DH ASC
);

/*==============================================================*/
/* Index: VOUCHER_PK                                            */
/*==============================================================*/
create unique index VOUCHER_PK on VOUCHER (
VOUCHER_ID ASC
);

create procedure CHINHANH_DELETEPROCEDURE  @CN_ID integer as
begin
delete from CHINHANH
where CHINHANH.CN_ID = @CN_ID
end;

create procedure CHINHANH_INSERTPROCEDURE  @CN_ID integer,@CN_TEN long varchar,@CN_DIACHI long varchar as
begin
insert into CHINHANH (CHINHANH.CN_ID,CHINHANH.CN_TEN,CHINHANH.CN_DIACHI)
values(@CN_ID,@CN_TEN,@CN_DIACHI)
end;

create procedure CHINHANH_SELECTPROCEDURE  @CN_ID integer as
begin
select * from CHINHANH
where CHINHANH.CN_ID = @CN_ID
end;

create procedure CHINHANH_UPDATEPROCEDURE  @CN_ID integer,@CN_TEN long varchar,@CN_DIACHI long varchar as
begin
update CHINHANH
set CHINHANH.CN_TEN = @CN_TEN, CHINHANH.CN_DIACHI = @CN_DIACHI
where (CHINHANH.CN_ID = @CN_ID)
end;

create procedure CHITIETDONHANG_DELETEPROCEDURE  @ID_DH integer,@SP_ID integer as
begin
delete from CHITIETDONHANG
where CHITIETDONHANG.ID_DH = @ID_DH and CHITIETDONHANG.SP_ID = @SP_ID
end;

create procedure CHITIETDONHANG_INSERTPROCEDURE  @ID_DH integer,@SP_ID integer,@SOLUONG integer,@GIABAN numeric(8,2) as
begin
insert into CHITIETDONHANG (CHITIETDONHANG.ID_DH,CHITIETDONHANG.SP_ID,CHITIETDONHANG.SOLUONG,CHITIETDONHANG.GIABAN)
values(@ID_DH,@SP_ID,@SOLUONG,@GIABAN)
end;

create procedure CHITIETDONHANG_SELECTPROCEDURE  @ID_DH integer,@SP_ID integer as
begin
select * from CHITIETDONHANG
where CHITIETDONHANG.ID_DH = @ID_DH and CHITIETDONHANG.SP_ID = @SP_ID
end;

create procedure CHITIETDONHANG_UPDATEPROCEDURE  @ID_DH integer,@SP_ID integer,@SOLUONG integer,@GIABAN numeric(8,2) as
begin
update CHITIETDONHANG
set CHITIETDONHANG.SOLUONG = @SOLUONG, CHITIETDONHANG.GIABAN = @GIABAN
where (CHITIETDONHANG.ID_DH = @ID_DH and CHITIETDONHANG.SP_ID = @SP_ID)
end;

create procedure CHITIETGIOHANG_DELETEPROCEDURE  @TK_ID integer,@SP_ID integer as
begin
delete from CHITIETGIOHANG
where CHITIETGIOHANG.TK_ID = @TK_ID and CHITIETGIOHANG.SP_ID = @SP_ID
end;

create procedure CHITIETGIOHANG_INSERTPROCEDURE  @TK_ID integer,@SP_ID integer,@SOLUONG integer as
begin
insert into CHITIETGIOHANG (CHITIETGIOHANG.TK_ID,CHITIETGIOHANG.SP_ID,CHITIETGIOHANG.SOLUONG)
values(@TK_ID,@SP_ID,@SOLUONG)
end;

create procedure CHITIETGIOHANG_SELECTPROCEDURE  @TK_ID integer,@SP_ID integer as
begin
select * from CHITIETGIOHANG
where CHITIETGIOHANG.TK_ID = @TK_ID and CHITIETGIOHANG.SP_ID = @SP_ID
end;

create procedure CHITIETGIOHANG_UPDATEPROCEDURE  @TK_ID integer,@SP_ID integer,@SOLUONG integer as
begin
update CHITIETGIOHANG
set CHITIETGIOHANG.SOLUONG = @SOLUONG
where (CHITIETGIOHANG.TK_ID = @TK_ID and CHITIETGIOHANG.SP_ID = @SP_ID)
end;

create procedure DONHANG_DELETEPROCEDURE  @ID_DH integer as
begin
delete from DONHANG
where DONHANG.ID_DH = @ID_DH
end;

create procedure DONHANG_INSERTPROCEDURE  @ID_DH integer,@VOUCHER_ID integer,@TK_ID integer,@SDT_DAT char(10),@TEN_DAT long varchar,@DIACHI_DAT long varchar,@SDT_NHAN char(10),@TEN_NHAN long varchar,@DIACHI_NHAN long varchar,@ANDANH smallint,@LOINHAN long varchar,@NOTE long varchar,@XUAT_GTGT smallint,@PHUPHI numeric(8,2),@THOIGIANDATHANG date,@THOIGIANNHANHANG date,@TINHTRANG long varchar,@TONGTIEN numeric(8,2) as
begin
insert into DONHANG (DONHANG.ID_DH,DONHANG.VOUCHER_ID,DONHANG.TK_ID,DONHANG.SDT_DAT,DONHANG.TEN_DAT,DONHANG.DIACHI_DAT,DONHANG.SDT_NHAN,DONHANG.TEN_NHAN,DONHANG.DIACHI_NHAN,DONHANG.ANDANH,DONHANG.LOINHAN,DONHANG.NOTE,DONHANG.XUAT_GTGT,DONHANG.PHUPHI,DONHANG.THOIGIANDATHANG,DONHANG.THOIGIANNHANHANG,DONHANG.TINHTRANG,DONHANG.TONGTIEN)
values(@ID_DH,@VOUCHER_ID,@TK_ID,@SDT_DAT,@TEN_DAT,@DIACHI_DAT,@SDT_NHAN,@TEN_NHAN,@DIACHI_NHAN,@ANDANH,@LOINHAN,@NOTE,@XUAT_GTGT,@PHUPHI,@THOIGIANDATHANG,@THOIGIANNHANHANG,@TINHTRANG,@TONGTIEN)
end;

create procedure DONHANG_SELECTPROCEDURE  @ID_DH integer as
begin
select * from DONHANG
where DONHANG.ID_DH = @ID_DH
end;

create procedure DONHANG_UPDATEPROCEDURE  @ID_DH integer,@VOUCHER_ID integer,@TK_ID integer,@SDT_DAT char(10),@TEN_DAT long varchar,@DIACHI_DAT long varchar,@SDT_NHAN char(10),@TEN_NHAN long varchar,@DIACHI_NHAN long varchar,@ANDANH smallint,@LOINHAN long varchar,@NOTE long varchar,@XUAT_GTGT smallint,@PHUPHI numeric(8,2),@THOIGIANDATHANG date,@THOIGIANNHANHANG date,@TINHTRANG long varchar,@TONGTIEN numeric(8,2) as
begin
update DONHANG
set DONHANG.VOUCHER_ID = @VOUCHER_ID, DONHANG.TK_ID = @TK_ID, DONHANG.SDT_DAT = @SDT_DAT, DONHANG.TEN_DAT = @TEN_DAT, DONHANG.DIACHI_DAT = @DIACHI_DAT, DONHANG.SDT_NHAN = @SDT_NHAN, DONHANG.TEN_NHAN = @TEN_NHAN, DONHANG.DIACHI_NHAN = @DIACHI_NHAN, DONHANG.ANDANH = @ANDANH, DONHANG.LOINHAN = @LOINHAN, DONHANG.NOTE = @NOTE, DONHANG.XUAT_GTGT = @XUAT_GTGT, DONHANG.PHUPHI = @PHUPHI, DONHANG.THOIGIANDATHANG = @THOIGIANDATHANG, DONHANG.THOIGIANNHANHANG = @THOIGIANNHANHANG, DONHANG.TINHTRANG = @TINHTRANG, DONHANG.TONGTIEN = @TONGTIEN
where (DONHANG.ID_DH = @ID_DH)
end;

create procedure KHACHHANG_DELETEPROCEDURE  @TK_ID integer as
begin
delete from KHACHHANG
where KHACHHANG.TK_ID = @TK_ID
end;

create procedure KHACHHANG_INSERTPROCEDURE  @TK_ID integer,@TK_USERNAME varchar(30),@TK_PASSWORD char(30),@TK_STATUS smallint,@TK_ROLE integer,@TK_TENHIENTHI long varchar,@TK_EMAIL varchar(30),@TK_CMND char(9),@TK_DIACHI long varchar,@TK_SDT char(10) as
begin
insert into KHACHHANG (KHACHHANG.TK_ID,KHACHHANG.TK_USERNAME,KHACHHANG.TK_PASSWORD,KHACHHANG.TK_STATUS,KHACHHANG.TK_ROLE,KHACHHANG.TK_TENHIENTHI,KHACHHANG.TK_EMAIL,KHACHHANG.TK_CMND,KHACHHANG.TK_DIACHI,KHACHHANG.TK_SDT)
values(@TK_ID,@TK_USERNAME,@TK_PASSWORD,@TK_STATUS,@TK_ROLE,@TK_TENHIENTHI,@TK_EMAIL,@TK_CMND,@TK_DIACHI,@TK_SDT)
end;

create procedure KHACHHANG_SELECTPROCEDURE  @TK_ID integer as
begin
select * from KHACHHANG
where KHACHHANG.TK_ID = @TK_ID
end;

create procedure KHACHHANG_UPDATEPROCEDURE  @TK_ID integer,@TK_USERNAME varchar(30),@TK_PASSWORD char(30),@TK_STATUS smallint,@TK_ROLE integer,@TK_TENHIENTHI long varchar,@TK_EMAIL varchar(30),@TK_CMND char(9),@TK_DIACHI long varchar,@TK_SDT char(10) as
begin
update KHACHHANG
set KHACHHANG.TK_USERNAME = @TK_USERNAME, KHACHHANG.TK_PASSWORD = @TK_PASSWORD, KHACHHANG.TK_STATUS = @TK_STATUS, KHACHHANG.TK_ROLE = @TK_ROLE, KHACHHANG.TK_TENHIENTHI = @TK_TENHIENTHI, KHACHHANG.TK_EMAIL = @TK_EMAIL, KHACHHANG.TK_CMND = @TK_CMND, KHACHHANG.TK_DIACHI = @TK_DIACHI, KHACHHANG.TK_SDT = @TK_SDT
where (KHACHHANG.TK_ID = @TK_ID)
end;

create procedure NHANVIEN_DELETEPROCEDURE  @TK_ID integer as
begin
delete from NHANVIEN
where NHANVIEN.TK_ID = @TK_ID
end;

create procedure NHANVIEN_INSERTPROCEDURE  @TK_ID integer,@CN_ID integer,@TK_USERNAME varchar(30),@TK_PASSWORD char(30),@TK_STATUS smallint,@TK_ROLE integer,@TK_TENHIENTHI long varchar,@TK_EMAIL varchar(30),@TK_CMND char(9),@TK_DIACHI long varchar,@TK_SDT char(10) as
begin
insert into NHANVIEN (NHANVIEN.TK_ID,NHANVIEN.CN_ID,NHANVIEN.TK_USERNAME,NHANVIEN.TK_PASSWORD,NHANVIEN.TK_STATUS,NHANVIEN.TK_ROLE,NHANVIEN.TK_TENHIENTHI,NHANVIEN.TK_EMAIL,NHANVIEN.TK_CMND,NHANVIEN.TK_DIACHI,NHANVIEN.TK_SDT)
values(@TK_ID,@CN_ID,@TK_USERNAME,@TK_PASSWORD,@TK_STATUS,@TK_ROLE,@TK_TENHIENTHI,@TK_EMAIL,@TK_CMND,@TK_DIACHI,@TK_SDT)
end;

create procedure NHANVIEN_SELECTPROCEDURE  @TK_ID integer as
begin
select * from NHANVIEN
where NHANVIEN.TK_ID = @TK_ID
end;

create procedure NHANVIEN_UPDATEPROCEDURE  @TK_ID integer,@CN_ID integer,@TK_USERNAME varchar(30),@TK_PASSWORD char(30),@TK_STATUS smallint,@TK_ROLE integer,@TK_TENHIENTHI long varchar,@TK_EMAIL varchar(30),@TK_CMND char(9),@TK_DIACHI long varchar,@TK_SDT char(10) as
begin
update NHANVIEN
set NHANVIEN.CN_ID = @CN_ID, NHANVIEN.TK_USERNAME = @TK_USERNAME, NHANVIEN.TK_PASSWORD = @TK_PASSWORD, NHANVIEN.TK_STATUS = @TK_STATUS, NHANVIEN.TK_ROLE = @TK_ROLE, NHANVIEN.TK_TENHIENTHI = @TK_TENHIENTHI, NHANVIEN.TK_EMAIL = @TK_EMAIL, NHANVIEN.TK_CMND = @TK_CMND, NHANVIEN.TK_DIACHI = @TK_DIACHI, NHANVIEN.TK_SDT = @TK_SDT
where (NHANVIEN.TK_ID = @TK_ID)
end;

create procedure SANPHAM_DELETEPROCEDURE  @SP_ID integer as
begin
delete from SANPHAM
where SANPHAM.SP_ID = @SP_ID
end;

create procedure SANPHAM_INSERTPROCEDURE  @SP_ID integer,@SP_NAME long varchar,@SP_GIAGOC float,@SP_GIABAN float,@SP_HINHANH long binary,@SP_STATUS smallint as
begin
insert into SANPHAM (SANPHAM.SP_ID,SANPHAM.SP_NAME,SANPHAM.SP_GIAGOC,SANPHAM.SP_GIABAN,SANPHAM.SP_HINHANH,SANPHAM.SP_STATUS)
values(@SP_ID,@SP_NAME,@SP_GIAGOC,@SP_GIABAN,@SP_HINHANH,@SP_STATUS)
end;

create procedure SANPHAM_SELECTPROCEDURE  @SP_ID integer as
begin
select * from SANPHAM
where SANPHAM.SP_ID = @SP_ID
end;

create procedure SANPHAM_UPDATEPROCEDURE  @SP_ID integer,@SP_NAME long varchar,@SP_GIAGOC float,@SP_GIABAN float,@SP_HINHANH long binary,@SP_STATUS smallint as
begin
update SANPHAM
set SANPHAM.SP_NAME = @SP_NAME, SANPHAM.SP_GIAGOC = @SP_GIAGOC, SANPHAM.SP_GIABAN = @SP_GIABAN, SANPHAM.SP_HINHANH = @SP_HINHANH, SANPHAM.SP_STATUS = @SP_STATUS
where (SANPHAM.SP_ID = @SP_ID)
end;

create procedure TAIKHOAN_DELETEPROCEDURE  @TK_ID integer as
begin
delete from TAIKHOAN
where TAIKHOAN.TK_ID = @TK_ID
end;

create procedure TAIKHOAN_INSERTPROCEDURE  @TK_ID integer,@TK_USERNAME varchar(30),@TK_PASSWORD char(30),@TK_STATUS smallint,@TK_ROLE integer,@TK_TENHIENTHI long varchar,@TK_EMAIL varchar(30),@TK_CMND char(9),@TK_DIACHI long varchar,@TK_SDT char(10) as
begin
insert into TAIKHOAN (TAIKHOAN.TK_ID,TAIKHOAN.TK_USERNAME,TAIKHOAN.TK_PASSWORD,TAIKHOAN.TK_STATUS,TAIKHOAN.TK_ROLE,TAIKHOAN.TK_TENHIENTHI,TAIKHOAN.TK_EMAIL,TAIKHOAN.TK_CMND,TAIKHOAN.TK_DIACHI,TAIKHOAN.TK_SDT)
values(@TK_ID,@TK_USERNAME,@TK_PASSWORD,@TK_STATUS,@TK_ROLE,@TK_TENHIENTHI,@TK_EMAIL,@TK_CMND,@TK_DIACHI,@TK_SDT)
end;

create procedure TAIKHOAN_SELECTPROCEDURE  @TK_ID integer as
begin
select * from TAIKHOAN
where TAIKHOAN.TK_ID = @TK_ID
end;

create procedure TAIKHOAN_UPDATEPROCEDURE  @TK_ID integer,@TK_USERNAME varchar(30),@TK_PASSWORD char(30),@TK_STATUS smallint,@TK_ROLE integer,@TK_TENHIENTHI long varchar,@TK_EMAIL varchar(30),@TK_CMND char(9),@TK_DIACHI long varchar,@TK_SDT char(10) as
begin
update TAIKHOAN
set TAIKHOAN.TK_USERNAME = @TK_USERNAME, TAIKHOAN.TK_PASSWORD = @TK_PASSWORD, TAIKHOAN.TK_STATUS = @TK_STATUS, TAIKHOAN.TK_ROLE = @TK_ROLE, TAIKHOAN.TK_TENHIENTHI = @TK_TENHIENTHI, TAIKHOAN.TK_EMAIL = @TK_EMAIL, TAIKHOAN.TK_CMND = @TK_CMND, TAIKHOAN.TK_DIACHI = @TK_DIACHI, TAIKHOAN.TK_SDT = @TK_SDT
where (TAIKHOAN.TK_ID = @TK_ID)
end;

create procedure THANHTOAN_DELETEPROCEDURE  @TT_ID integer as
begin
delete from THANHTOAN
where THANHTOAN.TT_ID = @TT_ID
end;

create procedure THANHTOAN_INSERTPROCEDURE  @TT_ID integer,@ID_DH integer,@THANHTOAN_TYPE smallint,@TRANGTHAI smallint as
begin
insert into THANHTOAN (THANHTOAN.TT_ID,THANHTOAN.ID_DH,THANHTOAN.THANHTOAN_TYPE,THANHTOAN.TRANGTHAI)
values(@TT_ID,@ID_DH,@THANHTOAN_TYPE,@TRANGTHAI)
end;

create procedure THANHTOAN_SELECTPROCEDURE  @TT_ID integer as
begin
select * from THANHTOAN
where THANHTOAN.TT_ID = @TT_ID
end;

create procedure THANHTOAN_UPDATEPROCEDURE  @TT_ID integer,@ID_DH integer,@THANHTOAN_TYPE smallint,@TRANGTHAI smallint as
begin
update THANHTOAN
set THANHTOAN.ID_DH = @ID_DH, THANHTOAN.THANHTOAN_TYPE = @THANHTOAN_TYPE, THANHTOAN.TRANGTHAI = @TRANGTHAI
where (THANHTOAN.TT_ID = @TT_ID)
end;

create procedure VOUCHER_DELETEPROCEDURE  @VOUCHER_ID integer as
begin
delete from VOUCHER
where VOUCHER.VOUCHER_ID = @VOUCHER_ID
end;

create procedure VOUCHER_INSERTPROCEDURE  @VOUCHER_ID integer,@VOUCHER_PERCENT float,@VOUCHER_VALIDATED date,@USED smallint,@VOUCHER_MASUDUNG varchar(20) as
begin
insert into VOUCHER (VOUCHER.VOUCHER_ID,VOUCHER.VOUCHER_PERCENT,VOUCHER.VOUCHER_VALIDATED,VOUCHER.USED,VOUCHER.VOUCHER_MASUDUNG)
values(@VOUCHER_ID,@VOUCHER_PERCENT,@VOUCHER_VALIDATED,@USED,@VOUCHER_MASUDUNG)
end;

create procedure VOUCHER_SELECTPROCEDURE  @VOUCHER_ID integer as
begin
select * from VOUCHER
where VOUCHER.VOUCHER_ID = @VOUCHER_ID
end;

create procedure VOUCHER_UPDATEPROCEDURE  @VOUCHER_ID integer,@VOUCHER_PERCENT float,@VOUCHER_VALIDATED date,@USED smallint,@VOUCHER_MASUDUNG varchar(20) as
begin
update VOUCHER
set VOUCHER.VOUCHER_PERCENT = @VOUCHER_PERCENT, VOUCHER.VOUCHER_VALIDATED = @VOUCHER_VALIDATED, VOUCHER.USED = @USED, VOUCHER.VOUCHER_MASUDUNG = @VOUCHER_MASUDUNG
where (VOUCHER.VOUCHER_ID = @VOUCHER_ID)
end;

