CREATE DATABASE [TEJEDA2C-TPF];
GO
USE [TEJEDA2C-TPF];
GO
CREATE TABLE [TEJEDA2C-TPF].dbo.Usuarios
    (
      Dni INT PRIMARY KEY,
      Nombre VARCHAR(255) NOT NULL,
      Apellido VARCHAR(255) NOT NULL,		
      NombreUsuario VARCHAR(255) NOT NULL,
      Passwword VARCHAR(10) NOT NULL,
    );
GO
INSERT INTO Usuarios VALUES ('18223125','Roberto','Tejeda','rtejeda','1234')
INSERT INTO Usuarios VALUES ('18456789','Alberto','Tejeda','atejeda','5678')
INSERT INTO Usuarios VALUES ('18987654','Norberto','Tejeda','ntejeda','9012')