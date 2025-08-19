CREATE DATABASE QLPK
GO
USE QLPK

-- TẠO BẢNG ROLE
CREATE TABLE Roles(
    maRole int IDENTITY,
    tenRole nvarchar(50) NOT NULL,
	CONSTRAINT pk_Roles PRIMARY KEY CLUSTERED (maRole ASC) ON [PRIMARY]
) ON [PRIMARY]

-- TẠO BẢNG USER
CREATE TABLE TaiKhoan(
	maTaiKhoan int IDENTITY,
    userName nvarchar(50) NOT NULL,
	passWord nvarchar(50) NOT NULL,
    name nvarchar(50) NOT NULL,
	maRole int,
    CONSTRAINT pk_TaiKhoan PRIMARY KEY CLUSTERED (maTaiKhoan ASC) ON [PRIMARY],
	CONSTRAINT fk_Roles_TaiKhoan FOREIGN KEY (maRole) REFERENCES Roles (maRole)
) ON [PRIMARY]

-- TẠO BẢNG BỆNH NHÂN
CREATE TABLE BenhNhan(
    maBenhNhan int IDENTITY,
    tenBenhNhan nvarchar(50) NOT NULL,
    ngaySinh date NOT NULL,
    diaChi nvarchar(50) NOT NULL,
	CCCD NVARCHAR(12) not null,
    gioiTinh nvarchar(50) NOT NULL,
	email nvarchar(100) NULL,
    CONSTRAINT pk_BenhNhan PRIMARY KEY CLUSTERED (maBenhNhan ASC) ON [PRIMARY]
) ON [PRIMARY]

-- TẠO BẢNG PHIẾU KHÁM BỆNH
CREATE TABLE PhieuKhamBenh(
    maPKB int IDENTITY,
    ngayKham date,
    trieuChung nvarchar(50),
	maBenhNhan int,
	maTaiKhoan int,
	ngayTaiKham date,
	DaGuiMail bit NOT NULL DEFAULT(0),
    CONSTRAINT pk_PhieuKhamBenh PRIMARY KEY CLUSTERED (maPKB ASC) ON [PRIMARY],
	CONSTRAINT fk_BenhNhan_PhieuKhamBenh FOREIGN KEY (maBenhNhan) REFERENCES BenhNhan(maBenhNhan),
	CONSTRAINT fk_TaiKhoan_PhieuKhamBenh FOREIGN KEY (maTaiKhoan) REFERENCES TaiKhoan(maTaiKhoan)
) ON [PRIMARY]

-- TẠO BẢNG LOẠI BỆNH
CREATE TABLE Benh(
    maBenh int IDENTITY,
    tenBenh nvarchar(50) NOT NULL,
    CONSTRAINT pk_Benh PRIMARY KEY CLUSTERED (maBenh ASC) ON [PRIMARY]
) ON [PRIMARY]

-- TẠO BẢNG CHUẨN ĐOÁN
CREATE TABLE ChuanDoan(
	maBenh int,
	maPKB int,
	tenChuanDoan nvarchar(50),
    CONSTRAINT pk_ChuanDoan PRIMARY KEY CLUSTERED (maBenh, maPKB ASC) ON [PRIMARY],
	CONSTRAINT fk_Benh_ChuanDoan FOREIGN KEY (maBenh) REFERENCES Benh (maBenh),
	CONSTRAINT fk_PhieuKhamBenh_ChuanDoan FOREIGN KEY (maPKB) REFERENCES PhieuKhamBenh (maPKB)
) ON [PRIMARY]

CREATE TABLE DonVi(
    maDonVi int IDENTITY,
    tenDonVi nvarchar(20) NOT NULL,
    CONSTRAINT pk_donVi PRIMARY KEY CLUSTERED (maDonVi ASC) ON [PRIMARY]
) ON [PRIMARY];

CREATE TABLE CachDung(
    maCachDung int IDENTITY,
    tenCachDung nvarchar(20) NOT NULL,
    CONSTRAINT pk_cachDung PRIMARY KEY CLUSTERED (maCachDung ASC) ON [PRIMARY]
) ON [PRIMARY];

