-- File script chứa script.
-- File Data chứa Data với các thuộc tính GiaBan, ThanhTien, TongTien mặc định.
-- File Updated Data sửa đổi dữ liệu các thuộc tính GiaBan, ThanhTien, TongTien theo đúng ý nghĩa của nó.
-- Thứ tự: Script -> Data -> Updated Data
**GiaGiam được random từ 0 đến 15000, bước nhảy 5000.
**GiaBan là giá bán tại thời điểm tạo lập hóa đơn (Mặc định dữ liệu được chạy hàm = Giá gốc + 5000) 
**ThanhTien = SoLuong*(GiaBan-GiaGiam)
**TongTien = Sum(CT_HOADON)(MaDH)