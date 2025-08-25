# 🏥 Bài tập lớn môn Lập trình cơ sở dữ liệu - Quản Lý Phòng Khám

---

## ⚙️ Chức năng chính

- 🔑 **Đăng nhập**: phân quyền người dùng (bác sĩ, điều dưỡng, thu ngân, quản trị viên).
- 📝 **Quản lý bệnh nhân**: thêm, sửa, xóa, tra cứu hồ sơ, xem lịch sử khám.
- 👩‍⚕️ **Lập phiếu khám**: ghi nhận triệu chứng, chẩn đoán, kê toa thuốc, hẹn tái khám.
- 💊 **Quản lý thuốc & dịch vụ**: thêm, sửa, xóa danh mục thuốc, loại bệnh, dịch vụ y tế.
- 📅 **Đặt lịch khám**: tạo lịch hẹn, kiểm tra khung giờ trống, nhắc lịch qua email tự động.
- 💵 **Thanh toán & Hóa đơn**: lập hóa đơn theo phiếu khám, in PDF, lưu vào hệ thống.
- 📊 **Báo cáo – Thống kê**:
  - Doanh thu theo tháng/năm
  - Tình hình sử dụng thuốc
  - Danh sách bệnh nhân, hóa đơn
- ⚙️ **Quản lý tài khoản**: thêm, sửa, xóa tài khoản người dùng.

---

## 🛠️ Công nghệ sử dụng

- **Ngôn ngữ**: C# (.NET Framework)
- **Giao diện**: Windows Forms
- **Cơ sở dữ liệu**: SQL Server
- **Kiến trúc**: 3 lớp (Data Access Layer – Business Layer – Presentation Layer)

---

## 🚀 Quá trình xây dựng đề tài

1. **Phân tích yêu cầu**

   - Xác định nghiệp vụ phòng khám, chức năng cần có.
   - Xây dựng Use Case tổng quát và đặc tả chi tiết.

2. **Thiết kế hệ thống**

   - Vẽ sơ đồ Use Case, Class Diagram, Activity Diagram, Sequence Diagram.
   - Thiết kế **ERD (Entity Relationship Diagram)** và **CSDL quan hệ**.

3. **Thực hiện dự án**

   - Xây dựng ứng dụng bằng **C# WinForms** kết nối **SQL Server**.
   - Áp dụng kiến trúc **3 lớp (DAL – BUS – GUI)** để quản lý code.

4. **Kiểm thử hệ thống**
   - Kiểm thử chức năng (lập phiếu khám, hóa đơn, đặt lịch, báo cáo…).
   - Kiểm thử giao diện người dùng.

---


