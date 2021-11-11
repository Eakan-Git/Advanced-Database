USE csdlnc_pa1


-- cau a: cac hoa don lap trong nam 2020
SELECT * 
FROM HoaDon hd 
WHERE YEAR(hd.NgayLap) = 2020
--cau b: cac khach hang o TPHCM
SELECT *
FROM KhachHang kh 
WHERE kh.Tpho LIKE  N'Thành Phố Hồ Chí Minh'
--cau c: cac san pham co gia tu … den …	(thay số sẵn để tránh lỗi)
SELECT *
FROM SanPham sp
WHERE sp.Gia between 10000 and 90000
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


--select * from CT_HOADON

--SELECT*FROM dbo.SANPHAM WHERE MaSP = 'SP-00009'
--SELECT*FROM dbo.HOADON
--WHERE MaHD = 'HD-0000001'

--SELECT*
--FROM dbo.CT_HOADON
--WHERE MaHD = 'HD-0000001'

--SELECT *
--FROM KhachHang kh 
--WHERE kh.Tpho NOT LIKE  N'Thành Phố Hồ Chí Minh'