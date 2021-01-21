﻿CREATE DATABASE QLCAFE;

CREATE TABLE BAN
(
  MaBan int primary key,
  TenBan NVARCHAR(55)  ,
   TrangThai NVARCHAR(50) NOT NULL DEFAULT N'Trong' 
);

--
-- Dumping data for table `Ban`
--

INSERT INTO BAN(MaBan, TenBan, TrangThai) 
VALUES(1, N'Ban 1', N'Da dat truoc'),
	  (2, N'Ban 2', N'Dang phuc vu'),
	  (3, N'Ban 3', N'Trong'),
	  (4, N'Ban 4', N'Da dat truoc'),
      (5, N'Ban 5', N'Trong'),
      (6, N'Ban 6', N'Trong'),
	  (7, N'Ban 7', N'Trong'),
	  (8, N'Ban 8', N'Dang phuc vu'),
	  (9, N'Ban 9', N'Trong'),
	  (10, N'Ban 10', N'Dang phuc vu'),
	  (11, N'Ban 11', N'Da dat truoc'),
	  (13, N'Ban 12', N'Trong'),
	  (14, N'Ban 13', N'Dang phuc vu'),
	  (15, N'Ban 14', N'Trong'),
	  (16, N'Ban 15', N'Trong'),
	  (17, N'Ban 16', N'Dang phuc vu'),
	  (18, N'Ban 17', N'Trong'),
	  (19, N'Ban 18', N'Trong'),
	  (25, N'Ban 19', N'Da dat truoc'),
	  (31, N'Ban 20', N'Trong');

-- -------------------------------------------------------- da test

--
-- Table structure for table `chitiethd`
--

CREATE TABLE CHITIETHD (
  MaChiTietHD int primary key,
  MaHoaDon int foreign key references HOADON ,
  MaMon int foreign key references MON ,
  SoLuong int ,
  Gia int 
) ;

--
-- Dumping data for table `chitiethd`
--

INSERT INTO CHITIETHD (MaChiTietHD, MaHoaDon, MaMon, SoLuong, Gia) 
VALUES(293, 159, 9, 5, 50000),
	(294, 160, 32, 10, 60000),
	(295, 161, 40, 12, 20000),
	(296, 162, 16, 2, 25000),
	(297, 163, 21, 5, 500000),
	(298, 164, 15, 1, 25000),
	(299, 165, 7, 1, 25000),
	(300, 166, 37, 1, 25000),
	(302, 168, 7, 1, 25000),
	(304, 170, 21, 12, 500000),
	(306, 172, 10, 3, 40000),
	(307, 173, 21, 2, 500000),
	(308, 174, 33, 2, 20000),
	(310, 176, 27, 1, 35000),
	(311, 177, 14, 1, 20000),
	(313, 179, 11, 2, 69000),
	(314, 180, 29, 2, 15000),
	(315, 181, 20, 1, 15000),
	(316, 182, 44, 2, 25000),
	(317, 183, 23, 2, 35000),
	(318, 184, 17, 1, 20000),
	(319, 184, 45, 1, 25000),
	(320, 184, 34, 3, 25000),
	(321, 184, 35, 2, 25000),
	(322, 184, 30, 2, 15000),
	(323, 184, 8, 2, 25000),
	(324, 185, 26, 1, 30000),
	(325, 186, 26, 1, 30000),
	(326, 187, 17, 1, 20000),
	(327, 188, 34, 1, 25000),
	(328, 189, 35, 2, 25000),
	(329, 187, 9, 1, 50000),
	(330, 187, 36, 3, 25000),
	(331, 187, 37, 2, 25000),
	(332, 190, 17, 1, 20000),
	(333, 191, 20, 1, 15000),
	(334, 192, 11, 1, 69000),
	(335, 193, 41, 1, 20000),
	(342, 195, 15, 1, 15000),
	(343, 195, 44, 1, 25000),
	(347, 196, 32, 2, 60000),
	(348, 197, 32, 2, 60000),
	(349, 198, 32, 1, 20000),
	(350, 192, 26, 1, 30000),
	(351, 192, 27, 1, 35000),
	(352, 192, 22, 1, 30000),
	(353, 192, 59, 1, 55000),
	(354, 192, 57, 1, 15000),
	(355, 192, 58, 1, 15000),
	(356, 192, 32, 1, 60000),
	(357, 192, 33, 1, 20000),
	(358, 192, 31, 1, 30000),
	(359, 192, 30, 1, 15000),
	(360, 192, 28, 1, 250000),
	(361, 192, 29, 1, 15000),
	(362, 192, 36, 1, 25000),
	(363, 192, 9, 1, 50000),
	(364, 193, 40, 1, 20000),
	(365, 193, 45, 1, 25000),
	(366, 193, 16, 1, 25000),
	(370, 200, 32, 1, 60000),
	(373, 201, 59, 2, 55000),
	(374, 201, 40, 2, 20000),
	(375, 202, 32, 2, 60000),
	(376, 203, 13, 1, 20000),
	(377, 204, 21, 2, 200000),
	(378, 204, 18, 1, 25000),
	(379, 204, 15, 1, 25000),
	(380, 204, 40, 1, 20000),
	(381, 205, 13, 1, 20000),
	(382, 206, 21, 1, 200000);

