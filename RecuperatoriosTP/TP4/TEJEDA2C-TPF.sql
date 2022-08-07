USE [master]
GO
/****** Object:  Database [TEJEDA2C-TPF]    Script Date: 7/8/2022 14:42:38 ******/
CREATE DATABASE [TEJEDA2C-TPF]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'TEJEDA2C-TPF', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\TEJEDA2C-TPF.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'TEJEDA2C-TPF_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\TEJEDA2C-TPF_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [TEJEDA2C-TPF] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [TEJEDA2C-TPF].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [TEJEDA2C-TPF] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [TEJEDA2C-TPF] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [TEJEDA2C-TPF] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [TEJEDA2C-TPF] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [TEJEDA2C-TPF] SET ARITHABORT OFF 
GO
ALTER DATABASE [TEJEDA2C-TPF] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [TEJEDA2C-TPF] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [TEJEDA2C-TPF] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [TEJEDA2C-TPF] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [TEJEDA2C-TPF] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [TEJEDA2C-TPF] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [TEJEDA2C-TPF] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [TEJEDA2C-TPF] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [TEJEDA2C-TPF] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [TEJEDA2C-TPF] SET  ENABLE_BROKER 
GO
ALTER DATABASE [TEJEDA2C-TPF] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [TEJEDA2C-TPF] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [TEJEDA2C-TPF] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [TEJEDA2C-TPF] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [TEJEDA2C-TPF] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [TEJEDA2C-TPF] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [TEJEDA2C-TPF] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [TEJEDA2C-TPF] SET RECOVERY FULL 
GO
ALTER DATABASE [TEJEDA2C-TPF] SET  MULTI_USER 
GO
ALTER DATABASE [TEJEDA2C-TPF] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [TEJEDA2C-TPF] SET DB_CHAINING OFF 
GO
ALTER DATABASE [TEJEDA2C-TPF] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [TEJEDA2C-TPF] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [TEJEDA2C-TPF] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [TEJEDA2C-TPF] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'TEJEDA2C-TPF', N'ON'
GO
ALTER DATABASE [TEJEDA2C-TPF] SET QUERY_STORE = OFF
GO
USE [TEJEDA2C-TPF]
GO
/****** Object:  Table [dbo].[Clientes]    Script Date: 7/8/2022 14:42:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Clientes](
	[Dni] [int] NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
	[Apellido] [varchar](50) NOT NULL,
	[Direccion] [varchar](50) NOT NULL,
	[EServicio] [varchar](50) NULL,
	[EFormaPago] [varchar](50) NULL,
	[ECantidadDecos] [int] NULL,
	[HBO] [bit] NULL,
	[NBA] [bit] NULL,
	[Star] [bit] NULL,
	[Paramount] [bit] NULL,
	[FutbolArgentino] [bit] NULL,
 CONSTRAINT [PK_Clientes] PRIMARY KEY CLUSTERED 
(
	[Dni] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Reclamos]    Script Date: 7/8/2022 14:42:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Reclamos](
	[NumeroReclamo] [int] IDENTITY(1,1) NOT NULL,
	[DniCliente] [varchar](50) NOT NULL,
	[EstaSolucionado] [bit] NULL,
 CONSTRAINT [PK_Reclamos] PRIMARY KEY CLUSTERED 
(
	[NumeroReclamo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Usuarios]    Script Date: 7/8/2022 14:42:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuarios](
	[Dni] [int] NOT NULL,
	[Nombre] [varchar](255) NOT NULL,
	[Apellido] [varchar](255) NOT NULL,
	[NombreUsuario] [varchar](255) NOT NULL,
	[Passwword] [varchar](10) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Dni] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Clientes] ([Dni], [Nombre], [Apellido], [Direccion], [EServicio], [EFormaPago], [ECantidadDecos], [HBO], [NBA], [Star], [Paramount], [FutbolArgentino]) VALUES (234567, N'Juan Manuel', N'de Rosas', N'El restaurador 290', N'NoActivo', N'TarjetaCredito', 0, 0, 0, 0, 0, 0)
GO
INSERT [dbo].[Clientes] ([Dni], [Nombre], [Apellido], [Direccion], [EServicio], [EFormaPago], [ECantidadDecos], [HBO], [NBA], [Star], [Paramount], [FutbolArgentino]) VALUES (1289456, N'Jose', N'San Martin', N'Cementerio Recoleta', N'Plata', N'TarjetaCredito', 0, 0, 0, 0, 1, 1)
GO
INSERT [dbo].[Clientes] ([Dni], [Nombre], [Apellido], [Direccion], [EServicio], [EFormaPago], [ECantidadDecos], [HBO], [NBA], [Star], [Paramount], [FutbolArgentino]) VALUES (10345984, N'Raul', N'Alfonsin', N'Salta 289', N'Oro', N'TarjetaDebito', 1, 0, 0, 0, 0, 1)
GO
INSERT [dbo].[Clientes] ([Dni], [Nombre], [Apellido], [Direccion], [EServicio], [EFormaPago], [ECantidadDecos], [HBO], [NBA], [Star], [Paramount], [FutbolArgentino]) VALUES (12908345, N'Cantalicio', N'Luna', N'Larralde 3987', N'NoActivo', N'TarjetaCredito', 0, 0, 0, 0, 0, 0)
GO
INSERT [dbo].[Clientes] ([Dni], [Nombre], [Apellido], [Direccion], [EServicio], [EFormaPago], [ECantidadDecos], [HBO], [NBA], [Star], [Paramount], [FutbolArgentino]) VALUES (18098193, N'Micaela', N'Suarez', N'PUAN 267Mi', N'Plata', N'TarjetaCredito', 2, 0, 0, 0, 0, 0)
GO
INSERT [dbo].[Clientes] ([Dni], [Nombre], [Apellido], [Direccion], [EServicio], [EFormaPago], [ECantidadDecos], [HBO], [NBA], [Star], [Paramount], [FutbolArgentino]) VALUES (18223125, N'Roberto', N'Tejeda', N'Larrea 123', N'DTVGo', N'TarjetaDebito', 0, 1, 1, 1, 1, 1)
GO
INSERT [dbo].[Clientes] ([Dni], [Nombre], [Apellido], [Direccion], [EServicio], [EFormaPago], [ECantidadDecos], [HBO], [NBA], [Star], [Paramount], [FutbolArgentino]) VALUES (24235466, N'Pepe', N'Argento', N'Larroque 2892', N'DTVGo', N'TarjetaDebito', 0, 0, 0, 0, 1, 0)
GO
INSERT [dbo].[Clientes] ([Dni], [Nombre], [Apellido], [Direccion], [EServicio], [EFormaPago], [ECantidadDecos], [HBO], [NBA], [Star], [Paramount], [FutbolArgentino]) VALUES (32546346, N'Arturo', N'Bonin', N'Lopes 235', N'Plata', N'TarjetaCredito', 0, 1, 1, 1, 1, 1)
GO
INSERT [dbo].[Clientes] ([Dni], [Nombre], [Apellido], [Direccion], [EServicio], [EFormaPago], [ECantidadDecos], [HBO], [NBA], [Star], [Paramount], [FutbolArgentino]) VALUES (34789123, N'Raul', N'Alacaraz', N'Perdo goyena 234', N'NoActivo', N'TarjetaCredito', 0, 0, 0, 0, 0, 0)
GO
INSERT [dbo].[Clientes] ([Dni], [Nombre], [Apellido], [Direccion], [EServicio], [EFormaPago], [ECantidadDecos], [HBO], [NBA], [Star], [Paramount], [FutbolArgentino]) VALUES (34890567, N'Ernesto', N'Alvarez', N'Sourigues 2879', N'NoActivo', N'TarjetaCredito', 0, 0, 0, 0, 0, 0)
GO
INSERT [dbo].[Clientes] ([Dni], [Nombre], [Apellido], [Direccion], [EServicio], [EFormaPago], [ECantidadDecos], [HBO], [NBA], [Star], [Paramount], [FutbolArgentino]) VALUES (34892876, N'Javier', N'Guzman', N'Latorrre 2', N'Plata', N'TarjetaDebito', 0, 1, 1, 0, 0, 1)
GO
INSERT [dbo].[Clientes] ([Dni], [Nombre], [Apellido], [Direccion], [EServicio], [EFormaPago], [ECantidadDecos], [HBO], [NBA], [Star], [Paramount], [FutbolArgentino]) VALUES (34978596, N'Carlos', N'Vives', N'Mao 456', N'Plata', N'TarjetaCredito', 3, 0, 0, 0, 1, 0)
GO
INSERT [dbo].[Clientes] ([Dni], [Nombre], [Apellido], [Direccion], [EServicio], [EFormaPago], [ECantidadDecos], [HBO], [NBA], [Star], [Paramount], [FutbolArgentino]) VALUES (45678298, N'Esteban', N'Prieto', N'Lafallet 389', N'Oro', N'TarjetaDebito', 2, 1, 1, 1, 1, 0)
GO
INSERT [dbo].[Clientes] ([Dni], [Nombre], [Apellido], [Direccion], [EServicio], [EFormaPago], [ECantidadDecos], [HBO], [NBA], [Star], [Paramount], [FutbolArgentino]) VALUES (56523891, N'Homero', N'Simpson', N'Fracaso 189', N'DTVGo', N'TarjetaCredito', 1, 0, 0, 0, 1, 0)
GO
INSERT [dbo].[Clientes] ([Dni], [Nombre], [Apellido], [Direccion], [EServicio], [EFormaPago], [ECantidadDecos], [HBO], [NBA], [Star], [Paramount], [FutbolArgentino]) VALUES (57984345, N'Lorena', N'Capurro', N'Perez 390', N'Plata', N'TarjetaDebito', 3, 1, 1, 0, 0, 1)
GO
INSERT [dbo].[Clientes] ([Dni], [Nombre], [Apellido], [Direccion], [EServicio], [EFormaPago], [ECantidadDecos], [HBO], [NBA], [Star], [Paramount], [FutbolArgentino]) VALUES (67356734, N'Eva', N'Peron', N'Roca 356', N'NoActivo', N'TarjetaCredito', 0, 1, 0, 0, 0, 0)
GO
INSERT [dbo].[Clientes] ([Dni], [Nombre], [Apellido], [Direccion], [EServicio], [EFormaPago], [ECantidadDecos], [HBO], [NBA], [Star], [Paramount], [FutbolArgentino]) VALUES (76289156, N'Charly', N'Garcia', N'Laralde 3456', N'NoActivo', N'TarjetaCredito', 0, 0, 0, 0, 0, 0)
GO
INSERT [dbo].[Clientes] ([Dni], [Nombre], [Apellido], [Direccion], [EServicio], [EFormaPago], [ECantidadDecos], [HBO], [NBA], [Star], [Paramount], [FutbolArgentino]) VALUES (89098345, N'Mao ', N'Tsetum', N'Triuvirato 4023', N'Plata', N'TarjetaDebito', 3, 0, 0, 0, 0, 1)
GO
INSERT [dbo].[Clientes] ([Dni], [Nombre], [Apellido], [Direccion], [EServicio], [EFormaPago], [ECantidadDecos], [HBO], [NBA], [Star], [Paramount], [FutbolArgentino]) VALUES (89654100, N'Facundo ', N'Cabral', N'Larrea 12', N'Plata', N'TarjetaCredito', 5, 1, 0, 1, 0, 1)
GO
INSERT [dbo].[Clientes] ([Dni], [Nombre], [Apellido], [Direccion], [EServicio], [EFormaPago], [ECantidadDecos], [HBO], [NBA], [Star], [Paramount], [FutbolArgentino]) VALUES (98123908, N'Diego', N'Maradona', N'Habana 4310', N'NoActivo', N'TarjetaCredito', 0, 0, 0, 0, 0, 0)
GO
INSERT [dbo].[Clientes] ([Dni], [Nombre], [Apellido], [Direccion], [EServicio], [EFormaPago], [ECantidadDecos], [HBO], [NBA], [Star], [Paramount], [FutbolArgentino]) VALUES (99239468, N'Tutan', N'Camon', N'Egipto 234', N'NoActivo', N'TarjetaCredito', 0, 0, 0, 0, 0, 0)
GO
INSERT [dbo].[Clientes] ([Dni], [Nombre], [Apellido], [Direccion], [EServicio], [EFormaPago], [ECantidadDecos], [HBO], [NBA], [Star], [Paramount], [FutbolArgentino]) VALUES (340982324, N'Joaquin', N'Sabina', N'madrid 823', N'Oro', N'TarjetaCredito', 2, 1, 0, 1, 1, 0)
GO
SET IDENTITY_INSERT [dbo].[Reclamos] ON 
GO
INSERT [dbo].[Reclamos] ([NumeroReclamo], [DniCliente], [EstaSolucionado]) VALUES (1, N'18223125', 0)
GO
INSERT [dbo].[Reclamos] ([NumeroReclamo], [DniCliente], [EstaSolucionado]) VALUES (2, N'18223125', 1)
GO
INSERT [dbo].[Reclamos] ([NumeroReclamo], [DniCliente], [EstaSolucionado]) VALUES (3, N'18098193', 0)
GO
INSERT [dbo].[Reclamos] ([NumeroReclamo], [DniCliente], [EstaSolucionado]) VALUES (4, N'340982324', 1)
GO
INSERT [dbo].[Reclamos] ([NumeroReclamo], [DniCliente], [EstaSolucionado]) VALUES (5, N'18098193', 0)
GO
INSERT [dbo].[Reclamos] ([NumeroReclamo], [DniCliente], [EstaSolucionado]) VALUES (6, N'32546346', 1)
GO
INSERT [dbo].[Reclamos] ([NumeroReclamo], [DniCliente], [EstaSolucionado]) VALUES (7, N'234567', 1)
GO
INSERT [dbo].[Reclamos] ([NumeroReclamo], [DniCliente], [EstaSolucionado]) VALUES (8, N'1289456', 1)
GO
INSERT [dbo].[Reclamos] ([NumeroReclamo], [DniCliente], [EstaSolucionado]) VALUES (9, N'18098193', 0)
GO
INSERT [dbo].[Reclamos] ([NumeroReclamo], [DniCliente], [EstaSolucionado]) VALUES (10, N'12908345', 0)
GO
INSERT [dbo].[Reclamos] ([NumeroReclamo], [DniCliente], [EstaSolucionado]) VALUES (11, N'1289456', 1)
GO
INSERT [dbo].[Reclamos] ([NumeroReclamo], [DniCliente], [EstaSolucionado]) VALUES (12, N'10345984', 1)
GO
INSERT [dbo].[Reclamos] ([NumeroReclamo], [DniCliente], [EstaSolucionado]) VALUES (13, N'1289456', 0)
GO
INSERT [dbo].[Reclamos] ([NumeroReclamo], [DniCliente], [EstaSolucionado]) VALUES (14, N'10345984', 0)
GO
INSERT [dbo].[Reclamos] ([NumeroReclamo], [DniCliente], [EstaSolucionado]) VALUES (15, N'12908345', 1)
GO
SET IDENTITY_INSERT [dbo].[Reclamos] OFF
GO
INSERT [dbo].[Usuarios] ([Dni], [Nombre], [Apellido], [NombreUsuario], [Passwword]) VALUES (18223125, N'Roberto', N'Tejeda', N'rtejeda', N'1234')
GO
INSERT [dbo].[Usuarios] ([Dni], [Nombre], [Apellido], [NombreUsuario], [Passwword]) VALUES (18456789, N'Alberto', N'Tejeda', N'atejeda', N'5678')
GO
INSERT [dbo].[Usuarios] ([Dni], [Nombre], [Apellido], [NombreUsuario], [Passwword]) VALUES (18987654, N'Norberto', N'Tejeda', N'ntejeda', N'9012')
GO
INSERT [dbo].[Usuarios] ([Dni], [Nombre], [Apellido], [NombreUsuario], [Passwword]) VALUES (35378567, N'Jose', N'alvarez', N'jAlvarez', N'4321')
GO
USE [master]
GO
ALTER DATABASE [TEJEDA2C-TPF] SET  READ_WRITE 
GO
