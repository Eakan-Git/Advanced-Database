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

select * from TAIKHOAN
--locked account
--exec checkTK 'Matthew459', 'GK7NWPFRM'


--exec checkTK 'George497', 'ZGNVVMWNK'
-- George497 ZGNVVMWNK customer
-- Victoria703 VUJFNRRU1 staff
-- Tiffany486 MZLKUOFYM manager


create or alter proc checklistDangGiao
@offset int,
@fetch int
as
select DH_ID as N'Mã Đơn', SDT_NHAN as N'SĐT Nhận', TEN_NHAN as N'Tên Người Nhận', 
DIACHI_NHAN N'Địa Chỉ Người Nhận', XUAT_GTGT as 'Xuất GTGT', PHUPHI as N'Phụ Phí', THOIGIANDATHANG as N'Ngày Đặt', TONGTIEN as N'Tổng Tiền' 
from DONHANG where TINHTRANG=N'Đang Giao'
order by THOIGIANDATHANG ASC
OFFSET @offset rows
fetch next @fetch rows only;

go 

create or alter proc checklistDangXuLy
@offset int,
@fetch int
as
select DH_ID as N'Mã Đơn', SDT_NHAN as N'SĐT Nhận', TEN_NHAN as N'Tên Người Nhận', 
DIACHI_NHAN N'Địa Chỉ Người Nhận', XUAT_GTGT as 'Xuất GTGT', PHUPHI as N'Phụ Phí', THOIGIANDATHANG as N'Ngày Đặt', TONGTIEN as N'Tổng Tiền' 
from DONHANG where TINHTRANG=N'Đang Xử Lí'
order by THOIGIANDATHANG ASC
OFFSET @offset rows
fetch next @fetch rows only;

exec checklistDangGiao 0, 20
exec checklistDangXuLy 0, 20