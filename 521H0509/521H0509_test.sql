CREATE DATABASE testDb;
use   testDb  ; 
CREATE TABLE doc_gia (
    ma_doc_gia INT PRIMARY KEY,
    ho_ten NVARCHAR(100),
    ngay_sinh DATE
);

CREATE TABLE sach (
    ma_sach INT PRIMARY KEY,
    ten_sach NVARCHAR(100),
    tac_gia NVARCHAR(100),
    so_luong INT
);

CREATE TABLE muon_sach (
    ma_phieu_muon BIGINT PRIMARY KEY,
    ma_doc_gia INT,
    ngay_muon DATE,
    FOREIGN KEY (ma_doc_gia) REFERENCES doc_gia(ma_doc_gia)
);

CREATE TABLE CTPM (
    ma_phieu_muon BIGINT,
    ma_sach INT,
    ngay_tra DATE,
    FOREIGN KEY (ma_phieu_muon) REFERENCES muon_sach(ma_phieu_muon),
    FOREIGN KEY (ma_sach) REFERENCES sach(ma_sach)
);





SELECT * FROM INFORMATION_SCHEMA.TABLES;




-- Insert into doc_gia
INSERT INTO doc_gia (ma_doc_gia, ho_ten, ngay_sinh)
VALUES
(1, 'Nguyen Van A', '1980-01-01'),
(2, 'Tran Thi B', '1981-02-02'),
(3, 'Le Van C', '1982-03-03'),
(4, 'Pham Thi D', '1983-04-04'),
(5, 'Hoang Van E', '1984-05-05');

-- Insert into sach
INSERT INTO sach (ma_sach, ten_sach, tac_gia, so_luong)
VALUES
(1, 'Sach A', 'Tac gia A', 10),
(2, 'Sach B', 'Tac gia B', 20),
(3, 'Sach C', 'Tac gia C', 30),
(4, 'Sach D', 'Tac gia D', 40),
(5, 'Sach E', 'Tac gia E', 50);

-- Insert into muon_sach
INSERT INTO muon_sach (ma_phieu_muon, ma_doc_gia, ngay_muon)
VALUES
(1001, 1, '2024-01-01'),
(1002, 2, '2024-02-02'),
(1003, 3, '2024-03-03'),
(1004, 4, '2024-04-04'),
(1005, 5, '2024-05-05');

-- Insert into CTPM
INSERT INTO CTPM (ma_phieu_muon, ma_sach, ngay_tra)
VALUES
(1001, 1, '2024-02-01'),
(1002, 2, '2024-03-02'),
(1003, 3, '2024-04-03'),
(1004, 4, '2024-05-04'),
(1005, 5, '2024-06-05');
