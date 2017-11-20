USE [master]
GO
/****** Object:  Database [PAO]    Script Date: 20.11.2017 22:27:09 ******/
CREATE DATABASE [PAO]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'ПАО Магнит', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\ПАО Магнит.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'ПАО Магнит_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\ПАО Магнит_log.ldf' , SIZE = 2048KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [PAO] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [PAO].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [PAO] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [PAO] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [PAO] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [PAO] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [PAO] SET ARITHABORT OFF 
GO
ALTER DATABASE [PAO] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [PAO] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [PAO] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [PAO] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [PAO] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [PAO] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [PAO] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [PAO] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [PAO] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [PAO] SET  DISABLE_BROKER 
GO
ALTER DATABASE [PAO] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [PAO] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [PAO] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [PAO] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [PAO] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [PAO] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [PAO] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [PAO] SET RECOVERY FULL 
GO
ALTER DATABASE [PAO] SET  MULTI_USER 
GO
ALTER DATABASE [PAO] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [PAO] SET DB_CHAINING OFF 
GO
ALTER DATABASE [PAO] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [PAO] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [PAO] SET DELAYED_DURABILITY = DISABLED 
GO
USE [PAO]
GO
/****** Object:  User [sas]    Script Date: 20.11.2017 22:27:09 ******/
CREATE USER [sas] FOR LOGIN [sas] WITH DEFAULT_SCHEMA=[dbo]
GO
ALTER ROLE [db_owner] ADD MEMBER [sas]
GO
/****** Object:  Table [dbo].[Employees]    Script Date: 20.11.2017 22:27:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Employees](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[first_name] [nvarchar](50) NULL,
	[middle__name] [nvarchar](50) NULL,
	[last_name] [nvarchar](50) NULL,
	[id_user_access] [int] NULL,
	[birthday] [date] NULL,
	[position] [nvarchar](50) NULL,
	[id_subsidiary_companies_region] [int] NULL,
	[id_education] [int] NULL,
	[foto] [image] NULL,
	[expiriens] [nvarchar](10) NULL,
	[date_begin] [date] NULL,
	[date_up]  AS (getdate()),
	[date_end] [date] NULL,
 CONSTRAINT [PK_Employees] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Employees_education]    Script Date: 20.11.2017 22:27:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Employees_education](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[id_сотрудника] [int] NULL,
	[тип] [nvarchar](50) NULL,
	[учебное_заведение] [nvarchar](500) NULL,
	[дата_получения] [date] NULL,
	[номер] [int] NULL,
	[квалификация] [nvarchar](100) NULL,
	[специальность] [nvarchar](100) NULL,
	[дата_обновления]  AS (getdate()),
 CONSTRAINT [PK_Сотрудники_образование] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Goods]    Script Date: 20.11.2017 22:27:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Goods](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[title] [nvarchar](50) NULL,
	[manufacturer] [nvarchar](100) NULL,
	[description] [nvarchar](1000) NULL,
	[id_goods_category] [int] NULL,
	[id_subsidiary_companies_region] [int] NULL,
	[shelf_life] [int] NULL,
	[date_create] [date] NULL,
	[price] [decimal](18, 0) NULL CONSTRAINT [DF_Goods_price]  DEFAULT ((0)),
	[discont] [float] NULL CONSTRAINT [DF_Goods_discont]  DEFAULT ((0)),
	[measurement] [nvarchar](50) NULL,
	[count] [int] NULL,
	[code] [nvarchar](30) NULL,
	[basket] [nvarchar](50) NULL CONSTRAINT [DF_Goods_basket]  DEFAULT (N'продается'),
	[status] [nvarchar](15) NULL,
 CONSTRAINT [PK_Товары] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Goods_category]    Script Date: 20.11.2017 22:27:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Goods_category](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[title] [nvarchar](50) NULL,
	[date_up] [datetime] NOT NULL,
 CONSTRAINT [PK_Товары_категории] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Sale]    Script Date: 20.11.2017 22:27:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sale](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[id_employess] [int] NULL,
	[discont] [decimal](18, 0) NULL,
	[payment] [decimal](18, 0) NULL,
	[price] [decimal](18, 0) NULL,
	[id_subsidiary_companies_region] [int] NULL,
	[date_up] [datetime] NOT NULL,
 CONSTRAINT [PK_Склад] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Sale_basket]    Script Date: 20.11.2017 22:27:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sale_basket](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[id_goods] [int] NULL,
	[id_sale] [int] NULL,
 CONSTRAINT [PK_Sale_basket] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Subsidiary_companies]    Script Date: 20.11.2017 22:27:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Subsidiary_companies](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[title] [nvarchar](100) NULL,
	[description] [text] NULL,
	[activity] [nvarchar](150) NULL,
	[date_up]  AS (getdate()),
 CONSTRAINT [PK_Дочерние_компании] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Subsidiary_companies_region]    Script Date: 20.11.2017 22:27:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Subsidiary_companies_region](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[id_subsidiary_companies] [int] NULL,
	[country] [nvarchar](15) NULL,
	[region] [nvarchar](30) NULL,
	[settlement] [nvarchar](50) NULL,
	[street] [nvarchar](70) NULL,
	[home] [int] NULL,
	[number] [int] NULL,
	[structure] [int] NULL,
 CONSTRAINT [PK_Дочерние_компании_расположение] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[User_access]    Script Date: 20.11.2017 22:27:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[User_access](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[login] [nvarchar](64) NULL,
	[password] [nvarchar](128) NULL,
	[type] [nvarchar](20) NULL,
	[id_subsidiary_companies_region] [int] NULL,
	[date_up]  AS (getdate()),
	[status] [nvarchar](10) NULL CONSTRAINT [DF_UserAccess_status]  DEFAULT (N'Активен'),
 CONSTRAINT [PK_dbo.UserAccesses] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[UserAccess_history]    Script Date: 20.11.2017 22:27:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UserAccess_history](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[id_доступа_пользователя] [int] NULL,
	[дата_входа]  AS (getdate()),
	[дата_выхода] [date] NULL,
 CONSTRAINT [PK_Доступ_пользователи_история] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Компания]    Script Date: 20.11.2017 22:27:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Компания](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[название] [nvarchar](100) NULL,
	[описание] [text] NULL,
	[дата_обновления]  AS (getdate()),
 CONSTRAINT [PK_Компания] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Продажи]    Script Date: 20.11.2017 22:27:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Продажи](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[id_дочерней_компании_расположение] [int] NULL,
	[id_сотрудника] [int] NULL,
	[id_товара] [int] NULL,
	[рабочее_место] [int] NULL,
	[дата_продажи]  AS (getdate()),
	[статус] [nvarchar](20) NULL,
 CONSTRAINT [PK_Продажи] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
ALTER TABLE [dbo].[Employees]  WITH CHECK ADD  CONSTRAINT [FK_Employees_User_access1] FOREIGN KEY([id_user_access])
REFERENCES [dbo].[User_access] ([id])
GO
ALTER TABLE [dbo].[Employees] CHECK CONSTRAINT [FK_Employees_User_access1]
GO
ALTER TABLE [dbo].[Goods]  WITH CHECK ADD  CONSTRAINT [FK_Goods_Goods_category] FOREIGN KEY([id_goods_category])
REFERENCES [dbo].[Goods_category] ([id])
ON UPDATE CASCADE
ON DELETE SET NULL
GO
ALTER TABLE [dbo].[Goods] CHECK CONSTRAINT [FK_Goods_Goods_category]
GO
ALTER TABLE [dbo].[Goods]  WITH CHECK ADD  CONSTRAINT [FK_Goods_Subsidiary_companies_region] FOREIGN KEY([id_subsidiary_companies_region])
REFERENCES [dbo].[Subsidiary_companies_region] ([id])
ON UPDATE CASCADE
ON DELETE SET NULL
GO
ALTER TABLE [dbo].[Goods] CHECK CONSTRAINT [FK_Goods_Subsidiary_companies_region]
GO
ALTER TABLE [dbo].[Sale]  WITH CHECK ADD  CONSTRAINT [FK_Sale_Subsidiary_companies_region] FOREIGN KEY([id_subsidiary_companies_region])
REFERENCES [dbo].[Subsidiary_companies_region] ([id])
GO
ALTER TABLE [dbo].[Sale] CHECK CONSTRAINT [FK_Sale_Subsidiary_companies_region]
GO
ALTER TABLE [dbo].[Sale_basket]  WITH CHECK ADD  CONSTRAINT [FK_Sale_basket_Goods] FOREIGN KEY([id_goods])
REFERENCES [dbo].[Goods] ([id])
GO
ALTER TABLE [dbo].[Sale_basket] CHECK CONSTRAINT [FK_Sale_basket_Goods]
GO
ALTER TABLE [dbo].[Sale_basket]  WITH CHECK ADD  CONSTRAINT [FK_Sale_basket_Sale] FOREIGN KEY([id_sale])
REFERENCES [dbo].[Sale] ([id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Sale_basket] CHECK CONSTRAINT [FK_Sale_basket_Sale]
GO
ALTER TABLE [dbo].[Subsidiary_companies_region]  WITH CHECK ADD  CONSTRAINT [FK_Subsidiary_companies_region_Subsidiary_companies] FOREIGN KEY([id_subsidiary_companies])
REFERENCES [dbo].[Subsidiary_companies] ([id])
GO
ALTER TABLE [dbo].[Subsidiary_companies_region] CHECK CONSTRAINT [FK_Subsidiary_companies_region_Subsidiary_companies]
GO
USE [master]
GO
ALTER DATABASE [PAO] SET  READ_WRITE 
GO
