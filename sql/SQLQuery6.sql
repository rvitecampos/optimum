USE [Despensa]
GO
/****** Object:  StoredProcedure [dbo].[insertar_Proveedor]    Script Date: 7/08/2018 18:38:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER procedure [dbo].[insertar_Proveedor] 
@Nombre_Proveedor nchar(30),
@Direccion nchar(50),
@Telefono nchar(11),
@Correo nchar(30)
as 
insert into proveedor (Nombre_Proveedor,Direccion,Telefono,correo) values (@nombre_proveedor,@Direccion,@Telefono,@Correo)
