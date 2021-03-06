USE [master]
GO
/****** Object:  Database [Grand_Video_Store]    Script Date: 30-07-2021 1.04.50 AM ******/
CREATE DATABASE [Grand_Video_Store]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Grand_Book_Store_Data', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\Grand_Book_Store.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'Grand_Book_Store_Log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\Grand_Book_Store.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [Grand_Video_Store] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Grand_Video_Store].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Grand_Video_Store] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Grand_Video_Store] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Grand_Video_Store] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Grand_Video_Store] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Grand_Video_Store] SET ARITHABORT OFF 
GO
ALTER DATABASE [Grand_Video_Store] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Grand_Video_Store] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Grand_Video_Store] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Grand_Video_Store] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Grand_Video_Store] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Grand_Video_Store] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Grand_Video_Store] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Grand_Video_Store] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Grand_Video_Store] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Grand_Video_Store] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Grand_Video_Store] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Grand_Video_Store] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Grand_Video_Store] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Grand_Video_Store] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Grand_Video_Store] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Grand_Video_Store] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Grand_Video_Store] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Grand_Video_Store] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Grand_Video_Store] SET  MULTI_USER 
GO
ALTER DATABASE [Grand_Video_Store] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Grand_Video_Store] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Grand_Video_Store] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Grand_Video_Store] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Grand_Video_Store] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Grand_Video_Store] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'Grand_Video_Store', N'ON'
GO
ALTER DATABASE [Grand_Video_Store] SET QUERY_STORE = OFF
GO
USE [Grand_Video_Store]
GO
/****** Object:  Table [dbo].[Books]    Script Date: 30-07-2021 1.04.50 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Books](
	[BookId] [int] IDENTITY(1,1) NOT NULL,
	[Title] [nchar](100) NULL,
	[Ratting] [nchar](100) NULL,
	[Year] [nchar](100) NULL,
	[Copies] [nchar](100) NULL,
	[Plot] [nchar](100) NULL,
	[Genre] [nchar](100) NULL,
	[Cost] [nchar](100) NULL,
 CONSTRAINT [PK_Books] PRIMARY KEY CLUSTERED 
(
	[BookId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Customers]    Script Date: 30-07-2021 1.04.51 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Customers](
	[CustomerId] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nchar](100) NULL,
	[Email] [nchar](100) NULL,
	[Mobile] [nchar](100) NULL,
	[Address] [nchar](100) NULL,
 CONSTRAINT [PK_Customers] PRIMARY KEY CLUSTERED 
(
	[CustomerId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Rentals]    Script Date: 30-07-2021 1.04.51 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Rentals](
	[RentalId] [int] IDENTITY(1,1) NOT NULL,
	[BookId] [int] NULL,
	[CustomerId] [int] NULL,
	[IssueDate] [nchar](100) NULL,
	[ReturnDate] [nchar](100) NULL,
 CONSTRAINT [PK_Rentals] PRIMARY KEY CLUSTERED 
(
	[RentalId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Books] ON 

INSERT [dbo].[Books] ([BookId], [Title], [Ratting], [Year], [Copies], [Plot], [Genre], [Cost]) VALUES (3, N'Jungle Bell                                                                                         ', N'5                                                                                                   ', N'2012                                                                                                ', N'10                                                                                                  ', N'Good                                                                                                ', N'Good                                                                                                ', N'2                                                                                                   ')
SET IDENTITY_INSERT [dbo].[Books] OFF
GO
SET IDENTITY_INSERT [dbo].[Customers] ON 

INSERT [dbo].[Customers] ([CustomerId], [Name], [Email], [Mobile], [Address]) VALUES (5, N'Peter                                                                                               ', N'peter@gmail.com                                                                                     ', N'9874548                                                                                             ', N'Papatoe                                                                                             ')
SET IDENTITY_INSERT [dbo].[Customers] OFF
GO
USE [master]
GO
ALTER DATABASE [Grand_Video_Store] SET  READ_WRITE 
GO
