USE [Despensa]
GO

/****** Object:  Table [dbo].[Cliente]    Script Date: 6/08/2018 18:30:22 ******/
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


