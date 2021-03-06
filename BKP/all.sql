USE [master]
GO
/****** Object:  Database [Despensa]    Script Date: 17/01/2019 18:37:03 ******/
CREATE DATABASE [Despensa]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Despensa', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\Despensa.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'Despensa_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\Despensa_1.ldf' , SIZE = 13632KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [Despensa] SET COMPATIBILITY_LEVEL = 100
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Despensa].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Despensa] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Despensa] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Despensa] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Despensa] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Despensa] SET ARITHABORT OFF 
GO
ALTER DATABASE [Despensa] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Despensa] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Despensa] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Despensa] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Despensa] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Despensa] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Despensa] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Despensa] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Despensa] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Despensa] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Despensa] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Despensa] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Despensa] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Despensa] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Despensa] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Despensa] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Despensa] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Despensa] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Despensa] SET  MULTI_USER 
GO
ALTER DATABASE [Despensa] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Despensa] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Despensa] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Despensa] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [Despensa] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Despensa] SET QUERY_STORE = OFF
GO
USE [Despensa]
GO
ALTER DATABASE SCOPED CONFIGURATION SET IDENTITY_CACHE = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET LEGACY_CARDINALITY_ESTIMATION = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET MAXDOP = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET PARAMETER_SNIFFING = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET QUERY_OPTIMIZER_HOTFIXES = PRIMARY;
GO
USE [Despensa]
GO
/****** Object:  User [conexion]    Script Date: 17/01/2019 18:37:03 ******/
CREATE USER [conexion] WITHOUT LOGIN WITH DEFAULT_SCHEMA=[db_accessadmin]
GO
/****** Object:  User [CJ]    Script Date: 17/01/2019 18:37:03 ******/
CREATE USER [CJ] WITHOUT LOGIN WITH DEFAULT_SCHEMA=[db_accessadmin]
GO
/****** Object:  User [Basico]    Script Date: 17/01/2019 18:37:03 ******/
CREATE USER [Basico] WITHOUT LOGIN WITH DEFAULT_SCHEMA=[db_datareader]
GO
/****** Object:  User [Administrador]    Script Date: 17/01/2019 18:37:03 ******/
CREATE USER [Administrador] WITHOUT LOGIN WITH DEFAULT_SCHEMA=[db_accessadmin]
GO
ALTER ROLE [db_backupoperator] ADD MEMBER [Administrador]
GO
/****** Object:  Table [dbo].[Detalle_Ganancia]    Script Date: 17/01/2019 18:37:03 ******/
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
/****** Object:  Table [dbo].[Detalle_venta]    Script Date: 17/01/2019 18:37:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Detalle_venta](
	[Cood_Venta] [int] NULL,
	[Cood_Cliente] [int] NULL,
	[Cood_Servicio] [int] NULL,
	[Uni_Medida] [nchar](3) NOT NULL,
	[Cantidad] [decimal](12, 4) NULL,
	[Nombre_Servicio] [nchar](70) NOT NULL,
	[Venta_unitario] [decimal](18, 2) NULL,
	[Venta] [decimal](18, 2) NULL,
	[IGV] [decimal](18, 2) NULL,
	[Total] [decimal](18, 2) NULL,
	[Nombre_tributo] [nchar](3) NOT NULL,
	[Codigo_tributo] [nchar](3) NOT NULL,
	[Detalle1] [nchar](70) NOT NULL,
	[Detalle2] [nchar](70) NOT NULL,
	[Detalle3] [nchar](70) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Producto]    Script Date: 17/01/2019 18:37:04 ******/
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
/****** Object:  View [dbo].[View_1]    Script Date: 17/01/2019 18:37:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[View_1]
AS
SELECT     dbo.Producto.Cod_Producto, dbo.Producto.Nombre_Producto, dbo.Producto.Stock, dbo.Detalle_venta.Cantidad, dbo.Detalle_Ganancia.Ganancia_Total
FROM         dbo.Producto INNER JOIN
                      dbo.Detalle_venta ON dbo.Producto.Cod_Producto = dbo.Detalle_venta.Cood_Producto INNER JOIN
                      dbo.Detalle_Ganancia ON dbo.Producto.Cod_Producto = dbo.Detalle_Ganancia.Cod_Producto
GO
/****** Object:  Table [dbo].[Cat02]    Script Date: 17/01/2019 18:37:04 ******/
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
/****** Object:  Table [dbo].[Cat06]    Script Date: 17/01/2019 18:37:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cat06](
	[Codigo] [nchar](1) NULL,
	[Descripcion] [nchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Cat51]    Script Date: 17/01/2019 18:37:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cat51](
	[Codigo] [nchar](4) NULL,
	[Descripcion] [nchar](100) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Cliente]    Script Date: 17/01/2019 18:37:04 ******/
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
/****** Object:  Table [dbo].[Compra]    Script Date: 17/01/2019 18:37:04 ******/
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
/****** Object:  Table [dbo].[Detalle_Compra]    Script Date: 17/01/2019 18:37:04 ******/
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
/****** Object:  Table [dbo].[Proveedor]    Script Date: 17/01/2019 18:37:04 ******/
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
/****** Object:  Table [dbo].[rutaSFS]    Script Date: 17/01/2019 18:37:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[rutaSFS](
	[rutasfs] [nchar](70) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[serieFac]    Script Date: 17/01/2019 18:37:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[serieFac](
	[Serie] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Servicios]    Script Date: 17/01/2019 18:37:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Servicios](
	[Cod_Servicio] [int] IDENTITY(1,1) NOT NULL,
	[Nombre_Servicio] [nchar](70) NOT NULL,
	[Costo] [decimal](18, 2) NULL,
	[Venta] [decimal](18, 2) NULL,
	[Items] [int] NULL,
 CONSTRAINT [PK_Servicios] PRIMARY KEY CLUSTERED 
(
	[Cod_Servicio] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Stock_Movimiento]    Script Date: 17/01/2019 18:37:04 ******/
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
/****** Object:  Table [dbo].[Usuario]    Script Date: 17/01/2019 18:37:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuario](
	[idUsuario] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NULL,
	[Apellidos] [varchar](50) NULL,
	[DNI] [varchar](8) NULL,
	[Direccion] [varchar](50) NULL,
	[Telefono] [nchar](10) NULL,
	[Login] [varchar](50) NULL,
	[Password] [varchar](50) NULL,
	[Acceso] [varchar](1) NULL,
	[Categoria] [varchar](1) NULL,
	[imagen] [image] NULL,
 CONSTRAINT [PK_Usuario] PRIMARY KEY CLUSTERED 
(
	[idUsuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Venta]    Script Date: 17/01/2019 18:37:04 ******/
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
	[Venta] [decimal](18, 2) NOT NULL,
	[IGV] [decimal](18, 2) NOT NULL,
	[Total] [decimal](18, 2) NOT NULL,
	[Letras] [nchar](100) NOT NULL,
	[Estado] [nchar](1) NULL,
	[Archivo] [nchar](100) NULL,
 CONSTRAINT [PK_Venta] PRIMARY KEY CLUSTERED 
