
USE [Despensa]
GO
/****** Object:  StoredProcedure [dbo].[insertar_detalleVenta]    Script Date: 17/10/2018 11:28:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER procedure [dbo].[insertar_detalleVenta](
@Cood_Venta int,
@Cood_Cliente int,
@Cood_Servicio int,
@Uni_Medida nchar(3),
@Cantidad decimal(12,2),
@Nombre_Servicio nchar(30),
@Venta_unitario decimal(18,2),
@Venta decimal(18,2),
@IGV decimal(18,2),
@Total decimal(18,2),
@Nombre_tributaro nchar(3),
@Codigo_tributario nchar(3)

)
as


if exists (SELECT Cood_Venta,Cood_Cliente,Cood_Servicio from Detalle_venta where Cood_Venta= @Cood_venta and Cood_Cliente = @Cood_Cliente and Cood_Servicio = @Cood_Servicio)
begin
RAISERROR ('YA EXISTE UN PRODUCTO CON ESE CODIGO, POR FAVOR INGRESE DE NUEVO', 16,1)
end
else 
begin
begin
declare @id int
declare @Ganancia decimal(18,2)
declare @Total_Ganancia decimal(18,2)
declare @Cantidad_Ganancia decimal(18,3)
set @id = (select min(id_ganancias) from Detalle_Ganancia WHERE Cantidaddescontada > 0 and Cod_Producto = @Cood_Producto)
if (select precio1_venta from Detalle_Ganancia where Id_Ganancias = @id) = @Precio_Unitario
begin

set @Total_Ganancia = (SELECT GANANCIATOTAL1 from Detalle_Ganancia where Id_Ganancias = @id)
set @Cantidad_Ganancia = (SELECT CANTIDAD FROM Detalle_Ganancia WHERE Id_Ganancias = @id)
set @Ganancia = (@Total_Ganancia/@Cantidad_Ganancia) * @cantidad
insert into detalle_venta (Cood_Producto,Cood_Venta, Cantidad, Total, Id_ganancias, Ganancia, Precio_Unitario) values (@Cood_Producto, @Cood_venta, @cantidad, @total, @id,@Ganancia, @Precio_Unitario)

end
if (select precio2_venta from Detalle_Ganancia where Id_Ganancias = @id) = @Precio_Unitario
begin

set @Total_Ganancia = (SELECT GANANCIATOTAL2 from Detalle_Ganancia where Id_Ganancias = @id)

set @Cantidad_Ganancia = (SELECT CANTIDAD FROM Detalle_Ganancia WHERE Id_Ganancias = @id)
set @Ganancia = (@Total_Ganancia/@Cantidad_Ganancia) * @cantidad
insert into detalle_venta (Cood_Producto,Cood_Venta, Cantidad, Total, Id_ganancias, Ganancia, Precio_Unitario) values (@Cood_Producto, @Cood_venta, @cantidad, @total, @id,@Ganancia, @Precio_Unitario)

end
end
end