use CS468_team11_DB
go
Insert into Song(Name, ID, Views, Official, Quality, releaseData)
values
('Neu nhu ngay do', 1, 22195, 1, 'HQ', '2020-01-04'),
('Khong ly do', 2, 56, 1, 'SQ','2020-02-08'),
('U thi em cu chia tay', 3, 2091, 1, 'HQ', '2021-04-30'),
('Cong chua', 4, 55, 1, 'SQ', '2021-05-24'),
('So khong con em', 5, 81, 1, 'SQ', '2021-02-25'),
('One second(Unplugged)', 6, 2189, 1, 'HQ', '2021-06-30'),
('Sao ta nguoc loi', 7, 596649, 1, 'HQ', '2021-07-23'),
('Roi em se quen', 8, 1344, 1, 'SQ', '2021-07-25'),
('Phan duyen lo lang', 9, 3270611, 1, 'HQ', '2021-06-12'),
('Dem', 10, 982, 0, 'SQ', '2021-02-15')

insert into Category(id,name,parentId)
values
(1, 'Viet Nam', 1),
(2,'Au My', 2),
(3,'Chau A',3),
(4,'Khac',4),
(5, 'Nhac tre', 1),
(6, 'Rap Viet', 1),
(7, 'Tru tinh', 1),
(8, 'Tien chien', 1),
(9,'Pop', 2),
(10,'Rock', 2),
(11,'Blue/Jazz', 2),
(12,'Country',2),
(13,'Latin', 2),
(14,'Nhac Han',3),
(15,'Nhac Nhat',3),
(16,'Nhac Hoa',3),
(17,'Nhac Thai',3),
(18,'Thieu Nhi',4),
(19,'Khong loi',4),
(20,'Beat',4)



insert into author(id,name)
values
(1,'FAY'),
(2,'Vu Phung Tien'),
(3,'WHEE'),
(4,'Long Ho Huynh'),
(5,'Long Hai'),
(6,'Vu Cat Tuong'),
(7,'Dinh Dung'),
(8,'Trung Nghia'),
(9,'Truzg'),
(10,'Hamlet Truong')

insert into SongAuthor(SongID,AuthorId)
values
(1,1),
(2,2),
(3,3),
(4,4),
(5,5),
(6,6),
(7,7),
(8,8),
(9,9),
(10,10)