-- --------------------------------------------------------

--
-- Table structure for table `hoadon`
--

CREATE TABLE HOADON (
  MaHoaDon int primary key,
  GiamGia int  DEFAULT NULL,
  MaBan int foreign key references BAN,
  GioDen datetime NOT NULL,
  TongTien int DEFAULT NULL,
  TrangThai int NOT NULL DEFAULT 0
) ;

--
-- Dumping data for table `hoadon`
--

INSERT INTO HOADON(MaHoaDon, GiamGia, MaBan, GioDen, TongTien, TrangThai) 
VALUES(159, NULL, 5, '2020-02-17 19:44:48', 250000, 1),
	(160, NULL, 17, '2020-01-17 19:45:04', 600000, 1),
	(161, NULL, 13, '2020-01-17 19:45:13', 240000, 1),
	(162, NULL, 6, '2020-03-17 19:45:20', 50000, 1),
	(163, NULL, 9, '2020-03-17 19:45:33', 2500000, 1),
	(164, NULL, 1, '2020-03-17 19:50:24', 25000, 1),
	(165, NULL, 9, '2020-03-17 19:50:28', 25000, 1),
	(166, NULL, 13, '2020-03-17 19:50:33', 25000, 1),
	(168, NULL, 7, '2020-02-17 19:50:42', 25000, 1),
	(170, NULL, 1, '2020-03-17 20:14:16', 6000000, 1),
	(172, NULL, 9, '2020-03-17 20:14:37', 102000, 1),
	(173, NULL, 8, '2020-03-17 20:14:47', 1000000, 1),
	(174, NULL, 16, '2020-03-17 20:14:59', 40000, 1),
	(176, NULL, 1, '2020-03-17 20:15:37', 35000, 1),
	(177, 20000, 14, '2020-03-17 23:47:38', 0, 1),
	(179, 35, 5, '2020-03-17 23:52:59', 89700, 1),
	(180, NULL, 17, '2020-03-17 23:53:14', 30000, 1),
	(181, 5, 7, '2020-03-17 23:53:50', 14250, 1),
	(182, 30, 2, '2020-03-17 23:54:01', 35000, 1),
	(183, 5, 9, '2020-03-18 00:11:27', 66500, 1),
	(184, 10, 14, '2018-12-18 00:11:57', 225000, 1),
	(185, NULL, 14, '2018-09-18 00:15:15', 30000, 1),
	(186, NULL, 17, '2018-07-18 00:15:20', 30000, 1),
	(187, 20, 2, '2020-02-18 00:15:25', 156000, 1),
	(188, NULL, 8, '2020-01-18 00:15:31', 25000, 1),
	(189, NULL, 25, '2020-03-18 00:15:42', 50000, 1),
	(190, NULL, 3, '2020-03-18 09:17:29', 20000, 1),
	(191, 10, 8, '2020-03-18 09:28:01', 13500, 1),
	(192, NULL, 17, '2020-03-18 09:28:05', NULL, 0),
	(193, 20000, 6, '2020-03-18 09:28:09', 70000, 1),
	(195, 10, 2, '2020-03-18 09:34:47', 36000, 1),
	(196, NULL, 18, '2020-03-30 02:37:43', 120000, 1),
	(197, 10, 19, '2020-03-30 03:18:39', 108000, 1),
	(198, NULL, 16, '2020-03-30 09:25:48', 20000, 1),
	(200, 20, 15, '2020-04-01 17:25:54', 48000, 1),
	(201, 10000, 9, '2020-04-01 17:27:43', 140000, 1),
	(202, NULL, 8, '2020-04-06 11:17:57', NULL, 0),
	(203, NULL, 2, '2020-04-06 11:18:04', NULL, 0),
	(204, NULL, 10, '2020-04-06 11:18:12', NULL, 0),
	(205, NULL, 14, '2020-04-06 11:18:37', NULL, 0),
	(206, NULL, 18, '2020-04-06 11:23:10', 200000, 1);

