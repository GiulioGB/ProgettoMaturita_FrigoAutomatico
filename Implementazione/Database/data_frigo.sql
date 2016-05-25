-- phpMyAdmin SQL Dump
-- version 4.5.2
-- http://www.phpmyadmin.net
--
-- Host: 127.0.0.1
-- Creato il: Mag 25, 2016 alle 15:41
-- Versione del server: 5.7.9
-- Versione PHP: 5.6.16

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `data_frigo`
--

-- --------------------------------------------------------

--
-- Struttura della tabella `alimento`
--

DROP TABLE IF EXISTS `alimento`;
CREATE TABLE IF NOT EXISTS `alimento` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `Nome` varchar(20) NOT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Struttura della tabella `familiare`
--

DROP TABLE IF EXISTS `familiare`;
CREATE TABLE IF NOT EXISTS `familiare` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `Nome` varchar(20) NOT NULL,
  `Cognome` varchar(20) NOT NULL,
  `Sesso` enum('M','F') NOT NULL,
  `Peso` int(5) NOT NULL COMMENT 'approssimato per ecesso',
  `Altezza` int(5) NOT NULL COMMENT 'in cm',
  `Eta` int(5) NOT NULL,
  `IDFrigo` int(5) NOT NULL,
  PRIMARY KEY (`ID`),
  KEY `IDFrigo` (`IDFrigo`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Struttura della tabella `frigo`
--

DROP TABLE IF EXISTS `frigo`;
CREATE TABLE IF NOT EXISTS `frigo` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `Username` varchar(20) NOT NULL,
  `Password` varchar(40) NOT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=latin1;

--
-- Dump dei dati per la tabella `frigo`
--

INSERT INTO `frigo` (`ID`, `Username`, `Password`) VALUES
(4, 'Frigo2', 'f2293aa6431ff49aa481e7acaea71116');

-- --------------------------------------------------------

--
-- Struttura della tabella `preferito`
--

DROP TABLE IF EXISTS `preferito`;
CREATE TABLE IF NOT EXISTS `preferito` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `IDAlimento` int(5) NOT NULL,
  `IDFamiliare` int(5) NOT NULL,
  PRIMARY KEY (`ID`),
  KEY `IDAlimento` (`IDAlimento`),
  KEY `IDFamiliare` (`IDFamiliare`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Struttura della tabella `prodotto`
--

DROP TABLE IF EXISTS `prodotto`;
CREATE TABLE IF NOT EXISTS `prodotto` (
  `ID` int(5) NOT NULL AUTO_INCREMENT,
  `EAN` varchar(50) DEFAULT NULL,
  `Nome` varchar(20) NOT NULL,
  `dataScadenza` date DEFAULT NULL,
  `IDFrigo` int(5) NOT NULL,
  `luogoProduzione` varchar(20) NOT NULL,
  `Quantita` int(5) NOT NULL,
  PRIMARY KEY (`ID`),
  KEY `IDFrigo` (`IDFrigo`)
) ENGINE=InnoDB AUTO_INCREMENT=11 DEFAULT CHARSET=latin1;

--
-- Limiti per le tabelle scaricate
--

--
-- Limiti per la tabella `familiare`
--
ALTER TABLE `familiare`
  ADD CONSTRAINT `familiare_ibfk_1` FOREIGN KEY (`IDFrigo`) REFERENCES `frigo` (`ID`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Limiti per la tabella `preferito`
--
ALTER TABLE `preferito`
  ADD CONSTRAINT `preferito_ibfk_1` FOREIGN KEY (`IDAlimento`) REFERENCES `alimento` (`ID`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `preferito_ibfk_2` FOREIGN KEY (`IDFamiliare`) REFERENCES `familiare` (`ID`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Limiti per la tabella `prodotto`
--
ALTER TABLE `prodotto`
  ADD CONSTRAINT `prodotto_ibfk_1` FOREIGN KEY (`IDFrigo`) REFERENCES `frigo` (`ID`) ON DELETE CASCADE ON UPDATE CASCADE;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
