-- phpMyAdmin SQL Dump
-- version 4.7.4
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: 19-Jan-2018 às 17:58
-- Versão do servidor: 10.1.29-MariaDB
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
-- Estrutura da tabela `company`
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
-- Extraindo dados da tabela `company`
--

INSERT INTO `company` (`id`, `idSector`, `name`, `email`, `Numero`, `address`) VALUES
(1, 3, 'Carrefour', 'carrefour@email.com', '0141450505', '3 rue adresse de Carrefour'),
(2, 3, 'Intermarche', 'intermarche@email.com', '9999999999', '5 rue adresse d\'Intermarche'),
(3, 1, 'Apple', 'apple@email.com', '0133713370', '1337 rue d\'Apple'),
(4, 1, 'Microsoft', 'microsoft@email.com', '1212121212', '12 adresse rue de Microsoft'),
(5, 1, 'Microsoft', 'microsoft666@email.com', '7787777877', '666 rue adresse de Microsoft');

-- --------------------------------------------------------

--
-- Estrutura da tabela `listcompanypresence`
--

CREATE TABLE `listcompanypresence` (
  `idCompany` int(10) NOT NULL,
  `nameCompany` varchar(77) NOT NULL,
  `Present` tinyint(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Extraindo dados da tabela `listcompanypresence`
--

INSERT INTO `listcompanypresence` (`idCompany`, `nameCompany`, `Present`) VALUES
(1, 'Carrefour', 1),
(2, 'Intermarche', 0),
(3, 'Apple', 1),
(4, 'Microsoft', 1),
(5, 'Microsoft', 0);

-- --------------------------------------------------------

--
-- Estrutura da tabela `listpresence`
--

CREATE TABLE `listpresence` (
  `idCompany` int(10) NOT NULL,
  `nameCompany` varchar(77) NOT NULL,
  `lol` varchar(77) NOT NULL,
  `lolilol` varchar(77) NOT NULL,
  `bjr` varchar(77) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Extraindo dados da tabela `listpresence`
--

INSERT INTO `listpresence` (`idCompany`, `nameCompany`, `lol`, `lolilol`, `bjr`) VALUES
(1, 'Carrefour', 'test', 'hehe', '');

-- --------------------------------------------------------

--
-- Estrutura da tabela `sector`
--

CREATE TABLE `sector` (
  `id` int(10) NOT NULL,
  `name` varchar(77) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Extraindo dados da tabela `sector`
--

INSERT INTO `sector` (`id`, `name`) VALUES
(1, 'Information technology'),
(2, 'Accounting'),
(3, 'Retail');

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
-- Indexes for table `sector`
--
ALTER TABLE `sector`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `company`
--
ALTER TABLE `company`
  MODIFY `id` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT for table `sector`
--
ALTER TABLE `sector`
  MODIFY `id` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- Constraints for dumped tables
--

--
-- Limitadores para a tabela `company`
--
ALTER TABLE `company`
  ADD CONSTRAINT `company_ibfk_1` FOREIGN KEY (`idSector`) REFERENCES `sector` (`id`);

--
-- Limitadores para a tabela `listcompanypresence`
--
ALTER TABLE `listcompanypresence`
  ADD CONSTRAINT `listcompanypresence_ibfk_2` FOREIGN KEY (`idCompany`,`nameCompany`) REFERENCES `company` (`id`, `name`) ON DELETE CASCADE;

--
-- Limitadores para a tabela `listpresence`
--
ALTER TABLE `listpresence`
  ADD CONSTRAINT `presence_ibfk_2` FOREIGN KEY (`idCompany`,`nameCompany`) REFERENCES `company` (`id`, `name`) ON DELETE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
