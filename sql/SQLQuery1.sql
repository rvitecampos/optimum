USE [Despensa]
GO
/****** Object:  StoredProcedure [dbo].[mostrar_activo]    Script Date: 3/08/2018 18:20:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER procedure [dbo].[mostrar_activo]
@login varchar(50),
@password varchar(50)
as
select Login, Nombre, Apellidos, imagen,Categoria
from Usuario
where Login = @login and Password = @password