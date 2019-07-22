
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 07/23/2019 00:24:22
-- Generated from EDMX file: C:\Users\Mes-vms.fr\Documents\dotnet\group-698762\Movies\backend\modelmovie.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [MovieDataBase];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_usercomments]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[commentsSet1] DROP CONSTRAINT [FK_usercomments];
GO
IF OBJECT_ID(N'[dbo].[FK_moviecomments]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[commentsSet1] DROP CONSTRAINT [FK_moviecomments];
GO
IF OBJECT_ID(N'[dbo].[FK_usernotes]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[notesSet] DROP CONSTRAINT [FK_usernotes];
GO
IF OBJECT_ID(N'[dbo].[FK_movienotes]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[notesSet] DROP CONSTRAINT [FK_movienotes];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[userSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[userSet];
GO
IF OBJECT_ID(N'[dbo].[movieSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[movieSet];
GO
IF OBJECT_ID(N'[dbo].[commentsSet1]', 'U') IS NOT NULL
    DROP TABLE [dbo].[commentsSet1];
GO
IF OBJECT_ID(N'[dbo].[notesSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[notesSet];
GO

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
    [user_Id] int  NOT NULL,
    [movie_Id] int  NOT NULL
);
GO

-- Creating table 'notesSet'
CREATE TABLE [dbo].[notesSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [note] float  NOT NULL,
    [user_Id] int  NOT NULL,
    [movie_Id] int  NOT NULL
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

-- Creating foreign key on [user_Id] in table 'commentsSet1'
ALTER TABLE [dbo].[commentsSet1]
ADD CONSTRAINT [FK_usercomments]
    FOREIGN KEY ([user_Id])
    REFERENCES [dbo].[userSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_usercomments'
CREATE INDEX [IX_FK_usercomments]
ON [dbo].[commentsSet1]
    ([user_Id]);
GO

-- Creating foreign key on [movie_Id] in table 'commentsSet1'
ALTER TABLE [dbo].[commentsSet1]
ADD CONSTRAINT [FK_moviecomments]
    FOREIGN KEY ([movie_Id])
    REFERENCES [dbo].[movieSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_moviecomments'
CREATE INDEX [IX_FK_moviecomments]
ON [dbo].[commentsSet1]
    ([movie_Id]);
GO

-- Creating foreign key on [user_Id] in table 'notesSet'
ALTER TABLE [dbo].[notesSet]
ADD CONSTRAINT [FK_usernotes]
    FOREIGN KEY ([user_Id])
    REFERENCES [dbo].[userSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_usernotes'
CREATE INDEX [IX_FK_usernotes]
ON [dbo].[notesSet]
    ([user_Id]);
GO

-- Creating foreign key on [movie_Id] in table 'notesSet'
ALTER TABLE [dbo].[notesSet]
ADD CONSTRAINT [FK_movienotes]
    FOREIGN KEY ([movie_Id])
    REFERENCES [dbo].[movieSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_movienotes'
CREATE INDEX [IX_FK_movienotes]
ON [dbo].[notesSet]
    ([movie_Id]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------