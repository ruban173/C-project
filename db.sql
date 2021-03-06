USE [PAO]
GO
/****** Object:  Table [dbo].[Employees]    Script Date: 11.12.2017 22:36:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Employees](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[first_name] [nvarchar](50) NULL,
	[middle_name] [nvarchar](50) NULL,
	[last_name] [nvarchar](50) NULL,
	[id_user_access] [int] NULL,
	[birthday] [date] NULL,
	[position] [nvarchar](50) NULL,
	[id_subsidiary_companies_region] [int] NULL,
	[id_education] [int] NULL,
	[expiriens] [nvarchar](10) NULL,
	[date_begin] [date] NULL,
	[date_up] [datetime] NOT NULL,
	[date_end] [date] NULL,
 CONSTRAINT [PK_Employees] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Employees_education]    Script Date: 11.12.2017 22:36:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Employees_education](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[id_employees] [int] NULL,
	[type] [nvarchar](50) NULL,
	[organization] [nvarchar](500) NULL,
	[date_create] [date] NULL,
	[number] [int] NULL,
	[qualification] [nvarchar](100) NULL,
	[specialty] [nvarchar](100) NULL,
	[date_up] [datetime] NULL,
 CONSTRAINT [PK_Сотрудники_образование] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Goods]    Script Date: 11.12.2017 22:36:51 ******/
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
	[date_end] [date] NULL,
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
/****** Object:  Table [dbo].[Goods_category]    Script Date: 11.12.2017 22:36:51 ******/
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
/****** Object:  Table [dbo].[Sale]    Script Date: 11.12.2017 22:36:51 ******/
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
/****** Object:  Table [dbo].[Sale_basket]    Script Date: 11.12.2017 22:36:51 ******/
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
/****** Object:  Table [dbo].[Subsidiary_companies]    Script Date: 11.12.2017 22:36:51 ******/
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
/****** Object:  Table [dbo].[Subsidiary_companies_region]    Script Date: 11.12.2017 22:36:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Subsidiary_companies_region](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[id_subsidiary_companies] [int] NULL,
	[city] [nvarchar](50) NULL,
	[adress] [nvarchar](300) NULL,
	[latitude] [nvarchar](50) NULL,
	[longitude] [varchar](50) NULL,
 CONSTRAINT [PK_Дочерние_компании_расположение] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[User_access]    Script Date: 11.12.2017 22:36:51 ******/
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
	[date_up] [datetime] NULL,
	[status] [nvarchar](15) NULL CONSTRAINT [DF_UserAccess_status]  DEFAULT (N'Активен'),
 CONSTRAINT [PK_dbo.UserAccesses] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[UserAccess_history]    Script Date: 11.12.2017 22:36:51 ******/
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
/****** Object:  Table [dbo].[Компания]    Script Date: 11.12.2017 22:36:51 ******/
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
/****** Object:  Table [dbo].[Продажи]    Script Date: 11.12.2017 22:36:51 ******/
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
ALTER TABLE [dbo].[Employees]  WITH CHECK ADD  CONSTRAINT [FK_Employees_Employees_education] FOREIGN KEY([id_education])
REFERENCES [dbo].[Employees_education] ([id])
GO
ALTER TABLE [dbo].[Employees] CHECK CONSTRAINT [FK_Employees_Employees_education]
GO
ALTER TABLE [dbo].[Employees]  WITH CHECK ADD  CONSTRAINT [FK_Employees_User_access] FOREIGN KEY([id_user_access])
REFERENCES [dbo].[User_access] ([id])
ON DELETE SET NULL
GO
ALTER TABLE [dbo].[Employees] CHECK CONSTRAINT [FK_Employees_User_access]
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
ON DELETE CASCADE
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
ON DELETE SET NULL
GO
ALTER TABLE [dbo].[Subsidiary_companies_region] CHECK CONSTRAINT [FK_Subsidiary_companies_region_Subsidiary_companies]
GO
