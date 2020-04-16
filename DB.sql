-- MySQL dump 10.13  Distrib 5.7.17, for Win64 (x86_64)
--
-- Host: localhost    Database: fevproject
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
-- Table structure for table `comment`
--

DROP TABLE IF EXISTS `comment`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `comment` (
  `commentId` int(11) NOT NULL AUTO_INCREMENT,
  `taskId` int(11) NOT NULL,
  `owner` varchar(50) NOT NULL,
  `description` varchar(250) DEFAULT NULL,
  PRIMARY KEY (`commentId`),
  KEY `taskId` (`taskId`),
  KEY `owner` (`owner`),
  CONSTRAINT `comment_ibfk_1` FOREIGN KEY (`taskId`) REFERENCES `task` (`taskId`),
  CONSTRAINT `comment_ibfk_2` FOREIGN KEY (`owner`) REFERENCES `user` (`username`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `comment`
--

LOCK TABLES `comment` WRITE;
/*!40000 ALTER TABLE `comment` DISABLE KEYS */;
/*!40000 ALTER TABLE `comment` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `event`
--

DROP TABLE IF EXISTS `event`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `event` (
  `eventId` int(11) NOT NULL AUTO_INCREMENT,
  `username` varchar(50) NOT NULL,
  `done` bit(1) DEFAULT NULL,
  `name` varchar(50) DEFAULT NULL,
  `description` varchar(500) DEFAULT NULL,
  PRIMARY KEY (`eventId`),
  KEY `username` (`username`),
  CONSTRAINT `event_ibfk_1` FOREIGN KEY (`username`) REFERENCES `user` (`username`)
) ENGINE=InnoDB AUTO_INCREMENT=15 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `event`
--

LOCK TABLES `event` WRITE;
/*!40000 ALTER TABLE `event` DISABLE KEYS */;
INSERT INTO `event` VALUES (1,'admin','\0','Tet Holiday','Lorem ipsum dolor sit amet'),(2,'user','','Christmas','Lorem ipsum dolor sit amet, placerat egestas condimentum volutpat parturient dolor, quis mollis, adipisicing suspendisse posuere porttitor nunc egestas, libero nunc suspendisse a rutrum, in lorem libero viverra dolore felis erat. Amet pede, lectus vitae, urna turpis suspendisse ac placerat vitae neque, nisl eu nulla vel condimentum amet. Maecenas nulla non purus. Sed facilisis at lorem ligula sit. '),(3,'admin','\0','Cocktail Party','Lorem ipsum dolor sit amet, placerat egestas condimentum volutpat parturient dolor, quis mollis, adipisicing suspendisse posuere porttitor nunc egestas, libero nunc suspendisse a rutrum, in lorem libero viverra dolore felis erat. Amet pede, lectus vitae, urna turpis suspendisse ac placerat vitae neque, nisl eu nulla vel condimentum amet. Maecenas nulla non purus. Sed facilisis at lorem ligula sit. '),(4,'anhvdq','\0','Halloween','Lorem ipsum dolor sit amet, placerat egestas condimentum volutpat parturient dolor, quis mollis, adipisicing suspendisse posuere porttitor nunc egestas, libero nunc suspendisse a rutrum, in lorem libero viverra dolore felis erat. Amet pede, lectus vitae, urna turpis suspendisse ac placerat vitae neque, nisl eu nulla vel condimentum amet. Maecenas nulla non purus. Sed facilisis at lorem ligula sit. '),(5,'luannm','\0','Women Day','Lorem ipsum dolor sit amet, placerat egestas condimentum volutpat parturient dolor, quis mollis, adipisicing suspendisse posuere porttitor nunc egestas, libero nunc suspendisse a rutrum, in lorem libero viverra dolore felis erat. Amet pede, lectus vitae, urna turpis suspendisse ac placerat vitae neque, nisl eu nulla vel condimentum amet. Maecenas nulla non purus. Sed facilisis at lorem ligula sit. '),(6,'hoangnt','\0','New Year','Lorem ipsum dolor sit amet, placerat egestas condimentum volutpat parturient dolor, quis mollis, adipisicing suspendisse posuere porttitor nunc egestas, libero nunc suspendisse a rutrum, in lorem libero viverra dolore felis erat. Amet pede, lectus vitae, urna turpis suspendisse ac placerat vitae neque, nisl eu nulla vel condimentum amet. Maecenas nulla non purus. Sed facilisis at lorem ligula sit. '),(7,'jarvis','\0','Teacher\'s Day','Lorem ipsum dolor sit amet, placerat egestas condimentum volutpat parturient dolor, quis mollis, adipisicing suspendisse posuere porttitor nunc egestas, libero nunc suspendisse a rutrum, in lorem libero viverra dolore felis erat. Amet pede, lectus vitae, urna turpis suspendisse ac placerat vitae neque, nisl eu nulla vel condimentum amet. Maecenas nulla non purus. Sed facilisis at lorem ligula sit. '),(8,'jarvis','\0','Charity For Midsouth','Lorem ipsum dolor sit amet, placerat egestas condimentum volutpat parturient dolor, quis mollis, adipisicing suspendisse posuere porttitor nunc egestas, libero nunc suspendisse a rutrum, in lorem libero viverra dolore felis erat. Amet pede, lectus vitae, urna turpis suspendisse ac placerat vitae neque, nisl eu nulla vel condimentum amet. Maecenas nulla non purus. Sed facilisis at lorem ligula sit. '),(9,'flower','\0','FPT Photomarathon','Lorem ipsum dolor sit amet, placerat egestas condimentum volutpat parturient dolor, quis mollis, adipisicing suspendisse posuere porttitor nunc egestas, libero nunc suspendisse a rutrum, in lorem libero viverra dolore felis erat. Amet pede, lectus vitae, urna turpis suspendisse ac placerat vitae neque, nisl eu nulla vel condimentum amet. Maecenas nulla non purus. Sed facilisis at lorem ligula sit. '),(10,'huynguyen','\0','Cookie-baking party','Lorem ipsum dolor sit amet, placerat egestas condimentum volutpat parturient dolor, quis mollis, adipisicing suspendisse posuere porttitor nunc egestas, libero nunc suspendisse a rutrum, in lorem libero viverra dolore felis erat. Amet pede, lectus vitae, urna turpis suspendisse ac placerat vitae neque, nisl eu nulla vel condimentum amet. Maecenas nulla non purus. Sed facilisis at lorem ligula sit. '),(11,'admin','\0','Finding Nemo','You Need To Find Nemo'),(12,'admin','\0','Fly','Fly Avril Lavigne Fly Avril Lavigne Fly Avril Lavigne Fly Avril Lavigne '),(13,'admin','\0','Test','test'),(14,'admin','\0','Flyd','asdf');
/*!40000 ALTER TABLE `event` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `task`
--

DROP TABLE IF EXISTS `task`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `task` (
  `taskId` int(11) NOT NULL AUTO_INCREMENT,
  `teamId` int(11) NOT NULL,
  `owner` varchar(50) NOT NULL,
  `receiver` varchar(50) NOT NULL,
  `startDate` varchar(50) DEFAULT NULL,
  `endDate` varchar(50) DEFAULT NULL,
  `description` varchar(250) DEFAULT NULL,
  `accepted` bit(1) DEFAULT NULL,
  `done` bit(1) DEFAULT NULL,
  PRIMARY KEY (`taskId`),
  KEY `teamId` (`teamId`),
  KEY `owner` (`owner`),
  KEY `receiver` (`receiver`),
  CONSTRAINT `task_ibfk_1` FOREIGN KEY (`teamId`) REFERENCES `team` (`teamId`),
  CONSTRAINT `task_ibfk_2` FOREIGN KEY (`owner`) REFERENCES `user` (`username`),
  CONSTRAINT `task_ibfk_3` FOREIGN KEY (`receiver`) REFERENCES `user` (`username`)
) ENGINE=InnoDB AUTO_INCREMENT=15 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `task`
--

LOCK TABLES `task` WRITE;
/*!40000 ALTER TABLE `task` DISABLE KEYS */;
INSERT INTO `task` VALUES (1,1,'jarvis','anhvdq','2015-05-05','2015-05-06','Lorem ipsum dolor sit amet, placerat egestas condimentum','',''),(2,1,'anhvdq','flower','2017-07-07','2018-08-08','Lorem ipsum dolor sit amet, placerat egestas condimentum','',''),(3,2,'jarvis','jarvis','2014-08-08','2018-08-08','Lorem ipsum dolor sit amet, placerat egestas condimentum','',''),(4,2,'hoangnt','flower','2012-02-02','2012-02-03','Lorem ipsum dolor sit amet, placerat egestas condimentum','',''),(12,1,'admin','admin','2018-11-05','2018-11-11','asd','',''),(13,1,'admin','jarvis','2018-11-14','2018-11-14','test','\0',''),(14,1,'admin','case','2018-11-14','2018-11-14','asdf','\0','');
/*!40000 ALTER TABLE `task` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `team`
--

DROP TABLE IF EXISTS `team`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `team` (
  `teamId` int(11) NOT NULL AUTO_INCREMENT,
  `eventId` int(11) NOT NULL,
  `name` varchar(50) DEFAULT NULL,
  `description` varchar(250) DEFAULT NULL,
  PRIMARY KEY (`teamId`),
  KEY `eventId` (`eventId`),
  CONSTRAINT `team_ibfk_1` FOREIGN KEY (`eventId`) REFERENCES `event` (`eventId`)
) ENGINE=InnoDB AUTO_INCREMENT=12 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `team`
--

LOCK TABLES `team` WRITE;
/*!40000 ALTER TABLE `team` DISABLE KEYS */;
INSERT INTO `team` VALUES (1,1,'Shark Team','Lorem ipsum dolor sit amet mattis ad'),(2,1,'Avenger Team','Lorem ipsum dolor sit amet, mattis ad.'),(3,2,'Marvel Team','Lorem ipsum dolor sit amet, mattis ad.'),(4,3,'Teddy Team','Lorem ipsum dolor sit amet, mattis ad.'),(5,3,'Ant Team','Lorem ipsum dolor sit amet, mattis ad.'),(6,2,'Elephant Team','Lorem ipsum dolor sit amet, mattis ad.'),(7,1,'Tiger Team','Lorem ipsum dolor sit amet, mattis ad.'),(9,1,'Luan Team','Lorem'),(10,11,'Hoang Team','asdasd'),(11,12,'aaa aa','aaa');
/*!40000 ALTER TABLE `team` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `teammember`
--

DROP TABLE IF EXISTS `teammember`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `teammember` (
  `teamId` int(11) NOT NULL,
  `username` varchar(50) NOT NULL,
  `role` int(11) NOT NULL,
  PRIMARY KEY (`teamId`,`username`),
  KEY `username` (`username`),
  CONSTRAINT `teammember_ibfk_1` FOREIGN KEY (`teamId`) REFERENCES `team` (`teamId`),
  CONSTRAINT `teammember_ibfk_2` FOREIGN KEY (`username`) REFERENCES `user` (`username`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `teammember`
--

LOCK TABLES `teammember` WRITE;
/*!40000 ALTER TABLE `teammember` DISABLE KEYS */;
INSERT INTO `teammember` VALUES (1,'admin',3),(1,'anhvdq',1),(1,'case',3),(1,'jarvis',1),(2,'user',2),(3,'admin',3),(3,'jarvis',1),(4,'luannm',2),(5,'obasami',3),(7,'case',1),(7,'flower',1),(11,'anhvdq',1),(11,'flower',1);
/*!40000 ALTER TABLE `teammember` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `user`
--

DROP TABLE IF EXISTS `user`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `user` (
  `username` varchar(50) NOT NULL,
  `password` varchar(50) NOT NULL,
  `role` int(11) NOT NULL,
  `fullName` varchar(50) DEFAULT NULL,
  `email` varchar(50) DEFAULT NULL,
  `phone` varchar(50) DEFAULT NULL,
  `birthdate` varchar(50) DEFAULT NULL,
  `disabled` bit(1) DEFAULT NULL,
  PRIMARY KEY (`username`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `user`
--

LOCK TABLES `user` WRITE;
/*!40000 ALTER TABLE `user` DISABLE KEYS */;
INSERT INTO `user` VALUES ('admin','123',2,'admin','abc@abc.com','123123123','1967-09-11','\0'),('anhvdq','123',1,'English Van','english@cuba.us','963852741','1980-10-29','\0'),('case','123',2,'Johnny Case','test@case.tc','369965471','1980-10-29','\0'),('dream','123',1,'Jordan Dream','toan@shinoda.ts','698574123','1980-10-29','\0'),('flower','123',1,'Flower Sun','doan@flower.sm','014745648','1980-10-29','\0'),('hoangnt','123',2,'Suoi Joan','suoinguon@tuoitre.dieudao','147852369','1980-10-29','\0'),('hoangtt','123',2,'Harley Davison','hoang@h.a','987654321','1980-10-29','\0'),('huynguyen','123',1,'Ninja Kawa','huy@xi.hai','123123112','1980-10-29','\0'),('jarvis','123',2,'Jarvis Oracle','gundamage@cum.shot','696969696','1980-10-29','\0'),('luannm','123',1,'Luan Boheme','luan@loan.xa','741258369','1980-10-29','\0'),('obasami','123',1,'Arap Xadi','rapper@ja.v','147547821','1980-10-29','\0'),('user','123',1,'Neko','user@gmail.com','1234567890','1980-10-29','\0'),('vnproben','123',1,'nguyen m','abc@abc.vn','1231231230','1997-02-28','\0'),('zuckerberg','123',1,'Zucker Doan','zukughe@zu.be','147852963','1980-10-29','\0');
/*!40000 ALTER TABLE `user` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping routines for database 'fevproject'
--
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2020-04-16 23:36:30
