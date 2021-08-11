
CREATE OR ALTER TRIGGER DuplicateSong
ON Song
AFTER INSERT, UPDATE
AS
BEGIN

	DECLARE @songId INT
	DECLARE @songName nvarchar(50)

	SELECT @songId = ID, @songName = Name FROM inserted

	

	IF EXISTS (SELECT * 
				FROM Song 
				WHERE ID = @songId OR Name LIKE @songName)
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
	DECLARE @Name nvarchar(50)

	SELECT @ID = ID, @Name = Name FROM inserted

	

	IF EXISTS (SELECT * 
				FROM Author 
				WHERE ID = @ID OR Name LIKE @Name)
	BEGIN
		raiserror('Author must not have the same ID or Name', 15, 0)
		ROLLBACK
	END
END
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

