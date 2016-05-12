-- phpMyAdmin SQL Dump
-- version 4.1.14
-- http://www.phpmyadmin.net
--
-- Host: 127.0.0.1
-- Generation Time: Apr 21, 2016 alle 10:54
-- Versione del server: 5.6.17
-- PHP Version: 5.5.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- Database: `databasefrigo`
--


-- --------------------------------------------------------

--
-- Struttura della tabella `alimento`
--

CREATE TABLE IF NOT EXISTS `alimento` (
  `Nome` varchar(20) NOT NULL,
  PRIMARY KEY (`Nome`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Struttura della tabella `dieta`
--

CREATE TABLE IF NOT EXISTS `dieta` (
  `ID` int(5) NOT NULL AUTO_INCREMENT,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1 AUTO_INCREMENT=1 ;


--
-- Struttura della tabella `frigo`
--

CREATE TABLE IF NOT EXISTS `frigo` (
  `ID` int(5) NOT NULL AUTO_INCREMENT,
  `Username` varchar(20) NOT NULL,
  `Password` varchar(40) NOT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1 AUTO_INCREMENT=1 ;



--
-- Struttura della tabella `ricette`
--

CREATE TABLE IF NOT EXISTS `ricette` (
  `COD` int(5) NOT NULL AUTO_INCREMENT,
  `Tempo` float NOT NULL,
  PRIMARY KEY (`COD`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1 AUTO_INCREMENT=1 ;



--
-- Struttura della tabella `spesa`
--

CREATE TABLE IF NOT EXISTS `spesa` (
  `ID` int(5) NOT NULL AUTO_INCREMENT,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1 AUTO_INCREMENT=1 ;

-- --------------------------------------------------------




--
-- Struttura della tabella `alimento-ricette`
--

CREATE TABLE IF NOT EXISTS `alimento-ricette` (
  `ID` int(5) NOT NULL AUTO_INCREMENT,
  `CodRicette` int(5) NOT NULL,
  `NomeAlimento` varchar(20) NOT NULL,
  `Quantità` int(5) NOT NULL,
  PRIMARY KEY (`ID`),
  INDEX(`CodRicette`, `NomeAlimento`),
  
  FOREIGN KEY(`CodRicette`) REFERENCES Ricette(`COD`),
  FOREIGN KEY(`NomeAlimento`) REFERENCES Alimento(`Nome`)
	ON UPDATE CASCADE 
	ON DELETE CASCADE
		
) ENGINE=InnoDB DEFAULT CHARSET=latin1 AUTO_INCREMENT=1 ;



--
-- Struttura della tabella `prodotto`
--

CREATE TABLE IF NOT EXISTS `prodotto` (
  `Barcode` int(6) NOT NULL,
  `Quantità` int(5) NOT NULL,
  `LivelloMin` int(5) NOT NULL,
  `NomeAlimento` varchar(20) NOT NULL,
  PRIMARY KEY (`Barcode`),
  INDEX(`NomeAlimento`),
  
    FOREIGN KEY(`NomeAlimento`) REFERENCES Alimento(`Nome`)
		ON UPDATE CASCADE 
		ON DELETE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=latin1;



--
-- Struttura della tabella `acquisto`
--

CREATE TABLE IF NOT EXISTS `acquisto` (
  `ID` int(5) NOT NULL AUTO_INCREMENT,
  `Data` date NOT NULL,
  `Quantità` int(5) NOT NULL,
  `Barcode` int(6) NOT NULL,
  `IDSpesa` int(5) NOT NULL,
  PRIMARY KEY (`ID`),
  INDEX(`Barcode` , `IDSpesa`),
  
  FOREIGN KEY(`IDSPesa`) REFERENCES Spesa(`ID`),
  FOREIGN KEY(`Barcode`) REFERENCES Prodotto(`Barcode`)
	ON UPDATE CASCADE 
	ON DELETE CASCADE
  
) ENGINE=InnoDB DEFAULT CHARSET=latin1 AUTO_INCREMENT=1 ;




--
-- Struttura della tabella `dieta-ricette`
--

CREATE TABLE IF NOT EXISTS `dieta-ricette` (
  `ID` int(5) NOT NULL AUTO_INCREMENT,
  `IDdieta` int(5) NOT NULL,
  `CodRicette` int(5) NOT NULL,
  PRIMARY KEY (`ID`),
  INDEX(`CodRicette`, `IDdieta`),
  
  FOREIGN KEY(`CodRicette`) REFERENCES Ricette(`COD`),
  FOREIGN KEY(`IDdieta`) REFERENCES Dieta(`ID`)
	ON UPDATE CASCADE 
	ON DELETE CASCADE
		
) ENGINE=InnoDB DEFAULT CHARSET=latin1 AUTO_INCREMENT=1 ;






--
-- Struttura della tabella `utente`
--

CREATE TABLE IF NOT EXISTS `utente` (
  `ID` int(5) NOT NULL AUTO_INCREMENT,
  `Nome` varchar(20) NOT NULL,
  `Cognome` varchar(20) NOT NULL,
  `Peso` float NOT NULL,
  `Sesso` enum('M','F') NOT NULL,
  `Altezza` int(5) NOT NULL COMMENT 'in centimetri',
  `Età` int(5) NOT NULL,
  `IDdieta` int(5) NOT NULL,
  PRIMARY KEY (`ID`),
  INDEX(`IDdieta`),
  
  FOREIGN KEY(`IDdieta`)
	REFERENCES Dieta(`ID`)
		ON UPDATE CASCADE 
		ON DELETE CASCADE
		
) ENGINE=InnoDB DEFAULT CHARSET=latin1 AUTO_INCREMENT=1 ;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
