use master
go
create database CS486_Team11_DB
go
use CS486_Team11_DB
go

create table Song(
    id  int not null PRIMARY KEY,
    name nvarchar(100),
    releaseDate date,
    views int,
    quality varchar(10),
    official int, 
)

go

create table Author(
    id int not null PRIMARY KEY,
    name nvarchar(100)
)

go

create table Category(
    id int not null PRIMARY KEY,
    name NVARCHAR(50),
    Parentid int REFERENCES Category(id)
)

go

create table SongAuthor(
    Songid int not null REFERENCES Song(id),
    AuthorId int not null REFERENCES Author(id),
    PRIMARY KEY(songid, AuthorId)
)

go

create table Songcat(
    Songid int not null REFERENCES Song(id),
    Catid int not NULL REFERENCES Category(id)
    PRIMARY KEY(songid, catid)
)

go
use master
go
drop database CS486_Team11_DB