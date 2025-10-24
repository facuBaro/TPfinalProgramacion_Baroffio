-- --------------------------------------------------------
-- Host:                         127.0.0.1
-- Versión del servidor:         9.0.1 - MySQL Community Server - GPL
-- SO del servidor:              Win64
-- HeidiSQL Versión:             12.8.0.6908
-- --------------------------------------------------------

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET NAMES utf8 */;
/*!50503 SET NAMES utf8mb4 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;


-- Volcando estructura de base de datos para proyectofinalbdd
CREATE DATABASE IF NOT EXISTS `proyectofinalbdd` /*!40100 DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci */ /*!80016 DEFAULT ENCRYPTION='N' */;
USE `proyectofinalbdd`;

-- Volcando estructura para tabla proyectofinalbdd.clientes
CREATE TABLE IF NOT EXISTS `clientes` (
  `id_cliente` int NOT NULL AUTO_INCREMENT,
  `telefono` int NOT NULL DEFAULT '0',
  `correo` varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `nombre` varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  PRIMARY KEY (`id_cliente`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- Volcando datos para la tabla proyectofinalbdd.clientes: ~0 rows (aproximadamente)

-- Volcando estructura para tabla proyectofinalbdd.login
CREATE TABLE IF NOT EXISTS `login` (
  `id_Login` int NOT NULL AUTO_INCREMENT,
  `usuario` varchar(50) NOT NULL,
  `contraseña` varchar(50) NOT NULL,
  PRIMARY KEY (`id_Login`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- Volcando datos para la tabla proyectofinalbdd.login: ~0 rows (aproximadamente)

-- Volcando estructura para tabla proyectofinalbdd.productos
CREATE TABLE IF NOT EXISTS `productos` (
  `id_producto` int NOT NULL AUTO_INCREMENT,
  `Nombre` varchar(50) NOT NULL,
  `Precio` int NOT NULL,
  `categoria` varchar(50) NOT NULL,
  PRIMARY KEY (`id_producto`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- Volcando datos para la tabla proyectofinalbdd.productos: ~0 rows (aproximadamente)

-- Volcando estructura para tabla proyectofinalbdd.ventas
CREATE TABLE IF NOT EXISTS `ventas` (
  `id_ventas` int NOT NULL AUTO_INCREMENT,
  `id_cliente` int NOT NULL,
  `fecha` date NOT NULL,
  `total` int NOT NULL,
  PRIMARY KEY (`id_ventas`),
  KEY `id_cliente` (`id_cliente`),
  CONSTRAINT `id_cliente` FOREIGN KEY (`id_cliente`) REFERENCES `clientes` (`id_cliente`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- Volcando datos para la tabla proyectofinalbdd.ventas: ~0 rows (aproximadamente)

-- Volcando estructura para tabla proyectofinalbdd.ventasitems
CREATE TABLE IF NOT EXISTS `ventasitems` (
  `id_ventasitems` int NOT NULL AUTO_INCREMENT,
  `id_ventas` int NOT NULL,
  `id_producto` int NOT NULL,
  `preciounitario` int NOT NULL,
  `cantidad` int NOT NULL,
  `preciototal` int NOT NULL,
  PRIMARY KEY (`id_ventasitems`),
  KEY `id_ventas` (`id_ventas`),
  KEY `id_producto` (`id_producto`),
  CONSTRAINT `id_producto` FOREIGN KEY (`id_producto`) REFERENCES `productos` (`id_producto`),
  CONSTRAINT `id_ventas` FOREIGN KEY (`id_ventas`) REFERENCES `ventas` (`id_ventas`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- Volcando datos para la tabla proyectofinalbdd.ventasitems: ~0 rows (aproximadamente)

/*!40103 SET TIME_ZONE=IFNULL(@OLD_TIME_ZONE, 'system') */;
/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IFNULL(@OLD_FOREIGN_KEY_CHECKS, 1) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40111 SET SQL_NOTES=IFNULL(@OLD_SQL_NOTES, 1) */;
