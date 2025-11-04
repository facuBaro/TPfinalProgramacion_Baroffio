-- --------------------------------------------------------
-- Host:                         127.0.0.1
-- Versión del servidor:         8.0.40 - MySQL Community Server - GPL
-- SO del servidor:              Win64
-- HeidiSQL Versión:             11.2.0.6213
-- --------------------------------------------------------

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET NAMES utf8 */;
/*!50503 SET NAMES utf8mb4 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;


-- Volcando estructura de base de datos para proyectofinalbdd
CREATE DATABASE IF NOT EXISTS `proyectofinalbdd` /*!40100 DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci */ /*!80016 DEFAULT ENCRYPTION='N' */;
USE `proyectofinalbdd`;

-- Volcando estructura para tabla proyectofinalbdd.clientes
CREATE TABLE IF NOT EXISTS `clientes` (
  `id_cliente` int NOT NULL AUTO_INCREMENT,
  `nombre` varchar(50) NOT NULL,
  `telefono` varchar(50) NOT NULL,
  `correo` varchar(50) NOT NULL,
  `activo` varchar(50) NOT NULL DEFAULT 'si',
  PRIMARY KEY (`id_cliente`),
  UNIQUE KEY `telefono` (`telefono`),
  UNIQUE KEY `correo` (`correo`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- Volcando datos para la tabla proyectofinalbdd.clientes: ~3 rows (aproximadamente)
/*!40000 ALTER TABLE `clientes` DISABLE KEYS */;
INSERT INTO `clientes` (`id_cliente`, `nombre`, `telefono`, `correo`, `activo`) VALUES
	(1, 'pepe', '12312321', 'pepe@gmail.com', 'si'),
	(2, 'juana', '1321312', 'J22@gmail.com', 'si'),
	(3, 'facu', '12312', 'facu@gmail.com', 'si');
/*!40000 ALTER TABLE `clientes` ENABLE KEYS */;

-- Volcando estructura para tabla proyectofinalbdd.login
CREATE TABLE IF NOT EXISTS `login` (
  `id_Login` int NOT NULL AUTO_INCREMENT,
  `usuario` varchar(50) NOT NULL,
  `contraseña` varchar(50) NOT NULL,
  PRIMARY KEY (`id_Login`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- Volcando datos para la tabla proyectofinalbdd.login: ~1 rows (aproximadamente)
/*!40000 ALTER TABLE `login` DISABLE KEYS */;
INSERT INTO `login` (`id_Login`, `usuario`, `contraseña`) VALUES
	(1, 'facu', 'fbg123');
/*!40000 ALTER TABLE `login` ENABLE KEYS */;

-- Volcando estructura para tabla proyectofinalbdd.productos
CREATE TABLE IF NOT EXISTS `productos` (
  `id_producto` int NOT NULL AUTO_INCREMENT,
  `Nombre` varchar(50) NOT NULL,
  `Precio` int NOT NULL,
  `categoria` varchar(50) NOT NULL,
  `activo` varchar(50) NOT NULL DEFAULT 'si',
  PRIMARY KEY (`id_producto`),
  UNIQUE KEY `Nombre` (`Nombre`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- Volcando datos para la tabla proyectofinalbdd.productos: ~5 rows (aproximadamente)
/*!40000 ALTER TABLE `productos` DISABLE KEYS */;
INSERT INTO `productos` (`id_producto`, `Nombre`, `Precio`, `categoria`, `activo`) VALUES
	(1, 'cocacola', 2000, 'bebidas', 'si'),
	(2, 'pepas', 1500, 'galletitas', 'si'),
	(3, 'cuningtonUva', 2000, 'bebidas', 'si'),
	(4, 'cuningtonNaranja', 2100, 'bebidas', 'si'),
	(5, 'cuningtonSprite', 2100, 'bebidas', 'si');
/*!40000 ALTER TABLE `productos` ENABLE KEYS */;

-- Volcando estructura para tabla proyectofinalbdd.ventas
CREATE TABLE IF NOT EXISTS `ventas` (
  `id_ventas` int NOT NULL AUTO_INCREMENT,
  `id_cliente` int NOT NULL,
  `fecha` date NOT NULL,
  `total` int NOT NULL,
  PRIMARY KEY (`id_ventas`),
  KEY `foranea_IDcliente` (`id_cliente`),
  CONSTRAINT `foranea_IDcliente` FOREIGN KEY (`id_cliente`) REFERENCES `clientes` (`id_cliente`)
) ENGINE=InnoDB AUTO_INCREMENT=12 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- Volcando datos para la tabla proyectofinalbdd.ventas: ~7 rows (aproximadamente)
/*!40000 ALTER TABLE `ventas` DISABLE KEYS */;
INSERT INTO `ventas` (`id_ventas`, `id_cliente`, `fecha`, `total`) VALUES
	(5, 3, '2025-10-31', 2000),
	(6, 2, '2025-10-31', 7000),
	(7, 2, '2025-10-31', 6200),
	(8, 3, '2025-10-31', 16000),
	(9, 1, '2025-10-31', 13500),
	(10, 2, '2025-11-01', 5500),
	(11, 3, '2025-11-01', 4000);
/*!40000 ALTER TABLE `ventas` ENABLE KEYS */;

-- Volcando estructura para tabla proyectofinalbdd.ventasitems
CREATE TABLE IF NOT EXISTS `ventasitems` (
  `id_ventasitems` int NOT NULL AUTO_INCREMENT,
  `id_ventas` int NOT NULL,
  `id_producto` int NOT NULL,
  `preciounitario` int NOT NULL,
  `cantidad` int NOT NULL,
  `preciototal` int NOT NULL,
  PRIMARY KEY (`id_ventasitems`),
  KEY `ForaneaId_Ventas` (`id_ventas`),
  KEY `ForaneaId_Producto` (`id_producto`),
  CONSTRAINT `ForaneaId_Producto` FOREIGN KEY (`id_producto`) REFERENCES `productos` (`id_producto`),
  CONSTRAINT `ForaneaId_Ventas` FOREIGN KEY (`id_ventas`) REFERENCES `ventas` (`id_ventas`)
) ENGINE=InnoDB AUTO_INCREMENT=23 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- Volcando datos para la tabla proyectofinalbdd.ventasitems: ~15 rows (aproximadamente)
/*!40000 ALTER TABLE `ventasitems` DISABLE KEYS */;
INSERT INTO `ventasitems` (`id_ventasitems`, `id_ventas`, `id_producto`, `preciounitario`, `cantidad`, `preciototal`) VALUES
	(8, 5, 3, 2000, 1, 2000),
	(9, 6, 2, 1500, 2, 3000),
	(10, 6, 3, 2000, 1, 2000),
	(11, 6, 1, 2000, 1, 2000),
	(12, 7, 4, 2100, 1, 2100),
	(13, 7, 5, 2100, 1, 2100),
	(14, 7, 3, 2000, 1, 2000),
	(15, 8, 1, 2000, 5, 10000),
	(16, 8, 2, 1500, 4, 6000),
	(17, 9, 4, 2100, 4, 8400),
	(18, 9, 2, 1500, 2, 3000),
	(19, 9, 5, 2100, 1, 2100),
	(20, 10, 3, 2000, 2, 4000),
	(21, 10, 2, 1500, 1, 1500),
	(22, 11, 3, 2000, 2, 4000);
/*!40000 ALTER TABLE `ventasitems` ENABLE KEYS */;

/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IFNULL(@OLD_FOREIGN_KEY_CHECKS, 1) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40111 SET SQL_NOTES=IFNULL(@OLD_SQL_NOTES, 1) */;
