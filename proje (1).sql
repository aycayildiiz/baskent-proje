-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Anamakine: 127.0.0.1
-- Üretim Zamanı: 24 May 2024, 21:57:20
-- Sunucu sürümü: 10.4.32-MariaDB
-- PHP Sürümü: 8.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Veritabanı: `proje`
--

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `akademisyen`
--

CREATE TABLE `akademisyen` (
  `Proje Danışmanı` text NOT NULL,
  `1.Jüri` text NOT NULL,
  `2.Jüri` text NOT NULL,
  `3.Jüri` text NOT NULL,
  `4.Jüri` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_turkish_ci;

--
-- Tablo döküm verisi `akademisyen`
--

INSERT INTO `akademisyen` (`Proje Danışmanı`, `1.Jüri`, `2.Jüri`, `3.Jüri`, `4.Jüri`) VALUES
('DR.ĞR.ÜYESİ BURÇİN ÇAKIR', 'DR.ÖĞR.ÜYESİ MEHMET GÜLŞEN', 'DOÇ.DR.GÜLİN F. CAN', 'DR.ÖĞR.ÜYESİ TUSAN DERYA', 'ÖĞR.GÖR.DR. MUHAMMED YORULMAZ');

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `giris`
--

CREATE TABLE `giris` (
  `eposta` text NOT NULL,
  `sifre` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_turkish_ci;

--
-- Tablo döküm verisi `giris`
--

INSERT INTO `giris` (`eposta`, `sifre`) VALUES
('admin', 1234);

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `proje`
--

CREATE TABLE `proje` (
  `Egitim_Ogretim_Donemi` varchar(25) NOT NULL,
  `Ogrenci_ID` int(11) NOT NULL,
  `Ogrenci_NO` int(11) NOT NULL,
  `Ogrenci_Ad_Soyad` text NOT NULL,
  `bitirmeprojeıd` text NOT NULL,
  `projeadı` text NOT NULL,
  `projedanısman` text NOT NULL,
  `birincijuri` int(11) NOT NULL,
  `ikincijuri` int(11) NOT NULL,
  `ucuncujuri` int(11) NOT NULL,
  `dorduncujuri` int(11) NOT NULL,
  `yarıyil` int(11) NOT NULL,
  `kac` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Tablo döküm verisi `proje`
--

INSERT INTO `proje` (`Egitim_Ogretim_Donemi`, `Ogrenci_ID`, `Ogrenci_NO`, `Ogrenci_Ad_Soyad`, `bitirmeprojeıd`, `projeadı`, `projedanısman`, `birincijuri`, `ikincijuri`, `ucuncujuri`, `dorduncujuri`, `yarıyil`, `kac`) VALUES
('20192020BAHAR', 784, 21593880, 'ENDAM ELHAKAN', '112', 'Staj Değerlendirme Sistemi', 'Ögr. Gör.Tuğba ALtındağ', 70, 60, 55, 60, 3, 1),
('20192020BAHAR', 785, 21593878, 'ELÇİM ELALDI', '113', 'Demirbaş Takip Sistemi', 'Ögr.Gör. Ahmet Tuncer', 80, 70, 60, 65, 2, 1),
('20192020BAHAR', 786, 21595228, 'AHMET TOKUŞTEPE', '115', 'Mezun Bilgi Sistemi', 'Ögr.Gör.Muhammet Yorulmaz', 80, 70, 60, 65, 5, 1),
('20192020BAHAR', 787, 21697269, 'A. SAFA DÖĞENCİ', '117', 'Not Takip Sistemi', 'Ögr.Gör.Ramazan Tekinarslan', 70, 80, 75, 70, 4, 1);

--
-- Dökümü yapılmış tablolar için indeksler
--

--
-- Tablo için indeksler `proje`
--
ALTER TABLE `proje`
  ADD PRIMARY KEY (`Ogrenci_ID`),
  ADD UNIQUE KEY `Ogrenci_NO` (`Ogrenci_NO`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
