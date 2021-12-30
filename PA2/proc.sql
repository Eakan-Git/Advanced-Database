USE Hoayeuthuong
go

create or alter proc checkTK
@username varchar(30),
@password char(30)
as
begin
        if not exists(select TK_ID from TAIKHOAN where TK_USERNAME=@username)
            begin
                raiserror(N'Sai tên đăng nhập!',0,1);
                return
            end
        if not exists(select TK_ID from TAIKHOAN where TK_USERNAME=@username and TK_PASSWORD=@password)
            begin
                raiserror('Sai mật khẩu!',0,1);
                return
            end
        if exists(select TK_ID from TAIKHOAN where TK_USERNAME=@username and TK_PASSWORD=@password)
            begin 
                select TK_ID, TK_ROLE from TAIKHOAN where TK_USERNAME=@username and TK_PASSWORD=@password
            end
end

--select * from TAIKHOAN
--exec checkTK 'Matthew459', 'GK7NWPFRM'