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
-- Table structure for table `apresentacao`
--

DROP TABLE IF EXISTS `apresentacao`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `apresentacao` (
  `id_apresentacao` int(11) NOT NULL AUTO_INCREMENT,
  `musica` varchar(250) DEFAULT NULL,
  `artista` varchar(250) DEFAULT NULL,
  `cantor` int(11) NOT NULL,
  `categoria` int(11) NOT NULL,
  `tom` varchar(45) DEFAULT NULL,
  `gravacao` varchar(250) DEFAULT NULL,
  `nomeartistico` varchar(255) DEFAULT NULL,
  `ativo` varchar(1) DEFAULT NULL,
  `ordem` varchar(5) DEFAULT NULL,
  `senha` varchar(5) DEFAULT NULL,
  PRIMARY KEY (`id_apresentacao`),
  KEY `cantor` (`cantor`),
  KEY `categoria` (`categoria`),
  CONSTRAINT `apresentacao_ibfk_1` FOREIGN KEY (`cantor`) REFERENCES `cantor` (`id_cantor`),
  CONSTRAINT `apresentacao_ibfk_2` FOREIGN KEY (`categoria`) REFERENCES `categoria` (`id_categoria`)
) ENGINE=InnoDB AUTO_INCREMENT=128 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `apresentacao`
--