-- --------------------------------------------------------

--
-- Table structure for table `nhommon`
--

CREATE TABLE DANHMUC (
  MaDM int primary key,
  TenDM NVARCHAR(50) ,
  MauSac NVARCHAR(50) 
);

--
-- Dumping data for table `nhommon`
--

INSERT INTO DANHMUC(MaDM, TenDM, MauSac) 
VALUES(1, N'Cà phê', N'#ac3939'),
	(2, N'Nước đóng chai', N'#66b3ff'),
	(3, N'Nước-Lon', N'#9900ff'),
	(4, N'Lipton-Trà', N'#ffcc00'),
	(5, N'Sinh tố', N'#40ff00'),
	(6, N'Thứ khác', N'#e68a00'),
	(14, N'Đồ ăn nhanh', N'#009966');

-- --------------------------------------------------------

--
-- Table structure for table `taikhoan`
--

CREATE TABLE TAIKHOAN (
  Username NVARCHAR(30) primary key ,
  Password  NVARCHAR(30) ,
  Lv int 
) ;

--
-- Dumping data for table `taikhoan`
--

INSERT INTO TAIKHOAN ( Username, Password, lv) 
VALUES( 'hungbui', '1', 1),
	( 'nhanvien', '1', 2),
	( 'nhanvien2', '1', 2),
	( 'admin', 'admin', 1);

-- --------------------------------------------------------

--
-- Table structure for table `thucdon`
--

CREATE TABLE MON (
  MaMon int primary key ,
  TenMon NVARCHAR(55) ,
  MaDM int foreign key references DANHMUC,
  DonGia int,
  DVT NVARCHAR(55) 
) ;

--
-- Dumping data for table `thucdon`
--

