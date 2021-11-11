
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