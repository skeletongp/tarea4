USE [master]
GO
/****** Object:  Database [Registro]    Script Date: 10/05/2021 21:00:16 ******/
CREATE DATABASE [Registro]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Registro', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\Registro.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Registro_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\Registro_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [Registro] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Registro].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Registro] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Registro] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Registro] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Registro] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Registro] SET ARITHABORT OFF 
GO
ALTER DATABASE [Registro] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Registro] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Registro] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Registro] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Registro] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Registro] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Registro] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Registro] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Registro] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Registro] SET  ENABLE_BROKER 
GO
ALTER DATABASE [Registro] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Registro] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Registro] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Registro] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Registro] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Registro] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Registro] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Registro] SET RECOVERY FULL 
GO
ALTER DATABASE [Registro] SET  MULTI_USER 
GO
ALTER DATABASE [Registro] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Registro] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Registro] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Registro] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Registro] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Registro] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'Registro', N'ON'
GO
ALTER DATABASE [Registro] SET QUERY_STORE = OFF
GO
USE [Registro]
GO
/****** Object:  Table [dbo].[Asignaturas]    Script Date: 10/05/2021 21:00:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Asignaturas](
	[idAsignatura] [int] IDENTITY(1,1) NOT NULL,
	[Asignatura] [nvarchar](45) NOT NULL,
	[Facilitador] [nvarchar](35) NOT NULL,
	[Estado] [nvarchar](15) NULL,
	[Calificacion] [int] NOT NULL,
	[Literal] [char](1) NOT NULL,
	[idTrimestre] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[idAsignatura] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Trimestre]    Script Date: 10/05/2021 21:00:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Trimestre](
	[idTrimestre] [int] IDENTITY(1,1) NOT NULL,
	[Trimestre] [nvarchar](25) NOT NULL,
	[Periodo] [nvarchar](15) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[idTrimestre] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Asignaturas] ON 
GO
INSERT [dbo].[Asignaturas] ([idAsignatura], [Asignatura], [Facilitador], [Estado], [Calificacion], [Literal], [idTrimestre]) VALUES (1, N'Español I', N'Rosa De La Cruz', N'Aprobado', 97, N'A', 1)
GO
INSERT [dbo].[Asignaturas] ([idAsignatura], [Asignatura], [Facilitador], [Estado], [Calificacion], [Literal], [idTrimestre]) VALUES (2, N'Matemáticas', N'Domingo De La C', N'Reprobado', 65, N'F', 2)
GO
INSERT [dbo].[Asignaturas] ([idAsignatura], [Asignatura], [Facilitador], [Estado], [Calificacion], [Literal], [idTrimestre]) VALUES (3, N'Lógica de Programación', N'Gregorio De La ', N'Aprobado', 98, N'A', 2)
GO
INSERT [dbo].[Asignaturas] ([idAsignatura], [Asignatura], [Facilitador], [Estado], [Calificacion], [Literal], [idTrimestre]) VALUES (4, N'Infotecnología', N'Juan Almonte', N'Reprobado', 69, N'F', 3)
GO
INSERT [dbo].[Asignaturas] ([idAsignatura], [Asignatura], [Facilitador], [Estado], [Calificacion], [Literal], [idTrimestre]) VALUES (5, N'Sociología', N'Griselda Pérez', N'Aprobado', 99, N'A', 2)
GO
INSERT [dbo].[Asignaturas] ([idAsignatura], [Asignatura], [Facilitador], [Estado], [Calificacion], [Literal], [idTrimestre]) VALUES (6, N'Fïsica II', N'Julio Sandoval', N'Aprobado', 87, N'B', 3)
GO
SET IDENTITY_INSERT [dbo].[Asignaturas] OFF
GO
SET IDENTITY_INSERT [dbo].[Trimestre] ON 
GO
INSERT [dbo].[Trimestre] ([idTrimestre], [Trimestre], [Periodo]) VALUES (1, N'Primero', N'2020-01')
GO
INSERT [dbo].[Trimestre] ([idTrimestre], [Trimestre], [Periodo]) VALUES (2, N'Segundo', N'2020-02')
GO
INSERT [dbo].[Trimestre] ([idTrimestre], [Trimestre], [Periodo]) VALUES (3, N'Cuarto', N'2020-4')
GO
SET IDENTITY_INSERT [dbo].[Trimestre] OFF
GO
ALTER TABLE [dbo].[Asignaturas]  WITH CHECK ADD FOREIGN KEY([idTrimestre])
REFERENCES [dbo].[Trimestre] ([idTrimestre])
GO
/****** Object:  StoredProcedure [dbo].[getAprobadas]    Script Date: 10/05/2021 21:00:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[getAprobadas] 
as 
Select a.Asignatura, a.Facilitador, a.Calificacion, a.Literal, t.Trimestre, t.Periodo
From Asignaturas a inner join Trimestre t on a.idTrimestre=t.idTrimestre Where a.Estado='Aprobado';
GO
/****** Object:  StoredProcedure [dbo].[getAsignaturas]    Script Date: 10/05/2021 21:00:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[getAsignaturas] 
as 
Select a.Asignatura, a.Facilitador, a.Calificacion, a.Literal, t.Trimestre, t.Periodo
From Asignaturas a inner join Trimestre t on a.idTrimestre=t.idTrimestre;
GO
/****** Object:  StoredProcedure [dbo].[getReprobada]    Script Date: 10/05/2021 21:00:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[getReprobada] 
as 
Select a.Asignatura, a.Facilitador, a.Calificacion, a.Literal, t.Trimestre, t.Periodo
From Asignaturas a inner join Trimestre t on a.idTrimestre=t.idTrimestre Where a.Estado='Reprobado';
GO
/****** Object:  StoredProcedure [dbo].[insertAsignatura]    Script Date: 10/05/2021 21:00:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create procedure [dbo].[insertAsignatura] @asignatura nvarchar(25), @facilitador nvarchar(15),
@calificacion int, @literal char, @idtrimestre int
as
Insert into Asignaturas(Asignatura, Facilitador, Calificacion, Literal, idTrimestre) 
values (@asignatura, @facilitador, @calificacion , @literal, @idtrimestre);
GO
/****** Object:  StoredProcedure [dbo].[insertTrimestre]    Script Date: 10/05/2021 21:00:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create procedure [dbo].[insertTrimestre] @trimestre nvarchar(25), @periodo nvarchar(15)
as
Insert into Trimestre (Trimestre, Periodo) values (@trimestre, @periodo);
GO
USE [master]
GO
ALTER DATABASE [Registro] SET  READ_WRITE 
GO
