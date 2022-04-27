USE MASTER
GO
CREATE DATABASE TESTAFP
GO
USE TESTAFP
GO

CREATE TABLE PACIENTE
(
	ID INT PRIMARY KEY IDENTITY(1,1),
	NOMBRE VARCHAR(50) NOT NULL,
	APELLIDO VARCHAR(50) NOT NULL,
	FECHA_NACIMIENTO DATE NOT NULL
);
GO


CREATE TABLE MEDICO
(
	ID INT PRIMARY KEY IDENTITY(1,1),
	NOMBRE VARCHAR(50) NOT NULL,
	APELLIDO VARCHAR(50) NOT NULL,
	FECHA_NACIMIENTO DATE NOT NULL
)