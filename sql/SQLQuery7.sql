USE [Despensa]
GO
/****** Object:  StoredProcedure [dbo].[editar_Proveedor]    Script Date: 7/08/2018 18:37:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER procedure [dbo].[editar_Proveedor]
@Cod_Proveedor int,
@Nombre_Proveedor nchar(30),
@Direccion nchar(50),
@Telefono nchar(11),
@Correo nchar(30)
as 
update proveedor set Nombre_Proveedor=@nombre_proveedor,Direccion=@Direccion,Telefono=@Telefono, correo = @Correo
where cod_proveedor= @cod_Proveedor
