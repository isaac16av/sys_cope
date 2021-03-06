USE [SPC]
GO
/****** Object:  Table [dbo].[DetalleEscala]    Script Date: 5/12/2018 00:51:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DetalleEscala](
	[IdDetalleEscala] [int] IDENTITY(1,1) NOT NULL,
	[Escala] [int] NOT NULL,
	[PCTMinimo] [int] NOT NULL,
	[PCTMaximo] [int] NOT NULL,
	[PCTComision] [decimal](18, 2) NOT NULL,
 CONSTRAINT [PK_DetalleEscala] PRIMARY KEY CLUSTERED 
(
	[IdDetalleEscala] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Ejecutivo]    Script Date: 5/12/2018 00:51:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ejecutivo](
	[Cedula] [int] NOT NULL,
	[CodigoVendedor] [varchar](50) NOT NULL,
	[Nombre] [varchar](100) NOT NULL,
	[Apellidos] [varchar](100) NOT NULL,
	[Telefono] [int] NOT NULL,
	[Correo] [varchar](100) NOT NULL,
	[FechaNacimiento] [date] NOT NULL,
	[FechaContratacion] [date] NOT NULL,
	[Estado] [bit] NOT NULL,
	[UnidadNegocio] [int] NOT NULL,
 CONSTRAINT [PK_Vendedor] PRIMARY KEY CLUSTERED 
(
	[Cedula] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Escala]    Script Date: 5/12/2018 00:51:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Escala](
	[IdEscala] [int] IDENTITY(1,1) NOT NULL,
	[Descripcion] [varchar](50) NOT NULL,
	[Estado] [bit] NOT NULL,
 CONSTRAINT [PK_Escala] PRIMARY KEY CLUSTERED 
(
	[IdEscala] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Meta]    Script Date: 5/12/2018 00:51:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Meta](
	[IdMeta] [int] IDENTITY(1,1) NOT NULL,
	[Descripcion] [varchar](50) NOT NULL,
	[Estado] [bit] NOT NULL,
	[Escala] [int] NOT NULL,
	[Salario] [int] NOT NULL,
 CONSTRAINT [PK_Meta] PRIMARY KEY CLUSTERED 
(
	[IdMeta] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MetaCDP]    Script Date: 5/12/2018 00:51:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MetaCDP](
	[IdMetaCDP] [int] IDENTITY(1,1) NOT NULL,
	[Metacdp] [decimal](18, 2) NOT NULL,
	[ValorIDP] [decimal](18, 2) NOT NULL,
	[Meta] [int] NOT NULL,
 CONSTRAINT [PK_MetaCDP] PRIMARY KEY CLUSTERED 
(
	[IdMetaCDP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MetaCredito]    Script Date: 5/12/2018 00:51:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MetaCredito](
	[IdMetaCredito] [int] IDENTITY(1,1) NOT NULL,
	[MetaColocacion] [decimal](18, 2) NOT NULL,
	[ValorIDP] [decimal](18, 2) NOT NULL,
	[Meta] [int] NOT NULL,
 CONSTRAINT [PK_DetalleMeta] PRIMARY KEY CLUSTERED 
(
	[IdMetaCredito] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MetaTipoProducto]    Script Date: 5/12/2018 00:51:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MetaTipoProducto](
	[IdMetaTipoProducto] [int] IDENTITY(1,1) NOT NULL,
	[MetaCantidad] [int] NOT NULL,
	[ValorIDP] [decimal](18, 2) NOT NULL,
	[Meta] [int] NOT NULL,
 CONSTRAINT [PK_MetaProducto] PRIMARY KEY CLUSTERED 
(
	[IdMetaTipoProducto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MetaTipoProductoDetalle]    Script Date: 5/12/2018 00:51:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MetaTipoProductoDetalle](
	[MetaTipoProducto] [int] NOT NULL,
	[TipoProducto] [int] NOT NULL,
 CONSTRAINT [PK_MetaProductoDetalle_1] PRIMARY KEY CLUSTERED 
(
	[MetaTipoProducto] ASC,
	[TipoProducto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Producto]    Script Date: 5/12/2018 00:51:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Producto](
	[IdProducto] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](200) NOT NULL,
	[Comision] [decimal](18, 2) NOT NULL,
	[Estado] [bit] NOT NULL,
	[TipoProducto] [int] NOT NULL,
 CONSTRAINT [PK_Producto] PRIMARY KEY CLUSTERED 
(
	[IdProducto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Salario]    Script Date: 5/12/2018 00:51:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Salario](
	[IdSalario] [int] IDENTITY(1,1) NOT NULL,
	[Base] [decimal](18, 2) NOT NULL,
	[Descripcion] [varchar](100) NOT NULL,
	[Estado] [bit] NOT NULL,
	[MesesInicio] [int] NOT NULL,
	[SalarioInicio] [decimal](18, 2) NOT NULL,
	[BonoInicio] [decimal](18, 2) NOT NULL,
 CONSTRAINT [PK_Salario] PRIMARY KEY CLUSTERED 
(
	[IdSalario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TipoCambio]    Script Date: 5/12/2018 00:51:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TipoCambio](
	[IdTipoCambio] [int] IDENTITY(1,1) NOT NULL,
	[Valor] [decimal](18, 2) NOT NULL,
	[Fecha] [date] NOT NULL,
	[Estado] [bit] NOT NULL,
 CONSTRAINT [PK_TipoCambio] PRIMARY KEY CLUSTERED 
(
	[IdTipoCambio] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TipoCDP]    Script Date: 5/12/2018 00:51:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TipoCDP](
	[IdTipoCDP] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](100) NOT NULL,
	[Moneda] [char](1) NOT NULL,
	[ComisionMaxima] [decimal](18, 2) NULL,
	[Estado] [bit] NOT NULL,
	[IDPNecesario] [decimal](18, 2) NOT NULL,
	[PCTComision] [decimal](18, 2) NOT NULL,
 CONSTRAINT [PK_TipoCDP] PRIMARY KEY CLUSTERED 
(
	[IdTipoCDP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TipoCredito]    Script Date: 5/12/2018 00:51:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TipoCredito](
	[IdTipoCredito] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](100) NOT NULL,
	[ComisionDistinta] [decimal](18, 2) NULL,
	[MaximoComision] [decimal](18, 2) NULL,
	[SumaIDP] [bit] NOT NULL,
	[Estado] [bit] NOT NULL,
 CONSTRAINT [PK_TipoCredito] PRIMARY KEY CLUSTERED 
(
	[IdTipoCredito] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TipoProducto]    Script Date: 5/12/2018 00:51:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TipoProducto](
	[IdTipoProducto] [int] IDENTITY(1,1) NOT NULL,
	[Descripcion] [varchar](200) NOT NULL,
	[Moneda] [char](1) NOT NULL,
	[Estado] [bit] NOT NULL,
	[IDPNecesario] [decimal](18, 2) NOT NULL,
 CONSTRAINT [PK_TipoProducto] PRIMARY KEY CLUSTERED 
(
	[IdTipoProducto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UnidadNegocio]    Script Date: 5/12/2018 00:51:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UnidadNegocio](
	[IdUnidad] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](100) NOT NULL,
	[Estado] [bit] NOT NULL,
	[Meta] [int] NOT NULL,
 CONSTRAINT [PK_UnidadNegocio] PRIMARY KEY CLUSTERED 
(
	[IdUnidad] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[VentaCDP]    Script Date: 5/12/2018 00:51:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[VentaCDP](
	[IdVentaCDP] [int] IDENTITY(1,1) NOT NULL,
	[Ejecutivo] [int] NOT NULL,
	[Fecha] [datetime] NOT NULL,
	[Cedula] [int] NOT NULL,
	[Nombre] [varchar](500) NOT NULL,
	[CentroTrabajo] [varchar](200) NOT NULL,
	[Monto] [decimal](18, 2) NOT NULL,
	[PlazoMeses] [int] NOT NULL,
	[Periocidad] [int] NOT NULL,
	[Tasa] [decimal](18, 2) NULL,
	[SobreTasa] [decimal](18, 2) NULL,
	[Estado] [bit] NOT NULL,
	[TipoCDP] [int] NOT NULL,
 CONSTRAINT [PK_VentaCDP] PRIMARY KEY CLUSTERED 
(
	[IdVentaCDP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[VentaCredito]    Script Date: 5/12/2018 00:51:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[VentaCredito](
	[IdVentaCredito] [int] IDENTITY(1,1) NOT NULL,
	[Ejecutivo] [int] NOT NULL,
	[Fecha] [datetime] NOT NULL,
	[Cedula] [int] NOT NULL,
	[Nombre] [varchar](500) NOT NULL,
	[CentroTrabajo] [varchar](200) NOT NULL,
	[FechaAfiliacion] [date] NOT NULL,
	[NumeroOperacion] [int] NOT NULL,
	[Monto] [decimal](18, 2) NOT NULL,
	[PlazoMeses] [int] NOT NULL,
	[Estado] [bit] NOT NULL,
	[TipoCredito] [int] NOT NULL,
 CONSTRAINT [PK_VentaCredito] PRIMARY KEY CLUSTERED 
(
	[IdVentaCredito] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[VentaProducto]    Script Date: 5/12/2018 00:51:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[VentaProducto](
	[IdVentaProducto] [int] IDENTITY(1,1) NOT NULL,
	[Ejecutivo] [int] NOT NULL,
	[Fecha] [datetime] NOT NULL,
	[Cedula] [int] NOT NULL,
	[Nombre] [varchar](500) NOT NULL,
	[CentroTrabajo] [varchar](200) NOT NULL,
	[Producto] [int] NOT NULL,
	[Estado] [bit] NOT NULL,
 CONSTRAINT [PK_VentaProducto] PRIMARY KEY CLUSTERED 
(
	[IdVentaProducto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[DetalleEscala] ON 

INSERT [dbo].[DetalleEscala] ([IdDetalleEscala], [Escala], [PCTMinimo], [PCTMaximo], [PCTComision]) VALUES (1, 1, 0, 50, CAST(0.00 AS Decimal(18, 2)))
INSERT [dbo].[DetalleEscala] ([IdDetalleEscala], [Escala], [PCTMinimo], [PCTMaximo], [PCTComision]) VALUES (2, 1, 51, 60, CAST(0.53 AS Decimal(18, 2)))
INSERT [dbo].[DetalleEscala] ([IdDetalleEscala], [Escala], [PCTMinimo], [PCTMaximo], [PCTComision]) VALUES (3, 1, 61, 84, CAST(0.95 AS Decimal(18, 2)))
INSERT [dbo].[DetalleEscala] ([IdDetalleEscala], [Escala], [PCTMinimo], [PCTMaximo], [PCTComision]) VALUES (4, 1, 85, 99, CAST(1.43 AS Decimal(18, 2)))
INSERT [dbo].[DetalleEscala] ([IdDetalleEscala], [Escala], [PCTMinimo], [PCTMaximo], [PCTComision]) VALUES (5, 1, 100, 100, CAST(1.75 AS Decimal(18, 2)))
INSERT [dbo].[DetalleEscala] ([IdDetalleEscala], [Escala], [PCTMinimo], [PCTMaximo], [PCTComision]) VALUES (1007, 2, 0, 50, CAST(0.00 AS Decimal(18, 2)))
INSERT [dbo].[DetalleEscala] ([IdDetalleEscala], [Escala], [PCTMinimo], [PCTMaximo], [PCTComision]) VALUES (1008, 2, 51, 60, CAST(1.00 AS Decimal(18, 2)))
INSERT [dbo].[DetalleEscala] ([IdDetalleEscala], [Escala], [PCTMinimo], [PCTMaximo], [PCTComision]) VALUES (1010, 2, 61, 84, CAST(2.00 AS Decimal(18, 2)))
INSERT [dbo].[DetalleEscala] ([IdDetalleEscala], [Escala], [PCTMinimo], [PCTMaximo], [PCTComision]) VALUES (1011, 2, 85, 90, CAST(3.00 AS Decimal(18, 2)))
INSERT [dbo].[DetalleEscala] ([IdDetalleEscala], [Escala], [PCTMinimo], [PCTMaximo], [PCTComision]) VALUES (1012, 2, 91, 100, CAST(4.00 AS Decimal(18, 2)))
INSERT [dbo].[DetalleEscala] ([IdDetalleEscala], [Escala], [PCTMinimo], [PCTMaximo], [PCTComision]) VALUES (1013, 1002, 0, 50, CAST(1.00 AS Decimal(18, 2)))
INSERT [dbo].[DetalleEscala] ([IdDetalleEscala], [Escala], [PCTMinimo], [PCTMaximo], [PCTComision]) VALUES (1014, 1002, 51, 100, CAST(2.00 AS Decimal(18, 2)))
INSERT [dbo].[DetalleEscala] ([IdDetalleEscala], [Escala], [PCTMinimo], [PCTMaximo], [PCTComision]) VALUES (1015, 1003, 0, 50, CAST(0.20 AS Decimal(18, 2)))
INSERT [dbo].[DetalleEscala] ([IdDetalleEscala], [Escala], [PCTMinimo], [PCTMaximo], [PCTComision]) VALUES (1016, 1003, 51, 100, CAST(0.52 AS Decimal(18, 2)))
INSERT [dbo].[DetalleEscala] ([IdDetalleEscala], [Escala], [PCTMinimo], [PCTMaximo], [PCTComision]) VALUES (1017, 1004, 0, 50, CAST(0.50 AS Decimal(18, 2)))
INSERT [dbo].[DetalleEscala] ([IdDetalleEscala], [Escala], [PCTMinimo], [PCTMaximo], [PCTComision]) VALUES (1018, 1004, 51, 100, CAST(1.00 AS Decimal(18, 2)))
INSERT [dbo].[DetalleEscala] ([IdDetalleEscala], [Escala], [PCTMinimo], [PCTMaximo], [PCTComision]) VALUES (1019, 1005, 0, 30, CAST(0.00 AS Decimal(18, 2)))
INSERT [dbo].[DetalleEscala] ([IdDetalleEscala], [Escala], [PCTMinimo], [PCTMaximo], [PCTComision]) VALUES (1020, 1005, 31, 50, CAST(0.50 AS Decimal(18, 2)))
INSERT [dbo].[DetalleEscala] ([IdDetalleEscala], [Escala], [PCTMinimo], [PCTMaximo], [PCTComision]) VALUES (1021, 1005, 551, 80, CAST(0.80 AS Decimal(18, 2)))
INSERT [dbo].[DetalleEscala] ([IdDetalleEscala], [Escala], [PCTMinimo], [PCTMaximo], [PCTComision]) VALUES (1022, 1005, 81, 90, CAST(1.00 AS Decimal(18, 2)))
INSERT [dbo].[DetalleEscala] ([IdDetalleEscala], [Escala], [PCTMinimo], [PCTMaximo], [PCTComision]) VALUES (1023, 1005, 91, 100, CAST(1.20 AS Decimal(18, 2)))
INSERT [dbo].[DetalleEscala] ([IdDetalleEscala], [Escala], [PCTMinimo], [PCTMaximo], [PCTComision]) VALUES (1024, 1006, 0, 30, CAST(0.00 AS Decimal(18, 2)))
INSERT [dbo].[DetalleEscala] ([IdDetalleEscala], [Escala], [PCTMinimo], [PCTMaximo], [PCTComision]) VALUES (1025, 1006, 31, 50, CAST(0.50 AS Decimal(18, 2)))
INSERT [dbo].[DetalleEscala] ([IdDetalleEscala], [Escala], [PCTMinimo], [PCTMaximo], [PCTComision]) VALUES (1026, 1006, 51, 80, CAST(0.80 AS Decimal(18, 2)))
INSERT [dbo].[DetalleEscala] ([IdDetalleEscala], [Escala], [PCTMinimo], [PCTMaximo], [PCTComision]) VALUES (1027, 1006, 81, 90, CAST(1.00 AS Decimal(18, 2)))
INSERT [dbo].[DetalleEscala] ([IdDetalleEscala], [Escala], [PCTMinimo], [PCTMaximo], [PCTComision]) VALUES (1028, 1006, 91, 100, CAST(1.20 AS Decimal(18, 2)))
SET IDENTITY_INSERT [dbo].[DetalleEscala] OFF
INSERT [dbo].[Ejecutivo] ([Cedula], [CodigoVendedor], [Nombre], [Apellidos], [Telefono], [Correo], [FechaNacimiento], [FechaContratacion], [Estado], [UnidadNegocio]) VALUES (1, N'prueba123', N'Ejecutivo', N'De Prueba', 88888888, N'ejprueba@prueba.com', CAST(N'1990-06-12' AS Date), CAST(N'2017-12-01' AS Date), 0, 1)
INSERT [dbo].[Ejecutivo] ([Cedula], [CodigoVendedor], [Nombre], [Apellidos], [Telefono], [Correo], [FechaNacimiento], [FechaContratacion], [Estado], [UnidadNegocio]) VALUES (6, N'abs123', N'Isaac', N'Alfaro', 88888888, N'is@gma.com', CAST(N'1997-10-16' AS Date), CAST(N'2017-12-12' AS Date), 1, 1)
INSERT [dbo].[Ejecutivo] ([Cedula], [CodigoVendedor], [Nombre], [Apellidos], [Telefono], [Correo], [FechaNacimiento], [FechaContratacion], [Estado], [UnidadNegocio]) VALUES (65, N'2s', N'da', N'da', 66, N'as.ac@asc.com', CAST(N'1997-10-06' AS Date), CAST(N'2001-01-01' AS Date), 0, 1)
INSERT [dbo].[Ejecutivo] ([Cedula], [CodigoVendedor], [Nombre], [Apellidos], [Telefono], [Correo], [FechaNacimiento], [FechaContratacion], [Estado], [UnidadNegocio]) VALUES (123, N'lak', N'Prueba', N'P P', 123, N'pp@gmilc.pm', CAST(N'2002-02-02' AS Date), CAST(N'2017-06-08' AS Date), 0, 1)
INSERT [dbo].[Ejecutivo] ([Cedula], [CodigoVendedor], [Nombre], [Apellidos], [Telefono], [Correo], [FechaNacimiento], [FechaContratacion], [Estado], [UnidadNegocio]) VALUES (654, N'sd', N'ih', N'ih', 999, N'sa.cls@s.com', CAST(N'2012-12-12' AS Date), CAST(N'2012-12-12' AS Date), 0, 1)
INSERT [dbo].[Ejecutivo] ([Cedula], [CodigoVendedor], [Nombre], [Apellidos], [Telefono], [Correo], [FechaNacimiento], [FechaContratacion], [Estado], [UnidadNegocio]) VALUES (11690000, N'M0215', N'Pedro', N'Gutierrez', 80011111, N'pedrog@mail.com', CAST(N'1990-06-12' AS Date), CAST(N'2017-04-04' AS Date), 0, 1)
INSERT [dbo].[Ejecutivo] ([Cedula], [CodigoVendedor], [Nombre], [Apellidos], [Telefono], [Correo], [FechaNacimiento], [FechaContratacion], [Estado], [UnidadNegocio]) VALUES (116900078, N'K2062', N'Pedro', N'Fernandez', 29955545, N'pfez@mail.com', CAST(N'1987-06-12' AS Date), CAST(N'2018-12-12' AS Date), 1, 3)
SET IDENTITY_INSERT [dbo].[Escala] ON 

INSERT [dbo].[Escala] ([IdEscala], [Descripcion], [Estado]) VALUES (1, N'Escala de prueba', 1)
INSERT [dbo].[Escala] ([IdEscala], [Descripcion], [Estado]) VALUES (2, N'Escala Lam', 0)
INSERT [dbo].[Escala] ([IdEscala], [Descripcion], [Estado]) VALUES (1002, N'sd', 0)
INSERT [dbo].[Escala] ([IdEscala], [Descripcion], [Estado]) VALUES (1003, N'asd', 0)
INSERT [dbo].[Escala] ([IdEscala], [Descripcion], [Estado]) VALUES (1004, N'Esscala 2', 0)
INSERT [dbo].[Escala] ([IdEscala], [Descripcion], [Estado]) VALUES (1005, N'Escala de Ejemplo', 0)
INSERT [dbo].[Escala] ([IdEscala], [Descripcion], [Estado]) VALUES (1006, N'Escala de Ejemplo', 1)
SET IDENTITY_INSERT [dbo].[Escala] OFF
SET IDENTITY_INSERT [dbo].[Meta] ON 

INSERT [dbo].[Meta] ([IdMeta], [Descripcion], [Estado], [Escala], [Salario]) VALUES (1, N'Meta de prueba', 1, 1, 1)
INSERT [dbo].[Meta] ([IdMeta], [Descripcion], [Estado], [Escala], [Salario]) VALUES (2, N'qw', 0, 1, 1)
INSERT [dbo].[Meta] ([IdMeta], [Descripcion], [Estado], [Escala], [Salario]) VALUES (3, N'drsf sd', 0, 1, 1)
INSERT [dbo].[Meta] ([IdMeta], [Descripcion], [Estado], [Escala], [Salario]) VALUES (4, N'Primera meta ojala sirva hdsptm', 1, 1006, 1)
INSERT [dbo].[Meta] ([IdMeta], [Descripcion], [Estado], [Escala], [Salario]) VALUES (5, N'Meta numero 2', 1, 1, 3)
SET IDENTITY_INSERT [dbo].[Meta] OFF
SET IDENTITY_INSERT [dbo].[MetaCDP] ON 

INSERT [dbo].[MetaCDP] ([IdMetaCDP], [Metacdp], [ValorIDP], [Meta]) VALUES (1, CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), 1)
INSERT [dbo].[MetaCDP] ([IdMetaCDP], [Metacdp], [ValorIDP], [Meta]) VALUES (2, CAST(300000000.00 AS Decimal(18, 2)), CAST(20.00 AS Decimal(18, 2)), 4)
INSERT [dbo].[MetaCDP] ([IdMetaCDP], [Metacdp], [ValorIDP], [Meta]) VALUES (3, CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), 5)
SET IDENTITY_INSERT [dbo].[MetaCDP] OFF
SET IDENTITY_INSERT [dbo].[MetaCredito] ON 

INSERT [dbo].[MetaCredito] ([IdMetaCredito], [MetaColocacion], [ValorIDP], [Meta]) VALUES (1, CAST(130000000.00 AS Decimal(18, 2)), CAST(70.00 AS Decimal(18, 2)), 1)
INSERT [dbo].[MetaCredito] ([IdMetaCredito], [MetaColocacion], [ValorIDP], [Meta]) VALUES (2, CAST(200000000.00 AS Decimal(18, 2)), CAST(60.00 AS Decimal(18, 2)), 4)
INSERT [dbo].[MetaCredito] ([IdMetaCredito], [MetaColocacion], [ValorIDP], [Meta]) VALUES (3, CAST(230000.00 AS Decimal(18, 2)), CAST(70.00 AS Decimal(18, 2)), 5)
SET IDENTITY_INSERT [dbo].[MetaCredito] OFF
SET IDENTITY_INSERT [dbo].[MetaTipoProducto] ON 

INSERT [dbo].[MetaTipoProducto] ([IdMetaTipoProducto], [MetaCantidad], [ValorIDP], [Meta]) VALUES (1, 16, CAST(20.00 AS Decimal(18, 2)), 1)
INSERT [dbo].[MetaTipoProducto] ([IdMetaTipoProducto], [MetaCantidad], [ValorIDP], [Meta]) VALUES (2, 8, CAST(10.00 AS Decimal(18, 2)), 1)
INSERT [dbo].[MetaTipoProducto] ([IdMetaTipoProducto], [MetaCantidad], [ValorIDP], [Meta]) VALUES (1002, 20, CAST(15.00 AS Decimal(18, 2)), 4)
INSERT [dbo].[MetaTipoProducto] ([IdMetaTipoProducto], [MetaCantidad], [ValorIDP], [Meta]) VALUES (1003, 10, CAST(5.00 AS Decimal(18, 2)), 4)
INSERT [dbo].[MetaTipoProducto] ([IdMetaTipoProducto], [MetaCantidad], [ValorIDP], [Meta]) VALUES (1004, 10, CAST(5.00 AS Decimal(18, 2)), 5)
INSERT [dbo].[MetaTipoProducto] ([IdMetaTipoProducto], [MetaCantidad], [ValorIDP], [Meta]) VALUES (1005, 8, CAST(5.00 AS Decimal(18, 2)), 5)
INSERT [dbo].[MetaTipoProducto] ([IdMetaTipoProducto], [MetaCantidad], [ValorIDP], [Meta]) VALUES (1006, 15, CAST(10.00 AS Decimal(18, 2)), 5)
INSERT [dbo].[MetaTipoProducto] ([IdMetaTipoProducto], [MetaCantidad], [ValorIDP], [Meta]) VALUES (1007, 6, CAST(10.00 AS Decimal(18, 2)), 5)
SET IDENTITY_INSERT [dbo].[MetaTipoProducto] OFF
INSERT [dbo].[MetaTipoProductoDetalle] ([MetaTipoProducto], [TipoProducto]) VALUES (1, 3)
INSERT [dbo].[MetaTipoProductoDetalle] ([MetaTipoProducto], [TipoProducto]) VALUES (1, 5)
INSERT [dbo].[MetaTipoProductoDetalle] ([MetaTipoProducto], [TipoProducto]) VALUES (2, 1)
INSERT [dbo].[MetaTipoProductoDetalle] ([MetaTipoProducto], [TipoProducto]) VALUES (1002, 2)
INSERT [dbo].[MetaTipoProductoDetalle] ([MetaTipoProducto], [TipoProducto]) VALUES (1002, 3)
INSERT [dbo].[MetaTipoProductoDetalle] ([MetaTipoProducto], [TipoProducto]) VALUES (1003, 1)
INSERT [dbo].[MetaTipoProductoDetalle] ([MetaTipoProducto], [TipoProducto]) VALUES (1004, 1)
INSERT [dbo].[MetaTipoProductoDetalle] ([MetaTipoProducto], [TipoProducto]) VALUES (1005, 3)
INSERT [dbo].[MetaTipoProductoDetalle] ([MetaTipoProducto], [TipoProducto]) VALUES (1005, 4)
INSERT [dbo].[MetaTipoProductoDetalle] ([MetaTipoProducto], [TipoProducto]) VALUES (1006, 1022)
INSERT [dbo].[MetaTipoProductoDetalle] ([MetaTipoProducto], [TipoProducto]) VALUES (1007, 2)
INSERT [dbo].[MetaTipoProductoDetalle] ([MetaTipoProducto], [TipoProducto]) VALUES (1007, 5)
SET IDENTITY_INSERT [dbo].[Producto] ON 

INSERT [dbo].[Producto] ([IdProducto], [Nombre], [Comision], [Estado], [TipoProducto]) VALUES (1, N'Tarjeta Black', CAST(25.00 AS Decimal(18, 2)), 1, 1)
INSERT [dbo].[Producto] ([IdProducto], [Nombre], [Comision], [Estado], [TipoProducto]) VALUES (2, N'Afiliacion', CAST(7000.00 AS Decimal(18, 2)), 1, 3)
INSERT [dbo].[Producto] ([IdProducto], [Nombre], [Comision], [Estado], [TipoProducto]) VALUES (3, N'Tarjeta Gold', CAST(15.00 AS Decimal(18, 2)), 1, 1)
INSERT [dbo].[Producto] ([IdProducto], [Nombre], [Comision], [Estado], [TipoProducto]) VALUES (4, N'Tu Salud', CAST(14000.00 AS Decimal(18, 2)), 1, 2)
INSERT [dbo].[Producto] ([IdProducto], [Nombre], [Comision], [Estado], [TipoProducto]) VALUES (6, N'T Dental', CAST(6000.00 AS Decimal(18, 2)), 1, 2)
INSERT [dbo].[Producto] ([IdProducto], [Nombre], [Comision], [Estado], [TipoProducto]) VALUES (7, N'T Familiar', CAST(3000.00 AS Decimal(18, 2)), 1, 2)
INSERT [dbo].[Producto] ([IdProducto], [Nombre], [Comision], [Estado], [TipoProducto]) VALUES (8, N'Ahorro', CAST(4000.00 AS Decimal(18, 2)), 1, 5)
INSERT [dbo].[Producto] ([IdProducto], [Nombre], [Comision], [Estado], [TipoProducto]) VALUES (9, N'Prueba', CAST(20.00 AS Decimal(18, 2)), 0, 1)
INSERT [dbo].[Producto] ([IdProducto], [Nombre], [Comision], [Estado], [TipoProducto]) VALUES (10, N'dfg', CAST(34.00 AS Decimal(18, 2)), 0, 1)
INSERT [dbo].[Producto] ([IdProducto], [Nombre], [Comision], [Estado], [TipoProducto]) VALUES (1010, N'sd', CAST(3.00 AS Decimal(18, 2)), 0, 4)
INSERT [dbo].[Producto] ([IdProducto], [Nombre], [Comision], [Estado], [TipoProducto]) VALUES (1011, N'Producto de Prueba', CAST(20000.00 AS Decimal(18, 2)), 1, 1022)
SET IDENTITY_INSERT [dbo].[Producto] OFF
SET IDENTITY_INSERT [dbo].[Salario] ON 

INSERT [dbo].[Salario] ([IdSalario], [Base], [Descripcion], [Estado], [MesesInicio], [SalarioInicio], [BonoInicio]) VALUES (1, CAST(400000.00 AS Decimal(18, 2)), N'Salario de prueba', 1, 3, CAST(250000.00 AS Decimal(18, 2)), CAST(75000.00 AS Decimal(18, 2)))
INSERT [dbo].[Salario] ([IdSalario], [Base], [Descripcion], [Estado], [MesesInicio], [SalarioInicio], [BonoInicio]) VALUES (2, CAST(550000.00 AS Decimal(18, 2)), N'Salario Numero 2', 0, 3, CAST(300000.00 AS Decimal(18, 2)), CAST(50000.00 AS Decimal(18, 2)))
INSERT [dbo].[Salario] ([IdSalario], [Base], [Descripcion], [Estado], [MesesInicio], [SalarioInicio], [BonoInicio]) VALUES (3, CAST(600.00 AS Decimal(18, 2)), N'jkhg', 1, 20, CAST(20.00 AS Decimal(18, 2)), CAST(20.00 AS Decimal(18, 2)))
SET IDENTITY_INSERT [dbo].[Salario] OFF
SET IDENTITY_INSERT [dbo].[TipoCambio] ON 

INSERT [dbo].[TipoCambio] ([IdTipoCambio], [Valor], [Fecha], [Estado]) VALUES (2, CAST(575.00 AS Decimal(18, 2)), CAST(N'2018-07-01' AS Date), 1)
INSERT [dbo].[TipoCambio] ([IdTipoCambio], [Valor], [Fecha], [Estado]) VALUES (5, CAST(570.00 AS Decimal(18, 2)), CAST(N'2018-08-01' AS Date), 1)
INSERT [dbo].[TipoCambio] ([IdTipoCambio], [Valor], [Fecha], [Estado]) VALUES (1002, CAST(595.00 AS Decimal(18, 2)), CAST(N'2018-10-01' AS Date), 1)
INSERT [dbo].[TipoCambio] ([IdTipoCambio], [Valor], [Fecha], [Estado]) VALUES (1003, CAST(610.00 AS Decimal(18, 2)), CAST(N'2018-11-01' AS Date), 0)
INSERT [dbo].[TipoCambio] ([IdTipoCambio], [Valor], [Fecha], [Estado]) VALUES (1004, CAST(700.00 AS Decimal(18, 2)), CAST(N'2018-01-01' AS Date), 0)
INSERT [dbo].[TipoCambio] ([IdTipoCambio], [Valor], [Fecha], [Estado]) VALUES (1005, CAST(510.00 AS Decimal(18, 2)), CAST(N'2018-01-01' AS Date), 1)
INSERT [dbo].[TipoCambio] ([IdTipoCambio], [Valor], [Fecha], [Estado]) VALUES (1006, CAST(650.00 AS Decimal(18, 2)), CAST(N'2018-11-01' AS Date), 1)
INSERT [dbo].[TipoCambio] ([IdTipoCambio], [Valor], [Fecha], [Estado]) VALUES (1007, CAST(543.00 AS Decimal(18, 2)), CAST(N'2018-09-01' AS Date), 1)
INSERT [dbo].[TipoCambio] ([IdTipoCambio], [Valor], [Fecha], [Estado]) VALUES (1009, CAST(620.00 AS Decimal(18, 2)), CAST(N'2018-12-01' AS Date), 1)
SET IDENTITY_INSERT [dbo].[TipoCambio] OFF
SET IDENTITY_INSERT [dbo].[TipoCDP] ON 

INSERT [dbo].[TipoCDP] ([IdTipoCDP], [Nombre], [Moneda], [ComisionMaxima], [Estado], [IDPNecesario], [PCTComision]) VALUES (1002, N'Cdp prueba 1', N'c', CAST(2000.00 AS Decimal(18, 2)), 1, CAST(2.00 AS Decimal(18, 2)), CAST(0.15 AS Decimal(18, 2)))
INSERT [dbo].[TipoCDP] ([IdTipoCDP], [Nombre], [Moneda], [ComisionMaxima], [Estado], [IDPNecesario], [PCTComision]) VALUES (1003, N'cdpprueba 2', N'd', CAST(5000.00 AS Decimal(18, 2)), 1, CAST(0.00 AS Decimal(18, 2)), CAST(0.20 AS Decimal(18, 2)))
INSERT [dbo].[TipoCDP] ([IdTipoCDP], [Nombre], [Moneda], [ComisionMaxima], [Estado], [IDPNecesario], [PCTComision]) VALUES (1005, N'Tipo CDP de Ejemplo', N'd', CAST(300000.00 AS Decimal(18, 2)), 1, CAST(0.30 AS Decimal(18, 2)), CAST(0.10 AS Decimal(18, 2)))
INSERT [dbo].[TipoCDP] ([IdTipoCDP], [Nombre], [Moneda], [ComisionMaxima], [Estado], [IDPNecesario], [PCTComision]) VALUES (1006, N'CDP Juridirca', N'c', CAST(5000000.00 AS Decimal(18, 2)), 1, CAST(60.00 AS Decimal(18, 2)), CAST(0.20 AS Decimal(18, 2)))
SET IDENTITY_INSERT [dbo].[TipoCDP] OFF
SET IDENTITY_INSERT [dbo].[TipoCredito] ON 

INSERT [dbo].[TipoCredito] ([IdTipoCredito], [Nombre], [ComisionDistinta], [MaximoComision], [SumaIDP], [Estado]) VALUES (1, N'Credi Activo', NULL, NULL, 1, 1)
INSERT [dbo].[TipoCredito] ([IdTipoCredito], [Nombre], [ComisionDistinta], [MaximoComision], [SumaIDP], [Estado]) VALUES (2, N'Credi Aguinaldo', NULL, NULL, 1, 1)
INSERT [dbo].[TipoCredito] ([IdTipoCredito], [Nombre], [ComisionDistinta], [MaximoComision], [SumaIDP], [Estado]) VALUES (3, N'Credicombo', NULL, NULL, 1, 0)
INSERT [dbo].[TipoCredito] ([IdTipoCredito], [Nombre], [ComisionDistinta], [MaximoComision], [SumaIDP], [Estado]) VALUES (4, N'Credinae', NULL, NULL, 1, 1)
INSERT [dbo].[TipoCredito] ([IdTipoCredito], [Nombre], [ComisionDistinta], [MaximoComision], [SumaIDP], [Estado]) VALUES (5, N'Crediauto', CAST(0.40 AS Decimal(18, 2)), NULL, 1, 1)
INSERT [dbo].[TipoCredito] ([IdTipoCredito], [Nombre], [ComisionDistinta], [MaximoComision], [SumaIDP], [Estado]) VALUES (6, N'Vivienda', CAST(0.50 AS Decimal(18, 2)), CAST(250000.00 AS Decimal(18, 2)), 0, 1)
INSERT [dbo].[TipoCredito] ([IdTipoCredito], [Nombre], [ComisionDistinta], [MaximoComision], [SumaIDP], [Estado]) VALUES (7, N'Otro', NULL, NULL, 1, 0)
INSERT [dbo].[TipoCredito] ([IdTipoCredito], [Nombre], [ComisionDistinta], [MaximoComision], [SumaIDP], [Estado]) VALUES (8, N'iu', CAST(3.00 AS Decimal(18, 2)), NULL, 0, 0)
INSERT [dbo].[TipoCredito] ([IdTipoCredito], [Nombre], [ComisionDistinta], [MaximoComision], [SumaIDP], [Estado]) VALUES (9, N'Credicredi', CAST(0.23 AS Decimal(18, 2)), CAST(200000.00 AS Decimal(18, 2)), 1, 0)
INSERT [dbo].[TipoCredito] ([IdTipoCredito], [Nombre], [ComisionDistinta], [MaximoComision], [SumaIDP], [Estado]) VALUES (10, N'dfg', CAST(2.00 AS Decimal(18, 2)), CAST(2.00 AS Decimal(18, 2)), 0, 0)
INSERT [dbo].[TipoCredito] ([IdTipoCredito], [Nombre], [ComisionDistinta], [MaximoComision], [SumaIDP], [Estado]) VALUES (11, N'ew', CAST(3.00 AS Decimal(18, 2)), CAST(3.00 AS Decimal(18, 2)), 0, 0)
INSERT [dbo].[TipoCredito] ([IdTipoCredito], [Nombre], [ComisionDistinta], [MaximoComision], [SumaIDP], [Estado]) VALUES (12, N'df', CAST(3.00 AS Decimal(18, 2)), CAST(3.00 AS Decimal(18, 2)), 1, 0)
INSERT [dbo].[TipoCredito] ([IdTipoCredito], [Nombre], [ComisionDistinta], [MaximoComision], [SumaIDP], [Estado]) VALUES (13, N'df', CAST(3.00 AS Decimal(18, 2)), CAST(3.00 AS Decimal(18, 2)), 1, 0)
INSERT [dbo].[TipoCredito] ([IdTipoCredito], [Nombre], [ComisionDistinta], [MaximoComision], [SumaIDP], [Estado]) VALUES (14, N'df', CAST(3.00 AS Decimal(18, 2)), CAST(3.00 AS Decimal(18, 2)), 1, 0)
INSERT [dbo].[TipoCredito] ([IdTipoCredito], [Nombre], [ComisionDistinta], [MaximoComision], [SumaIDP], [Estado]) VALUES (15, N'Credito de prueba', NULL, NULL, 1, 0)
INSERT [dbo].[TipoCredito] ([IdTipoCredito], [Nombre], [ComisionDistinta], [MaximoComision], [SumaIDP], [Estado]) VALUES (16, N'Credito de Prueba', CAST(0.50 AS Decimal(18, 2)), NULL, 0, 1)
SET IDENTITY_INSERT [dbo].[TipoCredito] OFF
SET IDENTITY_INSERT [dbo].[TipoProducto] ON 

INSERT [dbo].[TipoProducto] ([IdTipoProducto], [Descripcion], [Moneda], [Estado], [IDPNecesario]) VALUES (1, N'Tarjetas de Credito', N'd', 1, CAST(60.00 AS Decimal(18, 2)))
INSERT [dbo].[TipoProducto] ([IdTipoProducto], [Descripcion], [Moneda], [Estado], [IDPNecesario]) VALUES (2, N'T-Complementa', N'c', 1, CAST(40.00 AS Decimal(18, 2)))
INSERT [dbo].[TipoProducto] ([IdTipoProducto], [Descripcion], [Moneda], [Estado], [IDPNecesario]) VALUES (3, N'Afiliaciones', N'c', 1, CAST(0.00 AS Decimal(18, 2)))
INSERT [dbo].[TipoProducto] ([IdTipoProducto], [Descripcion], [Moneda], [Estado], [IDPNecesario]) VALUES (4, N'Tarjeta Debito', N'c', 1, CAST(0.00 AS Decimal(18, 2)))
INSERT [dbo].[TipoProducto] ([IdTipoProducto], [Descripcion], [Moneda], [Estado], [IDPNecesario]) VALUES (5, N'Ahorro Giro', N'c', 0, CAST(0.00 AS Decimal(18, 2)))
INSERT [dbo].[TipoProducto] ([IdTipoProducto], [Descripcion], [Moneda], [Estado], [IDPNecesario]) VALUES (1008, N'asd', N'd', 0, CAST(12.00 AS Decimal(18, 2)))
INSERT [dbo].[TipoProducto] ([IdTipoProducto], [Descripcion], [Moneda], [Estado], [IDPNecesario]) VALUES (1010, N'sd', N'd', 0, CAST(4.00 AS Decimal(18, 2)))
INSERT [dbo].[TipoProducto] ([IdTipoProducto], [Descripcion], [Moneda], [Estado], [IDPNecesario]) VALUES (1017, N'sf', N'd', 0, CAST(3.00 AS Decimal(18, 2)))
INSERT [dbo].[TipoProducto] ([IdTipoProducto], [Descripcion], [Moneda], [Estado], [IDPNecesario]) VALUES (1018, N'4', N'c', 0, CAST(4.00 AS Decimal(18, 2)))
INSERT [dbo].[TipoProducto] ([IdTipoProducto], [Descripcion], [Moneda], [Estado], [IDPNecesario]) VALUES (1019, N'gjhmgjmkghjm', N'c', 0, CAST(40.00 AS Decimal(18, 2)))
INSERT [dbo].[TipoProducto] ([IdTipoProducto], [Descripcion], [Moneda], [Estado], [IDPNecesario]) VALUES (1020, N'87', N'd', 0, CAST(78.00 AS Decimal(18, 2)))
INSERT [dbo].[TipoProducto] ([IdTipoProducto], [Descripcion], [Moneda], [Estado], [IDPNecesario]) VALUES (1021, N'ghj j ', N'c', 0, CAST(7.00 AS Decimal(18, 2)))
INSERT [dbo].[TipoProducto] ([IdTipoProducto], [Descripcion], [Moneda], [Estado], [IDPNecesario]) VALUES (1022, N'Tipo Producto de Prueba', N'c', 1, CAST(40.00 AS Decimal(18, 2)))
SET IDENTITY_INSERT [dbo].[TipoProducto] OFF
SET IDENTITY_INSERT [dbo].[UnidadNegocio] ON 

INSERT [dbo].[UnidadNegocio] ([IdUnidad], [Nombre], [Estado], [Meta]) VALUES (1, N'Unidad de prueba', 1, 1)
INSERT [dbo].[UnidadNegocio] ([IdUnidad], [Nombre], [Estado], [Meta]) VALUES (2, N'dkm', 0, 1)
INSERT [dbo].[UnidadNegocio] ([IdUnidad], [Nombre], [Estado], [Meta]) VALUES (3, N'Sucursal Tibas', 1, 4)
SET IDENTITY_INSERT [dbo].[UnidadNegocio] OFF
SET IDENTITY_INSERT [dbo].[VentaCDP] ON 

INSERT [dbo].[VentaCDP] ([IdVentaCDP], [Ejecutivo], [Fecha], [Cedula], [Nombre], [CentroTrabajo], [Monto], [PlazoMeses], [Periocidad], [Tasa], [SobreTasa], [Estado], [TipoCDP]) VALUES (2, 6, CAST(N'2018-10-12T00:00:00.000' AS DateTime), 1, N'a', N'a', CAST(2000000.00 AS Decimal(18, 2)), 6, 12, CAST(8.00 AS Decimal(18, 2)), CAST(2.00 AS Decimal(18, 2)), 1, 1002)
INSERT [dbo].[VentaCDP] ([IdVentaCDP], [Ejecutivo], [Fecha], [Cedula], [Nombre], [CentroTrabajo], [Monto], [PlazoMeses], [Periocidad], [Tasa], [SobreTasa], [Estado], [TipoCDP]) VALUES (4, 6, CAST(N'2018-10-16T00:00:00.000' AS DateTime), 2, N'B', N'b', CAST(3000.00 AS Decimal(18, 2)), 9, 6, CAST(5.00 AS Decimal(18, 2)), CAST(7.00 AS Decimal(18, 2)), 1, 1003)
INSERT [dbo].[VentaCDP] ([IdVentaCDP], [Ejecutivo], [Fecha], [Cedula], [Nombre], [CentroTrabajo], [Monto], [PlazoMeses], [Periocidad], [Tasa], [SobreTasa], [Estado], [TipoCDP]) VALUES (6, 116900078, CAST(N'2018-11-16T00:00:00.000' AS DateTime), 2, N'B', N'b', CAST(20000.00 AS Decimal(18, 2)), 9, 6, CAST(5.00 AS Decimal(18, 2)), CAST(7.00 AS Decimal(18, 2)), 1, 1003)
INSERT [dbo].[VentaCDP] ([IdVentaCDP], [Ejecutivo], [Fecha], [Cedula], [Nombre], [CentroTrabajo], [Monto], [PlazoMeses], [Periocidad], [Tasa], [SobreTasa], [Estado], [TipoCDP]) VALUES (7, 116900078, CAST(N'2018-11-12T00:00:00.000' AS DateTime), 1, N'a', N'a', CAST(2000000.00 AS Decimal(18, 2)), 6, 12, CAST(8.00 AS Decimal(18, 2)), CAST(2.00 AS Decimal(18, 2)), 1, 1002)
SET IDENTITY_INSERT [dbo].[VentaCDP] OFF
SET IDENTITY_INSERT [dbo].[VentaCredito] ON 

INSERT [dbo].[VentaCredito] ([IdVentaCredito], [Ejecutivo], [Fecha], [Cedula], [Nombre], [CentroTrabajo], [FechaAfiliacion], [NumeroOperacion], [Monto], [PlazoMeses], [Estado], [TipoCredito]) VALUES (3, 6, CAST(N'2018-10-08T00:00:00.000' AS DateTime), 1, N'A', N'A', CAST(N'2012-12-12' AS Date), 0, CAST(20000000.00 AS Decimal(18, 2)), 12, 1, 1)
INSERT [dbo].[VentaCredito] ([IdVentaCredito], [Ejecutivo], [Fecha], [Cedula], [Nombre], [CentroTrabajo], [FechaAfiliacion], [NumeroOperacion], [Monto], [PlazoMeses], [Estado], [TipoCredito]) VALUES (4, 6, CAST(N'2018-10-09T00:00:00.000' AS DateTime), 2, N'B', N'B', CAST(N'2012-12-12' AS Date), 0, CAST(30000000.00 AS Decimal(18, 2)), 12, 1, 2)
INSERT [dbo].[VentaCredito] ([IdVentaCredito], [Ejecutivo], [Fecha], [Cedula], [Nombre], [CentroTrabajo], [FechaAfiliacion], [NumeroOperacion], [Monto], [PlazoMeses], [Estado], [TipoCredito]) VALUES (5, 6, CAST(N'2018-10-10T00:00:00.000' AS DateTime), 3, N'C', N'C', CAST(N'2012-12-12' AS Date), 0, CAST(4000000.00 AS Decimal(18, 2)), 12, 1, 3)
INSERT [dbo].[VentaCredito] ([IdVentaCredito], [Ejecutivo], [Fecha], [Cedula], [Nombre], [CentroTrabajo], [FechaAfiliacion], [NumeroOperacion], [Monto], [PlazoMeses], [Estado], [TipoCredito]) VALUES (6, 6, CAST(N'2018-10-11T00:00:00.000' AS DateTime), 18, N'D', N'D', CAST(N'2012-12-12' AS Date), 0, CAST(50000000.00 AS Decimal(18, 2)), 12, 1, 4)
INSERT [dbo].[VentaCredito] ([IdVentaCredito], [Ejecutivo], [Fecha], [Cedula], [Nombre], [CentroTrabajo], [FechaAfiliacion], [NumeroOperacion], [Monto], [PlazoMeses], [Estado], [TipoCredito]) VALUES (7, 6, CAST(N'2018-10-08T00:00:00.000' AS DateTime), 4, N'E', N'E', CAST(N'2012-12-12' AS Date), 0, CAST(20000000.00 AS Decimal(18, 2)), 12, 1, 6)
INSERT [dbo].[VentaCredito] ([IdVentaCredito], [Ejecutivo], [Fecha], [Cedula], [Nombre], [CentroTrabajo], [FechaAfiliacion], [NumeroOperacion], [Monto], [PlazoMeses], [Estado], [TipoCredito]) VALUES (12, 6, CAST(N'2018-10-12T00:00:00.000' AS DateTime), 0, N'0', N'0', CAST(N'2012-12-12' AS Date), 0, CAST(30000000.00 AS Decimal(18, 2)), 3, 1, 2)
INSERT [dbo].[VentaCredito] ([IdVentaCredito], [Ejecutivo], [Fecha], [Cedula], [Nombre], [CentroTrabajo], [FechaAfiliacion], [NumeroOperacion], [Monto], [PlazoMeses], [Estado], [TipoCredito]) VALUES (13, 6, CAST(N'2018-09-01T00:00:00.000' AS DateTime), 4564564, N'ligbh', N'hbl', CAST(N'2001-01-01' AS Date), 456, CAST(200000.00 AS Decimal(18, 2)), 20, 1, 2)
INSERT [dbo].[VentaCredito] ([IdVentaCredito], [Ejecutivo], [Fecha], [Cedula], [Nombre], [CentroTrabajo], [FechaAfiliacion], [NumeroOperacion], [Monto], [PlazoMeses], [Estado], [TipoCredito]) VALUES (14, 116900078, CAST(N'2018-11-08T00:00:00.000' AS DateTime), 1, N'A', N'A', CAST(N'2012-12-12' AS Date), 0, CAST(20000000.00 AS Decimal(18, 2)), 12, 1, 1)
INSERT [dbo].[VentaCredito] ([IdVentaCredito], [Ejecutivo], [Fecha], [Cedula], [Nombre], [CentroTrabajo], [FechaAfiliacion], [NumeroOperacion], [Monto], [PlazoMeses], [Estado], [TipoCredito]) VALUES (15, 116900078, CAST(N'2018-11-09T00:00:00.000' AS DateTime), 2, N'B', N'B', CAST(N'2012-12-12' AS Date), 0, CAST(30000000.00 AS Decimal(18, 2)), 12, 1, 2)
INSERT [dbo].[VentaCredito] ([IdVentaCredito], [Ejecutivo], [Fecha], [Cedula], [Nombre], [CentroTrabajo], [FechaAfiliacion], [NumeroOperacion], [Monto], [PlazoMeses], [Estado], [TipoCredito]) VALUES (16, 116900078, CAST(N'2018-11-10T00:00:00.000' AS DateTime), 3, N'C', N'C', CAST(N'2012-12-12' AS Date), 0, CAST(40000000.00 AS Decimal(18, 2)), 12, 1, 3)
INSERT [dbo].[VentaCredito] ([IdVentaCredito], [Ejecutivo], [Fecha], [Cedula], [Nombre], [CentroTrabajo], [FechaAfiliacion], [NumeroOperacion], [Monto], [PlazoMeses], [Estado], [TipoCredito]) VALUES (17, 116900078, CAST(N'2018-11-11T00:00:00.000' AS DateTime), 18, N'D', N'D', CAST(N'2012-12-12' AS Date), 0, CAST(5000000.00 AS Decimal(18, 2)), 12, 1, 4)
INSERT [dbo].[VentaCredito] ([IdVentaCredito], [Ejecutivo], [Fecha], [Cedula], [Nombre], [CentroTrabajo], [FechaAfiliacion], [NumeroOperacion], [Monto], [PlazoMeses], [Estado], [TipoCredito]) VALUES (18, 116900078, CAST(N'2018-11-08T00:00:00.000' AS DateTime), 4, N'E', N'E', CAST(N'2012-12-12' AS Date), 0, CAST(20000000.00 AS Decimal(18, 2)), 12, 1, 6)
INSERT [dbo].[VentaCredito] ([IdVentaCredito], [Ejecutivo], [Fecha], [Cedula], [Nombre], [CentroTrabajo], [FechaAfiliacion], [NumeroOperacion], [Monto], [PlazoMeses], [Estado], [TipoCredito]) VALUES (19, 116900078, CAST(N'2018-11-12T00:00:00.000' AS DateTime), 0, N'0', N'0', CAST(N'2012-12-12' AS Date), 0, CAST(3000000.00 AS Decimal(18, 2)), 3, 1, 2)
SET IDENTITY_INSERT [dbo].[VentaCredito] OFF
SET IDENTITY_INSERT [dbo].[VentaProducto] ON 

INSERT [dbo].[VentaProducto] ([IdVentaProducto], [Ejecutivo], [Fecha], [Cedula], [Nombre], [CentroTrabajo], [Producto], [Estado]) VALUES (1, 6, CAST(N'2018-10-21T00:00:00.000' AS DateTime), 65, N'123', N'we', 1, 1)
INSERT [dbo].[VentaProducto] ([IdVentaProducto], [Ejecutivo], [Fecha], [Cedula], [Nombre], [CentroTrabajo], [Producto], [Estado]) VALUES (2, 6, CAST(N'2018-10-21T00:00:00.000' AS DateTime), 65, N'321', N'ew', 3, 1)
INSERT [dbo].[VentaProducto] ([IdVentaProducto], [Ejecutivo], [Fecha], [Cedula], [Nombre], [CentroTrabajo], [Producto], [Estado]) VALUES (3, 6, CAST(N'2018-10-21T00:00:00.000' AS DateTime), 654, N'wew', N'wedc', 8, 1)
INSERT [dbo].[VentaProducto] ([IdVentaProducto], [Ejecutivo], [Fecha], [Cedula], [Nombre], [CentroTrabajo], [Producto], [Estado]) VALUES (4, 6, CAST(N'2018-10-21T00:00:00.000' AS DateTime), 654845, N'as fe', N'fwef', 3, 1)
INSERT [dbo].[VentaProducto] ([IdVentaProducto], [Ejecutivo], [Fecha], [Cedula], [Nombre], [CentroTrabajo], [Producto], [Estado]) VALUES (5, 6, CAST(N'2018-10-21T00:00:00.000' AS DateTime), 55601, N'asda', N'ada asd', 2, 1)
INSERT [dbo].[VentaProducto] ([IdVentaProducto], [Ejecutivo], [Fecha], [Cedula], [Nombre], [CentroTrabajo], [Producto], [Estado]) VALUES (1003, 6, CAST(N'2018-10-12T00:00:00.000' AS DateTime), 1, N'1', N'1', 7, 1)
INSERT [dbo].[VentaProducto] ([IdVentaProducto], [Ejecutivo], [Fecha], [Cedula], [Nombre], [CentroTrabajo], [Producto], [Estado]) VALUES (1007, 116900078, CAST(N'2018-11-21T00:00:00.000' AS DateTime), 65, N'123', N'we', 1, 1)
INSERT [dbo].[VentaProducto] ([IdVentaProducto], [Ejecutivo], [Fecha], [Cedula], [Nombre], [CentroTrabajo], [Producto], [Estado]) VALUES (1008, 116900078, CAST(N'2018-11-21T00:00:00.000' AS DateTime), 65, N'321', N'ew', 3, 1)
INSERT [dbo].[VentaProducto] ([IdVentaProducto], [Ejecutivo], [Fecha], [Cedula], [Nombre], [CentroTrabajo], [Producto], [Estado]) VALUES (1009, 116900078, CAST(N'2018-11-21T00:00:00.000' AS DateTime), 654, N'wew', N'wedc', 8, 1)
INSERT [dbo].[VentaProducto] ([IdVentaProducto], [Ejecutivo], [Fecha], [Cedula], [Nombre], [CentroTrabajo], [Producto], [Estado]) VALUES (1010, 116900078, CAST(N'2018-11-21T00:00:00.000' AS DateTime), 654845, N'as fe', N'fwef', 3, 1)
INSERT [dbo].[VentaProducto] ([IdVentaProducto], [Ejecutivo], [Fecha], [Cedula], [Nombre], [CentroTrabajo], [Producto], [Estado]) VALUES (1011, 116900078, CAST(N'2018-11-21T00:00:00.000' AS DateTime), 55601, N'asda', N'ada asd', 2, 1)
INSERT [dbo].[VentaProducto] ([IdVentaProducto], [Ejecutivo], [Fecha], [Cedula], [Nombre], [CentroTrabajo], [Producto], [Estado]) VALUES (1012, 116900078, CAST(N'2018-11-12T00:00:00.000' AS DateTime), 1, N'1', N'1', 7, 1)
SET IDENTITY_INSERT [dbo].[VentaProducto] OFF
ALTER TABLE [dbo].[DetalleEscala]  WITH CHECK ADD  CONSTRAINT [FK_DetalleEscala_Escala] FOREIGN KEY([Escala])
REFERENCES [dbo].[Escala] ([IdEscala])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[DetalleEscala] CHECK CONSTRAINT [FK_DetalleEscala_Escala]
GO
ALTER TABLE [dbo].[Ejecutivo]  WITH CHECK ADD  CONSTRAINT [FK_Vendedor_UnidadNegocio] FOREIGN KEY([UnidadNegocio])
REFERENCES [dbo].[UnidadNegocio] ([IdUnidad])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[Ejecutivo] CHECK CONSTRAINT [FK_Vendedor_UnidadNegocio]
GO
ALTER TABLE [dbo].[Meta]  WITH CHECK ADD  CONSTRAINT [FK_Meta_Escala] FOREIGN KEY([Escala])
REFERENCES [dbo].[Escala] ([IdEscala])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[Meta] CHECK CONSTRAINT [FK_Meta_Escala]
GO
ALTER TABLE [dbo].[Meta]  WITH CHECK ADD  CONSTRAINT [FK_Meta_Salario] FOREIGN KEY([Salario])
REFERENCES [dbo].[Salario] ([IdSalario])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[Meta] CHECK CONSTRAINT [FK_Meta_Salario]
GO
ALTER TABLE [dbo].[MetaCDP]  WITH CHECK ADD  CONSTRAINT [FK_MetaCDP_Meta1] FOREIGN KEY([Meta])
REFERENCES [dbo].[Meta] ([IdMeta])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[MetaCDP] CHECK CONSTRAINT [FK_MetaCDP_Meta1]
GO
ALTER TABLE [dbo].[MetaCredito]  WITH CHECK ADD  CONSTRAINT [FK_MetaCredito_Meta1] FOREIGN KEY([Meta])
REFERENCES [dbo].[Meta] ([IdMeta])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[MetaCredito] CHECK CONSTRAINT [FK_MetaCredito_Meta1]
GO
ALTER TABLE [dbo].[MetaTipoProducto]  WITH CHECK ADD  CONSTRAINT [FK_MetaTipoProducto_Meta] FOREIGN KEY([Meta])
REFERENCES [dbo].[Meta] ([IdMeta])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[MetaTipoProducto] CHECK CONSTRAINT [FK_MetaTipoProducto_Meta]
GO
ALTER TABLE [dbo].[MetaTipoProductoDetalle]  WITH CHECK ADD  CONSTRAINT [FK_MetaProductoDetalle_MetaTipoProducto] FOREIGN KEY([MetaTipoProducto])
REFERENCES [dbo].[MetaTipoProducto] ([IdMetaTipoProducto])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[MetaTipoProductoDetalle] CHECK CONSTRAINT [FK_MetaProductoDetalle_MetaTipoProducto]
GO
ALTER TABLE [dbo].[MetaTipoProductoDetalle]  WITH CHECK ADD  CONSTRAINT [FK_MetaProductoDetalle_TipoProducto] FOREIGN KEY([TipoProducto])
REFERENCES [dbo].[TipoProducto] ([IdTipoProducto])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[MetaTipoProductoDetalle] CHECK CONSTRAINT [FK_MetaProductoDetalle_TipoProducto]
GO
ALTER TABLE [dbo].[Producto]  WITH CHECK ADD  CONSTRAINT [FK_Producto_TipoProducto] FOREIGN KEY([TipoProducto])
REFERENCES [dbo].[TipoProducto] ([IdTipoProducto])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[Producto] CHECK CONSTRAINT [FK_Producto_TipoProducto]
GO
ALTER TABLE [dbo].[UnidadNegocio]  WITH CHECK ADD  CONSTRAINT [FK_UnidadNegocio_Meta] FOREIGN KEY([Meta])
REFERENCES [dbo].[Meta] ([IdMeta])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[UnidadNegocio] CHECK CONSTRAINT [FK_UnidadNegocio_Meta]
GO
ALTER TABLE [dbo].[VentaCDP]  WITH CHECK ADD  CONSTRAINT [FK_VentaCDP_TipoCDP] FOREIGN KEY([TipoCDP])
REFERENCES [dbo].[TipoCDP] ([IdTipoCDP])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[VentaCDP] CHECK CONSTRAINT [FK_VentaCDP_TipoCDP]
GO
ALTER TABLE [dbo].[VentaCDP]  WITH CHECK ADD  CONSTRAINT [FK_VentaCDP_Vendedor] FOREIGN KEY([Ejecutivo])
REFERENCES [dbo].[Ejecutivo] ([Cedula])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[VentaCDP] CHECK CONSTRAINT [FK_VentaCDP_Vendedor]
GO
ALTER TABLE [dbo].[VentaCredito]  WITH CHECK ADD  CONSTRAINT [FK_VentaCredito_TipoCredito] FOREIGN KEY([TipoCredito])
REFERENCES [dbo].[TipoCredito] ([IdTipoCredito])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[VentaCredito] CHECK CONSTRAINT [FK_VentaCredito_TipoCredito]
GO
ALTER TABLE [dbo].[VentaCredito]  WITH CHECK ADD  CONSTRAINT [FK_VentaCredito_Vendedor] FOREIGN KEY([Ejecutivo])
REFERENCES [dbo].[Ejecutivo] ([Cedula])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[VentaCredito] CHECK CONSTRAINT [FK_VentaCredito_Vendedor]
GO
ALTER TABLE [dbo].[VentaProducto]  WITH CHECK ADD  CONSTRAINT [FK_VentaProducto_Producto] FOREIGN KEY([Producto])
REFERENCES [dbo].[Producto] ([IdProducto])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[VentaProducto] CHECK CONSTRAINT [FK_VentaProducto_Producto]
GO
ALTER TABLE [dbo].[VentaProducto]  WITH CHECK ADD  CONSTRAINT [FK_VentaProducto_Vendedor] FOREIGN KEY([Ejecutivo])
REFERENCES [dbo].[Ejecutivo] ([Cedula])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[VentaProducto] CHECK CONSTRAINT [FK_VentaProducto_Vendedor]
GO