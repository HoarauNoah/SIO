-- phpMyAdmin SQL Dump
-- version 5.0.2
-- https://www.phpmyadmin.net/
--
-- Hôte : 127.0.0.1:3307
-- Généré le : jeu. 20 mai 2021 à 16:42
-- Version du serveur :  10.4.13-MariaDB
-- Version de PHP : 7.3.21

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de données : `hoarau_ppe`
--

DELIMITER $$
--
-- Procédures
--
DROP PROCEDURE IF EXISTS `ChangeQteProduitCommande`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `ChangeQteProduitCommande` (IN `qte` INT(255), IN `idCom` INT(255), IN `idProd` INT(255))  NO SQL
update lignedecommande set QuantiteCom = qte Where idCommande = idCom and idProduit = idProd$$

DROP PROCEDURE IF EXISTS `DeleteCommandeById`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `DeleteCommandeById` (IN `id` INT(255))  NO SQL
delete from commande where commande.idCommande = id$$

DROP PROCEDURE IF EXISTS `DeleteProduitByCommande`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `DeleteProduitByCommande` (IN `idCom` INT(255), IN `idProd` INT(255))  NO SQL
DELETE FROM lignedecommande
WHERE lignedecommande.idCommande = idCom and lignedecommande.idProduit = idProd$$

DROP PROCEDURE IF EXISTS `GetAllCategories`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `GetAllCategories` ()  NO SQL
select * from categorie$$

DROP PROCEDURE IF EXISTS `GetAllClients`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `GetAllClients` ()  NO SQL
select * from client$$

DROP PROCEDURE IF EXISTS `GetAllCommandes`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `GetAllCommandes` ()  NO SQL
SELECT * from commande$$

DROP PROCEDURE IF EXISTS `GetAllCommandesDG`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `GetAllCommandesDG` ()  NO SQL
Select  commande.idCommande ,dateCommande , CONCAT(prenomClient , ' ' , nomClient) as Client , sum(prixHTProduit* 0.20* quantiteCom) as PrixTTC  from client, commande , produit , lignedecommande  where client.idClient = commande.idCli and lignedecommande.idCommande = commande.idCommande and lignedecommande.idProduit = produit.idProduit group by idCommande$$

DROP PROCEDURE IF EXISTS `GetCommandeById`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `GetCommandeById` (IN `id` INT(255))  NO SQL
select lignedecommande.* from lignedecommande where lignedecommande.idCommande = id$$

DROP PROCEDURE IF EXISTS `GetProduitByCommande`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `GetProduitByCommande` (IN `id` INT(255))  NO SQL
select lignedecommande.idProduit, produit.LibelleProduit from lignedecommande, produit where lignedecommande.idProduit = produit.idProduit and lignedecommande.idCommande = id$$

DROP PROCEDURE IF EXISTS `GetProduitByIdCategorie`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `GetProduitByIdCategorie` (IN `id` INT(255))  NO SQL
select * from produit where idCat = id$$

DROP PROCEDURE IF EXISTS `GetQteProduitCommande`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `GetQteProduitCommande` (IN `idCom` INT(255), IN `idProd` INT(255))  NO SQL
SELECT QuantiteCom From lignedecommande where idCommande = idcom and idProduit = idprod$$

DROP PROCEDURE IF EXISTS `GetTotalHTbyCommande`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `GetTotalHTbyCommande` (IN `id` INT(255))  NO SQL
select sum(produit.PrixHTProduit*lignedecommande.QuantiteCom) as "Total HT" from produit, lignedecommande where produit.idProduit = lignedecommande.idProduit and idCommande = id$$

DROP PROCEDURE IF EXISTS `InsertCommande`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `InsertCommande` (IN `idCom` INT(255), IN `DateCom` VARCHAR(10), IN `idCli` INT(255))  NO SQL
INSERT INTO commande VALUES (idCom, DateCom, idCli)$$

DROP PROCEDURE IF EXISTS `InsertProduitByCommande`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `InsertProduitByCommande` (IN `idCom` INT(255), IN `idProd` INT(255), IN `qte` INT(255))  NO SQL
INSERT INTO lignedecommande VALUES (idCom, idProd, qte)$$

DELIMITER ;

-- --------------------------------------------------------

--
-- Structure de la table `categorie`
--

