-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: May 15, 2024 at 08:15 AM
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
-- Database: `expensetrackingdb`
--

-- --------------------------------------------------------

--
-- Table structure for table `account`
--

CREATE TABLE `account` (
  `userName` varchar(255) NOT NULL,
  `accountID` int(30) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `account`
--

INSERT INTO `account` (`userName`, `accountID`) VALUES
('Ervhyne', 1),
('Garvs', 2),
('Emman', 3),
('Kurt', 6),
('Mein Kampf', 7);

-- --------------------------------------------------------

--
-- Table structure for table `category`
--

CREATE TABLE `category` (
  `categoryID` int(11) NOT NULL,
  `categoryName` varchar(255) NOT NULL,
  `transactionType` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `category`
--

INSERT INTO `category` (`categoryID`, `categoryName`, `transactionType`) VALUES
(92, 'Income', 'Income'),
(94, 'YETCOME', 'Income'),
(107, 'MOMA', 'Income'),
(108, 'POPA', 'Income'),
(111, 'FRIENDS', 'Income'),
(112, 'PIGGY BANK', 'Income'),
(115, 'mother', 'Income'),
(119, '10', 'Income'),
(120, 'a', 'Income'),
(121, 'b', 'Income'),
(127, 'Travel', 'Expense'),
(128, 'Food', 'Expense'),
(129, 'Shopping', 'Expense'),
(130, 'Clothes', 'Expense'),
(131, 'Gifts', 'Expense'),
(132, 'Entertainment', 'Expense');

-- --------------------------------------------------------

--
-- Table structure for table `transactions`
--

CREATE TABLE `transactions` (
  `user` varchar(100) NOT NULL,
  `transactionType` varchar(100) NOT NULL,
  `category` varchar(100) NOT NULL,
  `amount` int(255) DEFAULT NULL,
  `date` date NOT NULL,
  `notes` text DEFAULT NULL,
  `id` int(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `transactions`
--

INSERT INTO `transactions` (`user`, `transactionType`, `category`, `amount`, `date`, `notes`, `id`) VALUES
('Ervhyne', 'Expense', 'Clothes', 100, '2024-05-14', '', 1),
('Ervhyne', 'Expense', 'Entertainment', 70, '2024-05-14', '', 2),
('Emman', 'Expense', 'Clothes', 20, '2024-05-14', '', 3),
('Ervhyne', 'Expense', 'Clothes', 300, '2024-05-14', '', 4),
('Ervhyne', 'Income', 'Income', 50, '2024-05-14', '', 5),
('Kurt', 'Expense', 'Clothes', 40, '2024-05-15', '', 6),
('Ervhyne', 'Expense', 'Entertainment', 0, '2024-05-15', '', 7),
('Emman', 'Expense', 'Food', 0, '2024-05-15', '', 8),
('Emman', 'Expense', 'Entertainment', 1, '2024-05-15', '', 9),
('Emman', 'Expense', 'Clothes', 200, '2024-05-15', '', 10),
('Emman', 'Income', 'FRIENDS', 300, '2024-05-15', '', 11),
('Emman', 'Expense', 'Travel', 349, '2024-05-15', '', 12),
('Emman', 'Income', 'FRIENDS', 1000, '2024-05-15', '', 13);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `account`
--
ALTER TABLE `account`
  ADD PRIMARY KEY (`accountID`);

--
-- Indexes for table `category`
--
ALTER TABLE `category`
  ADD PRIMARY KEY (`categoryID`);

--
-- Indexes for table `transactions`
--
ALTER TABLE `transactions`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `account`
--
ALTER TABLE `account`
  MODIFY `accountID` int(30) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=10;

--
-- AUTO_INCREMENT for table `category`
--
ALTER TABLE `category`
  MODIFY `categoryID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=133;

--
-- AUTO_INCREMENT for table `transactions`
--
ALTER TABLE `transactions`
  MODIFY `id` int(255) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=14;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