INSERT INTO MON (MaMon, TenMon, MaDM, DonGia, DVT) 
VALUES(7, N'Nâu đá', 1, 25000, N'Ly'),
	(8, N'Nâu nóng', 1, 25000, N'Ly'),
	(9, N'Cafe Sữa', 1, 50000, N'Ly'),
	(10, N'Lọc đá vắt chanh', 2, 40000, N'Chậu'),
	(11, N'Nâu lắc', 1, 69000, N'Ly'),
	(12, N'Trà Xanh ', 2, 25000, N'Chai'),
	(13, N'Trà C2', 2, 20000, N'Chai'),
	(14, N'Chanh muối', 2, 20000, N'Chai'),
	(15, N'Coca Cola', 3, 25000, N'Lon'),
	(16, N'RedBull', 3, 25000, N'Lon'),
	(17, N'Pepsi', 3, 20000, N'Lon'),
	(18, N'Trà Gừng', 4, 25000, N'Ly'),
	(19, N'Trà Dilmah', 4, 25000, N'Ly'),
	(20, N'Trà chanh', 4, 15000, N'Ly'),
	(21, N'Trà My', 4, 200000, N'Bát'),
	(22, N'Sinh tố Xoài', 5, 30000, N'Ly'),
	(23, N'Sinh tố bơ', 5, 35000, N'Ly'),
	(24, N'Sinh tố Dưa Hấu', 5, 30000, N'Ly'),
	(25, N'Sinh tố Mãng Cầu', 5, 35000, N'Ly'),
	(26, N'Sinh tố chanh leo', 5, 30000, N'Ly'),
	(27, N'Sinh tố dưa chuột', 5, 35000, N'Ly'),
	(28, N'kẹo cao su', 6, 1000, N'cái'),
	(29, N'Hướng Dương', 6, 15000, N'Đĩa'),
	(30, N'Khoai chiên', 6, 15000, N'Miếng'),
	(31, N'Vina', 6, 30000, N'Bao'),
	(32, N'555', 6, 60000, N'Bao'),
	(33, N'Thăng Long', 6, 20000, N'Bao'),
	(34, N'Cao cao nóng', 1, 25000, N'Ly'),
	(35, N'Ca cao nguội', 1, 25000, N'Ly'),
	(36, N'Đen đá', 1, 25000, N'Ly'),
	(37, N'Đen nóng ', 1, 25000, N'Ly'),
	(38, N'Bia Ken', 3, 25000, N'Lon'),
	(40, N'Bia Sài Gòn', 3, 20000, N'Lon'),
	(41, N'Bia Hà Nội', 3, 20000, N'Lon'),
	(44, N'Bia Kenn', 3, 25000, N'Lon'),
	(45, N'Bia Ken', 3, 25000, N'Lon'),
	(57, N'Mỳ tôm', 14, 15000, N'Bát'),
	(58, N'Bánh mỳ pate', 14, 15000, N'Cái'),
	(59, N'Mực nướng', 14, 55000, N'Con');


	-----------------------------------------------------------

	SELECT TenMon, MaMon, DVT FROM MON where MaMon in (Select MaMon From CHITIETHD)
	------------------------------GetDsOrder--------------------------------------------
	Select ct.MaMon, TenMon, DVT, SoLuong, Gia, MaHoaDon
	From CHITIETHD AS ct INNER JOIN MON AS td ON ct.MaMon = td.MaMon
	Where ct.MaHoaDon = 192

	-----------------------------HOA DON ------------------------------------------------------------
	select * 
	from HOADON
	where TrangThai=0
	-----------------------------THEM CHI TIET HOA DON ------------------------------------------------------------
	Insert into CHITIETHD (MaHoaDon, MaMon, SoLuong, Gia)
	values ('"+cthd.GetMaHD()+"', '"+cthd.GetMaMon()+"', '"+cthd.GetSoLuong()+"', '"+cthd.GetGia()+"')
	----------------------------------------------------------------------------------------------------

	Select MON.TenMon from MON , DANHMUC WHERE DANHMUC.TenDM=N'Cà phê' and MON.MaDM=DANHMUC.MaDM
	------------------------------------------------
	delete  from CHITIETHD  where MaMon=23 
	delete from MON  where MaMon=23

	----------------------------
create proc CapNhatTrangThaiBanTheoMaBan
@maban nchar(10) ,
@trangthai nvarchar(50)

as
update BAN
set  TrangThai=@trangthai
where MaBan=@maban

exec CapNhatTrangThaiBanTheoMaBan   @maban=1 ,@trangthai=N'Trong'

UPDATE BAN SET TrangThai = N'Dang phuc vu' WHERE MaBan = 6

---------------------------------------

select CHITIETHD.* 
from CHITIETHD,HOADON ,BAN
where CHITIETHD.MaHoaDon=HOADON.MaHoaDon
and BAN.MaBan=HOADON.MaBan
and HOADON.TrangThai=0
and HOADON.MaBan=10


-------------------------------------------------------
select MON.TenMon,MON.DonGia,MON.DVT,BAN.TenBan 
from MON, HOADON, CHITIETHD, BAN 
where MON.MaMon = CHITIETHD.MaMon 
and CHITIETHD.MaHoaDon = HOADON.MaHoaDon 
and BAN.MaBan = HOADON.MaBan 
and HOADON.MaBan = 10
and HOADON.TrangThai = 0

---------------------------------------------
select MON.TenMon,MON.DonGia,MON.DVT,BAN.TenBan ,CHITIETHD.SoLuong,CHITIETHD.MaChiTietHD 
from MON, HOADON, CHITIETHD, BAN 
where MON.MaMon = CHITIETHD.MaMon 
and CHITIETHD.MaHoaDon = HOADON.MaHoaDon 
and BAN.MaBan = HOADON.MaBan 
and HOADON.MaBan = 6
and HOADON.TrangThai = 0