DROP TABLE IF EXISTS `categorie`;
CREATE TABLE IF NOT EXISTS `categorie` (
  `idCategorie` int(11) NOT NULL,
  `LibelleCategorie` varchar(45) DEFAULT NULL,
  `CaCategorie` int(255) NOT NULL DEFAULT 0,
  PRIMARY KEY (`idCategorie`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Déchargement des données de la table `categorie`
--

INSERT INTO `categorie` (`idCategorie`, `LibelleCategorie`, `CaCategorie`) VALUES
(1, 'Materiel', 1050),
(2, 'Logiciel', 0),
(3, 'Service', 0),
(4, 'Documentation', 0);

-- --------------------------------------------------------

--
-- Structure de la table `client`
--

DROP TABLE IF EXISTS `client`;
CREATE TABLE IF NOT EXISTS `client` (
  `idClient` int(11) NOT NULL,
  `NomClient` varchar(100) DEFAULT NULL,
  `PrenomClient` varchar(45) DEFAULT NULL,
  `AdRueClient` varchar(150) DEFAULT NULL,
  `AdCpClient` int(11) DEFAULT NULL,
  `AdVilleClient` varchar(100) DEFAULT NULL,
  PRIMARY KEY (`idClient`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Déchargement des données de la table `client`
--

INSERT INTO `client` (`idClient`, `NomClient`, `PrenomClient`, `AdRueClient`, `AdCpClient`, `AdVilleClient`) VALUES
(1, 'Dupont', 'Roger', '12 rue du patus', 34500, 'Beziers'),
(2, 'Durand', 'Yves', '17 rue des greses', 34500, 'Beziers'),
(3, 'Hoarau', 'Noah', 'Chemin', 34150, 'Gignac');

-- --------------------------------------------------------

--
-- Structure de la table `commande`
--

DROP TABLE IF EXISTS `commande`;
CREATE TABLE IF NOT EXISTS `commande` (
  `idCommande` int(11) NOT NULL,
  `DateCommande` varchar(10) DEFAULT NULL,
  `idCli` int(11) DEFAULT NULL,
  `valider` tinyint(1) NOT NULL,
  PRIMARY KEY (`idCommande`),
  KEY `FKCli` (`idCli`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Déchargement des données de la table `commande`
--

INSERT INTO `commande` (`idCommande`, `DateCommande`, `idCli`, `valider`) VALUES
(1, '22/01/2020', 1, 0),
(2, '21/01/2020', 1, 0),
(3, '21/01/2020', 2, 0),
(4, '12/11/2020', 2, 0),
(5, '12/11/2020', 2, 0),
(8, '01/04/2020', 3, 1);

--
-- Déclencheurs `commande`
--
DROP TRIGGER IF EXISTS `VerifValideCommande`;
DELIMITER $$
CREATE TRIGGER `VerifValideCommande` BEFORE INSERT ON `commande` FOR EACH ROW BEGIN
DECLARE msg varchar(255);
DECLARE idProduitI integer;
DECLARE idClientI integer;
declare valide integer;
set idClientI = NEW.idCli;
set valide =(SELECT COUNT(*) FROM commande where commande.idCli = idClientI and commande.valider = 0);

if(valide <> 0) then
set msg = 'Une commande est déjà en cours';
SIGNAL SQLSTATE '45000' set MESSAGE_TEXT = msg;
end if;
END
$$
DELIMITER ;

-- --------------------------------------------------------

--
-- Structure de la table `fournisseur`
--

DROP TABLE IF EXISTS `fournisseur`;
CREATE TABLE IF NOT EXISTS `fournisseur` (
  `idFournisseur` int(11) NOT NULL,
  `NomFournisseur` varchar(100) DEFAULT NULL,
  `VilleFournisseur` varchar(100) DEFAULT NULL,
  `CPFournisseur` int(11) DEFAULT NULL,
  PRIMARY KEY (`idFournisseur`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Déchargement des données de la table `fournisseur`
--

INSERT INTO `fournisseur` (`idFournisseur`, `NomFournisseur`, `VilleFournisseur`, `CPFournisseur`) VALUES
(1, 'DELL Computers', 'Montpellier', 34000),
(2, 'IBM', 'Montpellier', 34000),
(3, 'RC Consulting', 'Sérignan', 34500);

-- --------------------------------------------------------

--
-- Structure de la table `lignedecommande`
--

DROP TABLE IF EXISTS `lignedecommande`;
CREATE TABLE IF NOT EXISTS `lignedecommande` (
  `idCommande` int(11) NOT NULL,
  `idProduit` int(11) NOT NULL,
  `QuantiteCom` int(11) NOT NULL,
  PRIMARY KEY (`idCommande`,`idProduit`),
  KEY `FKCom` (`idCommande`),
  KEY `FKProd` (`idProduit`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Déchargement des données de la table `lignedecommande`
--

INSERT INTO `lignedecommande` (`idCommande`, `idProduit`, `QuantiteCom`) VALUES
(1, 1, 1),
(1, 2, 2),
(1, 3, 1),
(1, 5, 1),
(2, 2, 1),
(2, 3, 1),
(2, 4, 2),
(3, 4, 1),
(4, 1, 2);

--
-- Déclencheurs `lignedecommande`
--
DROP TRIGGER IF EXISTS `CACategorieInsert`;
DELIMITER $$
CREATE TRIGGER `CACategorieInsert` AFTER INSERT ON `lignedecommande` FOR EACH ROW BEGIN
DECLARE msg varchar(255);
DECLARE idProduitI integer;
declare CANew integer;
declare CA integer;
declare qteI integer;
declare idCategProduit integer;
set idProduitI = NEW.idProduit;
set qteI = new.QuantiteCom;

set idCategProduit = (SELECT produit.idCat from produit where produit.idProduit = idProduitI);

set CA = (SELECT categorie.CACategorie from categorie where categorie.idCategorie = idCategProduit);

set CANew =((SELECT prixHTProduit from produit where idProduit = new.idProduit)*qteI)+CA;

UPDATE categorie SET categorie.CACategorie = CANew where categorie.idCategorie = idProduitI;

END
$$
DELIMITER ;
DROP TRIGGER IF EXISTS `VerifStockInsert`;
DELIMITER $$
CREATE TRIGGER `VerifStockInsert` BEFORE INSERT ON `lignedecommande` FOR EACH ROW BEGIN
DECLARE msg varchar(255);
DECLARE idProduitI integer;
declare qteP integer;
declare qteI integer;
set idProduitI = NEW.idProduit;
set qteI = new.QuantiteCom;
set qteP =(SELECT QteStockProduit from produit where idProduit = new.idProduit);
if(qteP - qteI <0) then
set msg = 'La quantité commandée est supérieur à celle en stock';
SIGNAL SQLSTATE '45000' set MESSAGE_TEXT = msg;
end if;
END
$$
DELIMITER ;
DROP TRIGGER IF EXISTS `VerifStockUpdate`;
DELIMITER $$
CREATE TRIGGER `VerifStockUpdate` BEFORE UPDATE ON `lignedecommande` FOR EACH ROW BEGIN
DECLARE msg varchar(255);
DECLARE idProduitI integer;
declare qteP integer;
declare qteI integer;
set idProduitI = NEW.idProduit;
set qteI = new.QuantiteCom;
set qteP =(SELECT QteStockProduit from produit where idProduit = new.idProduit);
if(qteP - qteI <0) then
set msg = 'La quantité commandée est supérieur à celle en stock';
SIGNAL SQLSTATE '45000' set MESSAGE_TEXT = msg;
end if;
END
$$
DELIMITER ;

-- --------------------------------------------------------

--
-- Structure de la table `produit`
--

DROP TABLE IF EXISTS `produit`;
CREATE TABLE IF NOT EXISTS `produit` (
  `idProduit` int(11) NOT NULL,
  `LibelleProduit` varchar(100) DEFAULT NULL,
  `PrixHTProduit` float(6,2) DEFAULT NULL,
  `QteStockProduit` int(11) DEFAULT NULL,
  `idFourn` int(11) DEFAULT NULL,
  `idCat` int(11) DEFAULT NULL,
  PRIMARY KEY (`idProduit`),
  KEY `FKFourn` (`idFourn`),
  KEY `FKCat` (`idCat`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Déchargement des données de la table `produit`
--

INSERT INTO `produit` (`idProduit`, `LibelleProduit`, `PrixHTProduit`, `QteStockProduit`, `idFourn`, `idCat`) VALUES
(1, 'Optiplex 3010', 350.00, 12, 1, 1),
(2, 'Nas Server', 890.00, 6, 2, 1),
(3, 'Logiciel GestCom', 550.00, 10, 3, 2),
(4, 'Formation GestCom', 100.00, 10, 3, 3),
(5, 'Support Utilisateur', 150.00, 10, 3, 4);

--
-- Contraintes pour les tables déchargées
--

--
-- Contraintes pour la table `commande`
--
ALTER TABLE `commande`
  ADD CONSTRAINT `FKCli` FOREIGN KEY (`idCli`) REFERENCES `client` (`idClient`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Contraintes pour la table `lignedecommande`
--
ALTER TABLE `lignedecommande`
  ADD CONSTRAINT `FKCom` FOREIGN KEY (`idCommande`) REFERENCES `commande` (`idCommande`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `FKProd` FOREIGN KEY (`idProduit`) REFERENCES `produit` (`idProduit`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Contraintes pour la table `produit`
--
ALTER TABLE `produit`
  ADD CONSTRAINT `FKCat` FOREIGN KEY (`idCat`) REFERENCES `categorie` (`idCategorie`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `FKFourn` FOREIGN KEY (`idFourn`) REFERENCES `fournisseur` (`idFournisseur`) ON DELETE NO ACTION ON UPDATE NO ACTION;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
