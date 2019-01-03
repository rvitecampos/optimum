USE [Despensa]
GO

INSERT INTO [dbo].[Usuario]
           ([Nombre]
           ,[Apellidos]
           ,[DNI]
           ,[Direccion]
           ,[Telefono]
           ,[Login]
           ,[Password]
           ,[Acceso]
           ,[Categoria]
       ,[imagen])
     select
           'Nombre'
           ,'Apellido'
           ,'09797977'
           ,'Av Chorrillos'
           ,'4673030'
           ,'nape'
           ,'nape'
           ,'1'
       ,'A',
       *from OpenRowset(Bulk 'D:\optimum\optimum\Resources\avatar1.png', Single_Blob) As imagen
           
 
GO
