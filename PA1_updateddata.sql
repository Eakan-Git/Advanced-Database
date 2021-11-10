USE csdlnc_pa1
GO

IF DB_NAME() <> N'csdlnc_pa1' SET NOEXEC ON
GO

/*Update dữ liệu*/
update CT_HOADON
set GiaBan = dbo.fn_GiaBanSP(MaSP, 5000) from CT_HOADON

update CT_HOADON
set ThanhTien = dbo.fn_ThanhTienCTHD(SoLuong, GiaBan, GiaGiam) from CT_HOADON 

update HOADON
set TongTien = dbo.fn_TongTienHD(CT_HOADON.MaHD) from CT_HOADON 