(
	[Cod_Venta] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Compra]  WITH NOCHECK ADD  CONSTRAINT [FK_Compra_Proveedor] FOREIGN KEY([Cood_proveedor])
REFERENCES [dbo].[Proveedor] ([Cod_Proveedor])
NOT FOR REPLICATION 
GO
ALTER TABLE [dbo].[Compra] NOCHECK CONSTRAINT [FK_Compra_Proveedor]
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
ALTER TABLE [dbo].[Detalle_Ganancia]  WITH NOCHECK ADD  CONSTRAINT [FK_Detalle_Ganancia_Producto] FOREIGN KEY([Cod_Producto])
REFERENCES [dbo].[Producto] ([Cod_Producto])
NOT FOR REPLICATION 
GO
ALTER TABLE [dbo].[Detalle_Ganancia] NOCHECK CONSTRAINT [FK_Detalle_Ganancia_Producto]
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
ALTER TABLE [dbo].[Stock_Movimiento]  WITH CHECK ADD  CONSTRAINT [FK_Producto_Stock_Movimiento] FOREIGN KEY([Cood_Producto])
REFERENCES [dbo].[Producto] ([Cod_Producto])
GO
ALTER TABLE [dbo].[Stock_Movimiento] CHECK CONSTRAINT [FK_Producto_Stock_Movimiento]
GO
ALTER TABLE [dbo].[Venta]  WITH NOCHECK ADD  CONSTRAINT [FK_Venta_Cliente] FOREIGN KEY([Cood_Cliente])
REFERENCES [dbo].[Cliente] ([Cod_Cliente])
NOT FOR REPLICATION 
GO
ALTER TABLE [dbo].[Venta] NOCHECK CONSTRAINT [FK_Venta_Cliente]
GO
/****** Object:  StoredProcedure [dbo].[abrirFactura]    Script Date: 17/01/2019 18:37:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[abrirFactura]
@Cod_Venta int

as

update Venta 
set Estado = 0
where Cod_Venta = @Cod_Venta
GO
/****** Object:  StoredProcedure [dbo].[actualizar_Fondo]    Script Date: 17/01/2019 18:37:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[actualizar_Fondo]
@fondo decimal(18,2)
as
update fondo set Fondo = @fondo
where id_fondo = 1
GO
/****** Object:  StoredProcedure [dbo].[actualizar_total]    Script Date: 17/01/2019 18:37:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[actualizar_total]
@Cod_compra int,
@Total_a_pagar decimal(18,2)
as
if @Total_a_pagar <> 0
update Compra set Total_a_pagar = @Total_a_pagar
where Cod_compra = @Cod_compra
else 
begin
delete 
from Compra
where Cod_compra = @Cod_compra
end
GO
/****** Object:  StoredProcedure [dbo].[aumentar_ganancia]    Script Date: 17/01/2019 18:37:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[aumentar_ganancia]
@Cod_Producto as nchar(13),
@Cantidad decimal(18,3),
@Precio decimal(18,3)
as
declare @id int
set @id = (select min(id_ganancias) from Detalle_Ganancia WHERE Cantidaddescontada > 0 and Cod_Producto = @Cod_Producto)
if (SELECT PRECIO1_venta FROM Detalle_Ganancia WHERE Cod_Producto = @Cod_Producto and Id_Ganancias= @id) = @precio
begin
if (select cantidaddescontada from Detalle_Ganancia where Cod_Producto = @Cod_Producto and Id_Ganancias= @id) > 0
begin
update Detalle_Ganancia set Ganancia_total =  Ganancia_Total + (GananciaTotal1/Cantidad) * @Cantidad, Cantidaddescontada -= @cantidad
where Id_Ganancias = @id
end
end

if (SELECT PRECIO2_venta FROM Detalle_Ganancia WHERE Cod_Producto = @Cod_Producto and Id_Ganancias= @id) = @Precio
begin
if (select cantidaddescontada from Detalle_Ganancia where Cod_Producto = @Cod_Producto and Id_Ganancias= @id) > 0
begin
update Detalle_Ganancia set Ganancia_total =  Ganancia_Total + (GananciaTotal2/Cantidad) * @Cantidad, Cantidaddescontada -= @cantidad
where Id_Ganancias = @id
end
end
GO
/****** Object:  StoredProcedure [dbo].[aumentar_stock]    Script Date: 17/01/2019 18:37:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[aumentar_stock]
@Cod_Producto nchar(13),
@cantidad decimal(18,2)
as
update producto set stock+=@cantidad
where Cod_Producto = @Cod_producto
GO
/****** Object:  StoredProcedure [dbo].[backup_base]    Script Date: 17/01/2019 18:37:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[backup_base]
as 
BACKUP DATABASE [Despensa]
TO DISK =N'D:\optimum\optimum\BKP\Despensa.BAK'
with description = N'Respaldo de la base de datos del Sistema de Ventas',
NOFORMAT,
INIT,
NAME=N'Despensa',
SKIP,
NOREWIND,
NOUNLOAD,
STATS=10,
CHECKSUM
GO
/****** Object:  StoredProcedure [dbo].[Cambiar_Contraseña]    Script Date: 17/01/2019 18:37:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[Cambiar_Contraseña]
@login varchar(50),
@Password varchar(50),
@NuevoPassword varchar(50)
as
update Usuario set Password = @NuevoPassword
where Login = @login and Password = @Password
GO
/****** Object:  StoredProcedure [dbo].[cierraFactura]    Script Date: 17/01/2019 18:37:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[cierraFactura]
@Cod_Venta int,
@Cood_Cliente int,
@Letras nchar(100), 
@Referencial int
as

update Venta 
set letras = @Letras,
Estado = 1
where Cod_Venta = @Cod_Venta and Cood_Cliente = @Cood_Cliente and Referencial = @Referencial
GO
/****** Object:  StoredProcedure [dbo].[crearcabeceraFac]    Script Date: 17/01/2019 18:37:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE procedure [dbo].[crearcabeceraFac]
@Cod_venta int
as
SELECT    Tipo_oper as Campo1, Fecha_Venta as Campo2,Hora_Emision as Campo3,Fecha_Vence as Campo4,
		  '0000' as Campo5,Cod_Doc as Campo6,Nro_Doc as Campo7,Cliente as Campo8, Tip_Moneda as Campo9,
		  IGV as Campo10,Venta as Campo11,Total as Campo12,'0.00' as Campo13,'0.00' as Campo14,
		  '0.00' as Campo15,Total as Campo16,'2.1' as Campo17,'2.0' as Campo18, Serie as Campo19, Referencial as Campo20
FROM         dbo.Venta
                      where Cod_venta = @Cod_venta
                      order by cod_venta desc
GO
/****** Object:  StoredProcedure [dbo].[crearDetalleFac]    Script Date: 17/01/2019 18:37:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE procedure [dbo].[crearDetalleFac]
@Cod_Venta int,
@Cod_Cliente int
as
begin

SELECT    Uni_Medida as Campo1, Cantidad as Campo2,Cood_Servicio as Campo3,'-' as Campo4,
		 CONCAT(Nombre_Servicio,'  ',Detalle1,'      ',Detalle2,'      ',Detalle3) as Campo5,
		  Venta_unitario as Campo6,IGV as Campo7,'1000' as Campo8, IGV as Campo9,
		  (str((Cantidad * Venta_unitario),12,2)) as Campo10, Nombre_tributo as Campo11,Codigo_tributo as Campo12,
		  '10' as Campo13,	'18.00' as Campo14,
		  '-' as Campo15,'0.00' as Campo16,'0.00' as Campo17,'' as Campo18, '' as Campo19, '' as Campo20,
		  '15.00' as Campo21, '-' as Campo22,'0.00' as Campo23,'0.00' as Campo24,'' as Campo25, '' as Campo26, '15.00' as Campo27,
		   venta as Campo28, trim(str((Cantidad * Venta_unitario),12,2)) as Campo29, '0.00' as Campo30
FROM         dbo.Detalle_venta
                      where Cood_venta = @Cod_venta and Cood_Cliente = @Cod_Cliente  
end
GO
/****** Object:  StoredProcedure [dbo].[crearLeyAca]    Script Date: 17/01/2019 18:37:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE procedure [dbo].[crearLeyAca]
@Cod_Venta int,
@Cod_Cliente int
as
SELECT    '1000' as Campo1, A.Letras as Campo2, 'PE' as Campo3, '150100' as Campo4,
		  B.Cliente as Campo5, '' as Campo6 , Direccion as Campo7
FROM         dbo.Venta A inner join dbo.Cliente B 
					  on A.Cood_Cliente = B.Cod_Cliente

                      where A.Cod_venta = @Cod_venta and A.Cood_Cliente = @Cod_Cliente  
GO
/****** Object:  StoredProcedure [dbo].[crearTri]    Script Date: 17/01/2019 18:37:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE procedure [dbo].[crearTri]
@Cod_Venta int,
@Cod_Cliente int
as
SELECT    '1000' as Campo1, Nombre_tributo as Campo2,Codigo_tributo as Campo3,sum(Venta_unitario) as Campo4,
		  sum(IGV) as Campo5
FROM         dbo.Detalle_venta
                      where Cood_venta = @Cod_venta and Cood_Cliente = @Cod_Cliente  

group by Nombre_tributo,Codigo_tributo
order by Nombre_tributo,Codigo_tributo
GO
/****** Object:  StoredProcedure [dbo].[disminuir_stock]    Script Date: 17/01/2019 18:37:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[disminuir_stock]
@Cod_Producto nchar(13),
@cantidad decimal(18,2)
as
update producto set Stock -= @cantidad
where Cod_Producto = @Cod_producto
GO
/****** Object:  StoredProcedure [dbo].[editar_cliente]    Script Date: 17/01/2019 18:37:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[editar_cliente]
@cod_cliente integer,
@cliente nchar(30),
@ruc nchar(11),
@nombre nchar(20),
@apellido nchar(20),
@dni nchar(8),
@direccion nchar(50),
@Telefono nchar(11),
@Celular nchar(11),
@correo nchar(30)
as 
update cliente set cliente = @cliente, ruc = @ruc,nombre= @nombre, apellido = @apellido, dni = @dni, direccion = @direccion, telefono = @telefono, celular = @celular , correo = @correo
where cod_cliente = @cod_cliente
GO
/****** Object:  StoredProcedure [dbo].[Editar_Pagos]    Script Date: 17/01/2019 18:37:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[Editar_Pagos]
@Estado nchar(1),
@Cood_Venta int
as
update Venta set Estado = @Estado 
where Cod_Venta = @Cood_Venta
GO
/****** Object:  StoredProcedure [dbo].[editar_producto]    Script Date: 17/01/2019 18:37:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[editar_producto]
@cod_Producto nchar(14),
@nombre_producto nchar (20),
@limite decimal(18,2),
@cantidad decimal (18,2),
@precio_unitario decimal (18,2),
@Sprecio_unitario decimal(18,2),
@Cood_Proveedor int,
@imagen image
as
update producto set cod_Producto=@cod_Producto,Nombre_Producto = @Nombre_Producto,stock=@Cantidad,Limite= @limite, Precio_unitario= @Precio_unitario, Sprecio_Unitario=@Sprecio_Unitario, Cood_Proveedor=@cood_Proveedor, imagen= @imagen
where cod_producto = @cod_Producto

update Detalle_Ganancia set Precio1_Venta =@precio_unitario, Precio2_Venta = @Sprecio_unitario
where Cod_Producto = @cod_Producto and Cantidad > 0
GO
/****** Object:  StoredProcedure [dbo].[editar_Proveedor]    Script Date: 17/01/2019 18:37:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[editar_Proveedor]
@Cod_Proveedor int,
@Nombre_Proveedor nchar(30),
@Direccion nchar(50),
@Telefono nchar(11),
@Correo nchar(30)
as 
update proveedor set Nombre_Proveedor=@nombre_proveedor,Direccion=@Direccion,Telefono=@Telefono, correo = @Correo
where cod_proveedor= @cod_Proveedor
GO
/****** Object:  StoredProcedure [dbo].[editar_rutaSFS]    Script Date: 17/01/2019 18:37:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[editar_rutaSFS]
@rutaSFS nchar(70)
as 
update rutaSFS set rutasfs = @rutaSFS
GO
/****** Object:  StoredProcedure [dbo].[editar_servicios]    Script Date: 17/01/2019 18:37:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE proc [dbo].[editar_servicios]
@Cod_Servicio int,
@Nombre_Servicio nchar (49),
@Venta decimal (18,2)
as
update Servicios set Nombre_Servicio = @Nombre_Servicio+'.',Venta = @Venta
where Cod_Servicio = @Cod_Servicio


GO
/****** Object:  StoredProcedure [dbo].[editar_usuario]    Script Date: 17/01/2019 18:37:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[editar_usuario]
@nombre varchar(50),
@apellidos varchar(50),
@DNI varchar(8),
@Direccion varchar(50),
@Telefono nchar(10),
@Login varchar(50),
@Acceso varchar(1),
@Categoria varchar(1),
@imagen image
as
update Usuario set Nombre= @nombre, Apellidos = @apellidos, DNI = @DNI, Direccion = @Direccion, Telefono = @Telefono, Login = @Login,
 Acceso = @Acceso, Categoria = @Categoria, imagen = @imagen where Login = @Login
GO
/****** Object:  StoredProcedure [dbo].[editar_venta]    Script Date: 17/01/2019 18:37:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[editar_venta]
@Cod_Venta int,
@Cood_Cliente int,
@TC decimal (15,4),
@Tipo_oper nchar(4),
@Fecha_Venta nchar(10),
@Hora_Emision nchar(8),
@Fecha_Vence nchar(10),
@Nro_doc nchar(11),
@Cliente nchar(30),
@Tip_Moneda nchar(3),
@IGV decimal(15,2),
@Venta decimal (15,2),
@Total decimal(15,2),
@Letras nchar(100)
as 
begin
UPDATE [dbo].[Venta]
    SET
			Cood_Cliente = @Cood_Cliente,
	        TC = @TC,
			Tipo_oper = @Tipo_oper,
            Fecha_Venta = @Fecha_Venta,
            Hora_Emision = @Hora_Emision,
            Fecha_Vence = @Fecha_Vence,
            Nro_Doc = @Nro_Doc,
            Cliente = @Cliente,
            Tip_Moneda = @Tip_Moneda,
            IGV = @IGV,
            Venta = @Venta,
            Total = @Total,
			Letras = @Letras
			where Cod_Venta = @Cod_Venta
end
GO
/****** Object:  StoredProcedure [dbo].[eliminar_cliente]    Script Date: 17/01/2019 18:37:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[eliminar_cliente]
@cod_cliente integer
as 
delete from cliente where cod_cliente = @cod_cliente
GO
/****** Object:  StoredProcedure [dbo].[Eliminar_DetalleCompra]    Script Date: 17/01/2019 18:37:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[Eliminar_DetalleCompra]
@Cood_Producto nchar(13)
as
delete from Detalle_compra where Cood_Producto = @Cood_Producto
GO
/****** Object:  StoredProcedure [dbo].[Eliminar_DetalleGanancia]    Script Date: 17/01/2019 18:37:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[Eliminar_DetalleGanancia]
@cod_producto nvarchar(14)
as
declare @id int
set @id= (SELECT MAX(Id_Ganancias) from Detalle_Ganancia where Cod_Producto = @cod_producto)
delete
from Detalle_Ganancia
where Id_Ganancias = @id

GO
/****** Object:  StoredProcedure [dbo].[Eliminar_detalleVenta]    Script Date: 17/01/2019 18:37:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[Eliminar_detalleVenta](
@Cood_Venta int,
@Cood_Cliente int,
@Cood_Servicio int,
@Venta decimal(18,2),
@IGV decimal(18,2),
@Total decimal(18,2)

)
as


begin
begin

delete Detalle_venta where Cood_Venta = @Cood_Venta and Cood_Cliente = @Cood_Cliente and Cood_Servicio = @Cood_Servicio

end

begin
declare @Venta_fin decimal(18,2)
declare @IGV_fin decimal(18,2)
declare @Total_fin decimal(18,2)

set @Venta_fin = (select Venta from Venta WHERE Cod_Venta = @Cood_Venta and Cood_Cliente = @Cood_Cliente) - @Venta
set @IGV_fin = (select IGV from Venta WHERE Cod_Venta = @Cood_Venta and Cood_Cliente = @Cood_Cliente) - @IGV
set @Total_fin = (select Total from Venta WHERE Cod_Venta = @Cood_Venta and Cood_Cliente = @Cood_Cliente) - @Total


update Venta
set Venta = @Venta_fin , IGV = @IGV_fin, Total = @Total_fin  
where Cod_Venta = @Cood_Venta and Cood_Cliente = @Cood_Cliente
end
end
GO
/****** Object:  StoredProcedure [dbo].[eliminar_Producto]    Script Date: 17/01/2019 18:37:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[eliminar_Producto]
@cod_producto nchar(13)
as 
delete from Stock_Movimiento where Cood_Producto = @cod_Producto
delete from producto where cod_Producto = @cod_Producto
GO
/****** Object:  StoredProcedure [dbo].[eliminar_Proveedor]    Script Date: 17/01/2019 18:37:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[eliminar_Proveedor]
@Cod_Proveedor int
as 
delete from proveedor
where cod_proveedor= @cod_Proveedor
GO
/****** Object:  StoredProcedure [dbo].[eliminar_Servicio]    Script Date: 17/01/2019 18:37:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[eliminar_Servicio](
@Cod_Servicio int

)
as


if exists (SELECT * from Detalle_venta where  Cood_Servicio = @Cod_Servicio)
begin
RAISERROR ('EXISTEN FACTURAS ASOCIADAS AL SERVICIO, POR FAVOR REVISE', 16,1)
end
else 

begin
delete Servicios where Cod_Servicio = @Cod_Servicio
end

GO
/****** Object:  StoredProcedure [dbo].[grabaArchivo]    Script Date: 17/01/2019 18:37:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[grabaArchivo]
@Cod_venta int,
@Cood_cliente int,
@Archivo nchar(300)
as 
begin
update venta
set Archivo = @Archivo
where Cod_venta = @Cod_venta and Cood_Cliente = @Cood_cliente 
end
GO
/****** Object:  StoredProcedure [dbo].[insertar]    Script Date: 17/01/2019 18:37:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[insertar]
@cliente varchar(30),
@ruc varchar(11),
@Nombre varchar (20),
@Apellido varchar (20),
@Direccion varchar (50),
@dni varchar(8),
@Telefono varchar (10),
@Celular varchar (10),
@correo varchar (30)
as
insert into cliente (cliente,ruc, nombre, apellido,dni,direccion,telefono,celular,correo) values (@cliente,@ruc,@Nombre,@Apellido,@dni,@Direccion,@Telefono,@Celular,@correo)
GO
/****** Object:  StoredProcedure [dbo].[Insertar_caja]    Script Date: 17/01/2019 18:37:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[Insertar_caja]
@inicial decimal(18,2),
@ingreso decimal(18,2)
as
declare @fecha_sistema date
set @fecha_sistema = (SELECT GETDATE())
insert into Caja(Fecha,Inicial,Ingreso) values(@fecha_sistema,@inicial,@ingreso)
GO
/****** Object:  StoredProcedure [dbo].[insertar_compra]    Script Date: 17/01/2019 18:37:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[insertar_compra]
@Cood_proveedor int,
@fecha_compra date,
@Total_a_pagar decimal(18,2)
as
insert into compra (Cood_proveedor, fecha_compra, total_a_pagar) values (@Cood_proveedor, @Fecha_compra, @Total_a_pagar)
GO
/****** Object:  StoredProcedure [dbo].[insertar_detallecompra]    Script Date: 17/01/2019 18:37:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[insertar_detallecompra]
@Cood_Producto nchar(16),
@Cood_compra int,
@Cantidad decimal(18,2),
@Precio_compra decimal(18,2)
as
if exists (SELECT Cood_Compra from Detalle_Compra where Cood_Compra = @Cood_compra and Cood_Producto = @Cood_Producto)
begin
RAISERROR ('YA EXISTE UN PRODUCTO CON ESE CODIGO, POR FAVOR INGRESE DE NUEVO', 16,1)
end
else
begin
insert into detalle_compra (Cood_Producto,Cood_compra, Cantidad, Precio_compra) values (@Cood_Producto, @Cood_compra, @cantidad, @Precio_compra)
end
GO
/****** Object:  StoredProcedure [dbo].[insertar_detalleVenta]    Script Date: 17/01/2019 18:37:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[insertar_detalleVenta](
@Cood_Venta int,
@Cood_Cliente int,
@Cood_Servicio int,
@Uni_Medida nchar(3),
@Cantidad decimal(12,2),
@Nombre_Servicio nchar(70),
@Venta_unitario decimal(18,2),
@Venta decimal(18,2),
@IGV decimal(18,2),
@Total decimal(18,2),
@Nombre_tributo nchar(3),
@Codigo_tributo nchar(3),
@Detalle1 nchar(70),
@Detalle2 nchar(70),
@Detalle3 nchar(70)

)
as


if exists (SELECT Cood_Venta,Cood_Cliente,Cood_Servicio from Detalle_venta where Cood_Venta= @Cood_venta and Cood_Cliente = @Cood_Cliente and Cood_Servicio = @Cood_Servicio)
begin
RAISERROR ('YA EXISTE UN PRODUCTO CON ESE CODIGO, POR FAVOR INGRESE DE NUEVO', 16,1)
end
else 

begin

insert into detalle_venta (Cood_Venta,Cood_Cliente,Cood_Servicio,Uni_Medida,Cantidad,Nombre_Servicio,Venta_unitario,Venta,IGV,Total,Nombre_tributo,Codigo_tributo,Detalle1,Detalle2,Detalle3) 
values (@Cood_Venta,@Cood_Cliente,@Cood_Servicio,@Uni_Medida,@Cantidad,@Nombre_Servicio,@Venta_unitario,@Venta,@IGV,@Total,@Nombre_tributo,@Codigo_tributo,@Detalle1,@Detalle2,@Detalle3)

end

begin
declare @Venta_fin decimal(18,2)
declare @IGV_fin decimal(18,2)
declare @Total_fin decimal(18,2)

set @Venta_fin = (select Venta from Venta WHERE Cod_Venta = @Cood_Venta and Cood_Cliente = @Cood_Cliente) + @Venta_unitario*@Cantidad
set @IGV_fin = (select IGV from Venta WHERE Cod_Venta = @Cood_Venta and Cood_Cliente = @Cood_Cliente) + @IGV
set @Total_fin = (select Total from Venta WHERE Cod_Venta = @Cood_Venta and Cood_Cliente = @Cood_Cliente) + @Total


update Venta
set Venta = @Venta_fin , IGV = @IGV_fin, Total = @Total_fin  
where Cod_Venta = @Cood_Venta and Cood_Cliente = @Cood_Cliente
end
GO
/****** Object:  StoredProcedure [dbo].[insertar_detalleVenta_Variable]    Script Date: 17/01/2019 18:37:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[insertar_detalleVenta_Variable]
@Cood_Producto nchar(13),
@Cood_venta int,
@Cantidad decimal(18,2),
@Total decimal(18,2),
@Precio_Unitario decimal(18,2)
as
declare @DetalleVenta_Variable table (
Cood_Producto nchar(13),
Cood_Venta int,
Cantidad decimal(18,2),
Total decimal(18,3), 
Precio_Unitario decimal(18,2)
)
insert into @DetalleVenta_Variable(Cood_Producto,Cood_Venta, Cantidad, Total, Precio_Unitario) values (@Cood_Producto, @Cood_venta, @cantidad, @total, @Precio_Unitario)
GO
/****** Object:  StoredProcedure [dbo].[insertar_producto]    Script Date: 17/01/2019 18:37:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[insertar_producto]
@cod_Producto nchar(14),
@nombre_producto nchar (20),
@cantidad decimal (18,2),
@precio_unitario decimal (18,2),
@Sprecio_unitario decimal(18,2),
@Cood_Proveedor int,
@imagen image,
@limite decimal(18,2)
as

if EXISTS (SELECT COD_PRODUCTO FROM Producto where Cod_Producto = @cod_Producto )
RAISERROR ('YA EXISTE UN PRODUCTO CON ESE CODIGO, POR FAVOR INGRESE DE NUEVO', 16,1)
else
if @precio_unitario <> @Sprecio_unitario
begin
insert into producto (Cod_producto,Nombre_Producto,Stock,Precio_unitario, Sprecio_Unitario, Cood_Proveedor, imagen, Limite) 
values (@cod_producto,@nombre_producto, @cantidad,  @precio_unitario, @Sprecio_Unitario, @Cood_Proveedor, @imagen, @limite)

insert into Stock_Movimiento (Cood_Producto,Nombre_Producto,Ctdad,Tipo,Documento,Fecha,Cood_Proveedor,Cood_Servicio)
values (@cod_producto,@nombre_producto,0,'A','',GETDATE(),@Cood_Proveedor,0)
end

else	

RAISERROR ('Los precios no pueden ser iguales',16,1)

GO
/****** Object:  StoredProcedure [dbo].[insertar_Proveedor]    Script Date: 17/01/2019 18:37:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[insertar_Proveedor] 
@Nombre_Proveedor nchar(30),
@Direccion nchar(50),
@Telefono nchar(11),
@Correo nchar(30)
as 
insert into proveedor (Nombre_Proveedor,Direccion,Telefono,correo) values (@nombre_proveedor,@Direccion,@Telefono,@Correo)
GO
/****** Object:  StoredProcedure [dbo].[insertar_Servicios]    Script Date: 17/01/2019 18:37:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE procedure [dbo].[insertar_Servicios] 
@Nombre_Servicio nchar(50),
@Costo decimal (18,2),
@Venta decimal(18,2),
@items int
as 
insert into Servicios (Nombre_Servicio,Costo,Venta,items) values (@Nombre_Servicio,@Costo,@Venta,@items)
GO
/****** Object:  StoredProcedure [dbo].[insertar_StockMovimiento]    Script Date: 17/01/2019 18:37:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[insertar_StockMovimiento]
@Cood_Producto nchar(14),
@Costo int,
@Nombre_producto nchar (20),
@Ctdad int,
@Cood_Proveedor int,
@documento nchar(20),
@Cood_Servicio int
as

if @Ctdad >0


if @documento = ''

begin
update Producto set Stock = Stock-@Ctdad where Cod_Producto = @Cood_Producto
update Servicios set Costo = Costo + @Costo ,items = items+@Ctdad where Cod_Servicio = @Cood_Servicio

insert into Stock_Movimiento (Cood_Producto,Nombre_Producto,Ctdad,Tipo,Documento,Fecha,Cood_Proveedor,Cood_Servicio)
values (@Cood_producto,@Nombre_producto,-@Ctdad,'E',@documento,GETDATE(),@Cood_Proveedor,@Cood_Servicio)
end

 
else

begin

update Producto set Stock = Stock+@Ctdad where Cod_Producto = @Cood_Producto

insert into Stock_Movimiento (Cood_Producto,Nombre_Producto,Ctdad,Tipo,Documento,Fecha,Cood_Proveedor,Cood_Servicio)
values (@Cood_producto,@Nombre_producto,@Ctdad,'I',@documento,GETDATE(),@Cood_Proveedor,@Cood_Servicio)
end






else	

RAISERROR ('Ingresar Cantidad',16,1)

GO
/****** Object:  StoredProcedure [dbo].[insertar_usuario]    Script Date: 17/01/2019 18:37:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[insertar_usuario]
@nombre varchar(50),
@apellidos varchar(50),
@DNI varchar(8),
@Direccion varchar(50),
@Telefono nchar(10),
@Login varchar(50),
@Password varchar(50),
@Acceso varchar(1),
@Categoria varchar(1),
@imagen image
as 
if EXISTS (SELECT login FROM usuario where login = @login )
RAISERROR ('YA EXISTE UN USUARIO CON ESE LOGIN, POR FAVOR INGRESE DE NUEVO', 16,1)
else
insert into Usuario (Nombre, Apellidos, DNI, Direccion, Telefono, Login, Password, Acceso, Categoria, imagen) 
values (@nombre, @apellidos, @DNI, @Direccion, @Telefono, @Login, @Password, @Acceso, @Categoria, @imagen)
GO
/****** Object:  StoredProcedure [dbo].[insertar_venta]    Script Date: 17/01/2019 18:37:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[insertar_venta]
@Cood_Cliente int,
@Serie nchar(4),
@Referencial int,
@TC decimal (15,4),
@Tipo_oper nchar(4),
@Fecha_Venta nchar(10),
@Hora_Emision nchar(8),
@Fecha_Vence nchar(10),
@Nro_doc nchar(11),
@Cliente nchar(30),
@Tip_Moneda nchar(3),
@IGV decimal(15,2),
@Venta decimal (15,2),
@Total decimal(15,2),
@Letras nchar(100),
@serieF int
as 
begin
INSERT INTO [dbo].[Venta]
           ([Cood_Cliente]
           ,[Serie]
           ,[Referencial]
           ,[TC]
		   ,[Tipo_oper]
           ,[Fecha_Venta]
           ,[Hora_Emision]
           ,[Fecha_Vence]
		   ,[Cod_Doc]
           ,[Nro_Doc]
           ,[Cliente]
           ,[Tip_Moneda]
           ,[IGV]
           ,[Venta]
           ,[Total]
		   ,[Letras]
		   ,[Estado])
     VALUES
           (@Cood_Cliente,
            @Serie,
            @Referencial,
            @TC,
			@Tipo_oper,
            @Fecha_Venta,
            @Hora_Emision,
            @Fecha_Vence,
			'6',
            @Nro_Doc,
            @Cliente,
            @Tip_Moneda,
            @IGV,
            @Venta,
            @Total,
			@Letras,
			'0')


insert into dbo.serieFac (Serie) values (@serieF)
end
GO
/****** Object:  StoredProcedure [dbo].[insertarCliente]    Script Date: 17/01/2019 18:37:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[insertarCliente](
@Nombre nchar(20) ,
@Apellido nchar(20),
@Direccion nchar(50),
@Telefono nchar(11),
@Celular nchar(10)
) 
as 
insert into Cliente (nombre, Apellido, Direccion, Telefono, Celular) values (@nombre,@Apellido,@Direccion,@Telefono,@Celular)
GO
/****** Object:  StoredProcedure [dbo].[mostrar_activo]    Script Date: 17/01/2019 18:37:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[mostrar_activo]
@login varchar(50),
@password varchar(50)
as
select Login, Nombre, Apellidos, imagen,Categoria
from Usuario
where Login = @login and Password = @password
GO
/****** Object:  StoredProcedure [dbo].[Mostrar_Caja]    Script Date: 17/01/2019 18:37:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[Mostrar_Caja]
as

declare @Cod_Max int
set @Cod_Max = (SELECT max(Cod_Caja) FROM Caja)

select *
from Caja
where Cod_Caja = @Cod_Max
GO
/****** Object:  StoredProcedure [dbo].[mostrar_cliente]    Script Date: 17/01/2019 18:37:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[mostrar_cliente]
as
select Cod_Cliente,Cliente,Ruc,Nombre,Apellido,Dni,Direccion,Telefono,Celular,Correo
from cliente
GO
/****** Object:  StoredProcedure [dbo].[mostrar_compra]    Script Date: 17/01/2019 18:37:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[mostrar_compra]
as
SELECT     TOP (100)dbo.Compra.Cod_compra, dbo.Proveedor.Nombre_Proveedor, dbo.Compra.Fecha_compra, dbo.Compra.Total_a_pagar
FROM         dbo.Compra INNER JOIN
                      dbo.Proveedor ON dbo.Compra.Cood_proveedor = dbo.Proveedor.Cod_Proveedor
                      order by dbo.Compra.Cod_compra desc
GO
/****** Object:  StoredProcedure [dbo].[mostrar_detallecompra]    Script Date: 17/01/2019 18:37:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[mostrar_detallecompra]
@Cod_compra int
as
SELECT     dbo.Producto.Cod_Producto, dbo.Producto.Nombre_Producto, dbo.Detalle_Compra.Cantidad, dbo.Detalle_Compra.Precio_compra 
FROM         dbo.Compra INNER JOIN
                      dbo.Detalle_Compra ON dbo.Compra.Cod_compra = dbo.Detalle_Compra.Cood_Compra INNER JOIN
                      dbo.Producto ON dbo.Detalle_Compra.Cood_Producto = dbo.Producto.Cod_Producto
                      where dbo.Detalle_compra.Cood_compra = @Cod_compra
                      order by cod_compra desc
GO
/****** Object:  StoredProcedure [dbo].[mostrar_detalleVenta]    Script Date: 17/01/2019 18:37:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[mostrar_detalleVenta]
@Cood_Venta int,
@Cood_Cliente int
as
SELECT    Cood_Venta,Cood_Cliente,Uni_Medida,Cantidad,Cood_Servicio,Nombre_Servicio,Venta_unitario, IGV, Venta, Total, Nombre_tributo,Codigo_tributo 
FROM         dbo.Detalle_venta
                      where dbo.Detalle_venta.Cood_Venta = @Cood_Venta and dbo.Detalle_venta.Cood_Cliente = @Cood_Cliente
                   
GO
/****** Object:  StoredProcedure [dbo].[mostrar_fondo]    Script Date: 17/01/2019 18:37:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[mostrar_fondo]
as
select * from Fondo
GO
/****** Object:  StoredProcedure [dbo].[mostrar_ListaFac]    Script Date: 17/01/2019 18:37:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[mostrar_ListaFac]
as

SELECT     A.Fecha_Venta, B.Cliente, A.Nro_Doc as RUC,A.Serie,  A.Referencial,A.Tip_Moneda, A.Total,A.Cod_Venta as Cod_Venta, A.TC,A.IGV, A.Venta ,a.Estado, a.Archivo ,b.Correo
FROM         dbo.Venta A INNER JOIN
                      dbo.Cliente B ON A.Cood_Cliente = B.Cod_Cliente
					  where Estado = 1
                     
order by cod_venta desc
GO
/****** Object:  StoredProcedure [dbo].[mostrar_productos]    Script Date: 17/01/2019 18:37:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[mostrar_productos]
as 
select Cod_Producto, Nombre_Producto, Stock, Precio_unitario, SPrecio_unitario, Cood_Proveedor,imagen,Limite, b.Nombre_Proveedor
from producto a 
INNER JOIN dbo.Proveedor b
on a.Cood_Proveedor = b.Cod_Proveedor
order by Cod_Producto desc
GO
/****** Object:  StoredProcedure [dbo].[mostrar_Proveedor]    Script Date: 17/01/2019 18:37:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[mostrar_Proveedor]
as
select *
from proveedor
order by Cod_Proveedor desc
GO
/****** Object:  StoredProcedure [dbo].[mostrar_rutaSFS]    Script Date: 17/01/2019 18:37:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[mostrar_rutaSFS]
as
select rutasfs
from rutaSFS
GO
/****** Object:  StoredProcedure [dbo].[mostrar_serieFac]    Script Date: 17/01/2019 18:37:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[mostrar_serieFac]
as

SELECT     max(Serie)+1 as Serie
FROM         dbo.serieFac

GO
/****** Object:  StoredProcedure [dbo].[mostrar_servicios]    Script Date: 17/01/2019 18:37:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE proc [dbo].[mostrar_servicios]
as 
SELECT [Cod_Servicio]
      ,[Nombre_Servicio]
      ,[Costo]
      ,[Venta]
      ,[Items]
  FROM [dbo].[Servicios]
GO
/****** Object:  StoredProcedure [dbo].[mostrar_servicios2]    Script Date: 17/01/2019 18:37:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE proc [dbo].[mostrar_servicios2]
as 
select 0 AS Cod_Servicio,'All' AS Nombre_Servicio, 0 AS Costo, 0 AS Venta, 0 AS Items
UNION
SELECT [Cod_Servicio]
      ,TRIM([Nombre_Servicio]) AS Nombre_Servicio
      ,[Costo]
      ,[Venta]
      ,[Items]
  FROM [dbo].[Servicios]
GO
/****** Object:  StoredProcedure [dbo].[mostrar_StockMovimiento]    Script Date: 17/01/2019 18:37:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[mostrar_StockMovimiento]
@cood_Producto nchar(14)
as
SELECT [Cood_Producto]
      ,[Nombre_Producto]
      ,[Ctdad]
      ,[Tipo]
      ,[Documento]
      ,[Fecha]
	  ,B.Nombre_Proveedor
  FROM [dbo].[Stock_Movimiento] A
  INNER JOIN [dbo].[Proveedor] B on A.Cood_Proveedor = B.Cod_Proveedor
where cood_producto = @cood_Producto
GO
/****** Object:  StoredProcedure [dbo].[mostrar_TotalActual]    Script Date: 17/01/2019 18:37:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[mostrar_TotalActual]
@Cod_Venta int,
@Cood_Cliente int
as
SELECT    Total, Letras
FROM         dbo.Venta
                      where Cod_Venta = @Cod_Venta and Cood_Cliente = @Cood_Cliente
                   
GO
/****** Object:  StoredProcedure [dbo].[mostrar_usuario]    Script Date: 17/01/2019 18:37:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[mostrar_usuario]
as 
select * from Usuario order by idUsuario
GO
/****** Object:  StoredProcedure [dbo].[mostrar_venta]    Script Date: 17/01/2019 18:37:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[mostrar_venta]
@Cod_venta nchar(13)
as
SELECT     dbo.Producto.Nombre_Producto, dbo.Producto.Stock, dbo.Detalle_venta.Cood_Venta, dbo.Detalle_venta.Cantidad, dbo.Producto.Cod_Producto, dbo.Producto.Precio_unitario, dbo.Detalle_Venta.Total
FROM         dbo.Detalle_venta INNER JOIN
                      dbo.Producto ON dbo.Detalle_venta.Cood_Producto = dbo.Producto.Cod_Producto
                      where dbo.Detalle_venta.Cood_venta = @Cod_venta
                      order by cood_venta desc
GO
/****** Object:  StoredProcedure [dbo].[mostrar_ventaSimple]    Script Date: 17/01/2019 18:37:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[mostrar_ventaSimple]
as

SELECT     A.Cod_Venta,A.Fecha_Venta, A.Cood_Cliente, A.Nro_Doc, B.Cliente,A.Serie,  A.Referencial,a.Tipo_oper, A.Tip_Moneda, A.TC,A.Fecha_Vence,A.IGV, A.Venta, A.Total ,a.Estado
FROM         dbo.Venta A INNER JOIN
                      dbo.Cliente B ON A.Cood_Cliente = B.Cod_Cliente
                     
order by cod_venta desc
GO
/****** Object:  StoredProcedure [dbo].[mostrarCat51]    Script Date: 17/01/2019 18:37:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[mostrarCat51]
as

SELECT     Codigo,Descripcion
FROM         dbo.Cat51
                     

GO
/****** Object:  StoredProcedure [dbo].[Reporte_Inventario]    Script Date: 17/01/2019 18:37:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Reporte_Inventario]
as


select Cod_Producto, Nombre_Producto, Stock, Precio_unitario, SPrecio_unitario, Limite, 
'ESTADO'= (CASE
WHEN Stock>Limite THEN 'EN STOCK'
WHEN Stock=Limite THEN 'LIMITE'
WHEN Stock<Limite THEN 'HAGA UNA
SOLICITUD'
END)
from Producto
GO
/****** Object:  StoredProcedure [dbo].[Servicio_Items]    Script Date: 17/01/2019 18:37:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[Servicio_Items]
@Cod_servicio int

as
if @Cod_servicio = 0
SELECT A.Cod_Servicio
      ,A.Nombre_Servicio
      ,A.Costo
      ,A.Venta
      ,A.Items
	  ,ISNULL(B.Cood_Producto, '') AS Cood_Producto
	  ,ISNULL(B.Nombre_Producto,'') AS Nombre_Producto
	  ,ISNULL(B.Fecha,GETDATE()) AS Fecha 
	  ,ISNULL(-(B.Ctdad),0) AS Ctdad
  FROM [dbo].[Servicios] A
  left join Stock_Movimiento B 
  on A.Cod_Servicio = B.Cood_Servicio
  and B.Tipo = 'E'
else 
begin
SELECT A.Cod_Servicio
      ,A.Nombre_Servicio
      ,A.Costo
      ,A.Venta
      ,A.Items
	  ,ISNULL(B.Cood_Producto, '') AS Cood_Producto
	  ,ISNULL(B.Nombre_Producto,'') AS Nombre_Producto
	  ,ISNULL(B.Fecha,GETDATE()) AS Fecha 
	  ,ISNULL(-(B.Ctdad),0) AS Ctdad
  FROM [dbo].[Servicios] A
  left join Stock_Movimiento B 
  on A.Cod_Servicio = B.Cood_Servicio
  and B.Tipo = 'E'
  where Cod_Servicio = @Cod_servicio
end

GO
/****** Object:  StoredProcedure [dbo].[Validar_Administrador]    Script Date: 17/01/2019 18:37:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[Validar_Administrador]
@password varchar(50)
as
select * from usuario
where password = @password and acceso ='1'
GO
/****** Object:  StoredProcedure [dbo].[validar_usuario]    Script Date: 17/01/2019 18:37:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[validar_usuario]
@login varchar(50),
@password varchar(50)
as
select * from usuario
where login=@login and password = @password
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "Producto"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 147
               Right = 236
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Detalle_venta"
            Begin Extent = 
               Top = 6
               Left = 274
               Bottom = 147
               Right = 472
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Detalle_Ganancia"
            Begin Extent = 
               Top = 6
               Left = 510
               Bottom = 147
               Right = 708
            End
            DisplayFlags = 280
            TopColumn = 1
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'View_1'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'View_1'
GO
USE [master]
GO
ALTER DATABASE [Despensa] SET  READ_WRITE 
GO
