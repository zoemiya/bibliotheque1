-- phpMyAdmin SQL Dump
-- version 5.0.2
-- https://www.phpmyadmin.net/
--
-- Hôte : 127.0.0.1:3306
-- Généré le : jeu. 03 juin 2021 à 21:04
-- Version du serveur :  5.7.31
-- Version de PHP : 7.3.21

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de données : `bibliotheque`
--
CREATE DATABASE IF NOT EXISTS `bibliotheque` DEFAULT CHARACTER SET utf8 COLLATE utf8_unicode_ci;
USE `bibliotheque`;

-- --------------------------------------------------------

--
-- Structure de la table `absence`
--

DROP TABLE IF EXISTS `absence`;
CREATE TABLE IF NOT EXISTS `absence` (
  `IDPERSONNEL` int(11) NOT NULL,
  `DATEDEBUT` datetime NOT NULL,
  `IDMOTIF` int(11) NOT NULL,
  `DATEFIN` datetime DEFAULT NULL,
  PRIMARY KEY (`IDPERSONNEL`,`DATEDEBUT`),
  KEY `I_FK_ABSENCE_MOTIF` (`IDMOTIF`),
  KEY `I_FK_ABSENCE_PERSONNEL` (`IDPERSONNEL`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Déchargement des données de la table `absence`
--

INSERT INTO `absence` (`IDPERSONNEL`, `DATEDEBUT`, `IDMOTIF`, `DATEFIN`) VALUES
(1, '2020-05-29 21:58:47', 2, '2021-12-10 14:45:21'),
(3, '2021-06-01 14:31:19', 3, '2020-11-13 13:06:15'),
(10, '2020-08-27 20:11:23', 1, '2022-03-07 03:31:43'),
(2, '2022-02-22 00:09:10', 2, '2021-02-22 10:14:12'),
(10, '2021-04-24 06:35:37', 1, '2021-11-19 01:12:50'),
(3, '2022-04-30 03:53:11', 2, '2020-10-26 04:06:23'),
(7, '2021-07-17 18:29:58', 2, '2021-05-26 13:48:36'),
(8, '2020-11-11 17:21:12', 1, '2021-10-18 17:22:43'),
(4, '2022-04-11 20:10:29', 3, '2020-11-11 12:21:41'),
(9, '2020-08-21 05:13:28', 2, '2021-06-21 01:31:34'),
(8, '2020-11-21 11:09:30', 3, '2022-05-09 12:16:48'),
(4, '2022-05-22 07:49:14', 3, '2021-08-09 20:33:48'),
(7, '2021-01-23 12:25:10', 3, '2021-07-28 21:25:23'),
(4, '2021-05-16 17:55:24', 3, '2021-04-18 10:36:10'),
(3, '2020-06-08 23:22:07', 3, '2021-01-28 12:15:44'),
(1, '2021-05-05 13:16:36', 2, '2020-08-07 16:10:25'),
(8, '2020-07-09 18:24:34', 1, '2021-07-07 07:56:46'),
(4, '2020-12-29 16:34:21', 2, '2021-05-30 20:27:27'),
(2, '2022-01-31 00:45:36', 1, '2021-07-10 20:07:22'),
(8, '2022-03-25 18:02:11', 3, '2022-05-17 23:38:49'),
(9, '2021-04-11 21:20:07', 1, '2020-06-04 06:01:10'),
(4, '2020-07-15 14:52:13', 2, '2021-07-21 23:55:16'),
(1, '2020-11-06 21:53:28', 2, '2020-09-01 04:02:49'),
(3, '2021-04-17 15:39:26', 1, '2021-06-20 15:06:18'),
(9, '2021-12-30 23:02:01', 1, '2020-06-10 17:02:53'),
(6, '2020-09-01 18:09:20', 1, '2022-01-22 03:42:43'),
(6, '2021-06-02 09:23:26', 1, '2021-04-10 14:06:25'),
(6, '2020-07-06 22:20:12', 3, '2021-07-12 09:35:47'),
(1, '2020-05-27 00:02:38', 3, '2021-05-14 14:14:33'),
(2, '2020-09-11 18:49:23', 1, '2021-10-13 01:58:00'),
(3, '2021-05-12 04:00:07', 3, '2020-09-26 01:44:57'),
(9, '2021-12-14 09:32:08', 1, '2021-07-24 23:35:01'),
(5, '2021-08-11 19:02:28', 1, '2021-02-06 02:54:36'),
(9, '2021-03-19 03:57:30', 2, '2021-09-11 14:39:36'),
(6, '2020-11-20 09:38:29', 3, '2020-11-06 01:24:45'),
(2, '2021-11-02 17:19:01', 2, '2021-08-29 15:06:07'),
(4, '2020-12-22 16:04:14', 2, '2022-05-23 08:20:50'),
(8, '2020-09-24 05:29:18', 3, '2021-11-06 13:56:57'),
(1, '2021-11-16 04:13:08', 2, '2020-12-18 17:44:59'),
(1, '2021-11-01 17:52:02', 1, '2021-01-08 15:25:15'),
(4, '2021-06-21 11:50:45', 2, '2021-05-19 22:51:12'),
(7, '2022-02-28 23:22:30', 1, '2021-09-03 00:22:48'),
(7, '2020-07-17 18:13:34', 3, '2020-11-01 11:51:50'),
(9, '2022-01-28 14:50:33', 2, '2021-10-10 11:01:25'),
(5, '2022-05-13 01:05:56', 3, '2021-12-07 02:59:00'),
(4, '2022-01-19 01:44:09', 1, '2022-01-30 22:29:18'),
(3, '2020-12-07 23:02:41', 3, '2021-08-23 00:08:35'),
(9, '2021-06-03 10:43:49', 2, '2020-11-02 18:10:51'),
(3, '2021-06-03 09:27:54', 4, '2021-06-08 09:27:53'),
(9, '2021-06-03 09:36:11', 4, '2021-06-08 09:36:11'),
(4, '2021-06-01 10:10:35', 1, '2021-06-05 10:10:35');

-- --------------------------------------------------------

--
-- Structure de la table `motif`
--

DROP TABLE IF EXISTS `motif`;
CREATE TABLE IF NOT EXISTS `motif` (
  `IDMOTIF` int(11) NOT NULL AUTO_INCREMENT,
  `LIBELLE` varchar(128) COLLATE utf8_unicode_ci DEFAULT NULL,
  PRIMARY KEY (`IDMOTIF`)
) ENGINE=MyISAM AUTO_INCREMENT=5 DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Déchargement des données de la table `motif`
--

INSERT INTO `motif` (`IDMOTIF`, `LIBELLE`) VALUES
(1, 'vacances'),
(2, 'maladie'),
(3, 'motif familial'),
(4, 'congé parental');

-- --------------------------------------------------------

--
-- Structure de la table `personnel`
--

DROP TABLE IF EXISTS `personnel`;
CREATE TABLE IF NOT EXISTS `personnel` (
  `IDPERSONNEL` int(11) NOT NULL AUTO_INCREMENT,
  `IDSERVICE` int(11) NOT NULL,
  `NOM` varchar(50) COLLATE utf8_unicode_ci DEFAULT NULL,
  `PRENOM` varchar(50) COLLATE utf8_unicode_ci DEFAULT NULL,
  `TEL` varchar(15) COLLATE utf8_unicode_ci DEFAULT NULL,
  `MAIL` varchar(128) COLLATE utf8_unicode_ci DEFAULT NULL,
  PRIMARY KEY (`IDPERSONNEL`),
  KEY `I_FK_PERSONNEL_SERVICE` (`IDSERVICE`)
) ENGINE=MyISAM AUTO_INCREMENT=17 DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Déchargement des données de la table `personnel`
--

INSERT INTO `personnel` (`IDPERSONNEL`, `IDSERVICE`, `NOM`, `PRENOM`, `TEL`, `MAIL`) VALUES
(1, 1, 'Ashley', 'Brandon', '01 52 51 80 15', 'et.euismod.et@et.net'),
(2, 2, 'Bonner', 'Quincy', '04 56 41 19 39', 'Sed@disparturientmontes.com'),
(3, 3, 'Mejia', 'Britanney', '04 39 82 72 67', 'Donec.est.Nunc@egetlacus.com'),
(4, 1, 'rob', 'robi', '1', '0'),
(16, 1, 'nn', 'p', 'mm', 't'),
(5, 2, 'Talley', 'Driscoll', '04 86 65 71 10', 'lacus.Cras.interdum@sit.ca'),
(6, 2, 'Pennington', 'Uta', '07 37 46 95 06', 'pede.Praesent.eu@sitametconsectetuer.ca'),
(14, 1, 'n', 'p', 'mm', 't'),
(15, 1, 'n', 'p', 't', 'm'),
(8, 2, 'Rocha', 'Dana', '04 74 28 24 98', 'dignissim.lacus@sem.com'),
(9, 3, 'Meyers', 'Devin', '04 46 52 22 71', 'Vestibulum.ante.ipsum@tincidunttempusrisus.net'),
(10, 3, 'Torres', 'Camden', '04 81 48 86 06', 'tincidunt.neque@etmagnisdis.net'),
(12, 1, 'ss', 's', 's', 's');

-- --------------------------------------------------------

--
-- Structure de la table `responsable`
--

DROP TABLE IF EXISTS `responsable`;
CREATE TABLE IF NOT EXISTS `responsable` (
  `login` varchar(64) COLLATE utf8_unicode_ci NOT NULL,
  `pwd` varchar(64) COLLATE utf8_unicode_ci NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Déchargement des données de la table `responsable`
--

INSERT INTO `responsable` (`login`, `pwd`) VALUES
('adm', 'SHA2(\"adm\", 256)'),
('adm', 'SHA2(\"adm\", 256)'),
('rcharon', 'dfg'),
('zo', 'zo');

-- --------------------------------------------------------

--
-- Structure de la table `service`
--

DROP TABLE IF EXISTS `service`;
CREATE TABLE IF NOT EXISTS `service` (
  `IDSERVICE` int(11) NOT NULL AUTO_INCREMENT,
  `NOM` varchar(50) COLLATE utf8_unicode_ci DEFAULT NULL,
  PRIMARY KEY (`IDSERVICE`)
) ENGINE=MyISAM AUTO_INCREMENT=4 DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Déchargement des données de la table `service`
--

INSERT INTO `service` (`IDSERVICE`, `NOM`) VALUES
(1, 'administratif'),
(2, 'mediation culturelle'),
(3, 'pret');
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