CREATE TABLE Thuoc(
    maThuoc int IDENTITY,
    tenThuoc nvarchar(50) NOT NULL,
    donGia float NOT NULL,
    maCachDung int NOT NULL,
    maDonVi int NOT NULL,
	soLuong INT DEFAULT 0,
    CONSTRAINT pk_Thuoc PRIMARY KEY CLUSTERED (maThuoc ASC) ON [PRIMARY],
    CONSTRAINT fk_DonVi_Thuoc FOREIGN KEY (maDonVi) REFERENCES DonVi (maDonVi),
    CONSTRAINT fk_CachDung_Thuoc FOREIGN KEY (maCachDung) REFERENCES CachDung (maCachDung)
) ON [PRIMARY];
-- TẠO BẢNG TOA THUỐC
CREATE TABLE ToaThuoc(
    maToaThuoc int IDENTITY,
    ngayKeToa date,
	maPKB int,
    CONSTRAINT pk_ToaThuoc PRIMARY KEY CLUSTERED (maToaThuoc ASC) ON [PRIMARY],
	CONSTRAINT fk_PhieuKhamBenh_ToaThuoc FOREIGN KEY (maPKB) REFERENCES PhieuKhamBenh (maPKB)
) ON [PRIMARY]

-- TẠO BẢNG KÊ THUỐC (CHI TIẾT ĐƠN THUỐC)
CREATE TABLE ChiTietDonThuoc(
	maThuoc int,
	maToaThuoc int,
	soLuong int NOT NULL,
	CONSTRAINT pk_CTDT PRIMARY KEY CLUSTERED (maThuoc, maToaThuoc ASC) ON [PRIMARY],
	CONSTRAINT fk_Thuoc_CTDT FOREIGN KEY (maThuoc) REFERENCES Thuoc (maThuoc),
	CONSTRAINT fk_ToaThuoc_CTDT FOREIGN KEY (maToaThuoc) REFERENCES ToaThuoc (maToaThuoc)
) ON [PRIMARY]

-- TẠO BẢNG DichVu
CREATE TABLE DichVu(
	maDichVu int IDENTITY,
	tenDichVu nvarchar(20) NOT NULL,
    tienDichVu float NOT NULL,
	CONSTRAINT pk_DichVu PRIMARY KEY CLUSTERED (maDichVu ASC) ON [PRIMARY]
) ON [PRIMARY]

-- TẠO BẢNG HÓA ĐƠN
CREATE TABLE HoaDon(
    maHoaDon int IDENTITY,
    ngayLapHoaDon date,
	tienThuoc float,
	tienKham float,
    tongTien float,
	ngayTaiKham date,
	maPKB int,
	maTaiKhoan int,
    CONSTRAINT pk_HoaDon PRIMARY KEY CLUSTERED (maHoaDon ASC) ON [PRIMARY],
	CONSTRAINT fk_PhieuKhamBenh_HoaDon FOREIGN KEY (maPKB) REFERENCES PhieuKhamBenh (maPKB),
	CONSTRAINT fk_TaiKhoan_HoaDon FOREIGN KEY (maTaiKhoan) REFERENCES TaiKhoan(maTaiKhoan)
) ON [PRIMARY]

CREATE TABLE LichHen(
	maLichHen int IDENTITY,
	ngayHen DATETIME2,
	maTaiKhoan int,
	maBenhNhan int,
	maDieuDuong int,
	trangThai nvarchar(30),
	CONSTRAINT pk_LichHen PRIMARY KEY CLUSTERED (maLichHen ASC) ON [PRIMARY],
	CONSTRAINT fk_LichHen_BacSi    FOREIGN KEY(maTaiKhoan) REFERENCES TaiKhoan(maTaiKhoan),
	CONSTRAINT FK_LichHen_DieuDuong FOREIGN KEY(maDieuDuong) REFERENCES TaiKhoan(maTaiKhoan),
    CONSTRAINT FK_LichHen_BenhNhan FOREIGN KEY(maBenhNhan) REFERENCES BenhNhan(maBenhNhan)
) ON [PRIMARY]

INSERT INTO Roles (tenRole) VALUES
(N'Bác sĩ'),
(N'Thu ngân'),
(N'Điều dưỡng'),
(N'Quản trị viên')

INSERT INTO TaiKhoan (userName, passWord, name, maRole) VALUES
('bacsi','123',N'Bác sĩ Trang',1),
('thungan','123',N'Thu Ngân Thao',2),
('dieuduong','123',N'Điều Dưỡng Huynh',3),
('admin','123','Admin Trang',4)

