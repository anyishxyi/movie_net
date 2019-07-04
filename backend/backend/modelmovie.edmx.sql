
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 07/04/2019 14:47:16
-- Generated from EDMX file: C:\Users\Mes-vms.fr\Documents\dotnet\group-698762\backend\backend\modelmovie.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [moviebdd];
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

-- Creating table 'userSet'
CREATE TABLE [dbo].[userSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [username] nvarchar(max)  NOT NULL,
    [password] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'movieSet'
CREATE TABLE [dbo].[movieSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [title] nvarchar(max)  NOT NULL,
    [category] nvarchar(max)  NOT NULL,
    [synopsys] nvarchar(max)  NOT NULL,
    [actors] nvarchar(max)  NOT NULL,
    [date] nvarchar(max)  NOT NULL,
    [productors] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'commentsSet1'
CREATE TABLE [dbo].[commentsSet1] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [comment] nvarchar(max)  NOT NULL,
    [Entity1_Id] int  NOT NULL,
    [Entity2_Id] int  NOT NULL
);
GO

-- Creating table 'notesSet'
CREATE TABLE [dbo].[notesSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [note] nvarchar(max)  NOT NULL,
    [Entity1_Id] int  NOT NULL,
    [Entity2_Id] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'userSet'
ALTER TABLE [dbo].[userSet]
ADD CONSTRAINT [PK_userSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'movieSet'
ALTER TABLE [dbo].[movieSet]
ADD CONSTRAINT [PK_movieSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'commentsSet1'
ALTER TABLE [dbo].[commentsSet1]
ADD CONSTRAINT [PK_commentsSet1]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'notesSet'
ALTER TABLE [dbo].[notesSet]
ADD CONSTRAINT [PK_notesSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [Entity1_Id] in table 'commentsSet1'
ALTER TABLE [dbo].[commentsSet1]
ADD CONSTRAINT [FK_Entity1Entity3]
    FOREIGN KEY ([Entity1_Id])
    REFERENCES [dbo].[userSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Entity1Entity3'
CREATE INDEX [IX_FK_Entity1Entity3]
ON [dbo].[commentsSet1]
    ([Entity1_Id]);
GO

-- Creating foreign key on [Entity2_Id] in table 'commentsSet1'
ALTER TABLE [dbo].[commentsSet1]
ADD CONSTRAINT [FK_Entity2Entity3]
    FOREIGN KEY ([Entity2_Id])
    REFERENCES [dbo].[movieSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Entity2Entity3'
CREATE INDEX [IX_FK_Entity2Entity3]
ON [dbo].[commentsSet1]
    ([Entity2_Id]);
GO

-- Creating foreign key on [Entity1_Id] in table 'notesSet'
ALTER TABLE [dbo].[notesSet]
ADD CONSTRAINT [FK_Entity1Entity4]
    FOREIGN KEY ([Entity1_Id])
    REFERENCES [dbo].[userSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Entity1Entity4'
CREATE INDEX [IX_FK_Entity1Entity4]
ON [dbo].[notesSet]
    ([Entity1_Id]);
GO

-- Creating foreign key on [Entity2_Id] in table 'notesSet'
ALTER TABLE [dbo].[notesSet]
ADD CONSTRAINT [FK_Entity2Entity4]
    FOREIGN KEY ([Entity2_Id])
    REFERENCES [dbo].[movieSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Entity2Entity4'
CREATE INDEX [IX_FK_Entity2Entity4]
ON [dbo].[notesSet]
    ([Entity2_Id]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------