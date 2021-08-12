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

insert into Category(id, name, parentId)
values
(1,'Viet Nam',1),
(2,'Au My',2),
(3,'Chau A',3),
(4,'Khac', 4),
(5,'Nhac Tre',1),
(6,'Rap Viet',1),
(7,'Rock Viet',1),
(8,'Cach Mang',1),
(9,'Nhac Trinh',1),
(10,'Remix Viet',1),
(12,'Tien Chien',1),
(13,'Pop',2),
(14,'Rock',2),
(15,'Electroca/Dance',2),
(16,'Blue/Jazz',2),
(17,'Country',2),
(18,'R&B',2),
(19,'Nhac Han',3),
(20,'Nhac Nhat',3),
(21,'Nhac Hoa',3),
(22,'Nhac Thai',3),
(23,'Thieu Nhi', 4),
(24,'Khong Loi', 4),
(25,'Beat',4)

insert into Song(id, name, releaseData, views, official,quality)
values
(1,'Do toc 2', '2021-08-10', 60557, 1, 'HQ'),
(2,'Gap go, yeu duong va duoc ben em', '2021-08-04', 73849, 1, 'HQ'),
(3,'Cho anh xin mot chut huong thom', '2021-07-30', 535, 1, 'HQ'),
(4,'Toi la nguoi Viet Nam', '2021-08-02', 4541, 1, 'HQ'),
(5,'Hoa bay vao tim', '2021-05-09', 3028, 0, 'SQ'),
(6,'Nhat Than', '2021-06-05', 113682, 0, 'SQ'),
(7,'Neu nhu ngay do', '2021-07-22', 33157, 1, 'HQ'),
(8,'Khong ly do', '2021-08-01', 1910, 0, 'SQ'),
(9,'Quen Mot nguoi that kho', '2021-05-25', 237427, 1, 'HQ'),
(10,'Khi nguoi lon co don', '2021-05-11', 60557, 1, 'HQ')

insert into CatSong(catid,songId)
values
(1,5),
(2,6),
(3,5),
(4,6),
(5,7),
(6,8),
(7,5),
(8,6),
(9,7),
(10,5)

insert into author(id,name)
values
(1,'Do MIXI'),
(2,'Phuc Du'),
(3,'Phao'),
(4,'Phan Manh Quynh'),
(5,'Masew'),
(6,'Ogenus'),
(7,'Ron Vinh'),
(8,'Niet'),
(9,'Khoi Vu'),
(10,'FAY'),
(11,'Vu Phung Tien'),
(12,'Cao Nam Thanh'),
(13,'Quang Vinh')

insert into songAuthor(SongID, AuthorId)
values
(1,1),
(2,1),
(3,1),
(4,2),
(5,1),
(6,3),
(7,4),
(8,5),
(9,6),
(10,7),
(11,8),
(12,9),
(13,10)

go
use master
go
drop database CS486_Team11_DB