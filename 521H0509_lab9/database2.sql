CREATE DATABASE QLsinhvien;
USE QLsinhvien;

CREATE TABLE SinhVien (
    MaSoSinhVien VARCHAR(50) PRIMARY KEY,
    HoTen VARCHAR(100),
    QueQuan VARCHAR(100),
    NgaySinh DATE,
    HocLuc VARCHAR(50)
);

CREATE TABLE DeTai (
    MaSoDeTai VARCHAR(50) PRIMARY KEY,
    TenDeTai VARCHAR(100),
    ChuNhiemDeTai VARCHAR(100),
    KinhPhi DECIMAL(10, 2)
);

CREATE TABLE SinhVien_DeTai (
    MaSoSinhVien VARCHAR(50),
    MaSoDeTai VARCHAR(50),
    NoiThucTap VARCHAR(100),
    QuangDuong DECIMAL(10, 2),
    KetQua VARCHAR(50),
    FOREIGN KEY (MaSoSinhVien) REFERENCES SinhVien(MaSoSinhVien),
    FOREIGN KEY (MaSoDeTai) REFERENCES DeTai(MaSoDeTai)
);

-- Inserting data into the SinhVien table
INSERT INTO SinhVien (MaSoSinhVien, HoTen, QueQuan, NgaySinh, HocLuc)
VALUES
    ('SV001', 'Nguyen Van A', 'Hanoi', '2000-01-01', 'Gioi'),
    ('SV002', 'Tran Thi B', 'Ho Chi Minh City', '2001-02-02', 'Kha'),
    ('SV003', 'Le Van C', 'Da Nang', '2002-03-03', 'Trung binh');

-- Inserting data into the DeTai table
INSERT INTO DeTai (MaSoDeTai, TenDeTai, ChuNhiemDeTai, KinhPhi)
VALUES
    ('DT001', 'Phat trien ung dung di dong', 'Tran Van D', 10000.00),
    ('DT002', 'Nghien cuu keo dai pin', 'Nguyen Thi E', 15000.00),
    ('DT003', 'Xay dung he thong quan ly', 'Hoang Van F', 12000.00);

-- Inserting data into the SinhVien_DeTai table
INSERT INTO SinhVien_DeTai (MaSoSinhVien, MaSoDeTai, NoiThucTap, QuangDuong, KetQua)
VALUES
    ('SV001', 'DT001', 'Cong ty ABC', 50.5, 'Tot'),
    ('SV002', 'DT002', 'Truong Dai Hoc XYZ', 40.0, 'Kha'),
    ('SV003', 'DT003', 'Vien Cong Nghe GHI', 60.2, 'Gioi');
