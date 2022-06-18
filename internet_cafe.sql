-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Jun 18, 2022 at 08:30 PM
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
(1, 0, 1, '2565-06-18 22:04:38'),
(2, 1, 0, '2565-06-18 19:14:47'),
(3, 1, 0, '0000-00-00 00:00:00');

-- --------------------------------------------------------

--
-- Table structure for table `loginhistory`
--

CREATE TABLE `loginhistory` (
  `id` int(11) NOT NULL,
  `phone` varchar(10) COLLATE utf8_unicode_ci NOT NULL,
  `login_time` datetime NOT NULL,
  `logout_time` datetime NOT NULL,
  `computer_id` int(11) NOT NULL,
  `ticket_id` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

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
(5, '0000000000', '123456', 'Test', 'Test', 0);

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
(0, 0);

-- --------------------------------------------------------

--
-- Table structure for table `ticket`
--

CREATE TABLE `ticket` (
  `id` int(11) NOT NULL,
  `user` varchar(10) COLLATE utf8_unicode_ci NOT NULL,
  `password` varchar(10) COLLATE utf8_unicode_ci NOT NULL,
  `time` time NOT NULL,
  `remaining` time NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Dumping data for table `ticket`
--

INSERT INTO `ticket` (`id`, `user`, `password`, `time`, `remaining`) VALUES
(1, 'admin', '-', '01:00:00', '00:59:45'),
(2, 'admin', '-', '04:00:00', '00:00:00'),
(3, '0123456789', '-', '02:00:00', '00:00:00'),
(4, '0000000000', '-', '13:00:00', '00:00:00'),
(5, 'admin', '-', '08:00:00', '00:59:57'),
(6, 'guest', '2041175501', '04:00:00', '04:00:00'),
(7, 'admin', '-', '04:00:00', '00:00:00'),
(8, 'admin', '-', '03:00:00', '01:00:00'),
(9, 'admin', '-', '01:00:00', '01:00:00'),
(10, 'admin', '-', '04:00:00', '00:00:00'),
(11, '0123456789', '-', '01:00:00', '01:00:00'),
(12, 'admin', '-', '02:00:00', '00:00:00'),
(13, '0000000000', '-', '01:00:00', '01:00:00'),
(14, 'guest18067', '0677230399', '05:00:00', '05:00:00'),
(15, 'guest18090', '0903367953', '05:00:00', '05:00:00'),
(16, 'guest61817', '1754025611', '20:00:00', '20:00:00'),
(17, 'admin', '-', '03:00:00', '00:00:00');

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
(16, '2022-06-18 17:09:04', 'guest61817', '20:00:00', 300, 20, 0);

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
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT for table `loginhistory`
--
ALTER TABLE `loginhistory`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `member`
--
ALTER TABLE `member`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT for table `ticket`
--
ALTER TABLE `ticket`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=18;

--
-- AUTO_INCREMENT for table `tickethistory`
--
ALTER TABLE `tickethistory`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=17;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
