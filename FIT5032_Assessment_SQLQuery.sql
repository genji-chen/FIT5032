
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 09/29/2020 22:54:22
-- Generated from EDMX file: C:\Users\29474\source\repos\assessment\Models\assessment_Model.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [assessment_Database];
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

-- Creating table 'Users'
CREATE TABLE [dbo].[Users] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [UserName] nvarchar(max)  NOT NULL,
    [Email] nvarchar(max)  NOT NULL,
    [Level] nvarchar(max)  NOT NULL,
    [UserId] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Tests'
CREATE TABLE [dbo].[Tests] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Date] nvarchar(max)  NOT NULL,
    [Address] nvarchar(max)  NOT NULL,
    [TestName] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'TestLists'
CREATE TABLE [dbo].[TestLists] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [state] nvarchar(max)  NOT NULL,
    [UserId] int  NOT NULL,
    [TestId] int  NOT NULL
);
GO

-- Creating table 'Courses'
CREATE TABLE [dbo].[Courses] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [CourseName] nvarchar(max)  NOT NULL,
    [NoOfEpisode] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'CourseLists'
CREATE TABLE [dbo].[CourseLists] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [UserId] int  NOT NULL,
    [CourseId] int  NOT NULL
);
GO

-- Creating table 'Administrators'
CREATE TABLE [dbo].[Administrators] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [AdName] nvarchar(max)  NOT NULL,
    [Email] nvarchar(max)  NOT NULL,
    [UserId] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'ModifyTests'
CREATE TABLE [dbo].[ModifyTests] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [AdministratorId] int  NOT NULL,
    [TestId] int  NOT NULL,
    [Date] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'ModifyCourses'
CREATE TABLE [dbo].[ModifyCourses] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [AdministratorId] int  NOT NULL,
    [CourseId] int  NOT NULL
);
GO

-- Creating table 'ModifyUsers'
CREATE TABLE [dbo].[ModifyUsers] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Action] nvarchar(max)  NOT NULL,
    [Date] nvarchar(max)  NOT NULL,
    [UserId] int  NOT NULL,
    [AdministratorId] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'Users'
ALTER TABLE [dbo].[Users]
ADD CONSTRAINT [PK_Users]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Tests'
ALTER TABLE [dbo].[Tests]
ADD CONSTRAINT [PK_Tests]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'TestLists'
ALTER TABLE [dbo].[TestLists]
ADD CONSTRAINT [PK_TestLists]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Courses'
ALTER TABLE [dbo].[Courses]
ADD CONSTRAINT [PK_Courses]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'CourseLists'
ALTER TABLE [dbo].[CourseLists]
ADD CONSTRAINT [PK_CourseLists]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Administrators'
ALTER TABLE [dbo].[Administrators]
ADD CONSTRAINT [PK_Administrators]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'ModifyTests'
ALTER TABLE [dbo].[ModifyTests]
ADD CONSTRAINT [PK_ModifyTests]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'ModifyCourses'
ALTER TABLE [dbo].[ModifyCourses]
ADD CONSTRAINT [PK_ModifyCourses]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'ModifyUsers'
ALTER TABLE [dbo].[ModifyUsers]
ADD CONSTRAINT [PK_ModifyUsers]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [UserId] in table 'TestLists'
ALTER TABLE [dbo].[TestLists]
ADD CONSTRAINT [FK_UserTestList]
    FOREIGN KEY ([UserId])
    REFERENCES [dbo].[Users]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_UserTestList'
CREATE INDEX [IX_FK_UserTestList]
ON [dbo].[TestLists]
    ([UserId]);
GO

-- Creating foreign key on [TestId] in table 'TestLists'
ALTER TABLE [dbo].[TestLists]
ADD CONSTRAINT [FK_TestListTest]
    FOREIGN KEY ([TestId])
    REFERENCES [dbo].[Tests]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_TestListTest'
CREATE INDEX [IX_FK_TestListTest]
ON [dbo].[TestLists]
    ([TestId]);
GO

-- Creating foreign key on [UserId] in table 'CourseLists'
ALTER TABLE [dbo].[CourseLists]
ADD CONSTRAINT [FK_UserCourseList]
    FOREIGN KEY ([UserId])
    REFERENCES [dbo].[Users]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_UserCourseList'
CREATE INDEX [IX_FK_UserCourseList]
ON [dbo].[CourseLists]
    ([UserId]);
GO

-- Creating foreign key on [CourseId] in table 'CourseLists'
ALTER TABLE [dbo].[CourseLists]
ADD CONSTRAINT [FK_CourseCourseList]
    FOREIGN KEY ([CourseId])
    REFERENCES [dbo].[Courses]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_CourseCourseList'
CREATE INDEX [IX_FK_CourseCourseList]
ON [dbo].[CourseLists]
    ([CourseId]);
GO

-- Creating foreign key on [AdministratorId] in table 'ModifyTests'
ALTER TABLE [dbo].[ModifyTests]
ADD CONSTRAINT [FK_AdministratorModifyTest]
    FOREIGN KEY ([AdministratorId])
    REFERENCES [dbo].[Administrators]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_AdministratorModifyTest'
CREATE INDEX [IX_FK_AdministratorModifyTest]
ON [dbo].[ModifyTests]
    ([AdministratorId]);
GO

-- Creating foreign key on [TestId] in table 'ModifyTests'
ALTER TABLE [dbo].[ModifyTests]
ADD CONSTRAINT [FK_ModifyTestTest]
    FOREIGN KEY ([TestId])
    REFERENCES [dbo].[Tests]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ModifyTestTest'
CREATE INDEX [IX_FK_ModifyTestTest]
ON [dbo].[ModifyTests]
    ([TestId]);
GO

-- Creating foreign key on [AdministratorId] in table 'ModifyCourses'
ALTER TABLE [dbo].[ModifyCourses]
ADD CONSTRAINT [FK_ModifyCourseAdministrator]
    FOREIGN KEY ([AdministratorId])
    REFERENCES [dbo].[Administrators]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ModifyCourseAdministrator'
CREATE INDEX [IX_FK_ModifyCourseAdministrator]
ON [dbo].[ModifyCourses]
    ([AdministratorId]);
GO

-- Creating foreign key on [CourseId] in table 'ModifyCourses'
ALTER TABLE [dbo].[ModifyCourses]
ADD CONSTRAINT [FK_CourseModifyCourse]
    FOREIGN KEY ([CourseId])
    REFERENCES [dbo].[Courses]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_CourseModifyCourse'
CREATE INDEX [IX_FK_CourseModifyCourse]
ON [dbo].[ModifyCourses]
    ([CourseId]);
GO

-- Creating foreign key on [UserId] in table 'ModifyUsers'
ALTER TABLE [dbo].[ModifyUsers]
ADD CONSTRAINT [FK_UserModifyUser]
    FOREIGN KEY ([UserId])
    REFERENCES [dbo].[Users]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_UserModifyUser'
CREATE INDEX [IX_FK_UserModifyUser]
ON [dbo].[ModifyUsers]
    ([UserId]);
GO

-- Creating foreign key on [AdministratorId] in table 'ModifyUsers'
ALTER TABLE [dbo].[ModifyUsers]
ADD CONSTRAINT [FK_AdministratorModifyUser]
    FOREIGN KEY ([AdministratorId])
    REFERENCES [dbo].[Administrators]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_AdministratorModifyUser'
CREATE INDEX [IX_FK_AdministratorModifyUser]
ON [dbo].[ModifyUsers]
    ([AdministratorId]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------