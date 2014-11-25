
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 10/22/2014 19:03:26
-- Generated from EDMX file: C:\Users\Shelby\Desktop\411\IDScanner\IDScanner.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [SchoolTracker];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_Attendances_Students]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Attendances] DROP CONSTRAINT [FK_Attendances_Students];
GO
IF OBJECT_ID(N'[dbo].[FK_Schedule_Course]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Schedules] DROP CONSTRAINT [FK_Schedule_Course];
GO
IF OBJECT_ID(N'[dbo].[FK_Login_Faculty]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Logins] DROP CONSTRAINT [FK_Login_Faculty];
GO
IF OBJECT_ID(N'[dbo].[FK_Schedule_Student]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Schedules] DROP CONSTRAINT [FK_Schedule_Student];
GO
IF OBJECT_ID(N'[dbo].[FK_Courses_Faculties]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Courses] DROP CONSTRAINT [FK_Courses_Faculties];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Attendances]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Attendances];
GO
IF OBJECT_ID(N'[dbo].[Courses]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Courses];
GO
IF OBJECT_ID(N'[dbo].[Faculties]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Faculties];
GO
IF OBJECT_ID(N'[dbo].[Logins]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Logins];
GO
IF OBJECT_ID(N'[dbo].[Schedules]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Schedules];
GO
IF OBJECT_ID(N'[dbo].[Students]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Students];
GO
IF OBJECT_ID(N'[dbo].[sysdiagrams]', 'U') IS NOT NULL
    DROP TABLE [dbo].[sysdiagrams];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Attendances'
CREATE TABLE [dbo].[Attendances] (
    [SID] varchar(50)  NOT NULL,
    [Clock_In] datetime  NOT NULL,
    [Clock_Out] datetime  NULL
);
GO

-- Creating table 'Courses'
CREATE TABLE [dbo].[Courses] (
    [CID] varchar(50)  NOT NULL,
    [CourseName] varchar(50)  NOT NULL,
    [TimeStart] datetime  NOT NULL,
    [TimeEnd] datetime  NOT NULL,
    [Description] varchar(max)  NULL,
    [FID] varchar(50)  NULL
);
GO

-- Creating table 'Faculties'
CREATE TABLE [dbo].[Faculties] (
    [FID] varchar(50)  NOT NULL,
    [Fac_Fname] varchar(50)  NOT NULL,
    [Fac_Lname] varchar(50)  NOT NULL,
    [AccessLvl] int  NOT NULL
);
GO

-- Creating table 'Logins'
CREATE TABLE [dbo].[Logins] (
    [FID] varchar(50)  NOT NULL,
    [Password] varchar(50)  NOT NULL
);
GO

-- Creating table 'Schedules'
CREATE TABLE [dbo].[Schedules] (
    [ID] varchar(50)  NOT NULL,
    [CourseID] varchar(50)  NOT NULL
);
GO

-- Creating table 'Students'
CREATE TABLE [dbo].[Students] (
    [SID] varchar(50)  NOT NULL,
    [Fname] varchar(50)  NOT NULL,
    [Lname] varchar(50)  NOT NULL
);
GO

-- Creating table 'sysdiagrams'
CREATE TABLE [dbo].[sysdiagrams] (
    [name] nvarchar(128)  NOT NULL,
    [principal_id] int  NOT NULL,
    [diagram_id] int IDENTITY(1,1) NOT NULL,
    [version] int  NULL,
    [definition] varbinary(max)  NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [SID] in table 'Attendances'
ALTER TABLE [dbo].[Attendances]
ADD CONSTRAINT [PK_Attendances]
    PRIMARY KEY CLUSTERED ([SID] ASC);
GO

-- Creating primary key on [CID] in table 'Courses'
ALTER TABLE [dbo].[Courses]
ADD CONSTRAINT [PK_Courses]
    PRIMARY KEY CLUSTERED ([CID] ASC);
GO

-- Creating primary key on [FID] in table 'Faculties'
ALTER TABLE [dbo].[Faculties]
ADD CONSTRAINT [PK_Faculties]
    PRIMARY KEY CLUSTERED ([FID] ASC);
GO

-- Creating primary key on [FID] in table 'Logins'
ALTER TABLE [dbo].[Logins]
ADD CONSTRAINT [PK_Logins]
    PRIMARY KEY CLUSTERED ([FID] ASC);
GO

-- Creating primary key on [ID], [CourseID] in table 'Schedules'
ALTER TABLE [dbo].[Schedules]
ADD CONSTRAINT [PK_Schedules]
    PRIMARY KEY CLUSTERED ([ID], [CourseID] ASC);
GO

-- Creating primary key on [SID] in table 'Students'
ALTER TABLE [dbo].[Students]
ADD CONSTRAINT [PK_Students]
    PRIMARY KEY CLUSTERED ([SID] ASC);
GO

-- Creating primary key on [diagram_id] in table 'sysdiagrams'
ALTER TABLE [dbo].[sysdiagrams]
ADD CONSTRAINT [PK_sysdiagrams]
    PRIMARY KEY CLUSTERED ([diagram_id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [SID] in table 'Attendances'
ALTER TABLE [dbo].[Attendances]
ADD CONSTRAINT [FK_Attendances_Students]
    FOREIGN KEY ([SID])
    REFERENCES [dbo].[Students]
        ([SID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [CourseID] in table 'Schedules'
ALTER TABLE [dbo].[Schedules]
ADD CONSTRAINT [FK_Schedule_Course]
    FOREIGN KEY ([CourseID])
    REFERENCES [dbo].[Courses]
        ([CID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_Schedule_Course'
CREATE INDEX [IX_FK_Schedule_Course]
ON [dbo].[Schedules]
    ([CourseID]);
GO

-- Creating foreign key on [FID] in table 'Logins'
ALTER TABLE [dbo].[Logins]
ADD CONSTRAINT [FK_Login_Faculty]
    FOREIGN KEY ([FID])
    REFERENCES [dbo].[Faculties]
        ([FID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [ID] in table 'Schedules'
ALTER TABLE [dbo].[Schedules]
ADD CONSTRAINT [FK_Schedule_Student]
    FOREIGN KEY ([ID])
    REFERENCES [dbo].[Students]
        ([SID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [FID] in table 'Courses'
ALTER TABLE [dbo].[Courses]
ADD CONSTRAINT [FK_Courses_Faculties]
    FOREIGN KEY ([FID])
    REFERENCES [dbo].[Faculties]
        ([FID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_Courses_Faculties'
CREATE INDEX [IX_FK_Courses_Faculties]
ON [dbo].[Courses]
    ([FID]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------