INSERT INTO BenhNhan (tenBenhNhan, ngaySinh, diaChi, gioiTinh, CCCD, email) VALUES
(N'Nguyễn Văn A', '1980-01-01', N'Hà Nội', N'Nam', '091122334455', 'nguyen@gmail.com'),
(N'Trần Thị B', '1985-02-15', N'Sài Gòn', N'Nữ', '081122334456', 'tranB@gmail.com'),
(N'Lê Văn C', '1990-03-20', N'Đà Nẵng', N'Nam', '091122334457', 'le@gmail.com'),
(N'Phạm Thị D', '1992-04-10', N'Cần Thơ', N'Nữ', '091122334458', 'pham@gmail.com'),
(N'Hoàng Văn E', '1975-05-30', N'Hải Phòng', N'Nam', '081122334459', 'hoang@gmail.com'),
(N'Vũ Thị F', '1988-06-25', N'Quảng Ninh', N'Nữ', '071122334460', 'vu@gmail.com'),
(N'Bùi Văn G', '1995-07-07', N'Nghệ An', N'Nam', '071122334461', 'bui@gmail.com'),
(N'Đỗ Thị H', '1993-08-08', N'Hà Tĩnh', N'Nữ', '061122334462', 'do@gmail.com'),
(N'Phan Văn I', '1981-09-09', N'Huế', N'Nam', '081122334463', 'phan@gmail.com'),
(N'Ngô Thị J', '1986-10-10', N'Vĩnh Phúc', N'Nữ', '051122334464', 'ngo@gmail.com'),
(N'Nguyễn Văn K', '1982-11-11', N'Bắc Ninh', N'Nam', '041122334465', 'nguyen@gmail.com'),
(N'Trần Thị L', '1987-12-12', N'Hà Nam', N'Nữ', '091122334466', 'tran@gmail.com'),
(N'Lê Văn M', '1991-01-13', N'Thái Bình', N'Nam', '061122334467', 'le@gmail.com'),
(N'Phạm Thị N', '1994-02-14', N'Nam Định', N'Nữ', '041122334468', 'pham@gmail.com'),
(N'Hoàng Văn O', '1978-03-15', N'Tuyên Quang', N'Nam', '091122334469', 'hoang@gmail.com'),
(N'Huỳnh Văn Thảo', '1989-04-16', N'Lào Cai', N'Nam', '081122334470', 'thaotrangks1412@gmail.com'),
(N'Trang Lee', '2004-05-17', N'Lạng Sơn', N'Nữ', '081122334471', '2251050074trang@ou.edu.vn'),
(N'Huỳnh Thảo Trang', '2004-04-07', N'TP HCM', N'Nữ', '094304008479','httrang2004@gmail.com'),
(N'Lê Thị Thùy Trang', '2004-05-26', N'Phú Yên', N'Nữ', '081122334473','leethuytrang2605@gmail.com'),
(N'Trang Thảo', '1998-08-20', N'Hà Giang', N'Nữ', '071122334474','hvthaotrang2004@gmail.com');


INSERT INTO PhieuKhamBenh (ngayKham, trieuChung, maBenhNhan, maTaiKhoan, ngayTaiKham) VALUES
('2025-08-17', N'Sốt cao', 1, 1,'2025-08-24'),
('2025-08-17', N'Ho', 2, 1,'2025-08-24'),
('2025-08-17', N'Đau bụng', 3, 1,'2025-08-24'),
('2025-08-17', N'Đau đầu', 4, 1,'2025-08-24'),
('2025-08-18', N'Khó thở', 5, 1,'2025-08-23'),
('2025-08-18', N'Nôn mửa', 6, 1,'2025-08-23'),
('2025-08-18', N'Tiêu chảy', 7, 1,'2025-08-23'),
('2025-08-19', N'Chóng mặt', 8, 1,'2025-08-23'),
('2025-08-19', N'Mệt mỏi', 9, 1,'2025-08-23'),
('2025-08-19', N'Phát ban', 10, 1,'2025-08-23');

INSERT INTO Benh (tenBenh) VALUES
(N'Cảm cúm'),
(N'Sốt xuất huyết'),
(N'Tiểu đường'),
(N'Tăng huyết áp'),
(N'Viêm phổi'),
(N'Viêm gan B'),
(N'Sỏi thận'),
(N'Viêm họng'),
(N'Dị ứng'),
(N'Viêm dạ dày');

