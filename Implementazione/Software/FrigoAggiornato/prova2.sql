-- phpMyAdmin SQL Dump
-- version 4.1.14
-- http://www.phpmyadmin.net
--
-- Host: 127.0.0.1
-- Generation Time: Apr 21, 2016 alle 12:00
-- Versione del server: 5.6.17
-- PHP Version: 5.5.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- Database: `prova2`
--

-- --------------------------------------------------------

--
-- Struttura della tabella `prodotti`
--

CREATE TABLE IF NOT EXISTS `prodotti` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `Nome` varchar(40) NOT NULL,
  `dataScadenza` date NOT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=15 ;

--
-- Dump dei dati per la tabella `prodotti`
--

INSERT INTO `prodotti` (`ID`, `Nome`, `dataScadenza`) VALUES
(11, 'pollo', '2016-04-20'),
(12, 'latte', '2016-04-13'),
(13, 'tbgvr', '2016-04-27'),
(14, 'brtvecw', '2016-05-25');

-- --------------------------------------------------------

--
-- Struttura della tabella `ricette`
--

CREATE TABLE IF NOT EXISTS `ricette` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `Tipo` set('antipasti','primi','secondi','dolci') NOT NULL,
  `Titolo` varchar(25) NOT NULL,
  `Testo` text NOT NULL,
  `Prod1` varchar(25) DEFAULT 'vuoto',
  `Qta1` double DEFAULT '0',
  `Prod2` varchar(25) DEFAULT 'vuoto',
  `Qta2` double DEFAULT '0',
  `Prod3` varchar(25) DEFAULT 'vuoto',
  `Qta3` double DEFAULT '0',
  `Prod4` varchar(25) DEFAULT 'vuoto',
  `Qta4` double DEFAULT '0',
  `Prod5` varchar(25) DEFAULT 'vuoto',
  `Qta5` double DEFAULT '0',
  `Prod6` varchar(25) DEFAULT 'vuoto',
  `Qta6` double DEFAULT '0',
  `Prod7` varchar(25) DEFAULT 'vuoto',
  `Qta7` double DEFAULT '0',
  `Prod8` varchar(25) DEFAULT 'vuoto',
  `Qta8` double DEFAULT '0',
  `Prod9` varchar(25) DEFAULT 'vuoto',
  `Qta9` double DEFAULT '0',
  `Prod10` varchar(25) DEFAULT 'vuoto',
  `Qta10` double DEFAULT '0',
  `Prod11` varchar(25) DEFAULT 'vuoto',
  `Qta11` float DEFAULT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1 AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Struttura della tabella `utenti`
--

CREATE TABLE IF NOT EXISTS `utenti` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `Username` varchar(20) NOT NULL,
  `Password` varchar(35) NOT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=4 ;

--
-- Dump dei dati per la tabella `utenti`
--

INSERT INTO `utenti` (`ID`, `Username`, `Password`) VALUES
(1, 'Frigo1', '6e6bc4e49dd477ebc98ef4046c067b5f'),
(2, 'Frigo2', 'f2293aa6431ff49aa481e7acaea71116'),
(3, 'Frigo3', '3cd56ca40c0be39daad5c1398df013f9');

-- --------------------------------------------------------

--
-- Struttura della tabella `utenti_frigo`
--

CREATE TABLE IF NOT EXISTS `utenti_frigo` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `nome` varchar(20) NOT NULL,
  `cognome` varchar(20) NOT NULL,
  `sesso` char(3) NOT NULL,
  `peso` int(7) NOT NULL,
  `altezza` int(7) NOT NULL,
  `eta` int(5) NOT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=5 ;

--
-- Dump dei dati per la tabella `utenti_frigo`
--

INSERT INTO `utenti_frigo` (`ID`, `nome`, `cognome`, `sesso`, `peso`, `altezza`, `eta`) VALUES
(1, 'Giulio', 'Ballabio', 'M', 83, 184, 18),
(2, 'Luca', 'Pellizzer', 'M', 70, 180, 18),
(3, 'Francesco', 'Castelli', 'M', 65, 175, 18),
(4, 'Nicholas', 'Molteni', 'M', 68, 183, 18);

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
