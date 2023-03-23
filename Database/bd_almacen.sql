-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Servidor: localhost:3306
-- Tiempo de generación: 23-03-2023 a las 21:50:00
-- Versión del servidor: 8.0.31
-- Versión de PHP: 8.1.10

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de datos: `bd_almacen`
--

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tb_articulos`
--

CREATE TABLE `tb_articulos` (
  `codigo_ar` int NOT NULL,
  `descripcion_ar` varchar(100) DEFAULT NULL,
  `marca_ar` varchar(45) DEFAULT NULL,
  `codigo_um` int DEFAULT NULL,
  `codigo_ca` int DEFAULT NULL,
  `stock_actual` decimal(10,5) DEFAULT NULL,
  `fecha_crea` date DEFAULT NULL,
  `fecha_modifica` date DEFAULT NULL,
  `estado` smallint DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Volcado de datos para la tabla `tb_articulos`
--

INSERT INTO `tb_articulos` (`codigo_ar`, `descripcion_ar`, `marca_ar`, `codigo_um`, `codigo_ca`, `stock_actual`, `fecha_crea`, `fecha_modifica`, `estado`) VALUES
(1, 'ESCRITORIO', 'NO DEFINIDO', 1, 1, 40.00000, '2023-03-19', '2023-03-23', 1),
(2, 'ELECTRICOS', 'NO DEFINIDO', 1, 1, 20.00000, '2023-03-19', '2023-03-22', 1),
(3, 'aaaaa', 'aaaaa', 1, 1, 20.00000, '2023-03-21', '2023-03-21', 0),
(4, 'SILLA', 'NO DEFINIDO', 1, 1, 20.00000, '2023-03-22', '2023-03-22', 1),
(5, 'CEMENTO', 'SOL', 3, 3, 50.00000, '2023-03-22', '2023-03-22', 1),
(6, 'CALAMINA', 'NO DEFINIDO', 1, 3, 100.00000, '2023-03-22', '2023-03-22', 1);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tb_categorias`
--

CREATE TABLE `tb_categorias` (
  `codigo_ca` int NOT NULL,
  `descripcion_ca` varchar(50) DEFAULT NULL,
  `estado` smallint DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Volcado de datos para la tabla `tb_categorias`
--

INSERT INTO `tb_categorias` (`codigo_ca`, `descripcion_ca`, `estado`) VALUES
(1, 'OFICINAS PRUEBA', 1),
(2, 'HOGAR', 1),
(3, 'DECORACIONES', 1),
(4, 'MUEBLES PRUEBA', 1),
(5, 'TIENDA', 1),
(6, 'PRUEBA 2', 1);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tb_unidades_medida`
--

CREATE TABLE `tb_unidades_medida` (
  `codigo_um` int NOT NULL,
  `descripcion_um` varchar(45) DEFAULT NULL,
  `estado` smallint DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Volcado de datos para la tabla `tb_unidades_medida`
--

INSERT INTO `tb_unidades_medida` (`codigo_um`, `descripcion_um`, `estado`) VALUES
(1, 'UNIDADES', 1),
(3, 'KILOGRAMOS', 1),
(4, 'METROS', 1),
(5, 'PRUEBA 2', 0);

--
-- Índices para tablas volcadas
--

--
-- Indices de la tabla `tb_articulos`
--
ALTER TABLE `tb_articulos`
  ADD PRIMARY KEY (`codigo_ar`);

--
-- Indices de la tabla `tb_categorias`
--
ALTER TABLE `tb_categorias`
  ADD PRIMARY KEY (`codigo_ca`);

--
-- Indices de la tabla `tb_unidades_medida`
--
ALTER TABLE `tb_unidades_medida`
  ADD PRIMARY KEY (`codigo_um`);

--
-- AUTO_INCREMENT de las tablas volcadas
--

--
-- AUTO_INCREMENT de la tabla `tb_articulos`
--
ALTER TABLE `tb_articulos`
  MODIFY `codigo_ar` int NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- AUTO_INCREMENT de la tabla `tb_categorias`
--
ALTER TABLE `tb_categorias`
  MODIFY `codigo_ca` int NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- AUTO_INCREMENT de la tabla `tb_unidades_medida`
--
ALTER TABLE `tb_unidades_medida`
  MODIFY `codigo_um` int NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