------------------------------------------------------
select MON.MaMon,MON.TenMon,CHITIETHD.Gia, CHITIETHD.SoLuong ,CHITIETHD.MaChiTietHD
from MON,  CHITIETHD
where MON.MaMon = CHITIETHD.MaMon  
and CHITIETHD.MaChiTietHD = 293
-----------------------------------------------------------------
Update CHITIETHD set SoLuong = " + txtSoLuong.Text + " where MaChiTietHD = '" +lbMaCTHD.Text+ "'
---------------------------------------------------------------------------------------------------------
select SUM(CHITIETHD.SoLuong * CHITIETHD.Gia)
from CHITIETHD,HOADON
where CHITIETHD.MaHoaDon=HOADON.MaHoaDon
and HOADON.MaHoaDon=278
--------------------------
select *
from BAN
-----------------------------------------
DELETE FROM HOADON
 WHERE EXISTS
   (SELECT *
   FROM BAN
   WHERE HOADON.MaBan = BAN.MaBan
   AND BAN.MaBan=3);
   ---------------------------------Test Thong Ke--------------------------------
   ---------Thong ke theo hoa don---------------------------
   select HOADON.MaHoaDon ,HOADON.GioDen,HOADON.TongTien,TenBan
from BAN,HOADON
where BAN.MaBan=HOADON.MaBan
and HOADON.TrangThai=1
and (HOADON.GioDen  Between Convert(Datetime, '17-01-2020',105) And Convert(Datetime,'20-03-2020',105) )

------------Thong ke Theo Mon----------- Co nhung mon o CTHD nhung ma CHUA THANH TOAN ------------------------------
select MON.TenMon,Mon.DVT, sum(CHiTIETHD.SoLuong),Sum(MON.DonGia*CHITIETHD.SoLuong)
from MON,CHITIETHD,HOADON
where MON.MaMon=CHITIETHD.MaMon
and CHITIETHD.MaHoaDon=HOADON.MaHoaDon
and (HOADON.GioDen  Between Convert(Datetime, '17-01-2020',105) And Convert(Datetime,'20-03-2020',105) )
and HOADON.TrangThai=1
GROUP BY  MON.TenMon ,Mon.DVT;

---so luong ca qua trinh 
select sum(soluong)
from CHITIETHD
where MaMon=28


select sum(MON.DonGia*CHITIETHD.SoLuong)
from CHITIETHD,MON
where CHITIETHD.MaMon=28
and MON.MaMon=CHITIETHD.MaMon

select DonGia
from MON
Where MaMon=28

-------------------------Tong tien thu ve ------------------
-----------Thong tien thu ve thuc te 
select Sum(MON.DonGia*CHITIETHD.SoLuong) --,HOADON.MaHoaDon
from MON,CHITIETHD,HOADON
where MON.MaMon=CHITIETHD.MaMon
and CHITIETHD.MaHoaDon=HOADON.MaHoaDon
and (HOADON.GioDen  Between Convert(Datetime, '17-01-2020',105) And Convert(Datetime,'20-03-2020',105) )
and HOADON.TrangThai=1
--GROUP BY  HOADON.MaHoaDon

-----Tong tien thu ve khong thuc te vi khi nhap lieu Nhap Tong Tien cao hon Gia Tri Thuc cua Hoa Don
--Hoặc Có Hóa Đơn Nhung Mà khong có CHITIETHD trong Hóa Đơn nên Số Hoa Đơn sẽ Nhiều Hơn số Hoa Đơn Thực tế do nhập liệu 
select sum(TongTien) --,TongTien ,MaHoaDon
from HOADON
where (HOADON.GioDen  Between Convert(Datetime, '17-01-2020',105) And Convert(Datetime,'20-03-2020',105) )
and TrangThai=1

---------------------------Tong So Hoa Don Da Thanh Toan ----------------------------------------
select count(*)
from HOADON 
where (HOADON.GioDen  Between Convert(Datetime, '17-01-2011',105) And Convert(Datetime,'20-12-2021',105) )
and TrangThai=1

-----------------------Tong so mon da ban -------------------------------
select count(MON.MaMon)
from MON,CHITIETHD,HOADON
where MON.MaMon=CHITIETHD.MaMon
and CHITIETHD.MaHoaDon=HOADON.MaHoaDon
and (HOADON.GioDen  Between Convert(Datetime, '17-01-2020',105) And Convert(Datetime,'20-03-2020',105) )
and HOADON.TrangThai=1


----------------------------
select HOADON.MaHoaDon,MON.TenMon,CHITIETHD.SoLuong,MON.DonGia
from HOADON,CHITIETHD,MON
where HOADON.MaHoaDon=CHITIETHD.MaHoaDon
and CHITIETHD.MaMon=MON.MaMon
and HOADON.MaHoaDon=160