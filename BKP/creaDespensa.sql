USE [master]
GO

/****** Object:  Database [Despensa]    Script Date: 14/08/2018 18:45:12 ******/
CREATE DATABASE [Despensa]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Despensa', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\Despensa.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'Despensa_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\Despensa_1.ldf' , SIZE = 13632KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO

ALTER DATABASE [Despensa] SET COMPATIBILITY_LEVEL = 100
GO

IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Despensa].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO

ALTER DATABASE [Despensa] SET ANSI_NULL_DEFAULT OFF 
GO

ALTER DATABASE [Despensa] SET ANSI_NULLS OFF 
GO

ALTER DATABASE [Despensa] SET ANSI_PADDING OFF 
GO

ALTER DATABASE [Despensa] SET ANSI_WARNINGS OFF 
GO

ALTER DATABASE [Despensa] SET ARITHABORT OFF 
GO

ALTER DATABASE [Despensa] SET AUTO_CLOSE OFF 
GO

ALTER DATABASE [Despensa] SET AUTO_SHRINK OFF 
GO

ALTER DATABASE [Despensa] SET AUTO_UPDATE_STATISTICS ON 
GO

ALTER DATABASE [Despensa] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO

ALTER DATABASE [Despensa] SET CURSOR_DEFAULT  GLOBAL 
GO

ALTER DATABASE [Despensa] SET CONCAT_NULL_YIELDS_NULL OFF 
GO

ALTER DATABASE [Despensa] SET NUMERIC_ROUNDABORT OFF 
GO

ALTER DATABASE [Despensa] SET QUOTED_IDENTIFIER OFF 
GO

ALTER DATABASE [Despensa] SET RECURSIVE_TRIGGERS OFF 
GO

ALTER DATABASE [Despensa] SET  DISABLE_BROKER 
GO

ALTER DATABASE [Despensa] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO

ALTER DATABASE [Despensa] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO

ALTER DATABASE [Despensa] SET TRUSTWORTHY OFF 
GO

ALTER DATABASE [Despensa] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO

ALTER DATABASE [Despensa] SET PARAMETERIZATION SIMPLE 
GO

ALTER DATABASE [Despensa] SET READ_COMMITTED_SNAPSHOT OFF 
GO

ALTER DATABASE [Despensa] SET HONOR_BROKER_PRIORITY OFF 
GO

ALTER DATABASE [Despensa] SET RECOVERY SIMPLE 
GO

ALTER DATABASE [Despensa] SET  MULTI_USER 
GO

ALTER DATABASE [Despensa] SET PAGE_VERIFY CHECKSUM  
GO

ALTER DATABASE [Despensa] SET DB_CHAINING OFF 
GO

ALTER DATABASE [Despensa] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO

ALTER DATABASE [Despensa] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO

ALTER DATABASE [Despensa] SET DELAYED_DURABILITY = DISABLED 
GO

ALTER DATABASE [Despensa] SET QUERY_STORE = OFF
GO

USE [Despensa]
GO

ALTER DATABASE SCOPED CONFIGURATION SET IDENTITY_CACHE = ON;
GO

ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
GO

ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET LEGACY_CARDINALITY_ESTIMATION = PRIMARY;
GO

ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
GO

ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET MAXDOP = PRIMARY;
GO

ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
GO

ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET PARAMETER_SNIFFING = PRIMARY;
GO

ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
GO

ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET QUERY_OPTIMIZER_HOTFIXES = PRIMARY;
GO

ALTER DATABASE [Despensa] SET  READ_WRITE 
GO

