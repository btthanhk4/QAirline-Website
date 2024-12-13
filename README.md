### [ENG](https://github.com/btthanhk4/QAirline-Website/blob/main/README-en.md)
# QAirline - Vui từng chuyến bay

**Bài tập lớn - INT3306: Phát triển ứng dụng web**

QAirline là dự án xây dựng website cho hãng hàng không được phát triển bằng **ASP.NET MVC**, với mục tiêu cung cấp thông tin chuyến bay và dịch vụ đặt vé, đồng thời hỗ trợ quản lý nội bộ các dữ liệu liên quan đến chuyến bay và khách hàng.

## Thành viên nhóm
1. **[Bùi Thành Lộc](https://github.com/locbbb48)**
2. **[Bùi Tiến Thành](https://github.com/btthanhk4)**
3. **[Nguyễn Thanh Tùng](https://github.com/tungthanh11)**

## Tính Năng

- **Quản Lý Chuyến Bay**: Thực hiện các thao tác CRUD với lịch trình chuyến bay.
- **Hệ Thống Đặt Vé**: Tìm kiếm, chọn và đặt vé máy bay.
- **Xác Thực Người Dùng**: Đăng ký và đăng nhập an toàn.
- **Tìm Kiếm Chuyến Bay**: Tìm kiếm theo điểm đi, điểm đến, và ngày.
- **Giao Diện Tương Thích**: Tối ưu hóa cho cả máy tính và thiết bị di động.

---

## Công Nghệ Sử Dụng

- **Framework**: ASP.NET MVC
- **Ngôn Ngữ**: C#
- **Frontend**: HTML, CSS, JavaScript, Bootstrap
- **Cơ Sở Dữ Liệu**: SQL Server
- **ORM**: Entity Framework

---

## Cài Đặt

### Yêu Cầu

1. Cài đặt [Visual Studio](https://visualstudio.microsoft.com/).
2. Cài đặt [.NET Framework](https://dotnet.microsoft.com/) hoặc [.NET Core](https://dotnet.microsoft.com/download/dotnet-core).
3. Cài đặt SQL Server (tuỳ chọn nếu sử dụng localdb).

### Các Bước Thực Hiện

1. Clone repository:
   ```bash
   git clone https://github.com/btthanhk4/QAirline-Website.git
   ```

2. Di chuyển đến thư mục dự án:
   ```bash
   cd AirlinesReservationSystem
   ```

3. Mở dự án trong Visual Studio.

4. Khôi phục các gói NuGet:
   - Đi tới `Tools > NuGet Package Manager > Manage NuGet Packages for Solution`.
   - Nhấn `Restore`.

5. Cập nhật chuỗi kết nối cơ sở dữ liệu trong `appsettings.json`:
   ```json
   {
     "ConnectionStrings": {
       "DefaultConnection": "Server=YOUR_SERVER;Database=AirlinesDB;Trusted_Connection=True;"
     }
   }
   ```

6. Chạy migrations để thiết lập cơ sở dữ liệu:
   ```bash
   dotnet ef database update
   ```

7. Build và chạy dự án:
   - Nhấn `F5` trong Visual Studio.
   - Hoặc sử dụng lệnh:
     ```bash
     dotnet run
     ```

---

## Cấu Trúc Dự Án

```plaintext
AirlinesReservationSystem/
|-- Controllers/          # Xử lý các yêu cầu HTTP
|-- Models/               # Chứa cấu trúc dữ liệu và tương tác cơ sở dữ liệu
|-- Views/                # Razor templates cho giao diện người dùng
|-- Migrations/           # Các file migration cơ sở dữ liệu
|-- wwwroot/              # Các file tĩnh (CSS, JS, Hình ảnh)
|-- appsettings.json      # File cấu hình
|-- Program.cs            # Điểm vào của ứng dụng
|-- Startup.cs            # Cấu hình middleware và services
```

---

## Hướng Dẫn Sử Dụng

1. Truy cập ứng dụng qua `https://localhost:5001` hoặc URL được cấu hình.
2. Sử dụng menu điều hướng để khám phá các tính năng:
   - **Tìm Kiếm Chuyến Bay**: Nhập điểm đi, điểm đến, và ngày để tìm chuyến bay.
   - **Quản Lý Chuyến Bay**: Quản trị viên có thể thêm, chỉnh sửa hoặc xoá lịch trình.
   - **Đặt Vé**: Người dùng có thể đặt vé cho các chuyến bay khả dụng.
3. Đăng ký hoặc đăng nhập để truy cập các tính năng dành riêng cho người dùng.

---
