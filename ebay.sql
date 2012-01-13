CREATE DATABASE IF NOT EXISTS ebay_data;
USE ebay_data;

DROP TABLE IF EXISTS `ebay_data`.`listeditems`;
CREATE TABLE  `ebay_data`.`listeditems` (
  `ID` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `SKU` varchar(45) NOT NULL,
  `ItemID` varchar(45) NOT NULL,
  PRIMARY KEY (`ID`)
);


DROP TABLE IF EXISTS `ebay_data`.`logs`;
CREATE TABLE  `ebay_data`.`logs` (
  `ID` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `SKU` varchar(45) NOT NULL,
  `Comments` text NOT NULL,
  `TimeStamp` datetime NOT NULL,
  PRIMARY KEY (`ID`)
);


DROP TABLE IF EXISTS `ebay_data`.`tempdata`;
CREATE TABLE  `ebay_data`.`tempdata` (
  `SKU` varchar(45) NOT NULL,
  `AUTHOR` varchar(255) NOT NULL,
  `TITLE` varchar(255) DEFAULT NULL,
  `BOOK_CONDITION` varchar(45) DEFAULT NULL,
  `BOOK_SIZE` varchar(45) DEFAULT NULL,
  `JACKET_CONDITION` varchar(45) DEFAULT NULL,
  `BINDING` varchar(45) DEFAULT NULL,
  `ISBN` varchar(45) DEFAULT NULL,
  `PUBLISHER` varchar(45) DEFAULT NULL,
  `PUBLISH_PLACE` varchar(45) DEFAULT NULL,
  `PUBLISH_DATE` varchar(10) DEFAULT NULL,
  `EDITION` varchar(45) DEFAULT NULL,
  `SIGNATURE` varchar(45) DEFAULT NULL,
  `NOTES` text,
  `QUANTITY` smallint(5) unsigned NOT NULL,
  `PRICE` decimal(8,2) NOT NULL,
  `IMAGE` varchar(255) DEFAULT NULL,
  `CATEGORY1` varchar(45) DEFAULT NULL,
  `CATEGORY2` varchar(45) DEFAULT NULL,
  `CATEGORY3` varchar(45) DEFAULT NULL,
  `CATEGORY4` varchar(45) DEFAULT NULL,
  `CATEGORY5` varchar(45) DEFAULT NULL,
  `KEYWORD1` varchar(45) DEFAULT NULL,
  `KEYWORD2` varchar(45) DEFAULT NULL,
  `KEYWORD3` varchar(45) DEFAULT NULL,
  `KEYWORD4` varchar(45) DEFAULT NULL,
  `KEYWORD5` varchar(45) DEFAULT NULL,
  `KEYWORD6` varchar(45) DEFAULT NULL,
  `KEYWORD7` varchar(45) DEFAULT NULL,
  `KEYWORD8` varchar(45) DEFAULT NULL,
  `KEYWORD9` varchar(45) DEFAULT NULL,
  `WEIGHT` decimal(10,0) unsigned DEFAULT NULL,
  `UPC` varchar(20) DEFAULT NULL,
  `DESCRIPTION` varchar(45) NOT NULL,
  PRIMARY KEY (`SKU`)
);
