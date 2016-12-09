create database BarBlog
go


use BarBlog
go



CREATE TABLE [User]
(UserID int PRIMARY KEY,
UserName varchar(30) NOT NULL,
UserPassword varchar(30) NOT NULL,
UserPermissions varchar(15) NOT NULL)
GO
INSERT INTO [User] Values (1,'Dan','password','full')

CREATE TABLE Tags
(TagID int PRIMARY KEY,
TagName varchar(max) NOT NULL)
GO

INSERT INTO Tags VALUES (1,'#FirstTag')
INSERT INTO Tags VALUES (2,'#Tag#2')
INSERT INTO Tags VALUES (3,'#ThirdTag')
INSERT INTO Tags VALUES (4,'Test4')
INSERT INTO Tags VALUES (5,'#Tag5')
INSERT INTO Tags VALUES (6,'#6')



CREATE TABLE Post
(PostID int PRIMARY KEY,
UserID int NULL,
CategoryID int NOT NULL,
PostTitle varchar(max) NOT NULL,
PostSubtitle varchar(max) NULL,
PostBody varchar(max) NOT NULL,
PostStatus int NOT NULL,
PostDate datetime NOT NULL)
GO

INSERT INTO dbo.Post Values (1,1,1,'Test','Test Subtitle','<p>This is a sample post</p> <h2>Test Html</h2>',1,'11/29/2016')
INSERT INTO dbo.Post Values (2,1,1,'Test2','Test Subtitle2','<p>This is a sample post2</p> <h2>Test Html2</h2>',1,'11/19/2016')

CREATE TABLE Categories
(CategoryID int PRIMARY KEY,
CategoryName varchar(max) NOT NULL)
GO

INSERT INTO dbo.Categories VALUES (1,'Personal')
INSERT INTO dbo.Categories VALUES (2,'Review')

CREATE TABLE PostTags
(PostTagID int NOT NULL IDENTITY Primary Key, 
PostID int NOT NULL,
TagID int NOT NULL)
GO

INSERT INTO PostTags VALUES (1,1)
INSERT INTO PostTags VALUES (1,2)
INSERT INTO PostTags VALUES (2,2)
INSERT INTO PostTags VALUES (2,3)
INSERT INTO PostTags VALUES (2,5)
INSERT INTO PostTags VALUES (1,6)



CREATE TABLE StaticPages
(PageID int PRIMARY KEY,
--UserID int NOT NULL,
--PageStatus varchar(max) NOT NULL,
PageTitle varchar(max) NOT NULL,
PageBody varchar(max) NOT NULL,
PageDate datetime NOT NULL)

GO

INSERT INTO dbo.StaticPages VALUES (1,'FirstStatic','<h2>static1</h2><p>test of static page body</p>','11/30/16') 
INSERT INTO dbo.StaticPages VALUES (2,'SecondStatic','<h2>static2</h2><p>test of static page body2</p>','12/2/16') 
INSERT INTO dbo.StaticPages VALUES (3,'ThirdStatic','<h2>static3</h2><p>test of static page body3</p>','12/3/16') 