
USE [Despensa]
GO


/****** Object:  Table [dbo].[Detalle_Compra]    Script Date: 3/09/2018 12:37:10 ******/
DROP TABLE [dbo].[Detalle_Compra]
GO


/****** Object:  Table [dbo].[Detalle_venta]    Script Date: 3/09/2018 12:37:10 ******/
DROP TABLE [dbo].[Detalle_venta]
GO


/****** Object:  Table [dbo].[Detalle_Ganacia]    Script Date: 3/09/2018 12:37:10 ******/
DROP TABLE [dbo].[Detalle_Ganancia]
GO


/****** Object:  Table [dbo].[Stock_Movimiento]    Script Date: 3/09/2018 12:37:10 ******/
DROP TABLE [dbo].[Stock_Movimiento]
GO

/****** Object:  Table [dbo].[Producto]    Script Date: 3/09/2018 12:37:10 ******/
DROP TABLE [dbo].[Producto]
GO

/****** Object:  Table [dbo].[Venta]    Script Date: 3/09/2018 12:37:10 ******/
DROP TABLE [dbo].[Venta]
GO

/****** Object:  Table [dbo].[Cliente]    Script Date: 3/09/2018 12:37:10 ******/
DROP TABLE [dbo].[Cliente]
GO


/****** Object:  Table [dbo].[Compra]    Script Date: 3/09/2018 12:37:10 ******/
DROP TABLE [dbo].[Compra]
GO

/****** Object:  Table [dbo].[Proveedor]    Script Date: 3/09/2018 12:37:10 ******/
DROP TABLE [dbo].[Proveedor]
GO



/****** Object:  Table [dbo].[Servicios]    Script Date: 3/09/2018 12:37:10 ******/
DROP TABLE [dbo].[Servicios]
GO





/*------*/



USE [Despensa]
GO

/****** Object:  Table [dbo].[Cliente]    Script Date: 3/09/2018 12:36:45 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Cliente](
	[Cod_Cliente] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [nchar](20) NULL,
	[Apellido] [nchar](20) NULL,
	[Direccion] [nchar](50) NULL,
	[Telefono] [nchar](11) NULL,
	[Celular] [nchar](10) NULL,
	[Cliente] [nchar](30) NULL,
	[Ruc] [nchar](11) NULL,
	[Dni] [nchar](8) NULL,
	[Correo] [nchar](30) NULL,
 CONSTRAINT [PK_Cliente] PRIMARY KEY CLUSTERED 
(
	[Cod_Cliente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO



/*-------*/

USE [Despensa]
GO

/****** Object:  Table [dbo].[Producto]    Script Date: 3/09/2018 13:27:38 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Producto](
	[Cod_Producto] [nchar](13) NOT NULL,
	[Nombre_Producto] [nchar](20) NULL,
	[Stock] [decimal](18, 2) NULL,
	[Precio_unitario] [decimal](18, 2) NULL,
	[SPrecio_unitario] [decimal](18, 2) NULL,
	[Cood_Proveedor] [int] NULL,
	[imagen] [image] NULL,
	[Limite] [decimal](18, 2) NULL,
 CONSTRAINT [PK_Producto] PRIMARY KEY CLUSTERED 
(
	[Cod_Producto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO







/*-------*/


USE [Despensa]
GO

/****** Object:  Table [dbo].[Venta]    Script Date: 12/10/2018 11:34:12 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Venta](
	[Cod_Venta] [int] IDENTITY(1,1) NOT NULL,
	[Cood_Cliente] [int] NOT NULL,
	[Serie] [nchar](4) NOT NULL,
	[Referencial] [int] NOT NULL,
	[TC] [decimal](15, 4) NOT NULL,
	[Tipo_oper] [nchar](4) NOT NULL,
	[Fecha_Venta] [nchar](10) NOT NULL,
	[Hora_Emision] [nchar](8) NOT NULL,
	[Fecha_Vence] [nchar](10) NOT NULL,
	[Cod_Doc] [nchar](1) NOT NULL,
	[Nro_Doc] [nchar](11) NOT NULL,
	[Cliente] [nchar](30) NOT NULL,
	[Tip_Moneda] [nchar](3) NOT NULL,
	[IGV] [decimal](15, 2) NOT NULL,
	[Venta] [decimal](15, 2) NOT NULL,
	[Total] [decimal](15, 2) NOT NULL,
	[Estado] [nchar](1) NULL,
 CONSTRAINT [PK_Venta] PRIMARY KEY CLUSTERED 
(
	[Cod_Venta] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[Venta]  WITH NOCHECK ADD  CONSTRAINT [FK_Venta_Cliente] FOREIGN KEY([Cood_Cliente])
REFERENCES [dbo].[Cliente] ([Cod_Cliente])
NOT FOR REPLICATION 
GO

ALTER TABLE [dbo].[Venta] NOCHECK CONSTRAINT [FK_Venta_Cliente]
GO






/*-------*/




