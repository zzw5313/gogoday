
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 12/22/2018 23:29:39
-- Generated from EDMX file: D:\张建勋\gogoday\gogoday\Models\Org.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [gogoday];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Agent]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Agent];
GO
IF OBJECT_ID(N'[dbo].[Company]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Company];
GO
IF OBJECT_ID(N'[dbo].[Customer]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Customer];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Agent'
CREATE TABLE [dbo].[Agent] (
    [AgentId] int IDENTITY(1,1) NOT NULL,
    [Code] nvarchar(50)  NULL,
    [PCode] nvarchar(50)  NULL,
    [AgentLevel] int  NULL,
    [AgentType] nvarchar(50)  NULL,
    [CustomerCount] int  NULL,
    [Name] nvarchar(50)  NULL,
    [CreateTime] datetime  NULL
);
GO

-- Creating table 'Company'
CREATE TABLE [dbo].[Company] (
    [CompanyId] int IDENTITY(1,1) NOT NULL,
    [Code] nvarchar(50)  NULL,
    [Name] nvarchar(50)  NULL,
    [CreateTime] datetime  NULL
);
GO

-- Creating table 'Customer'
CREATE TABLE [dbo].[Customer] (
    [CustomerId] int IDENTITY(1,1) NOT NULL,
    [Code] nvarchar(50)  NULL,
    [PCode] nvarchar(50)  NULL,
    [AgentId] int  NULL,
    [Name] nvarchar(50)  NULL,
    [CreateTime] datetime  NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [AgentId] in table 'Agent'
ALTER TABLE [dbo].[Agent]
ADD CONSTRAINT [PK_Agent]
    PRIMARY KEY CLUSTERED ([AgentId] ASC);
GO

-- Creating primary key on [CompanyId] in table 'Company'
ALTER TABLE [dbo].[Company]
ADD CONSTRAINT [PK_Company]
    PRIMARY KEY CLUSTERED ([CompanyId] ASC);
GO

-- Creating primary key on [CustomerId] in table 'Customer'
ALTER TABLE [dbo].[Customer]
ADD CONSTRAINT [PK_Customer]
    PRIMARY KEY CLUSTERED ([CustomerId] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------