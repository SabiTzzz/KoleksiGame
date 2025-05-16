-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: May 14, 2025 at 04:48 PM
-- Server version: 10.4.32-MariaDB
-- PHP Version: 8.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `dbkoleksigame`
--
CREATE DATABASE IF NOT EXISTS `dbkoleksigame` DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci;
USE `dbkoleksigame`;

-- --------------------------------------------------------

--
-- Table structure for table `akun`
--

CREATE TABLE `akun` (
  `idakun` int(11) NOT NULL,
  `username` varchar(255) NOT NULL,
  `password` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `akun`
--

INSERT INTO `akun` (`idakun`, `username`, `password`) VALUES
(1, 'arya', 'arya123'),
(2, 'aray', 'aray'),
(3, 'array', 'array'),
(4, 'arya123', 'arya123'),
(5, 'ammar', '123'),
(6, '', '');

-- --------------------------------------------------------

--
-- Table structure for table `tbgame`
--

CREATE TABLE `tbgame` (
  `idgame` varchar(4) NOT NULL,
  `judul` text NOT NULL,
  `id_genre` int(2) NOT NULL,
  `id_platform` int(2) NOT NULL,
  `rating` int(1) NOT NULL,
  `rilis` date NOT NULL,
  `developer` text NOT NULL,
  `deskripsi` text NOT NULL,
  `idakun` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `tbgame`
--

INSERT INTO `tbgame` (`idgame`, `judul`, `id_genre`, `id_platform`, `rating`, `rilis`, `developer`, `deskripsi`, `idakun`) VALUES
('G001', 'Minecraft', 2, 3, 5, '2012-05-14', 'Mojang', 'Game sandbox', 1);

-- --------------------------------------------------------

--
-- Table structure for table `tbgenre`
--

CREATE TABLE `tbgenre` (
  `id_genre` int(2) NOT NULL,
  `genre` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `tbgenre`
--

INSERT INTO `tbgenre` (`id_genre`, `genre`) VALUES
(1, 'Action'),
(2, 'Adventure');

-- --------------------------------------------------------

--
-- Table structure for table `tbplatform`
--

CREATE TABLE `tbplatform` (
  `id_platform` int(2) NOT NULL,
  `platform` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `tbplatform`
--

INSERT INTO `tbplatform` (`id_platform`, `platform`) VALUES
(1, 'Playstation'),
(2, 'Xbox'),
(3, 'PC'),
(4, 'Mobile');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `akun`
--
ALTER TABLE `akun`
  ADD PRIMARY KEY (`idakun`);

--
-- Indexes for table `tbgame`
--
ALTER TABLE `tbgame`
  ADD PRIMARY KEY (`idgame`),
  ADD KEY `fk_idakun` (`idakun`),
  ADD KEY `id_genre` (`id_genre`),
  ADD KEY `id_platform` (`id_platform`);

--
-- Indexes for table `tbgenre`
--
ALTER TABLE `tbgenre`
  ADD PRIMARY KEY (`id_genre`);

--
-- Indexes for table `tbplatform`
--
ALTER TABLE `tbplatform`
  ADD PRIMARY KEY (`id_platform`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `akun`
--
ALTER TABLE `akun`
  MODIFY `idakun` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- AUTO_INCREMENT for table `tbgenre`
--
ALTER TABLE `tbgenre`
  MODIFY `id_genre` int(2) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT for table `tbplatform`
--
ALTER TABLE `tbplatform`
  MODIFY `id_platform` int(2) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `tbgame`
--
ALTER TABLE `tbgame`
  ADD CONSTRAINT `fk_idakun` FOREIGN KEY (`idakun`) REFERENCES `akun` (`idakun`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `tbgame_ibfk_1` FOREIGN KEY (`id_platform`) REFERENCES `tbplatform` (`id_platform`),
  ADD CONSTRAINT `tbgame_ibfk_2` FOREIGN KEY (`id_genre`) REFERENCES `tbgenre` (`id_genre`) ON DELETE NO ACTION ON UPDATE NO ACTION;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