INSERT INTO ChuanDoan (maBenh, maPKB) VALUES
(1, 1),
(2, 2),
(3, 3),
(4, 4),
(5, 5),
(6, 6),
(7, 7),
(8, 8),
(9, 9),
(10,10);

INSERT INTO DonVi (tenDonVi) VALUES
(N'Viên'),
(N'Chai'),
(N'Ống'),
(N'Gói'),
(N'Túi'),
(N'Hộp'),
(N'Lọ'),
(N'Thỏi'),
(N'Viên nang'),
(N'Dạng lỏng');


INSERT INTO CachDung (tenCachDung) VALUES
(N'Uống sau ăn'),
(N'Uống trước ăn'),
(N'Uống khi đói'),
(N'Uống buổi sáng'),
(N'Uống buổi tối'),
(N'Tiêm'),
(N'Bôi ngoài da'),
(N'Ngậm'),
(N'Nhai'),
(N'Hít');


INSERT INTO Thuoc (tenThuoc, donGia, maCachDung, maDonVi, soLuong) VALUES
(N'Paracetamol', 5000, 1, 1,100),
(N'Amoxicillin', 10000, 2, 1,200),
(N'Vitamin C', 2000, 3, 1,100),
(N'Ibuprofen', 8000, 4, 1,300),
(N'Aspirin', 7000, 5, 1,400),
(N'Cephalexin', 12000, 6, 3,500),
(N'Diclofenac', 6000, 7, 2,500),
(N'Ranitidine', 9000, 8, 1,500),
(N'Ceftriaxone', 15000, 9,9,500),
(N'Dexamethasone', 11000, 10 , 10,400);


INSERT INTO ToaThuoc (ngayKeToa, maPKB) VALUES
('2025-08-17', 1),
('2025-08-17', 2),
('2025-08-17', 3),
('2025-08-17', 4),
('2025-08-18', 5),
('2025-08-18', 6),
('2025-08-18', 7),
('2025-08-19', 8),
('2025-08-19', 9),
('2025-08-19', 10);


INSERT INTO ChiTietDonThuoc (maThuoc, maToaThuoc, soLuong) VALUES
(1, 1, 10),
(2, 2, 20),
(3, 3, 15),
(4, 4, 25),
(5, 5, 30),
(6, 6, 5),
(7, 7, 10),
(8, 8, 15),
(9, 9, 20),
(10, 10, 25);


INSERT INTO DichVu (tenDichVu, tienDichVu) VALUES
(N'Khám bệnh', 50000),
(N'Chụp X-quang', 300000),
(N'Siêu âm', 200000),
(N'Chụp CT', 1000000),
(N'Nội soi', 800000),
(N'Điện tim', 150000),
(N'Khám tổng quát', 250000),
(N'Tiêm phòng', 100000),
(N'Thử máu', 200000),
(N'Kiểm tra sức khỏe', 350000);


INSERT INTO HoaDon (ngayLapHoaDon, tienThuoc, tienKham, tongTien, maPKB, maTaiKhoan, ngayTaiKham) VALUES
('2025-08-17', 50000, 300000, 350000, 1, 2,'2025-08-24'),
('2025-08-17', 100000, 300000, 400000, 2, 2,'2025-08-24'),
('2025-08-17', 75000, 300000, 375000, 3, 2,'2025-08-24'),
('2025-08-17', 125000, 300000, 425000, 4, 2,'2025-08-24'),
('2025-08-18', 150000, 300000, 450000, 5, 2,'2025-08-23'),
('2025-08-18', 25000, 300000, 325000, 6, 2,'2025-08-23');


INSERT INTO LichHen (ngayHen, maTaiKhoan, maBenhNhan, trangThai,maDieuDuong) VALUES
('2025-08-19 09:30:00', 1,  11,N'Chờ khám', 3),
('2025-08-19 10:30:00', 1,  12, N'Chờ khám', 3),
('2025-08-19 08:30:00', 1,  13, N'Chờ khám', 3),
('2025-08-19 14:00:00', 1,  14, N'Chờ khám', 3),
('2025-08-19 13:00:00', 1,  15, N'Chờ khám', 3),
('2025-08-19 11:00:00', 1,  18, N'Chờ khám', 3),
('2025-08-19 16:30:00', 1,  16, N'Chờ khám', 3);
