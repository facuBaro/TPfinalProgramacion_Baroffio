-- --------------------------------------------------------
-- Host:                         127.0.0.1
-- Versión del servidor:         10.4.19-MariaDB - mariadb.org binary distribution
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
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- Volcando datos para la tabla proyectofinalbdd.clientes: ~0 rows (aproximadamente)
/*!40000 ALTER TABLE `clientes` DISABLE KEYS */;
/*!40000 ALTER TABLE `clientes` ENABLE KEYS */;

-- Volcando estructura para tabla proyectofinalbdd.login
CREATE TABLE IF NOT EXISTS `login` (
  `id_Login` int(11) NOT NULL AUTO_INCREMENT,
  `usuario` varchar(50) NOT NULL,
  `contraseña` varchar(50) NOT NULL,
  PRIMARY KEY (`id_Login`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8mb4;

-- Volcando datos para la tabla proyectofinalbdd.login: ~0 rows (aproximadamente)
/*!40000 ALTER TABLE `login` DISABLE KEYS */;
INSERT INTO `login` (`id_Login`, `usuario`, `contraseña`) VALUES
	(1, 'facu', 'fbg123');
/*!40000 ALTER TABLE `login` ENABLE KEYS */;

-- Volcando estructura para tabla proyectofinalbdd.productos
CREATE TABLE IF NOT EXISTS `productos` (
  `id_producto` int(11) NOT NULL AUTO_INCREMENT,
  `Nombre` varchar(50) NOT NULL,
  `Precio` int(11) NOT NULL,
  `categoria` varchar(50) NOT NULL,
  `activo` varchar(50) NOT NULL DEFAULT 'si',
  PRIMARY KEY (`id_producto`),
  UNIQUE KEY `Nombre` (`Nombre`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- Volcando datos para la tabla proyectofinalbdd.productos: ~0 rows (aproximadamente)
/*!40000 ALTER TABLE `productos` DISABLE KEYS */;
/*!40000 ALTER TABLE `productos` ENABLE KEYS */;

-- Volcando estructura para tabla proyectofinalbdd.ventas
CREATE TABLE IF NOT EXISTS `ventas` (
  `id_ventas` int(11) NOT NULL AUTO_INCREMENT,
  `id_cliente` int(11) NOT NULL,
  `fecha` date NOT NULL,
  `total` int(11) NOT NULL,
  PRIMARY KEY (`id_ventas`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- Volcando datos para la tabla proyectofinalbdd.ventas: ~0 rows (aproximadamente)
/*!40000 ALTER TABLE `ventas` DISABLE KEYS */;
/*!40000 ALTER TABLE `ventas` ENABLE KEYS */;

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
/*!40000 ALTER TABLE `ventasitems` DISABLE KEYS */;
/*!40000 ALTER TABLE `ventasitems` ENABLE KEYS */;

/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IFNULL(@OLD_FOREIGN_KEY_CHECKS, 1) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40111 SET SQL_NOTES=IFNULL(@OLD_SQL_NOTES, 1) */;
