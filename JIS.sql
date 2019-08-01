CREATE DATABASE  IF NOT EXISTS `jisdb` /*!40100 DEFAULT CHARACTER SET utf8 */;
USE `jisdb`;
-- MySQL dump 10.13  Distrib 5.7.17, for Win64 (x86_64)
--
-- Host: localhost    Database: jisdb
-- ------------------------------------------------------
-- Server version	5.7.19-log

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `accounts`
--

DROP TABLE IF EXISTS `accounts`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `accounts` (
  `Username` varchar(45) NOT NULL,
  `Password` varchar(45) DEFAULT NULL,
  `sec_ans1` varchar(45) DEFAULT NULL,
  `sec_ans2` varchar(45) DEFAULT NULL,
  `sec_ans3` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`Username`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `accounts`
--

LOCK TABLES `accounts` WRITE;
/*!40000 ALTER TABLE `accounts` DISABLE KEYS */;
INSERT INTO `accounts` VALUES ('','1234',NULL,NULL,NULL),('admin','admin','jhay','bucks','pet'),('jhay','bauyon',NULL,NULL,NULL),('John Erick','Bauyon',NULL,NULL,NULL);
/*!40000 ALTER TABLE `accounts` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `add_stocks`
--

DROP TABLE IF EXISTS `add_stocks`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `add_stocks` (
  `np_id` int(11) NOT NULL AUTO_INCREMENT,
  `productname` varchar(45) DEFAULT NULL,
  `stocks_added` varchar(45) DEFAULT NULL,
  `date` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`np_id`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `add_stocks`
--

LOCK TABLES `add_stocks` WRITE;
/*!40000 ALTER TABLE `add_stocks` DISABLE KEYS */;
INSERT INTO `add_stocks` VALUES (2,'shoecase','5','11/30/2017'),(3,'SHOECASE','-2','12/1/2017'),(4,'bag','25','12/6/2017'),(5,'lapis','6','12/6/2017');
/*!40000 ALTER TABLE `add_stocks` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `categories`
--

DROP TABLE IF EXISTS `categories`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `categories` (
  `CategoryId` int(11) NOT NULL AUTO_INCREMENT,
  `category` varchar(45) NOT NULL,
  PRIMARY KEY (`CategoryId`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `categories`
--

LOCK TABLES `categories` WRITE;
/*!40000 ALTER TABLE `categories` DISABLE KEYS */;
INSERT INTO `categories` VALUES (1,'school supply'),(2,'kitchen'),(3,'house'),(4,'personal');
/*!40000 ALTER TABLE `categories` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `products`
--

DROP TABLE IF EXISTS `products`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `products` (
  `ProductId` int(11) NOT NULL AUTO_INCREMENT,
  `ProductName` varchar(45) DEFAULT NULL,
  `CategoryID` int(11) DEFAULT NULL,
  `Stocks` int(11) DEFAULT NULL,
  `OriginalPrice` decimal(8,2) DEFAULT NULL,
  `RetailPrice` decimal(8,2) DEFAULT NULL,
  PRIMARY KEY (`ProductId`),
  KEY `fk_category_idx` (`CategoryID`),
  CONSTRAINT `fk_category` FOREIGN KEY (`CategoryID`) REFERENCES `categories` (`CategoryId`) ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=137 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `products`
--

LOCK TABLES `products` WRITE;
/*!40000 ALTER TABLE `products` DISABLE KEYS */;
INSERT INTO `products` VALUES (1,'shoecase',1,220,50.00,80.00),(2,'notebook',1,50,100.00,500.00),(3,'lapis',1,100,32.00,421.00),(4,'paper',3,64,50.00,80.00),(5,'ballpen',1,3,15.00,56.00),(108,'hanger',3,105,21.00,53.00),(109,'basin',3,75,51.00,60.00),(110,'cologne',4,90,13.00,54.00),(111,'lotion',4,36,21.00,156.00),(112,'dishwashing',2,35,30.00,50.00),(113,'soap',2,43,20.00,31.00),(115,'pen',1,3029,312.00,400.00),(134,'shoeglue',1,51,10.00,15.00),(135,'case',1,1234,5.00,8.00),(136,'bondpaper',2,12,12.00,18.00);
/*!40000 ALTER TABLE `products` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `purchased`
--

DROP TABLE IF EXISTS `purchased`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `purchased` (
  `PurchasedId` int(11) NOT NULL AUTO_INCREMENT,
  `ProductId` int(11) DEFAULT NULL,
  `Quantity` int(11) DEFAULT NULL,
  `Amount` decimal(8,2) DEFAULT NULL,
  `Profit` decimal(8,2) DEFAULT NULL,
  `Date` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`PurchasedId`),
  KEY `fk_productID_idx` (`ProductId`),
  CONSTRAINT `fk_productID` FOREIGN KEY (`ProductId`) REFERENCES `products` (`ProductId`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=63 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `purchased`
--

LOCK TABLES `purchased` WRITE;
/*!40000 ALTER TABLE `purchased` DISABLE KEYS */;
INSERT INTO `purchased` VALUES (44,1,4,320.00,120.00,'11/29/2017'),(45,2,4,2000.00,1600.00,'11/29/2017'),(46,3,6,2526.00,2334.00,'11/21/2017'),(47,111,2,312.00,270.00,'11/21/2017'),(49,112,4,200.00,80.00,'11/30/2017'),(50,115,6,2400.00,528.00,'11/30/2017'),(52,110,8,432.00,328.00,'12/2/2017'),(53,113,40,1240.00,440.00,'11/29/2017'),(54,110,123,6642.00,5043.00,'11/29/2018'),(55,1,1,80.00,30.00,'11/30/2017'),(56,1,4,320.00,120.00,'11/30/2017'),(57,1,5,400.00,150.00,'11/30/2017'),(58,1,2,160.00,60.00,'11/30/2017'),(59,1,23,1840.00,690.00,'11/30/2017'),(60,2,4,2000.00,1600.00,'12/1/2017'),(61,1,2,160.00,60.00,'12/6/2017'),(62,1,4,320.00,120.00,'12/6/2017');
/*!40000 ALTER TABLE `purchased` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2017-12-11 11:26:26
