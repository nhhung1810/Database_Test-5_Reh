
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
    releaseData date,
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

