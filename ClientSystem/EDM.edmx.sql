
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 12/11/2017 10:44:57
-- Generated from EDMX file: C:\C-project\ClientSystem\EDM.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [PAO];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_Employees_Employees_education]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Employees] DROP CONSTRAINT [FK_Employees_Employees_education];
GO
IF OBJECT_ID(N'[dbo].[FK_Employees_User_access]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Employees] DROP CONSTRAINT [FK_Employees_User_access];
GO
IF OBJECT_ID(N'[dbo].[FK_Goods_Goods_category]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Goods] DROP CONSTRAINT [FK_Goods_Goods_category];
GO
IF OBJECT_ID(N'[dbo].[FK_Goods_Subsidiary_companies_region]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Goods] DROP CONSTRAINT [FK_Goods_Subsidiary_companies_region];
GO
IF OBJECT_ID(N'[dbo].[FK_Sale_basket_Goods]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Sale_basket] DROP CONSTRAINT [FK_Sale_basket_Goods];
GO
IF OBJECT_ID(N'[dbo].[FK_Sale_basket_Sale]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Sale_basket] DROP CONSTRAINT [FK_Sale_basket_Sale];
GO
IF OBJECT_ID(N'[dbo].[FK_Sale_Subsidiary_companies_region]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Sale] DROP CONSTRAINT [FK_Sale_Subsidiary_companies_region];
GO
IF OBJECT_ID(N'[dbo].[FK_Subsidiary_companies_region_Subsidiary_companies]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Subsidiary_companies_region] DROP CONSTRAINT [FK_Subsidiary_companies_region_Subsidiary_companies];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Employees]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Employees];
GO
IF OBJECT_ID(N'[dbo].[Employees_education]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Employees_education];
GO
IF OBJECT_ID(N'[dbo].[Goods]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Goods];
GO
IF OBJECT_ID(N'[dbo].[Goods_category]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Goods_category];
GO
IF OBJECT_ID(N'[dbo].[Sale]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Sale];
GO
IF OBJECT_ID(N'[dbo].[Sale_basket]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Sale_basket];
GO
IF OBJECT_ID(N'[dbo].[Subsidiary_companies]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Subsidiary_companies];
GO
IF OBJECT_ID(N'[dbo].[Subsidiary_companies_region]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Subsidiary_companies_region];
GO
IF OBJECT_ID(N'[dbo].[User_access]', 'U') IS NOT NULL
    DROP TABLE [dbo].[User_access];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Subsidiary_companies'
CREATE TABLE [dbo].[Subsidiary_companies] (
    [id] int IDENTITY(1,1) NOT NULL,
    [title] nvarchar(100)  NULL,
    [description] varchar(max)  NULL,
    [activity] nvarchar(150)  NULL,
    [date_up] datetime  NOT NULL
);
GO

-- Creating table 'Subsidiary_companies_region'
CREATE TABLE [dbo].[Subsidiary_companies_region] (
    [id] int IDENTITY(1,1) NOT NULL,
    [id_subsidiary_companies] int  NULL,
    [country] nvarchar(15)  NULL,
    [region] nvarchar(30)  NULL,
    [settlement] nvarchar(50)  NULL,
    [street] nvarchar(70)  NULL,
    [home] int  NULL,
    [number] int  NULL,
    [structure] int  NULL
);
GO

-- Creating table 'Goods_category'
CREATE TABLE [dbo].[Goods_category] (
    [id] int IDENTITY(1,1) NOT NULL,
    [title] nvarchar(50)  NULL,
    [date_up] datetime  NOT NULL
);
GO

-- Creating table 'Sale_basket'
CREATE TABLE [dbo].[Sale_basket] (
    [id] int IDENTITY(1,1) NOT NULL,
    [id_goods] int  NULL,
    [id_sale] int  NULL
);
GO

-- Creating table 'Sale'
CREATE TABLE [dbo].[Sale] (
    [id] int IDENTITY(1,1) NOT NULL,
    [id_employess] int  NULL,
    [discont] decimal(18,0)  NULL,
    [payment] decimal(18,0)  NULL,
    [price] decimal(18,0)  NULL,
    [id_subsidiary_companies_region] int  NULL,
    [date_up] datetime  NOT NULL
);
GO

-- Creating table 'Goods'
CREATE TABLE [dbo].[Goods] (
    [id] int IDENTITY(1,1) NOT NULL,
    [title] nvarchar(50)  NULL,
    [manufacturer] nvarchar(100)  NULL,
    [description] nvarchar(1000)  NULL,
    [id_goods_category] int  NULL,
    [id_subsidiary_companies_region] int  NULL,
    [shelf_life] int  NULL,
    [date_create] datetime  NULL,
    [price] decimal(18,0)  NULL,
    [discont] float  NULL,
    [measurement] nvarchar(50)  NULL,
    [count] int  NULL,
    [code] nvarchar(30)  NULL,
    [basket] nvarchar(50)  NULL,
    [status] nvarchar(15)  NULL,
    [date_end] datetime  NULL
);
GO

-- Creating table 'Employees_education'
CREATE TABLE [dbo].[Employees_education] (
    [id] int IDENTITY(1,1) NOT NULL,
    [id_employees] int  NULL,
    [type] nvarchar(50)  NULL,
    [organization] nvarchar(500)  NULL,
    [date_create] datetime  NULL,
    [number] int  NULL,
    [qualification] nvarchar(100)  NULL,
    [specialty] nvarchar(100)  NULL,
    [date_up] datetime  NULL
);
GO

-- Creating table 'Employees'
CREATE TABLE [dbo].[Employees] (
    [id] int IDENTITY(1,1) NOT NULL,
    [first_name] nvarchar(50)  NULL,
    [middle_name] nvarchar(50)  NULL,
    [last_name] nvarchar(50)  NULL,
    [id_user_access] int  NULL,
    [birthday] datetime  NULL,
    [position] nvarchar(50)  NULL,
    [id_subsidiary_companies_region] int  NULL,
    [id_education] int  NULL,
    [expiriens] nvarchar(10)  NULL,
    [date_begin] datetime  NULL,
    [date_up] datetime  NOT NULL,
    [date_end] datetime  NULL
);
GO

-- Creating table 'User_access'
CREATE TABLE [dbo].[User_access] (
    [id] int IDENTITY(1,1) NOT NULL,
    [login] nvarchar(64)  NULL,
    [password] nvarchar(128)  NULL,
    [type] nvarchar(20)  NULL,
    [id_subsidiary_companies_region] int  NULL,
    [date_up] datetime  NULL,
    [status] nvarchar(15)  NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [id] in table 'Subsidiary_companies'
ALTER TABLE [dbo].[Subsidiary_companies]
ADD CONSTRAINT [PK_Subsidiary_companies]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- Creating primary key on [id] in table 'Subsidiary_companies_region'
ALTER TABLE [dbo].[Subsidiary_companies_region]
ADD CONSTRAINT [PK_Subsidiary_companies_region]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- Creating primary key on [id] in table 'Goods_category'
ALTER TABLE [dbo].[Goods_category]
ADD CONSTRAINT [PK_Goods_category]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- Creating primary key on [id] in table 'Sale_basket'
ALTER TABLE [dbo].[Sale_basket]
ADD CONSTRAINT [PK_Sale_basket]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- Creating primary key on [id] in table 'Sale'
ALTER TABLE [dbo].[Sale]
ADD CONSTRAINT [PK_Sale]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- Creating primary key on [id] in table 'Goods'
ALTER TABLE [dbo].[Goods]
ADD CONSTRAINT [PK_Goods]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- Creating primary key on [id] in table 'Employees_education'
ALTER TABLE [dbo].[Employees_education]
ADD CONSTRAINT [PK_Employees_education]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- Creating primary key on [id] in table 'Employees'
ALTER TABLE [dbo].[Employees]
ADD CONSTRAINT [PK_Employees]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- Creating primary key on [id] in table 'User_access'
ALTER TABLE [dbo].[User_access]
ADD CONSTRAINT [PK_User_access]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [id_subsidiary_companies] in table 'Subsidiary_companies_region'
ALTER TABLE [dbo].[Subsidiary_companies_region]
ADD CONSTRAINT [FK_Subsidiary_companies_region_Subsidiary_companies]
    FOREIGN KEY ([id_subsidiary_companies])
    REFERENCES [dbo].[Subsidiary_companies]
        ([id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Subsidiary_companies_region_Subsidiary_companies'
CREATE INDEX [IX_FK_Subsidiary_companies_region_Subsidiary_companies]
ON [dbo].[Subsidiary_companies_region]
    ([id_subsidiary_companies]);
GO

-- Creating foreign key on [id_sale] in table 'Sale_basket'
ALTER TABLE [dbo].[Sale_basket]
ADD CONSTRAINT [FK_Sale_basket_Sale]
    FOREIGN KEY ([id_sale])
    REFERENCES [dbo].[Sale]
        ([id])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Sale_basket_Sale'
CREATE INDEX [IX_FK_Sale_basket_Sale]
ON [dbo].[Sale_basket]
    ([id_sale]);
GO

-- Creating foreign key on [id_subsidiary_companies_region] in table 'Sale'
ALTER TABLE [dbo].[Sale]
ADD CONSTRAINT [FK_Sale_Subsidiary_companies_region]
    FOREIGN KEY ([id_subsidiary_companies_region])
    REFERENCES [dbo].[Subsidiary_companies_region]
        ([id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Sale_Subsidiary_companies_region'
CREATE INDEX [IX_FK_Sale_Subsidiary_companies_region]
ON [dbo].[Sale]
    ([id_subsidiary_companies_region]);
GO

-- Creating foreign key on [id_goods_category] in table 'Goods'
ALTER TABLE [dbo].[Goods]
ADD CONSTRAINT [FK_Goods_Goods_category]
    FOREIGN KEY ([id_goods_category])
    REFERENCES [dbo].[Goods_category]
        ([id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Goods_Goods_category'
CREATE INDEX [IX_FK_Goods_Goods_category]
ON [dbo].[Goods]
    ([id_goods_category]);
GO

-- Creating foreign key on [id_subsidiary_companies_region] in table 'Goods'
ALTER TABLE [dbo].[Goods]
ADD CONSTRAINT [FK_Goods_Subsidiary_companies_region]
    FOREIGN KEY ([id_subsidiary_companies_region])
    REFERENCES [dbo].[Subsidiary_companies_region]
        ([id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Goods_Subsidiary_companies_region'
CREATE INDEX [IX_FK_Goods_Subsidiary_companies_region]
ON [dbo].[Goods]
    ([id_subsidiary_companies_region]);
GO

-- Creating foreign key on [id_goods] in table 'Sale_basket'
ALTER TABLE [dbo].[Sale_basket]
ADD CONSTRAINT [FK_Sale_basket_Goods]
    FOREIGN KEY ([id_goods])
    REFERENCES [dbo].[Goods]
        ([id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Sale_basket_Goods'
CREATE INDEX [IX_FK_Sale_basket_Goods]
ON [dbo].[Sale_basket]
    ([id_goods]);
GO

-- Creating foreign key on [id_education] in table 'Employees'
ALTER TABLE [dbo].[Employees]
ADD CONSTRAINT [FK_Employees_Employees_education]
    FOREIGN KEY ([id_education])
    REFERENCES [dbo].[Employees_education]
        ([id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Employees_Employees_education'
CREATE INDEX [IX_FK_Employees_Employees_education]
ON [dbo].[Employees]
    ([id_education]);
GO

-- Creating foreign key on [id_user_access] in table 'Employees'
ALTER TABLE [dbo].[Employees]
ADD CONSTRAINT [FK_Employees_User_access]
    FOREIGN KEY ([id_user_access])
    REFERENCES [dbo].[User_access]
        ([id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Employees_User_access'
CREATE INDEX [IX_FK_Employees_User_access]
ON [dbo].[Employees]
    ([id_user_access]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------