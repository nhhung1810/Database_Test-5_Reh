
CREATE OR ALTER TRIGGER DuplicateSong
ON Song
AFTER INSERT, UPDATE
AS
BEGIN

	DECLARE @songId INT
	DECLARE @songName NVARCHAR(100)

	SELECT @songId = id, @songName = name FROM inserted

	IF EXISTS (SELECT * 
				FROM Song 
				WHERE id = @songId OR name LIKE @songName)
	BEGIN
		raiserror('Song must not have the same ID or Name', 15, 0)
		ROLLBACK
	END
END
GO

CREATE OR ALTER TRIGGER DuplicateAuthor
ON Author
AFTER INSERT, UPDATE
AS
BEGIN

	DECLARE @ID INT
	DECLARE @Name NVARCHAR(100)

	SELECT @ID = id, @Name = name FROM inserted

	

	IF EXISTS (SELECT * 
				FROM Author 
				WHERE id = @ID OR name LIKE @Name)
	BEGIN
		raiserror('Author must not have the same ID or Name', 15, 0)
		ROLLBACK
	END
END
GO

CREATE OR ALTER TRIGGER CheckAddSong
ON SongAuthor
AFTER INSERT, UPDATE
AS
BEGIN

	DECLARE @songID INT
	DECLARE @authorID INT

	SELECT @songID = SongID, @authorID = AuthorId FROM inserted

	IF NOT EXISTS(SELECT *
				FROM author
				WHERE id = @authorID)
	BEGIN
		raiserror('author not found', 15, 0)
		ROLLBACK
	END

	IF NOT EXISTS(SELECT *
				FROM Song
				WHERE id = @songID)
	BEGIN
		raiserror('song not found', 15, 0)
		ROLLBACK
	END

	IF EXISTS (SELECT * 
				FROM SongAuthor 
				WHERE SongID = @songID OR AuthorId = @authorID)
	BEGIN
		raiserror('duplicate song and author', 15, 0)
		ROLLBACK
	END
END
GO

CREATE OR ALTER PROCEDURE addSong
@id int,
@name NVARCHAR(100),
@views int,
@official int,
@quality varchar(5),
@releaseData date
AS
IF EXISTS (SELECT id 
		   FROM Song 
		   WHERE id = @id)
	RETURN
ELSE
	INSERT INTO Song (id, name, views, official, quality, releaseData) 
	VALUES (@id, @name, @views, @official, @quality, @releaseData);
GO

CREATE OR ALTER PROCEDURE addAuthor
@id int,
@name NVARCHAR(100)
AS
IF EXISTS (SELECT id 
		   FROM author 
		   WHERE id = @id)
	RETURN
ELSE
	INSERT INTO Song (id, name) 
	VALUES (@id, @name);
GO

CREATE OR ALTER PROCEDURE addSongAuthor
@song int, 
@author int
AS
IF EXISTS (SELECT * 
		   FROM SongAuthor 
		   WHERE SongID = @song)
	RETURN
ELSE
	INSERT INTO SongAuthor(SongID, AuthorId) 
	VALUES (@song, @author);
GO

CREATE OR ALTER PROCEDURE addCategory
@id int,
@name nvarchar(100),
@parentId int
AS
IF EXISTS (SELECT * 
		   FROM Category 
		   WHERE id = @id)
	RETURN
ELSE
	INSERT INTO Category(id, name, parentId) 
	VALUES (@id, @name, @parentId);
GO

CREATE OR ALTER PROCEDURE addCatSong
@song int,
@cat int
AS
IF EXISTS (SELECT * 
		   FROM CatSong 
		   WHERE songId = @song)
	RETURN
ELSE
	INSERT INTO CatSong (songId, catid) 
	VALUES (@song, @cat);
GO

USE master
go
create database CS468_team11_DB
GO
use CS468_team11_DB
go

create table Category(
    id int not null PRIMARY KEY,
    name NVARCHAR(100),
    parentId int REFERENCES Category(id)
)

go



CREATE TABLE Song
(
    id int not null primary key,
    name NVARCHAR(100),
    views int,
    official int,
    quality varchar(5),
    releaseData date
);
GO

create table CatSong(
    songId int not null REFERENCES Category(id),
    catid int not null REFERENCES Song(id),
    PRIMARY KEY(songid, catid)
)

go 

create table author(
    id int not null PRIMARY KEY,
    name NVARCHAR(100) not null,
)

CREATE TABLE SongAuthor(
    SongID int NOT NULL,
    AuthorId int not NULL
    PRIMARY KEY(songid, authorid)
)

go
use master
go
DROP DATABASE CS468_team11_DB

