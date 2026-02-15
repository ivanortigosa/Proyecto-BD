/*
SQLyog Ultimate v11.11 (64 bit)
MySQL - 5.5.5-10.4.32-MariaDB : Database - inventario
*********************************************************************
*/

/*!40101 SET NAMES utf8 */;

/*!40101 SET SQL_MODE=''*/;

/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;
CREATE DATABASE /*!32312 IF NOT EXISTS*/`inventario` /*!40100 DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_spanish_ci */;

USE `inventario`;

/*Table structure for table `articulos` */

DROP TABLE IF EXISTS `articulos`;

CREATE TABLE `articulos` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `nombre` varchar(255) NOT NULL,
  `stock` int(11) NOT NULL,
  `imagen` varchar(255) NOT NULL,
  `precio` decimal(10,2) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=32 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_spanish_ci;

/*Data for the table `articulos` */

insert  into `articulos`(`id`,`nombre`,`stock`,`imagen`,`precio`) values (1,'Aceite de oliva virgen extra 1L',25,'/bd/fotos/Aceite de oliva virgen extra 1L 779.png',7.79),(2,'Agua mineral 1,5L',120,'/bd/fotos/Agua mineral 1,5L 075.png',0.75),(3,'Arroz redondo 1kg',80,'/bd/fotos/Arroz redondo 1kg 195.png',1.95),(4,'Azúcar blanco 1kg',70,'/bd/fotos/Azúcar blanco 1kg 150.png',1.50),(5,'Barra de pan',150,'/bd/fotos/Barra de pan 075.png',0.75),(6,'Carne picada mixta 500g',35,'/bd/fotos/Carne picada mixta 500g 520.png',5.20),(7,'Chocolate con leche 100g',46,'/bd/fotos/Chocolate con leche 100g 299.png',2.00),(8,'Detergente líquido 2L',30,'/bd/fotos/Detergente líquido 2L 1420.png',14.20),(9,'Galletas María',90,'/bd/fotos/Galletas María 100.png',1.00),(10,'Helado de vainilla 1L',25,'/bd/fotos/Helado de vainilla 1L 412.png',4.12),(11,'Huevos camperos (12u)',50,'/bd/fotos/Huevos camperos (12u) 419.png',4.19),(12,'Leche semidesnatada 1L',110,'/bd/fotos/Leche semidesnatada 1L 135.png',1.35),(13,'Leche sin lactosa 1L',90,'/bd/fotos/Leche sin lactosa 1L 155.png',1.55),(14,'Lechuga iceberg',40,'/bd/fotos/Lechuga iceberg 130.png',1.30),(15,'Lentejas pardinas 1kg',60,'/bd/fotos/Lentejas pardinas 1kg 350.png',3.50),(16,'Manzanas Golden 1kg',70,'/bd/fotos/Manzanas Golden 1kg 199.png',1.99),(17,'Naranjas 1kg',65,'/bd/fotos/Naranjas 1kg 225.png',2.25),(18,'Pan de molde integral',55,'/bd/fotos/Pan de molde integral 135.png',1.35),(19,'Papel higiénico (12 rollos)',45,'/bd/fotos/Papel higiénico (12 rollos) 715.png',7.15),(20,'Pasta espaguetis 1kg',85,'/bd/fotos/Pasta espaguetis 1kg 120.png',1.20),(21,'Pechuga de pollo 1kg',30,'/bd/fotos/Pechuga de pollo 1kg 649.png',6.49),(22,'Pizza congelada 4 quesos',50,'/bd/fotos/Pizza congelada 4 quesos 395.png',3.95),(23,'Plátanos 1kg Canarias',75,'/bd/fotos/Plátanos 1kg Canarias 292.png',2.92),(24,'Refresco de cola 2L',95,'/bd/fotos/Refresco de cola 2L 215.png',2.15),(25,'Sal fina 1kg',100,'/bd/fotos/Sal fina 1kg 040.png',0.40),(26,'Tomates pera 1kg',60,'/bd/fotos/Tomates pera 1kg 144.png',1.44),(27,'Vinagre de vino 500ml',80,'/bd/fotos/Vinagre de vino 500ml 079.png',0.79),(28,'Yogur proteico de fresa',70,'/bd/fotos/Yogur proteico de fresa 199.png',1.99),(29,'Yogur proteico natural',70,'/bd/fotos/Yogur proteico natural 199.png',1.99),(30,'Zanahorias 1kg',85,'/bd/fotos/Zanahorias 1kg 135.png',1.35);

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;
