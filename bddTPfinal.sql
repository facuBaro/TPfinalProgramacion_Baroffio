-- --------------------------------------------------------
-- Host:                         127.0.0.1
-- Versión del servidor:         10.4.14-MariaDB - mariadb.org binary distribution
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
CREATE DATABASE IF NOT EXISTS `proyectofinalbdd` /*!40100 DEFAULT CHARACTER SET utf8mb4 */;
USE `proyectofinalbdd`;

-- Volcando estructura para tabla proyectofinalbdd.clientes
CREATE TABLE IF NOT EXISTS `clientes` (
  `id_cliente` int(11) NOT NULL AUTO_INCREMENT,
  `nombre` varchar(50) NOT NULL,
  `telefono` varchar(50) NOT NULL,
  `correo` varchar(50) NOT NULL,
  `activo` varchar(50) NOT NULL DEFAULT 'si',
  PRIMARY KEY (`id_cliente`),
  UNIQUE KEY `telefono` (`telefono`),
  UNIQUE KEY `correo` (`correo`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8mb4;

-- Volcando datos para la tabla proyectofinalbdd.clientes: ~3 rows (aproximadamente)
INSERT INTO `clientes` (`id_cliente`, `nombre`, `telefono`, `correo`, `activo`) VALUES
	(2, 'juan', '231553', 'juan08@gmail.com', 'si'),
	(3, 'ana', '314324321', 'ana@gmail.com', 'si'),
	(4, 'oscar', '1234332', 'oscar@gmail.com', 'si');

-- Volcando estructura para tabla proyectofinalbdd.login
CREATE TABLE IF NOT EXISTS `login` (
  `id_Login` int(11) NOT NULL AUTO_INCREMENT,
  `usuario` varchar(50) NOT NULL,
  `contraseña` varchar(50) NOT NULL,
  PRIMARY KEY (`id_Login`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4;

-- Volcando datos para la tabla proyectofinalbdd.login: ~2 rows (aproximadamente)
INSERT INTO `login` (`id_Login`, `usuario`, `contraseña`) VALUES
	(1, 'facu', 'fbg123'),
	(2, 'natha', '1234');

-- Volcando estructura para tabla proyectofinalbdd.productos
CREATE TABLE IF NOT EXISTS `productos` (
  `id_producto` int(11) NOT NULL AUTO_INCREMENT,
  `Nombre` varchar(50) NOT NULL,
  `Precio` int(11) NOT NULL,
  `categoria` varchar(50) NOT NULL,
  `activo` varchar(50) NOT NULL DEFAULT 'si',
  PRIMARY KEY (`id_producto`),
  UNIQUE KEY `Nombre` (`Nombre`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8mb4;

-- Volcando datos para la tabla proyectofinalbdd.productos: ~4 rows (aproximadamente)
INSERT INTO `productos` (`id_producto`, `Nombre`, `Precio`, `categoria`, `activo`) VALUES
	(1, 'pepsi', 2310, 'bebidas', 'si'),
	(2, 'manaosUva', 2000, 'bebidas', 'si'),
	(3, 'manaosNaranja', 2000, 'bebidas', 'si'),
	(5, 'rex', 1332, 'snack', 'no');

-- Volcando estructura para tabla proyectofinalbdd.ventas
CREATE TABLE IF NOT EXISTS `ventas` (
  `id_ventas` int(11) NOT NULL AUTO_INCREMENT,
  `id_cliente` int(11) NOT NULL,
  `fecha` date NOT NULL,
  `total` int(11) NOT NULL,
  PRIMARY KEY (`id_ventas`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- Volcando datos para la tabla proyectofinalbdd.ventas: ~0 rows (aproximadamente)

-- Volcando estructura para tabla proyectofinalbdd.ventasitems
CREATE TABLE IF NOT EXISTS `ventasitems` (
  `id_ventasitems` int(11) NOT NULL AUTO_INCREMENT,
  `id_ventas` int(11) NOT NULL,
  `id_producto` int(11) NOT NULL,
  `preciounitario` int(11) NOT NULL,
  `cantidad` int(11) NOT NULL,
  `preciototal` int(11) NOT NULL,
  PRIMARY KEY (`id_ventasitems`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- Volcando datos para la tabla proyectofinalbdd.ventasitems: ~0 rows (aproximadamente)

/*!40103 SET TIME_ZONE=IFNULL(@OLD_TIME_ZONE, 'system') */;
/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IFNULL(@OLD_FOREIGN_KEY_CHECKS, 1) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40111 SET SQL_NOTES=IFNULL(@OLD_SQL_NOTES, 1) */;
