-- phpMyAdmin SQL Dump
-- version 4.1.14
-- http://www.phpmyadmin.net
--
-- Host: 127.0.0.1
-- Generation Time: Mag 15, 2016 alle 14:31
-- Versione del server: 5.6.17
-- PHP Version: 5.5.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- Database: `data_frigo`
--

-- --------------------------------------------------------

--
-- Struttura della tabella `alimento`
--

CREATE TABLE IF NOT EXISTS `alimento` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `Nome` varchar(20) NOT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1 AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Struttura della tabella `familiare`
--

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
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=3 ;

-- --------------------------------------------------------

--
-- Struttura della tabella `frigo`
--

CREATE TABLE IF NOT EXISTS `frigo` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `Username` varchar(20) NOT NULL,
  `Password` varchar(40) NOT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=5 ;

--
-- Dump dei dati per la tabella `frigo`
--

INSERT INTO `frigo` (`ID`, `Username`, `Password`) VALUES
(4, 'Frigo2', 'f2293aa6431ff49aa481e7acaea71116');

-- --------------------------------------------------------

--
-- Struttura della tabella `ingrediente`
--

CREATE TABLE IF NOT EXISTS `ingrediente` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `Nome` varchar(20) NOT NULL,
  `Quantita` float NOT NULL,
  `IDRicetta` int(5) NOT NULL,
  PRIMARY KEY (`ID`),
  KEY `IDRicetta` (`IDRicetta`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1 AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Struttura della tabella `preferito`
--

CREATE TABLE IF NOT EXISTS `preferito` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `IDAlimento` int(5) NOT NULL,
  `IDFamiliare` int(5) NOT NULL,
  PRIMARY KEY (`ID`),
  KEY `IDAlimento` (`IDAlimento`),
  KEY `IDFamiliare` (`IDFamiliare`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1 AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Struttura della tabella `prodotto`
--

CREATE TABLE IF NOT EXISTS `prodotto` (
  `ID` int(5) NOT NULL AUTO_INCREMENT,
  `Barcode` varchar(50) DEFAULT NULL,
  `Nome` varchar(20) NOT NULL,
  `dataScadenza` date DEFAULT NULL,
  `IDFrigo` int(5) NOT NULL,
  PRIMARY KEY (`ID`),
  KEY `IDFrigo` (`IDFrigo`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=8 ;

--
-- Dump dei dati per la tabella `prodotto`
--

INSERT INTO `prodotto` (`ID`, `Barcode`, `Nome`, `dataScadenza`, `IDFrigo`) VALUES
(5, '980654981', 'panna', '2016-05-07', 4),
(6, '948378456', 'burro', '2016-05-07', 4);

-- --------------------------------------------------------

--
-- Struttura della tabella `ricetta`
--

CREATE TABLE IF NOT EXISTS `ricetta` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `Tipo` enum('Antipasto','Primo','Secondo','Dolce') NOT NULL,
  `Titolo` varchar(20) NOT NULL,
  `Spiegazione` varchar(65000) NOT NULL,
  `Tempo` float NOT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1 AUTO_INCREMENT=1 ;

--
-- Limiti per le tabelle scaricate
--

--
-- Limiti per la tabella `familiare`
--
ALTER TABLE `familiare`
  ADD CONSTRAINT `familiare_ibfk_1` FOREIGN KEY (`IDFrigo`) REFERENCES `frigo` (`ID`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Limiti per la tabella `ingrediente`
--
ALTER TABLE `ingrediente`
  ADD CONSTRAINT `ingrediente_ibfk_1` FOREIGN KEY (`IDRicetta`) REFERENCES `ricetta` (`ID`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Limiti per la tabella `preferito`
--
ALTER TABLE `preferito`
  ADD CONSTRAINT `preferito_ibfk_2` FOREIGN KEY (`IDFamiliare`) REFERENCES `familiare` (`ID`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `preferito_ibfk_1` FOREIGN KEY (`IDAlimento`) REFERENCES `alimento` (`ID`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Limiti per la tabella `prodotto`
--
ALTER TABLE `prodotto`
  ADD CONSTRAINT `prodotto_ibfk_1` FOREIGN KEY (`IDFrigo`) REFERENCES `frigo` (`ID`) ON DELETE CASCADE ON UPDATE CASCADE;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
