USE [spc_coope]
GO
/****** Object:  Table [dbo].[Afiliaciones]    Script Date: 30/7/2018 17:06:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Afiliaciones](
	[IdAfiliacion] [int] IDENTITY(1,1) NOT NULL,
	[Fecha] [date] NOT NULL,
	[Cedula] [int] NOT NULL,
	[Nombre] [varchar](500) NOT NULL,
	[CentroTrabajo] [varchar](200) NOT NULL,
	[Sucursal] [varchar](150) NOT NULL,
	[FechaAfiliacion] [date] NOT NULL,
	[FechaNacimiento] [date] NOT NULL,
	[Comision] [int] NOT NULL,
	[Ejecutivo] [int] NOT NULL,
	[Estado] [int] NOT NULL,
 CONSTRAINT [PK_Afiliaciones] PRIMARY KEY CLUSTERED 
(
	[IdAfiliacion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Categorias]    Script Date: 30/7/2018 17:06:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Categorias](
	[IdCategoria] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
	[Escala] [int] NOT NULL,
	[Meta] [int] NOT NULL,
	[Estado] [int] NOT NULL,
 CONSTRAINT [PK_Categorias] PRIMARY KEY CLUSTERED 
(
	[IdCategoria] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ColocacionCDP]    Script Date: 30/7/2018 17:06:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ColocacionCDP](
	[IdColocacionCDP] [int] IDENTITY(1,1) NOT NULL,
	[Fecha] [date] NOT NULL,
	[NumeroTitulo] [int] NOT NULL,
	[Cedula] [int] NOT NULL,
	[Nombre] [varchar](500) NOT NULL,
	[CentroTrabajo] [varchar](200) NOT NULL,
	[FechaEmision] [date] NOT NULL,
	[Sucursal] [varchar](100) NOT NULL,
	[Periocidad] [varchar](100) NOT NULL,
	[MontoCDP] [decimal](18, 2) NOT NULL,
	[PlazoMeses] [int] NOT NULL,
	[TasaOtorgada] [decimal](18, 2) NOT NULL,
	[SobreTasa] [decimal](18, 2) NOT NULL,
	[Ejecutivo] [int] NOT NULL,
	[Estado] [int] NOT NULL,
	[TipoCDP] [int] NOT NULL,
 CONSTRAINT [PK_ColocacionCDP] PRIMARY KEY CLUSTERED 
(
	[IdColocacionCDP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ColocacionCredito]    Script Date: 30/7/2018 17:06:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ColocacionCredito](
	[IdColocacionCredito] [int] IDENTITY(1,1) NOT NULL,
	[FechaFormalizacion] [date] NOT NULL,
	[Cedula] [int] NOT NULL,
	[CentroTrabajo] [varchar](100) NOT NULL,
	[Sector] [char](1) NOT NULL,
	[FechaAfiliacion] [date] NOT NULL,
	[NumeroOperacion] [int] NOT NULL,
	[Sucursal] [varchar](100) NOT NULL,
	[MontoDesembolsado] [decimal](18, 2) NOT NULL,
	[PlazoMeses] [nchar](10) NOT NULL,
	[TipoCredito] [int] NOT NULL,
	[Ejecutivo] [int] NOT NULL,
	[Estado] [int] NOT NULL,
 CONSTRAINT [PK_ColocacionCredito] PRIMARY KEY CLUSTERED 
(
	[IdColocacionCredito] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ColocacionProducto]    Script Date: 30/7/2018 17:06:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ColocacionProducto](
	[IdColocacionProducto] [int] IDENTITY(1,1) NOT NULL,
	[Fecha] [date] NOT NULL,
	[Cedula] [int] NOT NULL,
	[Nombre] [varchar](500) NOT NULL,
	[CentroTrabajo] [varchar](200) NOT NULL,
	[Producto] [int] NOT NULL,
	[Ejecutivo] [int] NOT NULL,
	[Estado] [int] NOT NULL,
 CONSTRAINT [PK_ColocacionProducto] PRIMARY KEY CLUSTERED 
(
	[IdColocacionProducto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ComisionAfiliacion]    Script Date: 30/7/2018 17:06:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ComisionAfiliacion](
	[IdComisionAfiliacion] [int] IDENTITY(1,1) NOT NULL,
	[Comision] [decimal](18, 2) NOT NULL,
 CONSTRAINT [PK_ComisionAfiliacion] PRIMARY KEY CLUSTERED 
(
	[IdComisionAfiliacion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Ejecutivos]    Script Date: 30/7/2018 17:06:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ejecutivos](
	[Cedula] [int] NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
	[Apellidos] [varchar](50) NOT NULL,
	[Sexo] [char](1) NOT NULL,
	[Telefono] [varchar](20) NOT NULL,
	[Correo] [varchar](50) NOT NULL,
	[CodigoVendedor] [varchar](50) NOT NULL,
	[Residencia] [varchar](200) NOT NULL,
	[Sucursal] [int] NOT NULL,
	[FechaNacimiento] [date] NOT NULL,
	[FechaContratacion] [date] NOT NULL,
	[Estado] [int] NOT NULL,
	[MetaAparte] [int] NOT NULL,
	[Salario] [int] NOT NULL,
 CONSTRAINT [PK_Ejecutivos] PRIMARY KEY CLUSTERED 
(
	[Cedula] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[EscalaComisionesIDP]    Script Date: 30/7/2018 17:06:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EscalaComisionesIDP](
	[IdEscala] [int] IDENTITY(1,1) NOT NULL,
	[Descripcion] [varchar](100) NOT NULL,
	[Estado] [int] NOT NULL,
	[Menos50] [decimal](18, 2) NOT NULL,
	[Mas51] [decimal](18, 2) NOT NULL,
	[Mas61] [decimal](18, 2) NOT NULL,
	[Mas80] [decimal](18, 2) NOT NULL,
	[Si100] [decimal](18, 2) NOT NULL,
 CONSTRAINT [PK_EscalaComisiones] PRIMARY KEY CLUSTERED 
(
	[IdEscala] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Factura]    Script Date: 30/7/2018 17:06:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Factura](
	[IdFactura] [int] IDENTITY(1,1) NOT NULL,
	[Viaticos] [decimal](18, 2) NULL,
	[Vacaciones] [decimal](18, 2) NULL,
	[Comisiones] [int] NOT NULL,
	[Fecha] [datetime] NULL,
	[Cedula] [int] NULL,
	[NombreEjecutivo] [varchar](50) NULL,
 CONSTRAINT [PK_Factura] PRIMARY KEY CLUSTERED 
(
	[IdFactura] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MetasIDP]    Script Date: 30/7/2018 17:06:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MetasIDP](
	[IdMeta] [int] IDENTITY(1,1) NOT NULL,
	[Creditos] [decimal](18, 2) NOT NULL,
	[OtrosProductos] [int] NOT NULL,
	[TarjetasCredito] [int] NOT NULL,
	[Descripcion] [varchar](200) NOT NULL,
	[Estado] [int] NOT NULL,
	[MinimoComisionarCDP] [decimal](18, 2) NOT NULL,
 CONSTRAINT [PK_Metas] PRIMARY KEY CLUSTERED 
(
	[IdMeta] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Productos]    Script Date: 30/7/2018 17:06:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Productos](
	[IdProducto] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](100) NOT NULL,
	[ComisionGenera] [decimal](18, 2) NOT NULL,
	[EsDolar] [int] NOT NULL,
	[Estado] [int] NOT NULL,
 CONSTRAINT [PK_ProductosColocar] PRIMARY KEY CLUSTERED 
(
	[IdProducto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Salario]    Script Date: 30/7/2018 17:06:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Salario](
	[IdSalario] [int] IDENTITY(1,1) NOT NULL,
	[SalarioBase] [decimal](18, 2) NOT NULL,
	[SalarioInicial] [decimal](18, 2) NOT NULL,
	[MesesSalIni] [int] NOT NULL,
 CONSTRAINT [PK_Salario] PRIMARY KEY CLUSTERED 
(
	[IdSalario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Sucursal]    Script Date: 30/7/2018 17:06:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sucursal](
	[IdSucursal] [int] IDENTITY(1,1) NOT NULL,
	[NombreSucursal] [varchar](200) NOT NULL,
	[Categoria] [int] NOT NULL,
	[Estado] [int] NOT NULL,
 CONSTRAINT [PK_Sucursal] PRIMARY KEY CLUSTERED 
(
	[IdSucursal] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TipoCDP]    Script Date: 30/7/2018 17:06:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TipoCDP](
	[IdTipoCDP] [int] NOT NULL,
	[Nombre] [varchar](100) NOT NULL,
	[Moneda] [char](1) NOT NULL,
	[Comision] [decimal](18, 2) NOT NULL,
	[Estado] [int] NOT NULL,
 CONSTRAINT [PK_TipoCDP] PRIMARY KEY CLUSTERED 
(
	[IdTipoCDP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TipoCredito]    Script Date: 30/7/2018 17:06:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TipoCredito](
	[IdCredito] [int] IDENTITY(1,1) NOT NULL,
	[NombreDeCredito] [varchar](100) NOT NULL,
	[ComisionDirefente] [decimal](18, 2) NOT NULL,
	[Estado] [int] NOT NULL,
 CONSTRAINT [PK_TipoCredito] PRIMARY KEY CLUSTERED 
(
	[IdCredito] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Usuarios]    Script Date: 30/7/2018 17:06:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuarios](
	[Username] [varchar](100) NOT NULL,
	[TipoUsuario] [int] NULL,
 CONSTRAINT [PK_Usuarios] PRIMARY KEY CLUSTERED 
(
	[Username] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UsuariosTipo]    Script Date: 30/7/2018 17:06:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UsuariosTipo](
	[IdTipo] [int] NOT NULL,
	[Nombre] [varchar](50) NULL,
 CONSTRAINT [PK_UsuariosTipo] PRIMARY KEY CLUSTERED 
(
	[IdTipo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Afiliaciones]  WITH CHECK ADD  CONSTRAINT [FK_Afiliaciones_ComisionAfiliacion] FOREIGN KEY([Comision])
REFERENCES [dbo].[ComisionAfiliacion] ([IdComisionAfiliacion])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[Afiliaciones] CHECK CONSTRAINT [FK_Afiliaciones_ComisionAfiliacion]
GO
ALTER TABLE [dbo].[Afiliaciones]  WITH CHECK ADD  CONSTRAINT [FK_Afiliaciones_Ejecutivos] FOREIGN KEY([Ejecutivo])
REFERENCES [dbo].[Ejecutivos] ([Cedula])
GO
ALTER TABLE [dbo].[Afiliaciones] CHECK CONSTRAINT [FK_Afiliaciones_Ejecutivos]
GO
ALTER TABLE [dbo].[Categorias]  WITH CHECK ADD  CONSTRAINT [FK_Categorias_EscalaComisiones] FOREIGN KEY([Escala])
REFERENCES [dbo].[EscalaComisionesIDP] ([IdEscala])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[Categorias] CHECK CONSTRAINT [FK_Categorias_EscalaComisiones]
GO
ALTER TABLE [dbo].[Categorias]  WITH CHECK ADD  CONSTRAINT [FK_Categorias_Metas] FOREIGN KEY([Meta])
REFERENCES [dbo].[MetasIDP] ([IdMeta])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[Categorias] CHECK CONSTRAINT [FK_Categorias_Metas]
GO
ALTER TABLE [dbo].[ColocacionCDP]  WITH CHECK ADD  CONSTRAINT [FK_ColocacionCDP_Ejecutivos] FOREIGN KEY([Ejecutivo])
REFERENCES [dbo].[Ejecutivos] ([Cedula])
GO
ALTER TABLE [dbo].[ColocacionCDP] CHECK CONSTRAINT [FK_ColocacionCDP_Ejecutivos]
GO
ALTER TABLE [dbo].[ColocacionCDP]  WITH CHECK ADD  CONSTRAINT [FK_ColocacionCDP_TipoCDP] FOREIGN KEY([TipoCDP])
REFERENCES [dbo].[TipoCDP] ([IdTipoCDP])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[ColocacionCDP] CHECK CONSTRAINT [FK_ColocacionCDP_TipoCDP]
GO
ALTER TABLE [dbo].[ColocacionCredito]  WITH CHECK ADD  CONSTRAINT [FK_ColocacionCredito_Ejecutivos] FOREIGN KEY([Ejecutivo])
REFERENCES [dbo].[Ejecutivos] ([Cedula])
GO
ALTER TABLE [dbo].[ColocacionCredito] CHECK CONSTRAINT [FK_ColocacionCredito_Ejecutivos]
GO
ALTER TABLE [dbo].[ColocacionCredito]  WITH CHECK ADD  CONSTRAINT [FK_ColocacionCredito_TipoCredito] FOREIGN KEY([TipoCredito])
REFERENCES [dbo].[TipoCredito] ([IdCredito])
GO
ALTER TABLE [dbo].[ColocacionCredito] CHECK CONSTRAINT [FK_ColocacionCredito_TipoCredito]
GO
ALTER TABLE [dbo].[ColocacionProducto]  WITH CHECK ADD  CONSTRAINT [FK_ColocacionProducto_Ejecutivos] FOREIGN KEY([Ejecutivo])
REFERENCES [dbo].[Ejecutivos] ([Cedula])
GO
ALTER TABLE [dbo].[ColocacionProducto] CHECK CONSTRAINT [FK_ColocacionProducto_Ejecutivos]
GO
ALTER TABLE [dbo].[ColocacionProducto]  WITH CHECK ADD  CONSTRAINT [FK_ColocacionProducto_ProductosColocar] FOREIGN KEY([Producto])
REFERENCES [dbo].[Productos] ([IdProducto])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[ColocacionProducto] CHECK CONSTRAINT [FK_ColocacionProducto_ProductosColocar]
GO
ALTER TABLE [dbo].[Ejecutivos]  WITH CHECK ADD  CONSTRAINT [FK_Ejecutivos_Salario] FOREIGN KEY([Salario])
REFERENCES [dbo].[Salario] ([IdSalario])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[Ejecutivos] CHECK CONSTRAINT [FK_Ejecutivos_Salario]
GO
ALTER TABLE [dbo].[Ejecutivos]  WITH CHECK ADD  CONSTRAINT [FK_Ejecutivos_Sucursal] FOREIGN KEY([Sucursal])
REFERENCES [dbo].[Sucursal] ([IdSucursal])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[Ejecutivos] CHECK CONSTRAINT [FK_Ejecutivos_Sucursal]
GO
ALTER TABLE [dbo].[Sucursal]  WITH CHECK ADD  CONSTRAINT [FK_Sucursal_Categorias] FOREIGN KEY([Categoria])
REFERENCES [dbo].[Categorias] ([IdCategoria])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[Sucursal] CHECK CONSTRAINT [FK_Sucursal_Categorias]
GO
ALTER TABLE [dbo].[Usuarios]  WITH CHECK ADD  CONSTRAINT [FK_Usuarios_UsuariosTipo] FOREIGN KEY([TipoUsuario])
REFERENCES [dbo].[UsuariosTipo] ([IdTipo])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[Usuarios] CHECK CONSTRAINT [FK_Usuarios_UsuariosTipo]
GO
