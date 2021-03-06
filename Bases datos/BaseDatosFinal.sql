USE [master]
GO
/****** Object:  Database [ListaToDo]    Script Date: 20/11/2021 20:56:54 ******/
CREATE DATABASE [ListaToDo]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'ListaToDo', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\ListaToDo.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'ListaToDo_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\ListaToDo.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [ListaToDo] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [ListaToDo].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [ListaToDo] SET ANSI_NULL_DEFAULT ON 
GO
ALTER DATABASE [ListaToDo] SET ANSI_NULLS ON 
GO
ALTER DATABASE [ListaToDo] SET ANSI_PADDING ON 
GO
ALTER DATABASE [ListaToDo] SET ANSI_WARNINGS ON 
GO
ALTER DATABASE [ListaToDo] SET ARITHABORT ON 
GO
ALTER DATABASE [ListaToDo] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [ListaToDo] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [ListaToDo] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [ListaToDo] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [ListaToDo] SET CURSOR_DEFAULT  LOCAL 
GO
ALTER DATABASE [ListaToDo] SET CONCAT_NULL_YIELDS_NULL ON 
GO
ALTER DATABASE [ListaToDo] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [ListaToDo] SET QUOTED_IDENTIFIER ON 
GO
ALTER DATABASE [ListaToDo] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [ListaToDo] SET  DISABLE_BROKER 
GO
ALTER DATABASE [ListaToDo] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [ListaToDo] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [ListaToDo] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [ListaToDo] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [ListaToDo] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [ListaToDo] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [ListaToDo] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [ListaToDo] SET RECOVERY FULL 
GO
ALTER DATABASE [ListaToDo] SET  MULTI_USER 
GO
ALTER DATABASE [ListaToDo] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [ListaToDo] SET DB_CHAINING OFF 
GO
ALTER DATABASE [ListaToDo] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [ListaToDo] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [ListaToDo] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [ListaToDo] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'ListaToDo', N'ON'
GO
ALTER DATABASE [ListaToDo] SET QUERY_STORE = OFF
GO
USE [ListaToDo]
GO
/****** Object:  Table [dbo].[Categorias]    Script Date: 20/11/2021 20:56:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Categorias](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
	[FechaCreacion] [datetime] NULL,
 CONSTRAINT [PK_Categorias] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TodoListItems]    Script Date: 20/11/2021 20:56:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TodoListItems](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[FechaCreacion] [datetime] NOT NULL,
	[Titulo] [nvarchar](250) NOT NULL,
	[Prioridad] [int] NULL,
	[Fecha] [datetime] NULL,
	[Completada] [bit] NOT NULL,
	[IdCategoria] [int] NULL,
 CONSTRAINT [PK__TodoList__3214EC0726FD8FAD] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[Vista]    Script Date: 20/11/2021 20:56:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[Vista]
AS
SELECT        dbo.TodoListItems.Id, dbo.TodoListItems.Completada, dbo.TodoListItems.Titulo, dbo.TodoListItems.Fecha, dbo.TodoListItems.Prioridad, dbo.TodoListItems.FechaCreacion, dbo.Categorias.Nombre
FROM            dbo.Categorias INNER JOIN
                         dbo.TodoListItems ON dbo.Categorias.Id = dbo.TodoListItems.IdCategoria
GO
/****** Object:  Table [dbo].[CategoriaTarea]    Script Date: 20/11/2021 20:56:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CategoriaTarea](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[IdTarea] [int] NOT NULL,
	[IdCategoria] [int] NOT NULL,
 CONSTRAINT [PK_CategoriaTarea] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Usuarios]    Script Date: 20/11/2021 20:56:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuarios](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
	[Clave] [varchar](50) NOT NULL,
	[FechaCreacion] [date] NOT NULL,
 CONSTRAINT [PK_usuarios] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[TodoListItems] ADD  CONSTRAINT [DF__TodoListI__IsDon__300424B4]  DEFAULT ((0)) FOR [Completada]
GO
ALTER TABLE [dbo].[TodoListItems]  WITH CHECK ADD  CONSTRAINT [FK_TodoListItems_Categorias] FOREIGN KEY([IdCategoria])
REFERENCES [dbo].[Categorias] ([Id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[TodoListItems] CHECK CONSTRAINT [FK_TodoListItems_Categorias]
GO
/****** Object:  StoredProcedure [dbo].[GetCategoria]    Script Date: 20/11/2021 20:56:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[GetCategoria]
as
begin
select Id, Nombre, FechaCreacion from Categorias WITH(NOLOCK)
end
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "Categorias"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 119
               Right = 246
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "TodoListItems"
            Begin Extent = 
               Top = 6
               Left = 284
               Bottom = 202
               Right = 492
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Vista'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Vista'
GO
USE [master]
GO
ALTER DATABASE [ListaToDo] SET  READ_WRITE 
GO
