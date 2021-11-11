USE csdlnc_pa1
go
CREATE PROCEDURE updateHOADON @MaHD CHAR(10)
AS
BEGIN
	DECLARE @TongTien MONEY;
	SET @TongTien = 0;
	IF(EXISTS (SELECT*
					FROM CT_HOADON
					WHERE CT_HOADON.MaHD = @MaHD))
				BEGIN
				SET @TongTien = (SELECT SUM(CT_HOADON.ThanhTien)
										FROM CT_HOADON
										WHERE @MaHD = CT_HOADON.MaHD)
				END
	UPDATE HOADON
	SET TongTien = @TongTien
	WHERE HOADON.MaHD = @MaHD;
END
GO

--them hoa don
--check tong tien sau khi insert
CREATE TRIGGER TRG_HD_INSERT
ON HOADON
AFTER INSERT
AS
BEGIN
	DECLARE @MaHD CHAR(10)
	DECLARE AddBillCursor CURSOR LOCAL STATIC READ_ONLY FORWARD_ONLY
			FOR SELECT MaHD FROM inserted;
			OPEN AddBillCursor;
			FETCH NEXT FROM AddBillCursor INTO @MaHD;
			WHILE @@FETCH_STATUS = 0
			BEGIN
				EXEC updateHOADON @MaHD;
				FETCH NEXT FROM AddBillCursor INTO @MaHD;
			END
			CLOSE AddBillCursor;
			DEALLOCATE AddBillCursor;
END
GO

--check tong tien sau khi update
CREATE TRIGGER TRG_HD_UPDATE
ON HOADON
AFTER UPDATE
AS
BEGIN
		DECLARE @MaHD CHAR(10), @TongTien MONEY;
		DECLARE UpdateBillCursor CURSOR LOCAL STATIC READ_ONLY FORWARD_ONLY
				FOR SELECT MaHD, TongTien FROM inserted;

		OPEN UpdateBillCursor;
		FETCH NEXT FROM UpdateBillCursor INTO @MaHD, @TongTien;
		WHILE @@FETCH_STATUS = 0
		BEGIN
			IF @TongTien != (SELECT SUM(CTHD.ThanhTien)
									FROM CT_HOADON CTHD
									WHERE CTHD.MaHD = @MaHD)
			BEGIN
					RAISERROR(N'Không Thể Cập Nhật Đơn Hàng.', 16, 1);
					ROLLBACK TRANSACTION;
			END
			FETCH NEXT FROM UpdateBillCursor INTO @MaHD, @TongTien;
		END
CLOSE UpdateBillCursor;
DEALLOCATE UpdateBillCursor;
END
GO

/*
	CHI TIẾT HÓA ĐƠN
*/

--Thêm chi tiết hóa đơn
CREATE TRIGGER TRG_CTHD_INSERT
ON CT_HOADON
INSTEAD OF INSERT
AS 
BEGIN
	BEGIN TRY
			DECLARE @MaHD CHAR(10), @MaSP CHAR(8), @GiaBan MONEY, @GiaGiam MONEY, @SoLuong INT;
			DECLARE AddDetailedBillCursor CURSOR STATIC READ_ONLY FORWARD_ONLY
				FOR SELECT MaHD, MaSP, GiaBan, GiaGiam, SoLuong FROM inserted;
				OPEN AddDetailedBillCursor;
				FETCH NEXT FROM AddDetailedBillCursor INTO @MaHD, @MaSP, @GiaBan, @GiaGiam, @SoLuong;
				WHILE @@FETCH_STATUS = 0
				BEGIN
					IF(@GiaGiam > @GiaBan) --giá giảm > giá bán -> cả 2 = nhau => 0 đồng
						BEGIN
						    SET @GiaGiam = @GiaBan;
						END
					INSERT INTO CT_HOADON(MaHD, MaSP, SoLuong, GiaBan, GiaGiam, ThanhTien)
					VALUES(@MaHD, @MaSP, @SoLuong, @GiaBan, @GiaGiam, @SoLuong * (@GiaBan - @GiaGiam));
					EXEC dbo.updateHOADON @MaHD;
					FETCH NEXT FROM AddDetailedBillCursor INTO @MaHD, @MaSP, @GiaBan, @GiaGiam, @SoLuong;
				END
				CLOSE AddDetailedBillCursor;
				DEALLOCATE AddDetailedBillCursor;
	END TRY

	BEGIN CATCH
			IF CURSOR_STATUS('local', 'AddDetailedBillCursor') >= 0
			BEGIN
				CLOSE AddDetailedBillCursor;
				DEALLOCATE AddDetailedBillCursor;
			END
			RAISERROR(N'Không Thể Thêm Chi Tiết Đơn Hàng', 16, 1);
			ROLLBACK TRANSACTION;
	END CATCH;
