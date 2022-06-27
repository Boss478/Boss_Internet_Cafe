-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Jun 27, 2022 at 07:16 PM
-- Server version: 10.4.24-MariaDB
-- PHP Version: 8.1.6

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `internet_cafe`
--

-- --------------------------------------------------------

--
-- Table structure for table `computer`
--

CREATE TABLE `computer` (
  `id` int(11) NOT NULL,
  `available` tinyint(1) NOT NULL,
  `ticket_id` int(11) NOT NULL,
  `start_time` datetime NOT NULL DEFAULT current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Dumping data for table `computer`
--

INSERT INTO `computer` (`id`, `available`, `ticket_id`, `start_time`) VALUES
(1, 1, 0, '2022-06-28 00:14:55'),
(2, 1, 0, '2022-06-27 21:07:19'),
(3, 1, 0, '2022-06-26 23:44:26'),
(4, 1, 0, '2022-06-26 23:45:39'),
(5, 1, 0, '2022-06-26 23:43:05'),
(6, 1, 0, '2022-06-27 21:40:07'),
(7, 1, 0, '2022-06-25 23:54:38'),
(8, 1, 0, '2022-06-27 21:40:07'),
(9, 1, 0, '2022-06-25 23:54:38'),
(10, 1, 0, '2022-06-25 23:54:38'),
(11, 1, 0, '2022-06-27 21:15:20'),
(12, 1, 0, '2022-06-25 23:54:38'),
(13, 1, 0, '2022-06-25 23:54:38'),
(14, 1, 0, '2022-06-26 23:26:03'),
(15, 1, 0, '2022-06-25 23:54:38'),
(16, 1, 0, '2022-06-25 23:54:38'),
(17, 1, 0, '2022-06-25 23:54:38'),
(18, 1, 0, '2022-06-26 23:46:57'),
(19, 1, 0, '2022-06-25 23:54:38'),
(20, 1, 0, '2022-06-25 23:54:38'),
(21, 1, 0, '2022-06-26 23:46:52'),
(22, 1, 0, '2022-06-28 00:01:10');

-- --------------------------------------------------------

--
-- Table structure for table `loginhistory`
--

CREATE TABLE `loginhistory` (
  `id` int(11) NOT NULL,
  `phone` varchar(10) COLLATE utf8_unicode_ci NOT NULL,
  `date` date NOT NULL DEFAULT current_timestamp(),
  `login_time` datetime NOT NULL,
  `logout_time` datetime DEFAULT NULL,
  `computer_id` int(11) NOT NULL,
  `ticket_id` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Dumping data for table `loginhistory`
--

INSERT INTO `loginhistory` (`id`, `phone`, `date`, `login_time`, `logout_time`, `computer_id`, `ticket_id`) VALUES
(1, 'admin', '2022-06-26', '2022-06-26 21:06:50', '2022-06-26 21:06:50', 2, 9),
(2, '0123456789', '2022-06-26', '2022-06-26 21:08:33', '2022-06-26 21:08:33', 1, 12),
(3, 'admin', '2022-06-27', '2022-06-27 21:13:51', '2022-06-27 21:13:51', 1, 9),
(4, 'admin', '2022-06-27', '2022-06-27 21:14:59', '2022-06-27 21:15:05', 11, 12),
(5, 'admin', '2022-06-27', '2022-06-27 21:15:15', '2022-06-27 21:15:21', 11, 8),
(6, '0123456789', '2022-06-27', '2022-06-27 21:15:15', '2022-06-27 21:15:21', 16, 3),
(7, '0555555555', '2022-06-28', '2022-06-28 00:09:26', '2022-06-28 00:11:04', 1, 26),
(8, 'guest62899', '2022-06-28', '2022-06-28 00:14:46', '2022-06-28 00:14:55', 1, 27);

-- --------------------------------------------------------

--
-- Table structure for table `member`
--

CREATE TABLE `member` (
  `id` int(11) NOT NULL,
  `phone` varchar(10) COLLATE utf8_unicode_ci NOT NULL,
  `passcode` varchar(6) COLLATE utf8_unicode_ci NOT NULL,
  `fname` varchar(50) COLLATE utf8_unicode_ci NOT NULL,
  `sname` varchar(50) COLLATE utf8_unicode_ci NOT NULL,
  `point` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Dumping data for table `member`
--

INSERT INTO `member` (`id`, `phone`, `passcode`, `fname`, `sname`, `point`) VALUES
(1, 'admin', '123456', 'Admin', 'Admin', 30),
(2, '0123456789', '123456', 'Boss', 'Test', 0),
(5, '0000000000', '123456', 'Test', 'Test', 0),
(6, '9876543210', '123456', 'abc', 'abc', 0),
(7, '0555555555', '123456', 'Boss', 'Boss', 2200);

-- --------------------------------------------------------

--
-- Table structure for table `point_exchange`
--

CREATE TABLE `point_exchange` (
  `point` int(11) NOT NULL,
  `discount` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Dumping data for table `point_exchange`
--

INSERT INTO `point_exchange` (`point`, `discount`) VALUES
(0, 0),
(20, 1),
(50, 3),
(75, 5),
(100, 8),
(150, 15),
(300, 31),
(500, 57),
(800, 100),
(1000, 150);

-- --------------------------------------------------------

--
-- Table structure for table `ticket`
--

CREATE TABLE `ticket` (
  `id` int(11) NOT NULL,
  `user` varchar(15) COLLATE utf8_unicode_ci NOT NULL,
  `password` varchar(10) COLLATE utf8_unicode_ci NOT NULL,
  `time` time NOT NULL,
  `remaining` time NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Dumping data for table `ticket`
--

INSERT INTO `ticket` (`id`, `user`, `password`, `time`, `remaining`) VALUES
(1, 'admin', '-', '01:00:00', '00:57:51'),
(2, 'admin', '-', '04:00:00', '00:00:00'),
(3, '0123456789', '-', '02:00:00', '00:00:00'),
(4, '0000000000', '-', '13:00:00', '00:02:39'),
(5, 'admin', '-', '08:00:00', '00:59:44'),
(6, 'guest', '2041175501', '04:00:00', '04:00:00'),
(7, 'admin', '-', '04:00:00', '00:00:00'),
(8, 'admin', '-', '03:00:00', '00:59:42'),
(9, 'admin', '-', '01:00:00', '00:58:28'),
(10, 'admin', '-', '04:00:00', '00:00:00'),
(11, '0123456789', '-', '01:00:00', '01:00:00'),
(12, 'admin', '-', '02:00:00', '00:00:00'),
(13, '0000000000', '-', '01:00:00', '01:00:00'),
(14, 'guest18067', '0677230399', '05:00:00', '05:00:00'),
(15, 'guest18090', '0903367953', '05:00:00', '05:00:00'),
(16, 'guest61817', '1754025611', '20:00:00', '20:00:00'),
(17, 'admin', '-', '03:00:00', '00:00:00'),
(18, 'guest61907', '0780622284', '05:00:00', '05:00:00'),
(19, 'guest62020', '8381445750', '02:00:00', '02:00:00'),
(20, 'guest620067', '0670565062', '01:00:00', '01:00:00'),
(21, 'guest60276', '2760966062', '01:00:00', '01:00:00'),
(22, 'guest6202220', '2220546689', '01:00:00', '00:00:00'),
(23, 'guest6204774', '4774966494', '02:00:00', '01:59:51'),
(24, 'guest6201417', '1417327482', '01:00:00', '00:00:00'),
(25, 'admin', '-', '04:00:00', '00:00:00'),
(26, '0555555555', '-', '02:00:00', '01:58:21'),
(27, 'guest6289980', '9980431810', '03:00:00', '02:59:51');

-- --------------------------------------------------------

--
-- Table structure for table `tickethistory`
--

CREATE TABLE `tickethistory` (
  `id` int(11) NOT NULL,
  `timestamp` datetime NOT NULL DEFAULT current_timestamp(),
  `phone` varchar(10) COLLATE utf8_unicode_ci NOT NULL,
  `time` time NOT NULL,
  `price` int(11) NOT NULL,
  `pointreceived` int(11) NOT NULL,
  `pointused` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Dumping data for table `tickethistory`
--

INSERT INTO `tickethistory` (`id`, `timestamp`, `phone`, `time`, `price`, `pointreceived`, `pointused`) VALUES
(1, '2022-06-10 20:45:52', 'admin', '01:00:00', 15, 1, 0),
(2, '2022-06-10 00:00:00', 'admin', '04:00:00', 60, 4, 0),
(3, '2022-06-10 00:00:00', 'admin', '02:00:00', 30, 2, 0),
(4, '2022-06-10 00:00:00', '0000000000', '13:00:00', 195, 13, 0),
(5, '2022-06-10 00:00:00', 'admin', '08:00:00', 119, 8, 20),
(6, '2022-06-10 00:00:00', 'guest', '04:00:00', 60, 4, 0),
(7, '2022-06-10 00:00:00', 'admin', '04:00:00', 30, 2, 0),
(8, '2022-06-10 00:00:00', 'admin', '03:00:00', 45, 3, 0),
(9, '2022-06-10 21:51:20', 'admin', '01:00:00', 15, 1, 0),
(10, '2022-06-10 22:27:34', 'admin', '04:00:00', 59, 4, 20),
(11, '2022-06-10 22:34:44', '0123456789', '01:00:00', 15, 1, 0),
(12, '2022-06-10 22:40:52', 'admin', '02:00:00', 30, 2, 0),
(13, '2022-06-10 22:41:06', '0000000000', '01:00:00', 15, 1, 0),
(14, '2022-06-18 12:53:29', 'guest18067', '05:00:00', 75, 5, 0),
(15, '2022-06-18 17:06:28', 'guest18090', '05:00:00', 75, 5, 0),
(16, '2022-06-18 17:09:04', 'guest61817', '20:00:00', 300, 20, 0),
(17, '2022-06-19 11:50:41', 'guest61907', '05:00:00', 75, 5, 0),
(18, '2022-06-20 20:40:25', 'guest62020', '02:00:00', 30, 2, 0),
(19, '2022-06-20 20:42:15', 'guest62006', '01:00:00', 15, 1, 0),
(20, '2022-06-20 20:43:08', 'guestMMdd2', '01:00:00', 15, 1, 0),
(21, '2022-06-20 20:49:06', 'guest62022', '01:00:00', 15, 1, 0),
(22, '2022-06-20 20:49:17', 'guest62047', '02:00:00', 30, 2, 0),
(23, '2022-06-20 20:51:03', 'guest62014', '01:00:00', 15, 1, 0),
(24, '2022-06-28 00:07:26', '0555555555', '02:00:00', 0, 2, 300),
(25, '2022-06-28 00:07:37', 'guest62899', '03:00:00', 45, 3, 0);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `computer`
--
ALTER TABLE `computer`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `loginhistory`
--
ALTER TABLE `loginhistory`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `member`
--
ALTER TABLE `member`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `point_exchange`
--
ALTER TABLE `point_exchange`
  ADD PRIMARY KEY (`point`);

--
-- Indexes for table `ticket`
--
ALTER TABLE `ticket`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `tickethistory`
--
ALTER TABLE `tickethistory`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `computer`
--
ALTER TABLE `computer`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=23;

--
-- AUTO_INCREMENT for table `loginhistory`
--
ALTER TABLE `loginhistory`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9;

--
-- AUTO_INCREMENT for table `member`
--
ALTER TABLE `member`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;

--
-- AUTO_INCREMENT for table `ticket`
--
ALTER TABLE `ticket`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=28;

--
-- AUTO_INCREMENT for table `tickethistory`
--
ALTER TABLE `tickethistory`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=26;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