USE [Despensa]
GO

/****** Object:  Table [dbo].[Detalle_venta]    Script Date: 3/09/2018 12:35:00 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Detalle_venta](
	[Cood_Cliente] [int] NULL,
	[Cood_Venta] [int] NULL,
	[Cantidad] [decimal](18, 2) NULL,
	[Total] [decimal](18, 2) NULL,
	[Id_ganancias] [int] NULL,
	[Ganancia] [decimal](18, 2) NULL,
	[Precio_Unitario] [decimal](18, 2) NULL
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[Detalle_venta]  WITH NOCHECK ADD  CONSTRAINT [FK_Detalle_venta_Cliente] FOREIGN KEY([Cood_Cliente])
REFERENCES [dbo].[Cliente] ([Cod_Cliente])
NOT FOR REPLICATION 
GO

ALTER TABLE [dbo].[Detalle_venta] NOCHECK CONSTRAINT [FK_Detalle_venta_Cliente]
GO

ALTER TABLE [dbo].[Detalle_venta]  WITH NOCHECK ADD  CONSTRAINT [FK_Detalle_venta_Venta] FOREIGN KEY([Cood_Venta])
REFERENCES [dbo].[Venta] ([Cod_Venta])
NOT FOR REPLICATION 
GO

ALTER TABLE [dbo].[Detalle_venta] NOCHECK CONSTRAINT [FK_Detalle_venta_Venta]
GO


/*------*/


USE [Despensa]
GO

/****** Object:  Table [dbo].[Proveedor]    Script Date: 3/09/2018 12:56:40 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Proveedor](
	[Cod_Proveedor] [int] IDENTITY(1,1) NOT NULL,
	[Nombre_Proveedor] [nchar](30) NULL,
	[Direccion] [nchar](50) NULL,
	[Telefono] [nchar](11) NULL,
	[Correo] [nchar](30) NULL,
 CONSTRAINT [PK_Proveedor] PRIMARY KEY CLUSTERED 
(
	[Cod_Proveedor] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO


/*------*/


USE [Despensa]
GO

/****** Object:  Table [dbo].[Compra]    Script Date: 3/09/2018 12:57:38 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Compra](
	[Cod_compra] [int] IDENTITY(1,1) NOT NULL,
	[Cood_proveedor] [int] NULL,
	[Fecha_compra] [date] NULL,
	[Total_a_pagar] [decimal](18, 2) NULL,
 CONSTRAINT [PK_Compra] PRIMARY KEY CLUSTERED 
(
	[Cod_compra] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[Compra]  WITH NOCHECK ADD  CONSTRAINT [FK_Compra_Proveedor] FOREIGN KEY([Cood_proveedor])
REFERENCES [dbo].[Proveedor] ([Cod_Proveedor])
NOT FOR REPLICATION 
GO

ALTER TABLE [dbo].[Compra] NOCHECK CONSTRAINT [FK_Compra_Proveedor]
GO


/*------*/



USE [Despensa]
GO

/****** Object:  Table [dbo].[Detalle_Compra]    Script Date: 3/09/2018 12:58:04 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Detalle_Compra](
	[Cood_Producto] [nchar](13) NULL,
	[Cood_Compra] [int] NULL,
	[Precio_compra] [decimal](18, 2) NULL,
	[Cantidad] [decimal](18, 2) NULL
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[Detalle_Compra]  WITH NOCHECK ADD  CONSTRAINT [FK_Detalle_Compra_Compra] FOREIGN KEY([Cood_Compra])
REFERENCES [dbo].[Compra] ([Cod_compra])
NOT FOR REPLICATION 
GO

ALTER TABLE [dbo].[Detalle_Compra] NOCHECK CONSTRAINT [FK_Detalle_Compra_Compra]
GO

ALTER TABLE [dbo].[Detalle_Compra]  WITH NOCHECK ADD  CONSTRAINT [FK_Detalle_Compra_Producto] FOREIGN KEY([Cood_Producto])
REFERENCES [dbo].[Producto] ([Cod_Producto])
NOT FOR REPLICATION 
GO

ALTER TABLE [dbo].[Detalle_Compra] NOCHECK CONSTRAINT [FK_Detalle_Compra_Producto]
GO



/*-------*/


