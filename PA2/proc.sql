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

--select * from TAIKHOAN
--locked account
--exec checkTK 'Matthew459', 'GK7NWPFRM'


--exec checkTK 'George497', 'ZGNVVMWNK'
-- George497 ZGNVVMWNK customer
-- Victoria703 VUJFNRRU1 staff
-- Tiffany486 MZLKUOFYM manager

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