LOCK TABLES `apresentacao` WRITE;
/*!40000 ALTER TABLE `apresentacao` DISABLE KEYS */;
INSERT INTO `apresentacao` VALUES (115,'Por um minuto','Bruno e Marrone',147,4,'G','Original','Ricardo B','A',NULL,'2'),(116,'Seu Astral','Jorge',148,1,'E','Original','Mohammed','A',NULL,'2'),(117,'Desejo',NULL,149,3,'Do','Original','Nega','A',NULL,NULL),(118,'o detento apaixonado',NULL,150,4,'c','wanderley andrade','Laiza Linda','A',NULL,NULL),(119,'O amor e o poder',NULL,151,1,'Mi maior','Rosanna','Lu',' ',NULL,NULL),(120,'Atirei o pau no gato','',152,1,'Dó','Luciane Fátima','Pedro Henrique de Oliveira Franceschina','A',NULL,NULL),(121,'Parabéns para você','Domínio Publico',153,1,'sei lá','xuxa','Flavio de Melo',' ',NULL,NULL),(122,'SEI LÁ KKK','A',154,3,'JJJ','KKK','Edemila','\0',NULL,NULL),(123,'Fantasma da Ópera','',155,3,'Lá menor','Emílio e a Mulher','Pedro','\0',NULL,NULL),(124,'The Wall','A',156,3,'G','froid','Confirmador Teste','\0',NULL,NULL),(125,'Vamos construir','',157,1,'Mi','Sandy e Junior','Luluzinha','\0',NULL,NULL),(126,'Era uma vez','',158,2,'Ré','Kelly','Lu','A',NULL,NULL),(127,'Back to black','',159,3,'Original','Amy winehoyse','Lu','A',NULL,NULL);
/*!40000 ALTER TABLE `apresentacao` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `cantor`
--

DROP TABLE IF EXISTS `cantor`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `cantor` (
  `id_cantor` int(11) NOT NULL AUTO_INCREMENT,
  `nome` varchar(250) DEFAULT NULL,
  `email` varchar(250) DEFAULT NULL,
  `contato` varchar(50) DEFAULT NULL,
  `cpf` varchar(14) DEFAULT NULL,
  `rg` varchar(11) DEFAULT NULL,
  `observacao` text,
  `cidade` varchar(150) DEFAULT NULL,
  `estado` varchar(150) DEFAULT NULL,
  `idade` varchar(45) DEFAULT NULL,
  `nascimento` varchar(45) DEFAULT NULL,
  `id_apresentacao` int(11) DEFAULT NULL,
  PRIMARY KEY (`id_cantor`)
) ENGINE=InnoDB AUTO_INCREMENT=160 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `cantor`
--

LOCK TABLES `cantor` WRITE;
/*!40000 ALTER TABLE `cantor` DISABLE KEYS */;
INSERT INTO `cantor` VALUES (147,'Ricardo Bavaresco','ricardo@email.com','(49) 991-545678',NULL,'59654587','Nada a observar','Irani','Santa Catarina','25','4/12/1997',0),(148,'Matue Ali','mohmmedo.alv17@gmail.com','(49) 991-594194',NULL,'5736372','','Campos Novos','SC','20','27/7/2001',0),(149,'Nilza Bavaresco','nega@email.com','(49) 991-401034',NULL,'789456123','','Irani','SC','31','12/7/1990',0),(150,'aretuza salvador','laizazenaro@gmail.com','(49) 991-136118',NULL,'7819085908','a lu me obrigou','irani','sc','15','13/2/2006',0),(151,'Luciani Oliveira','luciani1972@yahoo.com.br','(49) 991-440693',NULL,'2693076','','Centro','SC','49','26/7/1972',0),(152,'Pedro Franceschina','pedrofranceschima@hotmail.com','(49) 999-900000',NULL,'6216260','','Irani','SC','20','5/2/2001',0),(153,'Flavio Melo','flaviodml@gmail.com','(49) 991-342992',NULL,'4615732','','bavaresco','sc','35','27/2/1986',0),(154,'Edemila Bosio','edemilabosio@yahoo.com.br','(49) 988-092124',NULL,'53983750','','Santo Marcon','SC','30','4/1/1991',0),(155,'Pedro Henrique','pedrofranceschina@hotmail.com','(49) 999-999999',NULL,'0','','Irani','SC','0','1/8/2022',0),(156,'NomeAir SurnameFryer','Ricardo Bavaresco','(48) 889-545645',NULL,'785468754','','Ponte Serrada','Paraná','6','11/8/2016',0),(157,'Luciani Oliveira','luciani1972@yahoo.com.br','(49) 991-440693',NULL,'85447899','','Centro','SC','0','1/8/2022',0),(158,'Luciani Oliveira','luciani1972@yahoo.com.br','(49) 991-440693',NULL,'8555084','','Centro','SC','0','1/8/2022',0),(159,'Luciani Oliveira','luciani1972@yahoo.com.br','(49) 991-440693',NULL,'2693076','','Centro','SC','0','1/8/2022',0);
/*!40000 ALTER TABLE `cantor` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `categoria`
--

DROP TABLE IF EXISTS `categoria`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `categoria` (
  `id_categoria` int(11) NOT NULL AUTO_INCREMENT,
  `categoria` varchar(250) NOT NULL,
  `dia` datetime DEFAULT NULL,
  PRIMARY KEY (`id_categoria`)
) ENGINE=InnoDB AUTO_INCREMENT=26 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `categoria`
--

LOCK TABLES `categoria` WRITE;
/*!40000 ALTER TABLE `categoria` DISABLE KEYS */;
INSERT INTO `categoria` VALUES (1,'Infantil','2022-09-07 00:00:00'),(2,'Juvenil','2022-09-07 00:00:00'),(3,'Popular','2022-09-08 00:00:00'),(4,'Sertanejo','2022-09-09 00:00:00'),(21,'Gospel','2022-09-08 00:00:00'),(24,'Final Popular','2022-09-10 00:00:00'),(25,'Final Sertanejo','2022-09-10 00:00:00');
/*!40000 ALTER TABLE `categoria` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `classificacao`
--

DROP TABLE IF EXISTS `classificacao`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `classificacao` (
  `id_classificacao` int(11) NOT NULL AUTO_INCREMENT,
  `notafinal` double DEFAULT '0',
  `apresentacao` int(11) NOT NULL,
  `cantor` int(11) NOT NULL,
  `categoria` int(11) NOT NULL,
  PRIMARY KEY (`id_classificacao`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `classificacao`
--

LOCK TABLES `classificacao` WRITE;
/*!40000 ALTER TABLE `classificacao` DISABLE KEYS */;
/*!40000 ALTER TABLE `classificacao` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `festival`
--

DROP TABLE IF EXISTS `festival`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `festival` (
  `id_evento` int(11) NOT NULL AUTO_INCREMENT,
  `titulo` varchar(250) NOT NULL,
  `descricao` varchar(250) DEFAULT NULL,
  `dataInicial` datetime DEFAULT NULL,
  `dataFinal` datetime NOT NULL,
  PRIMARY KEY (`id_evento`,`titulo`,`dataFinal`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `festival`
--

LOCK TABLES `festival` WRITE;
/*!40000 ALTER TABLE `festival` DISABLE KEYS */;
INSERT INTO `festival` VALUES (2,'FIMUSI XXXII','Festival de Irani','2022-09-07 00:00:00','2022-09-10 00:00:00');
/*!40000 ALTER TABLE `festival` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `jurado`
--

DROP TABLE IF EXISTS `jurado`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `jurado` (
  `id_jurado` int(11) NOT NULL AUTO_INCREMENT,
  `nome` varchar(255) DEFAULT NULL,
  `contato` varchar(255) DEFAULT NULL,
  `documento` varchar(255) DEFAULT NULL,
  `observacao` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`id_jurado`)
) ENGINE=InnoDB AUTO_INCREMENT=16 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `jurado`
--

LOCK TABLES `jurado` WRITE;
/*!40000 ALTER TABLE `jurado` DISABLE KEYS */;
/*!40000 ALTER TABLE `jurado` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `notas`
--

DROP TABLE IF EXISTS `notas`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `notas` (
  `id_notas` int(11) NOT NULL AUTO_INCREMENT,
  `nota1` double DEFAULT '0',
  `nota2` double DEFAULT '0',
  `categoria` int(11) DEFAULT NULL,
  `cantor` int(11) DEFAULT NULL,
  `jurado` int(11) DEFAULT NULL,
  `apresentacao` int(11) DEFAULT NULL,
  `nota3` double DEFAULT '0',
  `nota4` double DEFAULT '0',
  `notafinal` double DEFAULT '0',
  PRIMARY KEY (`id_notas`)
) ENGINE=InnoDB AUTO_INCREMENT=16 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

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

-- Dump completed on 2022-08-06  1:16:52