USE [Despensa]
GO

/****** Object:  Table [dbo].[Stock_Movimiento]    Script Date: 3/09/2018 13:28:03 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Stock_Movimiento](
	[Id_Stock] [int] IDENTITY(1,1) NOT NULL,
	[Cood_Producto] [nchar](13) NOT NULL,
	[Nombre_Producto] [nchar](20) NOT NULL,
	[Ctdad] [int] NOT NULL,
	[Tipo] [nchar](1) NOT NULL,
	[Documento] [nchar](15) NOT NULL,
	[Fecha] [date] NOT NULL,
	[Cood_Proveedor] [int] NOT NULL,
	[Cood_Servicio] [int] NOT NULL,
 CONSTRAINT [PK_Stock_Movimiento] PRIMARY KEY CLUSTERED 
(
	[Id_Stock] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[Stock_Movimiento]  WITH CHECK ADD  CONSTRAINT [FK_Producto_Stock_Movimiento] FOREIGN KEY([Cood_Producto])
REFERENCES [dbo].[Producto] ([Cod_Producto])
GO

ALTER TABLE [dbo].[Stock_Movimiento] CHECK CONSTRAINT [FK_Producto_Stock_Movimiento]
GO



/*-------*/


USE [Despensa]
GO

/****** Object:  Table [dbo].[Detalle_Ganancia]    Script Date: 3/09/2018 13:26:43 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Detalle_Ganancia](
	[Id_Ganancias] [int] IDENTITY(1,1) NOT NULL,
	[Cod_Producto] [nchar](13) NULL,
	[Cantidad] [decimal](18, 2) NULL,
	[CantidadDescontada] [decimal](18, 2) NULL,
	[Precio_Compra] [decimal](18, 2) NULL,
	[Ganancia_Total] [decimal](18, 2) NULL,
	[PrecioUnitario_compra]  AS ([Precio_Compra]/[Cantidad]),
	[Precio1_Venta] [decimal](18, 2) NULL,
	[GananciaTotal1]  AS ([Precio1_Venta]*[Cantidad]-[Precio_Compra]),
	[GananciaTotal2]  AS ([Precio2_Venta]*[Cantidad]-[Precio_Compra]),
	[Precio2_Venta] [decimal](18, 2) NULL,
	[Fecha_Compra] [date] NULL,
 CONSTRAINT [PK_Detalle_Ganancia] PRIMARY KEY CLUSTERED 
(
	[Id_Ganancias] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[Detalle_Ganancia]  WITH NOCHECK ADD  CONSTRAINT [FK_Detalle_Ganancia_Producto] FOREIGN KEY([Cod_Producto])
REFERENCES [dbo].[Producto] ([Cod_Producto])
NOT FOR REPLICATION 
GO

ALTER TABLE [dbo].[Detalle_Ganancia] NOCHECK CONSTRAINT [FK_Detalle_Ganancia_Producto]
GO


/*-------*/



USE [Despensa]
GO

/****** Object:  Table [dbo].[Servicios]    Script Date: 10/10/2018 18:04:14 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Servicios](
	[Cod_Servicio] [int] IDENTITY(1,1) NOT NULL,
	[Nombre_Servicio] [nchar](30) NOT NULL,
	[Costo] [decimal](18, 2) NULL,
	[Venta] [decimal](18, 2) NULL,
	[Items] [int] NULL,
 CONSTRAINT [PK_Servicios] PRIMARY KEY CLUSTERED 
(
	[Cod_Servicio] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO


/*-------*/

USE [Despensa]
GO

/****** Object:  Table [dbo].[Cat51]    Script Date: 11/10/2018 14:56:43 ******/
DROP TABLE [dbo].[Cat51]
GO

/****** Object:  Table [dbo].[Cat51]    Script Date: 11/10/2018 14:56:43 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Cat51](
	[Codigo] [nchar](4) NULL,
	[Descripcion] [nchar](100) NULL
) ON [PRIMARY]
GO


USE [Despensa]
GO

INSERT INTO [dbo].[Cat51]
           ([Codigo]
           ,[Descripcion])
     VALUES
           ('0101','Venta Interna')
GO

INSERT INTO [dbo].[Cat51]
           ([Codigo]
           ,[Descripcion])
     VALUES
           ('0102','Prueba')
GO



/*-------*/



