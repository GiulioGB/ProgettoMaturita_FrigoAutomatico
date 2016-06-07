-- phpMyAdmin SQL Dump
-- version 4.1.14
-- http://www.phpmyadmin.net
--
-- Host: 127.0.0.1
-- Generation Time: Giu 07, 2016 alle 10:49
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
  `Nome` varchar(35) NOT NULL,
  PRIMARY KEY (`ID`),
  UNIQUE KEY `Nome` (`Nome`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=40 ;

--
-- Dump dei dati per la tabella `alimento`
--

INSERT INTO `alimento` (`ID`, `Nome`) VALUES
(11, 'Ananas'),
(5, 'Anguria'),
(2, 'Banana'),
(21, 'Burro d''arachidi'),
(36, 'Cioccolato fondente'),
(29, 'Cipolla tritata'),
(22, 'Cous cous'),
(37, 'Dado vegetale'),
(26, 'Fanta'),
(10, 'Fichi'),
(35, 'Formaggio spalmabile'),
(15, 'Grana'),
(4, 'Insalata'),
(19, 'Lasagne'),
(1, 'Latte'),
(9, 'Limone'),
(20, 'Marmellata albicocch'),
(38, 'Mascarpone'),
(7, 'Mela'),
(12, 'Melone'),
(33, 'Merluzzo'),
(28, 'Misto per soffritto'),
(30, 'Mozzarelle'),
(16, 'Pane'),
(23, 'Pasta sfoglia'),
(6, 'Pera'),
(8, 'Pesca'),
(3, 'Pomodoro'),
(27, 'Robiola'),
(34, 'Salmone'),
(25, 'Sfornato'),
(39, 'Sorbetto al limone'),
(18, 'Sprite'),
(17, 'Succo arancia'),
(24, 'Succo arancia rosso'),
(31, 'Thè pesca'),
(14, 'Uova'),
(13, 'Uva'),
(32, 'Vongole');

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

--
-- Dump dei dati per la tabella `familiare`
--

INSERT INTO `familiare` (`ID`, `Nome`, `Cognome`, `Sesso`, `Peso`, `Altezza`, `Eta`, `IDFrigo`) VALUES
(1, 'Giulio', 'Ballabio', 'M', 80, 180, 18, 1),
(2, 'Molteni', 'Nicholas', 'F', 80, 170, 18, 1);

-- --------------------------------------------------------

--
-- Struttura della tabella `frigo`
--

CREATE TABLE IF NOT EXISTS `frigo` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `Username` varchar(20) NOT NULL,
  `Password` varchar(40) NOT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=3 ;

--
-- Dump dei dati per la tabella `frigo`
--

INSERT INTO `frigo` (`ID`, `Username`, `Password`) VALUES
(1, 'Frigo1', 'c7cc6a1fd6d6b5f4817025cb532b52fa'),
(2, 'Frigo2', 'f2293aa6431ff49aa481e7acaea71116');

-- --------------------------------------------------------

--
-- Struttura della tabella `listaspesa`
--

CREATE TABLE IF NOT EXISTS `listaspesa` (
  `ID` int(5) NOT NULL AUTO_INCREMENT,
  `nomeAlimento` varchar(30) NOT NULL,
  `quantita` int(5) NOT NULL,
  `IDFrigo` int(5) NOT NULL,
  PRIMARY KEY (`ID`),
  KEY `IDFrigo` (`IDFrigo`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=5 ;

--
-- Dump dei dati per la tabella `listaspesa`
--

INSERT INTO `listaspesa` (`ID`, `nomeAlimento`, `quantita`, `IDFrigo`) VALUES
(3, 'BananaGiulio', 2, 1),
(4, 'Mela', 4, 1);

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
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=6 ;

--
-- Dump dei dati per la tabella `preferito`
--

INSERT INTO `preferito` (`ID`, `IDAlimento`, `IDFamiliare`) VALUES
(1, 1, 1),
(2, 2, 1),
(3, 3, 1),
(4, 4, 1),
(5, 4, 2);

-- --------------------------------------------------------

--
-- Struttura della tabella `prodotto`
--

CREATE TABLE IF NOT EXISTS `prodotto` (
  `ID` int(5) NOT NULL AUTO_INCREMENT,
  `EAN` varchar(50) DEFAULT NULL,
  `NomeAlimento` varchar(35) NOT NULL,
  `dataScadenza` varchar(25) DEFAULT NULL,
  `IDFrigo` int(5) NOT NULL,
  `luogoProduzione` varchar(20) DEFAULT NULL,
  `Quantita` int(5) NOT NULL,
  PRIMARY KEY (`ID`),
  KEY `IDFrigo` (`IDFrigo`),
  KEY `NomeAlimento` (`NomeAlimento`)
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
-- Limiti per la tabella `listaspesa`
--
ALTER TABLE `listaspesa`
  ADD CONSTRAINT `listaspesa_ibfk_1` FOREIGN KEY (`IDFrigo`) REFERENCES `frigo` (`ID`) ON DELETE CASCADE ON UPDATE CASCADE;

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
  ADD CONSTRAINT `prodotto_ibfk_1` FOREIGN KEY (`IDFrigo`) REFERENCES `frigo` (`ID`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `prodotto_ibfk_2` FOREIGN KEY (`NomeAlimento`) REFERENCES `alimento` (`Nome`) ON DELETE NO ACTION ON UPDATE NO ACTION;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