END
GO

--Update chi tiết hóa đơn
CREATE TRIGGER TRG_CTHD_UPDATE
ON CT_HOADON
INSTEAD OF UPDATE
AS
BEGIN
	BEGIN TRY
		DECLARE @MaHD CHAR(10), @MaSP CHAR(8), @GiaBan MONEY, @GiaGiam MONEY, @SoLuong INT;
		DECLARE UpdateDetailedBillCursor CURSOR STATIC READ_ONLY FORWARD_ONLY
			FOR SELECT MaHD, MaSP, GiaBan, GiaGiam, SoLuong FROM inserted;
			OPEN UpdateDetailedBillCursor;
			FETCH NEXT FROM UpdateDetailedBillCursor INTO @MaHD, @MaSP, @GiaBan, @GiaGiam, @SoLuong;
				WHILE @@FETCH_STATUS = 0
				BEGIN
					UPDATE CT_HOADON
					SET
						SoLuong = @SoLuong,
						GiaBan = @GiaBan,
						GiaGiam = @GiaGiam,
						ThanhTien = @SoLuong * (@GiaBan - @GiaGiam)
					WHERE	CT_HOADON.MaHD = @MaHD AND
							CT_HOADON.MaSP = @MaSP
					EXEC dbo.updateHOADON @MaHD
					FETCH NEXT FROM UpdateDetailedBillCursor INTO @MaHD, @MaSP, @GiaBan, @GiaGiam, @SoLuong;
				END
				CLOSE UpdateDetailedBillCursor;
				DEALLOCATE UpdateDetailedBillCursor;
	END TRY

	BEGIN CATCH
			IF CURSOR_STATUS('local', 'UpdateDetailedBillCursor') >= 0
			BEGIN
				CLOSE UpdateDetailedBillCursor;
				DEALLOCATE UpdateDetailedBillCursor;
			END
			RAISERROR(N'Không Thể Cập Nhật Chi Tiết Đơn Hàng', 16, 1);
			ROLLBACK TRANSACTION;
	END CATCH;
END
GO

--Xóa chi tiết hóa đơn
CREATE TRIGGER TRG_CTHD_DELETE
ON CT_HOADON
AFTER DELETE
AS
BEGIN
	BEGIN TRY
		DECLARE @MaHD CHAR(10)
		DECLARE DeleteDetailedBillCursor CURSOR LOCAL STATIC READ_ONLY FORWARD_ONLY
			FOR SELECT MaHD FROM inserted;
		OPEN DeleteDetailedBillCursor;
		FETCH NEXT FROM DeleteDetailedBillCursor INTO @MaHD;
		WHILE @@FETCH_STATUS = 0
		BEGIN
			--xóa hết chi tiết đơn hàng => đơn hàng không có sản phẩm nào => xóa đơn hàng
			IF NOT EXISTS (SELECT* FROM CT_HOADON WHERE CT_HOADON.MaHD = @MaHD)
				BEGIN
					DELETE FROM HOADON
					WHERE HOADON.MaHD = @MaHD;
				END
			ELSE
				BEGIN
					EXEC dbo.updateHOADON @MaHD
				END
			FETCH NEXT FROM DeleteDetailedBillCursor INTO @MaHD;
		END
		CLOSE DeleteDetailedBillCursor;
		DEALLOCATE DeleteDetailedBillCursor;
	END TRY
	BEGIN CATCH
			IF CURSOR_STATUS('local', 'DeleteDetailedBillCursor') >= 0
			BEGIN
				CLOSE DeleteDetailedBillCursor;
				DEALLOCATE DeleteDetailedBillCursor;
			END
			RAISERROR(N'Không Thể Xóa Chi Tiết Đơn Hàng', 16, 1);
			ROLLBACK TRANSACTION;
	END CATCH;
END
GO
				