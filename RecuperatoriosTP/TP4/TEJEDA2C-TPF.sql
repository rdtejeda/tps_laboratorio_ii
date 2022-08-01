USE [TEJEDA2C-TPF]
GO
/****** Object:  Table [dbo].[Clientes]    Script Date: 1/8/2022 09:25:33 ******/
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
/****** Object:  Table [dbo].[Usuarios]    Script Date: 1/8/2022 09:25:33 ******/
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
INSERT [dbo].[Clientes] ([Dni], [Nombre], [Apellido], [Direccion], [EServicio], [EFormaPago], [ECantidadDecos], [HBO], [NBA], [Star], [Paramount], [FutbolArgentino]) VALUES (1289456, N'Jose', N'San Martin', N'Cementerio Recoleta', N'NoActivo', N'TarjetaCredito', 0, 0, 0, 0, 0, 0)
GO
INSERT [dbo].[Clientes] ([Dni], [Nombre], [Apellido], [Direccion], [EServicio], [EFormaPago], [ECantidadDecos], [HBO], [NBA], [Star], [Paramount], [FutbolArgentino]) VALUES (10345984, N'Raul', N'Alfonsin', N'Salta 289', N'NoActivo', N'TarjetaCredito', 0, 0, 0, 0, 0, 0)
GO
INSERT [dbo].[Clientes] ([Dni], [Nombre], [Apellido], [Direccion], [EServicio], [EFormaPago], [ECantidadDecos], [HBO], [NBA], [Star], [Paramount], [FutbolArgentino]) VALUES (18098193, N'Micaela', N'Suarez', N'PUAN 267Mi', N'NoActivo', N'TarjetaCredito', 0, 0, 0, 0, 0, 0)
GO
INSERT [dbo].[Clientes] ([Dni], [Nombre], [Apellido], [Direccion], [EServicio], [EFormaPago], [ECantidadDecos], [HBO], [NBA], [Star], [Paramount], [FutbolArgentino]) VALUES (18223125, N'Roberto', N'Tejeda', N'Larrea 123', N'Plata', N'TarjetaCredito', 2, 0, 0, 0, 0, 1)
GO
INSERT [dbo].[Clientes] ([Dni], [Nombre], [Apellido], [Direccion], [EServicio], [EFormaPago], [ECantidadDecos], [HBO], [NBA], [Star], [Paramount], [FutbolArgentino]) VALUES (24235466, N'Pepe', N'Argento', N'Larroque 2890', N'DTVGo', N'TarjetaCredito', 0, 0, 0, 0, 0, 1)
GO
INSERT [dbo].[Clientes] ([Dni], [Nombre], [Apellido], [Direccion], [EServicio], [EFormaPago], [ECantidadDecos], [HBO], [NBA], [Star], [Paramount], [FutbolArgentino]) VALUES (32546346, N'Arturo', N'Bonin', N'Lopes 235', N'Plata', N'TarjetaCredito', 5, 0, 0, 1, 1, 0)
GO
INSERT [dbo].[Clientes] ([Dni], [Nombre], [Apellido], [Direccion], [EServicio], [EFormaPago], [ECantidadDecos], [HBO], [NBA], [Star], [Paramount], [FutbolArgentino]) VALUES (34892876, N'Javier', N'Guzman', N'Latorrre 2', N'Oro', N'TarjetaDebito', 5, 0, 1, 0, 0, 1)
GO
INSERT [dbo].[Clientes] ([Dni], [Nombre], [Apellido], [Direccion], [EServicio], [EFormaPago], [ECantidadDecos], [HBO], [NBA], [Star], [Paramount], [FutbolArgentino]) VALUES (34978596, N'Carlos', N'Vives', N'Mao 456', N'Plata', N'TarjetaCredito', 3, 0, 0, 0, 1, 0)
GO
INSERT [dbo].[Clientes] ([Dni], [Nombre], [Apellido], [Direccion], [EServicio], [EFormaPago], [ECantidadDecos], [HBO], [NBA], [Star], [Paramount], [FutbolArgentino]) VALUES (45678298, N'Esteban', N'Prieto', N'Lafallet 389', N'Oro', N'TarjetaDebito', 2, 1, 1, 1, 1, 0)
GO
INSERT [dbo].[Clientes] ([Dni], [Nombre], [Apellido], [Direccion], [EServicio], [EFormaPago], [ECantidadDecos], [HBO], [NBA], [Star], [Paramount], [FutbolArgentino]) VALUES (67356734, N'Eva', N'Peron', N'Roca 356', N'NoActivo', N'TarjetaCredito', 0, 0, 0, 0, 0, 0)
GO
INSERT [dbo].[Clientes] ([Dni], [Nombre], [Apellido], [Direccion], [EServicio], [EFormaPago], [ECantidadDecos], [HBO], [NBA], [Star], [Paramount], [FutbolArgentino]) VALUES (76289156, N'Charly', N'Garcia', N'Laralde 3456', N'NoActivo', N'TarjetaCredito', 0, 0, 0, 0, 0, 0)
GO
INSERT [dbo].[Clientes] ([Dni], [Nombre], [Apellido], [Direccion], [EServicio], [EFormaPago], [ECantidadDecos], [HBO], [NBA], [Star], [Paramount], [FutbolArgentino]) VALUES (89098345, N'Mao ', N'Tsetum', N'Triuvirato 4023', N'Plata', N'TarjetaDebito', 3, 0, 0, 0, 0, 1)
GO
INSERT [dbo].[Clientes] ([Dni], [Nombre], [Apellido], [Direccion], [EServicio], [EFormaPago], [ECantidadDecos], [HBO], [NBA], [Star], [Paramount], [FutbolArgentino]) VALUES (89654100, N'Facundo ', N'Cabral', N'Larrea 12', N'NoActivo', N'TarjetaCredito', 0, 0, 0, 0, 0, 0)
GO
INSERT [dbo].[Clientes] ([Dni], [Nombre], [Apellido], [Direccion], [EServicio], [EFormaPago], [ECantidadDecos], [HBO], [NBA], [Star], [Paramount], [FutbolArgentino]) VALUES (98123908, N'Diego', N'Maradona', N'Habana 4310', N'NoActivo', N'TarjetaCredito', 0, 0, 0, 0, 0, 0)
GO
INSERT [dbo].[Usuarios] ([Dni], [Nombre], [Apellido], [NombreUsuario], [Passwword]) VALUES (18223125, N'Roberto', N'Tejeda', N'rtejeda', N'1234')
GO
INSERT [dbo].[Usuarios] ([Dni], [Nombre], [Apellido], [NombreUsuario], [Passwword]) VALUES (18456789, N'Alberto', N'Tejeda', N'atejeda', N'5678')
GO
INSERT [dbo].[Usuarios] ([Dni], [Nombre], [Apellido], [NombreUsuario], [Passwword]) VALUES (18987654, N'Norberto', N'Tejeda', N'ntejeda', N'9012')
GO
