USE [Despensa]
GO
/****** Object:  StoredProcedure [dbo].[editar_cliente]    Script Date: 6/08/2018 16:24:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER procedure [dbo].[editar_cliente]
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