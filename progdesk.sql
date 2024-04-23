-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1:3307
-- Generation Time: Apr 23, 2024 at 01:32 PM
-- Server version: 10.4.28-MariaDB
-- PHP Version: 8.2.4

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `progdesk`
--

-- --------------------------------------------------------

--
-- Table structure for table `tbllangganan`
--

CREATE TABLE `tbllangganan` (
  `id` int(11) NOT NULL,
  `no_plat` varchar(50) DEFAULT NULL,
  `nama` varchar(50) DEFAULT NULL,
  `jenis` varchar(50) DEFAULT NULL,
  `biaya` int(11) DEFAULT NULL,
  `expired` timestamp NULL DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `tbllangganan`
--

INSERT INTO `tbllangganan` (`id`, `no_plat`, `nama`, `jenis`, `biaya`, `expired`) VALUES
(1, 'N 2424', 'Angel', 'Mobil', 2000, '2024-03-20 09:00:00');

-- --------------------------------------------------------

--
-- Table structure for table `tblparkir`
--

CREATE TABLE `tblparkir` (
  `id` int(11) NOT NULL,
  `no_plat` varchar(10) NOT NULL,
  `waktu_masuk` timestamp NOT NULL DEFAULT current_timestamp() ON UPDATE current_timestamp(),
  `waktu_keluar` timestamp NULL DEFAULT NULL,
  `jenis` set('Motor','Mobil','Taksi/Umum','Sepeda','Bus/Truk') NOT NULL DEFAULT 'Motor',
  `harga` int(11) NOT NULL,
  `user` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_swedish_ci;

--
-- Dumping data for table `tblparkir`
--

INSERT INTO `tblparkir` (`id`, `no_plat`, `waktu_masuk`, `waktu_keluar`, `jenis`, `harga`, `user`) VALUES
(41, 'AB 9876 R ', '2024-04-23 10:48:03', '2024-04-23 10:48:03', 'Motor', 2000, 'anton'),
(42, 'AA 9573 P', '2024-04-22 10:48:20', '2024-04-22 10:48:20', 'Mobil', 3000, 'anton'),
(43, 'NA 8712 E', '2024-04-23 10:52:02', '2024-04-23 10:52:02', 'Mobil', 3000, 'nadine'),
(44, 'DG 0865 A', '2024-04-23 11:16:01', '2024-04-23 11:16:01', 'Mobil', 3000, 'nadine');

-- --------------------------------------------------------

--
-- Table structure for table `users`
--

CREATE TABLE `users` (
  `username` varchar(50) DEFAULT NULL,
  `password` varchar(50) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `users`
--

INSERT INTO `users` (`username`, `password`) VALUES
('nadine', '123');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `tbllangganan`
--
ALTER TABLE `tbllangganan`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `tblparkir`
--
ALTER TABLE `tblparkir`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `tbllangganan`
--
ALTER TABLE `tbllangganan`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT for table `tblparkir`
--
ALTER TABLE `tblparkir`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=45;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
