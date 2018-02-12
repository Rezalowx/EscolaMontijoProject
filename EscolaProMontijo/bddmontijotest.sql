-- phpMyAdmin SQL Dump
-- version 4.7.4
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Feb 12, 2018 at 05:59 PM
-- Server version: 10.1.29-MariaDB
-- PHP Version: 7.2.0

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `bddmontijotest`
--

-- --------------------------------------------------------

--
-- Table structure for table `company`
--

CREATE TABLE `company` (
  `id` int(10) NOT NULL,
  `idSector` int(10) NOT NULL,
  `name` varchar(77) NOT NULL,
  `email` varchar(77) NOT NULL,
  `Numero` varchar(20) NOT NULL,
  `address` varchar(77) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 ROW_FORMAT=COMPACT;

--
-- Dumping data for table `company`
--

INSERT INTO `company` (`id`, `idSector`, `name`, `email`, `Numero`, `address`) VALUES
(1, 3, 'Carrefour', 'carrefour@email.com', '0141450505', '3 rue adresse de Carrefour'),
(2, 3, 'Intermarche', 'intermarche@email.com', 'numintermarche', '5 rue adresse d\'Intermarche'),
(3, 1, 'Apple', 'apple@email.com', '0133713370', '1337 rue d\'Apple'),
(4, 1, 'Microsoft', 'microsoft@email.com', 'nummicrosoft', '12 adresse rue de Microsoft'),
(5, 1, 'Microsoft', 'microsoft666@email.com', '7787777877', '666 rue adresse de Microsoft'),
(6, 1, 'GregCompany', 'gregory.brugnet@gmail.com', 'osefdunum', 'osefdeladresse'),
(7, 1, 'GregCompany', 'cakeizalie@hotmail.fr', 'osefdunum', 'osefdeladresse');

-- --------------------------------------------------------

--
-- Table structure for table `listcompanypresence`
--

CREATE TABLE `listcompanypresence` (
  `idCompany` int(10) NOT NULL,
  `nameCompany` varchar(77) NOT NULL,
  `Present` tinyint(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `listcompanypresence`
--

INSERT INTO `listcompanypresence` (`idCompany`, `nameCompany`, `Present`) VALUES
(1, 'Carrefour', 1),
(2, 'Intermarche', 1),
(3, 'Apple', 1),
(4, 'Microsoft', 1),
(5, 'Microsoft', 0);

-- --------------------------------------------------------

--
-- Table structure for table `listpresence`
--

CREATE TABLE `listpresence` (
  `idCompany` int(10) NOT NULL,
  `nameCompany` varchar(77) NOT NULL,
  `lol` varchar(77) NOT NULL,
  `lolilol` varchar(77) NOT NULL,
  `bjr` varchar(77) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `listpresence`
--

INSERT INTO `listpresence` (`idCompany`, `nameCompany`, `lol`, `lolilol`, `bjr`) VALUES
(1, 'Carrefour', 'test10', 'hehe', ''),
(5, 'Microsoft', '', '', ''),
(6, 'GregCompany', 'test', '', ''),
(7, 'GregCompany', '', '', '');

-- --------------------------------------------------------

--
-- Table structure for table `listtestmail`
--

CREATE TABLE `listtestmail` (
  `idCompany` int(10) NOT NULL,
  `nameCompany` varchar(77) NOT NULL,
  `osef` varchar(77) NOT NULL,
  `osef2` varchar(77) NOT NULL,
  `osef3` varchar(77) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `listtestmail`
--

INSERT INTO `listtestmail` (`idCompany`, `nameCompany`, `osef`, `osef2`, `osef3`) VALUES
(6, 'GregCompany', 'hehe', '', ''),
(7, 'GregCompany', 'test', '', '');

-- --------------------------------------------------------

--
-- Table structure for table `manager_list`
--

CREATE TABLE `manager_list` (
  `id` int(10) NOT NULL,
  `name` varchar(77) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `manager_list`
--

INSERT INTO `manager_list` (`id`, `name`) VALUES
(1, 'listcompanypresence');

-- --------------------------------------------------------

--
-- Table structure for table `sector`
--

CREATE TABLE `sector` (
  `id` int(10) NOT NULL,
  `name` varchar(77) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `sector`
--

INSERT INTO `sector` (`id`, `name`) VALUES
(1, 'Information technology'),
(2, 'Accounting'),
(3, 'Retail');

-- --------------------------------------------------------

--
-- Table structure for table `user`
--

CREATE TABLE `user` (
  `id` int(10) NOT NULL,
  `name` varchar(77) NOT NULL,
  `email` varchar(77) NOT NULL,
  `signature` varchar(1000) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `user`
--

INSERT INTO `user` (`id`, `name`, `email`, `signature`) VALUES
(1, 'Gregory Brugnet', 'gregory.brugnet@gmail.com', 'Gregory Brugnet\r\nTrainee');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `company`
--
ALTER TABLE `company`
  ADD PRIMARY KEY (`id`,`name`,`address`),
  ADD UNIQUE KEY `email` (`email`),
  ADD KEY `idSector` (`idSector`),
  ADD KEY `name` (`name`);

--
-- Indexes for table `listcompanypresence`
--
ALTER TABLE `listcompanypresence`
  ADD PRIMARY KEY (`idCompany`,`nameCompany`),
  ADD KEY `nameCompany` (`nameCompany`),
  ADD KEY `idCompany` (`idCompany`,`nameCompany`);

--
-- Indexes for table `listpresence`
--
ALTER TABLE `listpresence`
  ADD PRIMARY KEY (`idCompany`,`nameCompany`),
  ADD KEY `nameCompany` (`nameCompany`),
  ADD KEY `idCompany` (`idCompany`,`nameCompany`);

--
-- Indexes for table `listtestmail`
--
ALTER TABLE `listtestmail`
  ADD PRIMARY KEY (`idCompany`,`nameCompany`),
  ADD KEY `nameCompany` (`nameCompany`),
  ADD KEY `idCompany` (`idCompany`,`nameCompany`);

--
-- Indexes for table `manager_list`
--
ALTER TABLE `manager_list`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `sector`
--
ALTER TABLE `sector`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `user`
--
ALTER TABLE `user`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `company`
--
ALTER TABLE `company`
  MODIFY `id` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;

--
-- AUTO_INCREMENT for table `manager_list`
--
ALTER TABLE `manager_list`
  MODIFY `id` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT for table `sector`
--
ALTER TABLE `sector`
  MODIFY `id` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT for table `user`
--
ALTER TABLE `user`
  MODIFY `id` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `company`
--
ALTER TABLE `company`
  ADD CONSTRAINT `company_ibfk_1` FOREIGN KEY (`idSector`) REFERENCES `sector` (`id`);

--
-- Constraints for table `listcompanypresence`
--
ALTER TABLE `listcompanypresence`
  ADD CONSTRAINT `listcompanypresence_ibfk_2` FOREIGN KEY (`idCompany`,`nameCompany`) REFERENCES `company` (`id`, `name`) ON DELETE CASCADE;

--
-- Constraints for table `listpresence`
--
ALTER TABLE `listpresence`
  ADD CONSTRAINT `presence_ibfk_2` FOREIGN KEY (`idCompany`,`nameCompany`) REFERENCES `company` (`id`, `name`) ON DELETE CASCADE;

--
-- Constraints for table `listtestmail`
--
ALTER TABLE `listtestmail`
  ADD CONSTRAINT `testmail_ibfk_2` FOREIGN KEY (`idCompany`,`nameCompany`) REFERENCES `company` (`id`, `name`) ON DELETE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
