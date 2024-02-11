-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Servidor: 127.0.0.1
-- Tiempo de generación: 11-02-2024 a las 14:13:38
-- Versión del servidor: 10.4.28-MariaDB
-- Versión de PHP: 8.0.28

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de datos: `sensorph`
--

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `datos`
--

CREATE TABLE `datos` (
  `id` int(11) NOT NULL,
  `nombre_estudiante` varchar(40) NOT NULL,
  `nombre` varchar(20) NOT NULL,
  `ph` varchar(11) NOT NULL,
  `temperatura` varchar(11) NOT NULL,
  `detalles` varchar(60) NOT NULL,
  `observacion` varchar(200) NOT NULL,
  `fecha` varchar(25) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Volcado de datos para la tabla `datos`
--

INSERT INTO `datos` (`id`, `nombre_estudiante`, `nombre`, `ph`, `temperatura`, `detalles`, `observacion`, `fecha`) VALUES
(31, 'Frank', 'Agua', '7', '12', 'Agua de cocina', 'Un olor leve a cloro', '15/09/2023 4:10:05 a. m.');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `estudiantes`
--

CREATE TABLE `estudiantes` (
  `identificacion` varchar(15) NOT NULL,
  `nombre` varchar(50) NOT NULL,
  `grado` varchar(5) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Volcado de datos para la tabla `estudiantes`
--

INSERT INTO `estudiantes` (`identificacion`, `nombre`, `grado`) VALUES
('101023456', 'Luis Barrios', '6'),
('1063782124', 'Pepito Ramirez', '11'),
('12023423', 'frank Genes', '9'),
('23564645', 'Pepito', '7'),
('58923782', 'Andrea Figueroa', '6'),
('67576476', 'angel Garcia', '10'),
('9345739485', 'Andres Bermudez', '7');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `sustanciasregistros`
--

CREATE TABLE `sustanciasregistros` (
  `id` int(10) NOT NULL,
  `estudiante` varchar(50) NOT NULL,
  `grado_alumno` varchar(10) NOT NULL,
  `escala` varchar(20) NOT NULL,
  `sustancia` varchar(20) NOT NULL,
  `tipoSustancia` varchar(20) NOT NULL,
  `ph` varchar(4) NOT NULL,
  `observacion` varchar(200) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Volcado de datos para la tabla `sustanciasregistros`
--

INSERT INTO `sustanciasregistros` (`id`, `estudiante`, `grado_alumno`, `escala`, `sustancia`, `tipoSustancia`, `ph`, `observacion`) VALUES
(10, 'Luis Barrios', '6', 'repollo', 'Limon', 'Acido', '1', 'Agua semi amarilla'),
(11, 'Luis Barrios', '6', 'repollo', 'Agua', 'Neutro', '7', 'Liquido transparente consumible'),
(12, 'Luis Barrios', '6', 'repollo', 'Leche', 'Neutro', '6', 'Sustancia blanca proveniente de la leche'),
(13, 'Andrea Figueroa', '6', 'repollo', 'Agua Jabonosa', 'Base', '9', 'Agua colorada con olor a jabon'),
(14, 'Andrea Figueroa', '6', 'repollo', 'Hidroxido de sodio', 'Alcalinos', '14', 'agua semi salada'),
(15, 'Pepito', '7', 'repollo', 'Agua salada', 'Acido', '3', 'NACL'),
(16, 'Pepito Ramirez', '11', 'repollo', 'Limon', 'Muy Acido', '1', 'Limon amargo'),
(17, 'Andrea Figueroa', '6', 'repollo', 'dsfsdhgd', 'Muy Acido', '3', 'ghsdsf'),
(18, 'angel Garcia', '10', 'repollo', 'gjhgjgh', 'Alcalinos', '10', 'ghfdsgdfh');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `sustanciasregistrosnormales`
--

CREATE TABLE `sustanciasregistrosnormales` (
  `idN` int(11) NOT NULL,
  `estudianteN` varchar(50) NOT NULL,
  `grado_alumnoN` varchar(2) NOT NULL,
  `escala` varchar(20) NOT NULL,
  `sustanciaN` varchar(20) NOT NULL,
  `tipoSustanciaN` varchar(20) NOT NULL,
  `phN` varchar(5) NOT NULL,
  `observacionN` varchar(200) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Volcado de datos para la tabla `sustanciasregistrosnormales`
--

INSERT INTO `sustanciasregistrosnormales` (`idN`, `estudianteN`, `grado_alumnoN`, `escala`, `sustanciaN`, `tipoSustanciaN`, `phN`, `observacionN`) VALUES
(8, 'frank Genes', '9', 'normal', 'lIMONADA', 'Acido', '2', 'Agua con Limon'),
(9, 'Pepito Ramirez', '11', 'normal', 'Agua', 'Neutro', '7', 'Liquido transparente');

--
-- Índices para tablas volcadas
--

--
-- Indices de la tabla `datos`
--
ALTER TABLE `datos`
  ADD PRIMARY KEY (`id`);

--
-- Indices de la tabla `estudiantes`
--
ALTER TABLE `estudiantes`
  ADD PRIMARY KEY (`identificacion`);

--
-- Indices de la tabla `sustanciasregistros`
--
ALTER TABLE `sustanciasregistros`
  ADD PRIMARY KEY (`id`);

--
-- Indices de la tabla `sustanciasregistrosnormales`
--
ALTER TABLE `sustanciasregistrosnormales`
  ADD PRIMARY KEY (`idN`);

--
-- AUTO_INCREMENT de las tablas volcadas
--

--
-- AUTO_INCREMENT de la tabla `datos`
--
ALTER TABLE `datos`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=32;

--
-- AUTO_INCREMENT de la tabla `sustanciasregistros`
--
ALTER TABLE `sustanciasregistros`
  MODIFY `id` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=19;

--
-- AUTO_INCREMENT de la tabla `sustanciasregistrosnormales`
--
ALTER TABLE `sustanciasregistrosnormales`
  MODIFY `idN` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=10;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
