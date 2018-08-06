USE [Despensa]
GO
/****** Object:  StoredProcedure [dbo].[insertar]    Script Date: 6/08/2018 16:28:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER procedure [dbo].[insertar]
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
