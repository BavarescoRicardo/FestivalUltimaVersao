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
  PRIMARY KEY (`id_apresentacao`),
  KEY `cantor` (`cantor`),
  KEY `categoria` (`categoria`),
  CONSTRAINT `apresentacao_ibfk_1` FOREIGN KEY (`cantor`) REFERENCES `cantor` (`id_cantor`),
  CONSTRAINT `apresentacao_ibfk_2` FOREIGN KEY (`categoria`) REFERENCES `categoria` (`id_categoria`)
) ENGINE=InnoDB AUTO_INCREMENT=13 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `apresentacao`
--

LOCK TABLES `apresentacao` WRITE;
/*!40000 ALTER TABLE `apresentacao` DISABLE KEYS */;
INSERT INTO `apresentacao` VALUES (1,'Bijuteria','Bruno e marrone',1,3),(2,'Musica 7','Cabo daciolo',1,4),(3,'simfonia da noite','cleiton rasta',1,3),(4,'Music 8','musico',1,3),(5,'Music 8','musico',1,3),(7,'vida vazia','brno e marrone',1,4),(8,'to estou ','pink froid',8,4),(9,'would','alicio chais',11,4),(10,'wqeqwewe','teste',12,4),(11,'comobmocmombo','comovmom',13,3),(12,'comobmocmombo','comovmom',14,3);
/*!40000 ALTER TABLE `apresentacao` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2020-07-08 21:46:34
