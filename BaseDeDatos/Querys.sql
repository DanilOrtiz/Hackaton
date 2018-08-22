CREATE TABLE Usuario
( ID INT NOT NULL Identity(1,1),
Nombre varchar(500) not null,
Correo varchar(500) not null,
Clave varbinary(500) not null,
Ciudad_ID INT,
Perfil_ID INT,
Imagen Varchar(500) not null,
Fecha_Crea DATETIME NOT NULL,
Activo bit default(1))

CREATE TABLE Ciudad(
ID INT NOT NULL IDENTITY(1,1),
Nombre Varchar(500) NOT NULL,
Latitud  Numeric(18,6),
Longitid Numeric(18,6),
Fecha_Crea DATETIME NOT NULL,
Activo bit default(1))

CREATE TABLE Perfil(
ID INT NOT NULL IDENTITY(1,1),
Nombre Varchar(500) NOT NULL,
Fecha_Crea DATETIME NOT NULL,
Activo bit default(1))

CREATE TABLE Categoria(
ID INT NOT NULL IDENTITY(1,1),
Nombre Varchar(500) NOT NULL,
Fecha_Crea DATETIME NOT NULL,
Activo bit default(1))

CREATE TABLE Suceso(
ID INT NOT NULL IDENTITY(1,1),
Usuario_ID INT,
Descripcion VARCHAR(1000),
Latitud  Numeric(18,6),
Longitid Numeric(18,6),
Suceso_Categoria_ID INT,
Ciudad_ID INT,
Estado_ID INT,
EsAnonimo BIT Default(0),
Fecha_Crea DATETIME NOT NULL,
Activo bit default(1))

CREATE TABLE Suceso_Categoria(
ID INT NOT NULL Identity(1,1),
Suceso_ID INT,
Categoria_ID INT,
Fecha_Crea DATETIME NOT NULL,
Activo bit default(1))

CREATE TABLE Suceso_Multimedia(
ID INT NOT NULL Identity(1,1),
Ruta VARCHAR(1000),
Nombre Varchar(500),
Tipo_ID INT,
Suceso_ID INT,
Fecha_Crea DATETIME NOT NULL,
Activo bit default(1))


CREATE TABLE Suceso_Multimedia_Tipo(
ID INT NOT NULL Identity(1,1),
Nombre Varchar(500),
Fecha_Crea DATETIME NOT NULL,
Activo bit default(1))

CREATE TABLE Suceso_Valoracion(
ID INT NOT NULL IDENTITY(1,1),
Suceso_ID INT NOT NULL,
Usuario_ID INT NOT NULL,
Fecha_Crea DATETIME NOT NULL,
Suceso_Valoracion_Tipo_ID INT, 
Activo bit default(1))


CREATE TABLE Suceso_Valoracion_Tipo(
ID INT NOT NULL IDENTITY(1,1),
Nombre Varchar(500),
Valoracion INT,
Fecha_Crea DATETIME NOT NULL,
Activo bit default(1))