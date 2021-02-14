
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 02/13/2021 20:31:50
-- Generated from EDMX file: C:\Users\Zito\source\repos\byronrainier\ProgramacionCSharp\Clase\CourseManagment.Conceptual\CourseAdmModel.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [ShopDb];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------


-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Departaments'
CREATE TABLE [dbo].[Departaments] (
    [DepartamentId] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(50)  NOT NULL,
    [Budget] decimal(18,0)  NOT NULL,
    [StartDate] datetime  NOT NULL,
    [Administrator] int  NULL
);
GO

-- Creating table 'Courses'
CREATE TABLE [dbo].[Courses] (
    [CourseId] int IDENTITY(1,1) NOT NULL,
    [Title] nvarchar(50)  NOT NULL,
    [Credits] smallint  NOT NULL,
    [DepartamentDepartamentId] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [DepartamentId] in table 'Departaments'
ALTER TABLE [dbo].[Departaments]
ADD CONSTRAINT [PK_Departaments]
    PRIMARY KEY CLUSTERED ([DepartamentId] ASC);
GO

-- Creating primary key on [CourseId] in table 'Courses'
ALTER TABLE [dbo].[Courses]
ADD CONSTRAINT [PK_Courses]
    PRIMARY KEY CLUSTERED ([CourseId] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [DepartamentDepartamentId] in table 'Courses'
ALTER TABLE [dbo].[Courses]
ADD CONSTRAINT [FK_DepartamentCourse]
    FOREIGN KEY ([DepartamentDepartamentId])
    REFERENCES [dbo].[Departaments]
        ([DepartamentId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_DepartamentCourse'
CREATE INDEX [IX_FK_DepartamentCourse]
ON [dbo].[Courses]
    ([DepartamentDepartamentId]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------