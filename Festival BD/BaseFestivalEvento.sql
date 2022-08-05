CREATE DATABASE  IF NOT EXISTS `evento` /*!40100 DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci */ /*!80016 DEFAULT ENCRYPTION='N' */;
USE `evento`;
-- MySQL dump 10.13  Distrib 8.0.18, for Win64 (x86_64)
--
-- Host: localhost    Database: evento
-- ------------------------------------------------------
-- Server version	8.0.18

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Dumping data for table `apresentacao`
--

LOCK TABLES `apresentacao` WRITE;
/*!40000 ALTER TABLE `apresentacao` DISABLE KEYS */;
INSERT INTO `apresentacao` VALUES (115,'Por um minuto','Bruno e Marrone',147,4,'G','Original','Ricardo B','\0',NULL,NULL),(116,'Seu Astral','Jorge',148,1,'E','Original','Mohammed','\0',NULL,NULL),(117,'Desejo','Chiquinho',149,3,'Do','Original','Nega','A',NULL,NULL),(118,'o detento apaixonado','wanderley andrade',150,4,'c','wanderley andrade','Laiza Linda','A',NULL,NULL),(119,'O amor e o poder','',151,1,'Mi maior','Rosanna','Lu','A',NULL,NULL),(120,'Atirei o pau no gato','',152,1,'Dó','Luciane Fátima','Pedro Henrique de Oliveira Franceschina','\0',NULL,NULL),(121,'Parabéns para você','Domínio Publico',153,1,'sei lá','xuxa','Flavio de Melo','\0',NULL,NULL),(122,'SEI LÁ KKK','A',154,3,'JJJ','KKK','Edemila','\0',NULL,NULL),(123,'Fantasma da Ópera','',155,3,'Lá menor','Emílio e a Mulher','Pedro','\0',NULL,NULL),(124,'The Wall','A',156,3,'G','froid','Confirmador Teste','\0',NULL,NULL),(125,'Vamos construir','',157,1,'Mi','Sandy e Junior','Luluzinha','\0',NULL,NULL),(126,'Era uma vez','',158,2,'Ré','Kelly','Lu','A',NULL,NULL),(127,'Back to black','',159,3,'Original','Amy winehoyse','Lu','A',NULL,NULL);
/*!40000 ALTER TABLE `apresentacao` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping data for table `cantor`
--

LOCK TABLES `cantor` WRITE;
/*!40000 ALTER TABLE `cantor` DISABLE KEYS */;
INSERT INTO `cantor` VALUES (147,'Ricardo Bavaresco','ricardo@email.com','(49) 991-545678',NULL,'59654587','Nada a observar','Irani','Santa Catarina','25','4/12/1997',0),(148,'Matue Ali','mohmmedo.alv17@gmail.com','(49) 991-594194',NULL,'5736372','','Campos Novos','SC','20','27/7/2001',0),(149,'Nilza Bavaresco','nega@email.com','(49) 991-401034',NULL,'789456123','','Irani','SC','31','12/7/1990',0),(150,'aretuza salvador','laizazenaro@gmail.com','(49) 991-136118',NULL,'7819085908','a lu me obrigou','irani','sc','15','13/2/2006',0),(151,'Luciani Oliveira','luciani1972@yahoo.com.br','(49) 991-440693',NULL,'2693076','','Centro','SC','49','26/7/1972',0),(152,'Pedro Franceschina','pedrofranceschima@hotmail.com','(49) 999-900000',NULL,'6216260','','Irani','SC','20','5/2/2001',0),(153,'Flavio Melo','flaviodml@gmail.com','(49) 991-342992',NULL,'4615732','','bavaresco','sc','35','27/2/1986',0),(154,'Edemila Bosio','edemilabosio@yahoo.com.br','(49) 988-092124',NULL,'53983750','','Santo Marcon','SC','30','4/1/1991',0),(155,'Pedro Henrique','pedrofranceschina@hotmail.com','(49) 999-999999',NULL,'0','','Irani','SC','0','1/8/2022',0),(156,'NomeAir SurnameFryer','Ricardo Bavaresco','(48) 889-545645',NULL,'785468754','','Ponte Serrada','Paraná','6','11/8/2016',0),(157,'Luciani Oliveira','luciani1972@yahoo.com.br','(49) 991-440693',NULL,'85447899','','Centro','SC','0','1/8/2022',0),(158,'Luciani Oliveira','luciani1972@yahoo.com.br','(49) 991-440693',NULL,'8555084','','Centro','SC','0','1/8/2022',0),(159,'Luciani Oliveira','luciani1972@yahoo.com.br','(49) 991-440693',NULL,'2693076','','Centro','SC','0','1/8/2022',0);
/*!40000 ALTER TABLE `cantor` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping data for table `categoria`
--

LOCK TABLES `categoria` WRITE;
/*!40000 ALTER TABLE `categoria` DISABLE KEYS */;
INSERT INTO `categoria` VALUES (1,'Infantil','2022-09-07 00:00:00'),(2,'Juvenil','2022-09-07 00:00:00'),(3,'Popular','2022-09-08 00:00:00'),(4,'Sertanejo','2022-09-09 00:00:00'),(21,'Gospel','2022-09-08 00:00:00'),(24,'Final Popular','2022-09-10 00:00:00'),(25,'Final Sertanejo','2022-09-10 00:00:00');
/*!40000 ALTER TABLE `categoria` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping data for table `classificacao`
--

LOCK TABLES `classificacao` WRITE;
/*!40000 ALTER TABLE `classificacao` DISABLE KEYS */;
/*!40000 ALTER TABLE `classificacao` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping data for table `festival`
--

LOCK TABLES `festival` WRITE;
/*!40000 ALTER TABLE `festival` DISABLE KEYS */;
INSERT INTO `festival` VALUES (2,'FIMUSI XXXII','Festival de Irani','2022-09-07 00:00:00','2022-09-10 00:00:00');
/*!40000 ALTER TABLE `festival` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping data for table `jurado`
--

LOCK TABLES `jurado` WRITE;
/*!40000 ALTER TABLE `jurado` DISABLE KEYS */;
/*!40000 ALTER TABLE `jurado` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping data for table `notas`
--

LOCK TABLES `notas` WRITE;
/*!40000 ALTER TABLE `notas` DISABLE KEYS */;
/*!40000 ALTER TABLE `notas` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2022-08-05  2:36:59
