-- phpMyAdmin SQL Dump
-- version 4.1.14
-- http://www.phpmyadmin.net
--
-- Host: 127.0.0.1
-- Generation Time: Apr 07, 2016 alle 12:01
-- Versione del server: 5.6.17
-- PHP Version: 5.5.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- Database: `dbfrigo`
--

-- --------------------------------------------------------

--
-- Struttura della tabella `acquisto`
--

CREATE TABLE IF NOT EXISTS `acquisto` (
  `ID` int(11) NOT NULL AUTO_INCREMENT COMMENT 'ID che identifica l''acquisto',
  `Data` date NOT NULL COMMENT 'Data in cui è avvenuto l''acquisto',
  `Quantita` int(5) NOT NULL COMMENT 'Quantità del prodotto',
  `Barcode` varchar(30) NOT NULL COMMENT 'Chiave esterna di prodotto',
  `IDSpesa` int(11) NOT NULL COMMENT 'Chiave esterna di spesa',
  PRIMARY KEY (`ID`),
  UNIQUE KEY `Barcode` (`Barcode`),
  UNIQUE KEY `IDSpesa` (`IDSpesa`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1 AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Struttura della tabella `alimento`
--

CREATE TABLE IF NOT EXISTS `alimento` (
  `Nome` varchar(50) NOT NULL COMMENT 'Nome dell''alimento',
  PRIMARY KEY (`Nome`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Struttura della tabella `dieta`
--

CREATE TABLE IF NOT EXISTS `dieta` (
  `ID` int(11) NOT NULL AUTO_INCREMENT COMMENT 'ID che identifica la dieta',
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1 AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Struttura della tabella `dietaricette`
--

CREATE TABLE IF NOT EXISTS `dietaricette` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `IDdieta` int(11) NOT NULL COMMENT 'Chiave esterna di dieta',
  `Giorno` date NOT NULL COMMENT 'Data',
  `CodRicetta` int(11) NOT NULL,
  PRIMARY KEY (`ID`),
  UNIQUE KEY `IDdieta` (`IDdieta`),
  UNIQUE KEY `CodRicetta` (`CodRicetta`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1 AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Struttura della tabella `prodotto`
--

CREATE TABLE IF NOT EXISTS `prodotto` (
  `Barcode` varchar(30) NOT NULL COMMENT 'Barcode univoco che identifica il prodotto',
  `Quantita` int(5) NOT NULL COMMENT 'Quantità del prodotto',
  `LivelloMin` int(5) NOT NULL COMMENT 'Livello minimo del prodotto',
  `NomeAlimento` varchar(50) NOT NULL COMMENT 'Chiave esterna di Alimento',
  PRIMARY KEY (`Barcode`),
  UNIQUE KEY `NomeAlimento` (`NomeAlimento`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Struttura della tabella `ricette`
--

CREATE TABLE IF NOT EXISTS `ricette` (
  `COD` int(11) NOT NULL COMMENT 'Codice della ricetta',
  `Tempo` int(6) NOT NULL COMMENT 'Tempo in minuti impiegato per la ricetta',
  PRIMARY KEY (`COD`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Struttura della tabella `ricettealimento`
--

CREATE TABLE IF NOT EXISTS `ricettealimento` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `CodRicetta` int(11) NOT NULL COMMENT 'Chiave esterna di ricetta',
  `Quantita` int(11) NOT NULL COMMENT 'Quantità',
  `NomeAlimento` varchar(50) NOT NULL,
  PRIMARY KEY (`ID`),
  UNIQUE KEY `CodRicetta` (`CodRicetta`),
  UNIQUE KEY `NomeAlimento` (`NomeAlimento`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1 AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Struttura della tabella `spesa`
--

CREATE TABLE IF NOT EXISTS `spesa` (
  `ID` int(11) NOT NULL COMMENT 'ID della spesa',
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Struttura della tabella `utente`
--

CREATE TABLE IF NOT EXISTS `utente` (
  `ID` int(11) NOT NULL AUTO_INCREMENT COMMENT 'Chiave primaria che identifica l''utente',
  `Nome` varchar(30) NOT NULL COMMENT 'Nome dell''utente',
  `Cognome` int(30) NOT NULL COMMENT 'Cognome dell''utente',
  `Sesso` enum('Maschio','Femmina') NOT NULL COMMENT 'Sesso dell''utente , scelto tra maschio e femmina',
  `Età` int(4) NOT NULL COMMENT 'Età dell''utente',
  `Peso` float NOT NULL COMMENT 'Peso in kg',
  `Altezza` int(5) NOT NULL COMMENT 'Altezza in cm',
  `IDdieta` int(11) NOT NULL COMMENT 'Chiave esterna corrispondente alla tabella dieta',
  PRIMARY KEY (`ID`),
  UNIQUE KEY `IDdieta` (`IDdieta`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1 AUTO_INCREMENT=1 ;

--
-- Limiti per le tabelle scaricate
--

--
-- Limiti per la tabella `acquisto`
--
ALTER TABLE `acquisto`
  ADD CONSTRAINT `acquisto_ibfk_2` FOREIGN KEY (`IDSpesa`) REFERENCES `spesa` (`ID`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `acquisto_ibfk_1` FOREIGN KEY (`Barcode`) REFERENCES `prodotto` (`Barcode`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Limiti per la tabella `dietaricette`
--
ALTER TABLE `dietaricette`
  ADD CONSTRAINT `dietaricette_ibfk_2` FOREIGN KEY (`CodRicetta`) REFERENCES `ricette` (`COD`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `dietaricette_ibfk_1` FOREIGN KEY (`IDdieta`) REFERENCES `dieta` (`ID`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Limiti per la tabella `prodotto`
--
ALTER TABLE `prodotto`
  ADD CONSTRAINT `prodotto_ibfk_1` FOREIGN KEY (`NomeAlimento`) REFERENCES `alimento` (`Nome`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Limiti per la tabella `ricettealimento`
--
ALTER TABLE `ricettealimento`
  ADD CONSTRAINT `ricettealimento_ibfk_2` FOREIGN KEY (`NomeAlimento`) REFERENCES `alimento` (`Nome`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `ricettealimento_ibfk_1` FOREIGN KEY (`CodRicetta`) REFERENCES `ricette` (`COD`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Limiti per la tabella `utente`
--
ALTER TABLE `utente`
  ADD CONSTRAINT `utente_ibfk_1` FOREIGN KEY (`IDdieta`) REFERENCES `dieta` (`ID`) ON DELETE CASCADE ON UPDATE CASCADE;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
