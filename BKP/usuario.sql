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
           'Ricardo'
           ,'Vite'
           ,'09798107'
           ,'Av Chorrillos'
           ,'4673030'
           ,'RVITE'
           ,'RVITE'
           ,'1'
       ,'A',
       *from OpenRowset(Bulk 'E:\optimum\optimum\Resources\ric.jpg', Single_Blob) As imagen
           
 
GO