USE [Despensa]
GO

/****** Object:  Table [dbo].[Cat02]    Script Date: 11/10/2018 15:19:14 ******/
DROP TABLE [dbo].[Cat02]
GO

/****** Object:  Table [dbo].[Cat02]    Script Date: 11/10/2018 15:19:14 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Cat02](
	[Codigo] [nchar](3) NULL,
	[Simbolo] [nchar](3) NULL,
	[Descripcion] [nchar](15) NULL
) ON [PRIMARY]
GO


USE [Despensa]
GO



INSERT INTO [dbo].[Cat02]
           ([Codigo]
           ,[Simbolo]
           ,[Descripcion])
     VALUES
           ('PEN','S/.','NUEVOS SOLES')
GO

INSERT INTO [dbo].[Cat02]
           ([Codigo]
           ,[Simbolo]
           ,[Descripcion])
     VALUES
           ('USD','$','DOLARES')
GO
INSERT INTO [dbo].[Cat02]
           ([Codigo]
           ,[Simbolo]
           ,[Descripcion])
     VALUES
           ('EUR','€','EUROS')
GO



/*-------*/



USE [Despensa]
GO

/****** Object:  Table [dbo].[serieFac]    Script Date: 15/10/2018 17:48:42 ******/
DROP TABLE [dbo].[serieFac]
GO

/****** Object:  Table [dbo].[serieFac]    Script Date: 15/10/2018 17:48:42 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[serieFac](
	[Serie] [int] NULL
) ON [PRIMARY]
GO

/*-------*/


USE [Despensa]
GO

INSERT INTO [dbo].[serieFac]
           ([Serie])
     VALUES
           (0)
GO

/*-------*/

USE [Despensa]
GO

ALTER TABLE [dbo].[Detalle_venta] DROP CONSTRAINT [FK_Detalle_venta_Venta]
GO

ALTER TABLE [dbo].[Detalle_venta] DROP CONSTRAINT [FK_Detalle_venta_Servicios]
GO

ALTER TABLE [dbo].[Detalle_venta] DROP CONSTRAINT [FK_Detalle_venta_Cliente]
GO

/****** Object:  Table [dbo].[Detalle_venta]    Script Date: 16/10/2018 15:20:03 ******/
DROP TABLE [dbo].[Detalle_venta]
GO

/****** Object:  Table [dbo].[Detalle_venta]    Script Date: 16/10/2018 15:20:03 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Detalle_venta](
	[Cood_Venta] [int] NULL,
	[Cood_Cliente] [int] NULL,
	[Cood_Servicio] [int] NULL,
	[Uni_Medida] [nchar](3) NOT NULL,
	[Cantidad] [decimal](12, 2) NULL,
	[Nombre_Servicio] [nchar](30) NOT NULL,
	[Venta_unitario] [decimal](18, 2) NULL,
	[Venta] [decimal](18, 2) NULL,
	[IGV] [decimal](18, 2) NULL,
	[Nombre_tributo] [nchar](3) NOT NULL,
	[Codigo_tributo] [nchar](3) NOT NULL,
	[Total] [decimal](18, 2) NULL
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[Detalle_venta]  WITH NOCHECK ADD  CONSTRAINT [FK_Detalle_venta_Cliente] FOREIGN KEY([Cood_Cliente])
REFERENCES [dbo].[Cliente] ([Cod_Cliente])
NOT FOR REPLICATION 
GO

ALTER TABLE [dbo].[Detalle_venta] NOCHECK CONSTRAINT [FK_Detalle_venta_Cliente]
GO

ALTER TABLE [dbo].[Detalle_venta]  WITH NOCHECK ADD  CONSTRAINT [FK_Detalle_venta_Servicios] FOREIGN KEY([Cood_Servicio])
REFERENCES [dbo].[Servicios] ([Cod_Servicio])
NOT FOR REPLICATION 
GO

ALTER TABLE [dbo].[Detalle_venta] NOCHECK CONSTRAINT [FK_Detalle_venta_Servicios]
GO

ALTER TABLE [dbo].[Detalle_venta]  WITH NOCHECK ADD  CONSTRAINT [FK_Detalle_venta_Venta] FOREIGN KEY([Cood_Venta])
REFERENCES [dbo].[Venta] ([Cod_Venta])
NOT FOR REPLICATION 
GO

ALTER TABLE [dbo].[Detalle_venta] NOCHECK CONSTRAINT [FK_Detalle_venta_Venta]
GO




/*-------*/