-- phpMyAdmin SQL Dump
-- version 4.1.14
-- http://www.phpmyadmin.net
--
-- Host: 127.0.0.1
-- Generation Time: Apr 09, 2016 alle 14:17
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
  `nome` varchar(35) NOT NULL,
  `tipo` varchar(20) NOT NULL,
  `dataScadenza` date NOT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=8 ;

--
-- Dump dei dati per la tabella `prodotti`
--

INSERT INTO `prodotti` (`ID`, `nome`, `tipo`, `dataScadenza`) VALUES
(1, 'latte', 'bevanda', '2016-04-04'),
(2, 'insalata', 'verdura', '2016-04-01'),
(3, 'vino', 'bevanda', '2016-04-24'),
(4, 'pollo', 'carne', '2016-04-27'),
(5, 'fontina', 'formaggio', '2016-05-18'),
(6, 'tavoletta di cioccolato', 'dolce', '2016-05-12'),
(7, 'bistecche tacchino', 'carne', '2016-04-05');

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
