USE [Despensa]
GO
/****** Object:  StoredProcedure [dbo].[backup_base]    Script Date: 7/08/2018 18:49:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER procedure [dbo].[backup_base]
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