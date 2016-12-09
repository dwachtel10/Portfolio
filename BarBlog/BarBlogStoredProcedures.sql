-- Blog Posts

CREATE PROCEDURE GetBlogPost
(
	@PostID int
) as

Select *
From Post
Where PostID = @PostID

GO

CREATE PROCEDURE GetAllBlogPosts as

Select *
From Post

GO

Create PROCEDURE RemoveBlogPost
(
	@PostID int
) AS

Delete
From Post
Where PostID = @PostID

GO

Create Procedure AddBlogPost
(
	@PostID int,
	@UserID int,
	@CategoryID int,
	@PostTitle varchar(max),
	@PostSubTitle varchar(max),
	@PostBody varchar(max),
	@PostStatus int,
	@PostDate datetime
	
) AS

INSERT INTO Post (PostID, UserID, CategoryID, PostTitle, PostSubtitle, PostBody, PostStatus, PostDate)
Values (@PostID, @UserID, @CategoryID, @PostTitle, @PostSubtitle, @PostBody, @PostStatus, @PostDate)

GO

Create Procedure UpdateBlogPost
(
	@PostID int,
	@UserID int,
	@CategoryID int,
	@PostTitle varchar(max),
	@PostSubTitle varchar(max),
	@PostBody varchar(max),
	@PostStatus int,
	@PostDate datetime
) AS

UPDATE Post
Set UserID = @UserID,
CategoryID = @CategoryID,
PostTitle = @PostTitle,
PostSubtitle = @PostSubtitle,
PostBody = @PostBody,
PostStatus = @PostStatus,
PostDate = @PostDate

Where PostID = @PostID

GO

--Static Pages

CREATE PROCEDURE GetStaticPage
(
	@PageID int
) as

Select *
From StaticPages
Where PageID = @PageID

GO

CREATE PROCEDURE GetAllStaticPages as

Select *
From StaticPages

GO

Create PROCEDURE RemoveStaticPages
(
	@PageID int
) AS

Delete
From StaticPages
Where PageID = @PageID

GO

Create Procedure AddStaticPage
(
	@PageID int,
--	@UserID int,
--	@PageStatus varchar(max),
	@PageTitle varchar(max),
	@PageBody varchar(max),
	@PageDate datetime
	
) AS

INSERT INTO StaticPages (PageID, PageTitle, PageBody, PageDate)
Values (@PageID, @PageTitle, @PageBody, @PageDate)

GO

Create Procedure UpdateStaticPage
(
	@PageID int,
--	@UserID int,
	@PageTitle varchar (max),
--	@PageStatus varchar(max),
	@PageBody varchar(max),
	@Pagedate datetime
) AS

UPDATE StaticPages
Set 
PageTitle = @PageTitle,
PageBody =	@PageBody,
PageDate = @PageDate

Where PageID = @PageID

GO

--Tags

CREATE PROCEDURE AddTag
(
	@TagID int,
	@TagName varchar(max)
) AS

INSERT INTO Tags (TagID, TagName)
Values (@TagID, @TagName)

GO

Create Procedure GetTag
(
	@TagID int
)AS

Select *
From Tags
Where TagID = @TagID

GO

Create Procedure GetAllTags AS

Select *
From Tags

GO

Create Procedure UpdateTag
(
	@TagID int,
	@TagName varchar(max)
) AS

UPDATE Tags
Set TagName = @TagName

Where TagID = @TagID

GO

Create PROCEDURE RemoveTag
(
	@TagID int
) AS

Delete
From Tags
Where TagID = @TagID

GO


--PostTags

CREATE PROCEDURE AddPostTag
(
	@TagID int,
	@PostID int
) AS

INSERT INTO PostTags(TagID, PostID)
Values (@TagID, @PostID)

GO

CREATE PROCEDURE GetTagsByPostID
(
	@PostID int
)AS
SELECT PostTags.TagID, Tags.TagName
FROM PostTags INNER JOIN Tags
ON PostTags.TagID = Tags.TagID
WHERE PostTags.PostID = @PostID

GO

CREATE PROCEDURE RemovePostTags
(
	@PostID int
)AS
Delete
From PostTags
Where PostID = @PostID

GO

CREATE PROCEDURE RemovePostTagsByTagID
(
	@TagID int
)AS
DELETE
FROM PostTags
WHERE TagID = @TagID

GO

--Categories

CREATE PROCEDURE AddCategory
(
@CategoryID int,
@CategoryName varchar(max) 
) AS

INSERT INTO Categories(CategoryID, CategoryName)
Values (@CategoryID, @CategoryName)

GO

Create Procedure GetCategory
(
	@CategoryID int
)AS

Select *
From Categories
Where CategoryID = @CategoryID

GO

Create Procedure GetAllCategories AS

Select *
From Categories

GO

Create Procedure UpdateCategory
(
	@CategoryID int,
	@CategoryName varchar(max)
) AS

UPDATE Categories
Set CategoryName = @CategoryName

Where CategoryID = @CategoryID

GO

Create PROCEDURE RemoveCategory
(
	@CategoryID int
) AS

Delete
From Categories
Where CategoryID = @CategoryID

GO

--Tests

--Blog Post Procedure tests
exec GetAllBlogPosts

exec AddBlogPost 3,2,3,'Woah A test Post', 'SubTitle' ,'<h1>Dude!</h1><p><i>where is my car?</i></p>',2,'2016-11-19'
exec GetBlogPost 1

exec UpdateBlogPost 3,2,3,'Woah An Updated test Post', 'SubTitle' ,'<h1>Dude!</h1><p><i>where is my car?</i></p>',2,'2016-11-19'
exec GetBlogPost 3

exec RemoveBlogPost 3

exec GetAllBlogPosts
--Tags Procedure tests
exec GetAllTags

exec AddTag 1, 'Woah Dude'
exec GetTag 1

exec UpdateTag 1, 'Updated'
exec GetTag 1

exec RemoveTag 1
exec GetAllTags

exec GetTagsByPostID 2

--Category Procedure tests

exec GetAllCategories

exec AddCategory 1, 'Humor'
exec GetCategory 1

exec UpdateCategory 1, 'Changed'
exec GetCategory 1

exec RemoveCategory 1
exec GetAllCategories

exec GetAllStaticPages

