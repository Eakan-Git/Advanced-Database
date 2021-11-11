
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

