create database College

use College

create table Category
(Id int primary key,
CourseCategory nvarchar(50) not null unique)

create table Course
(Id int primary key,
Name nvarchar(50),
Fee Float,
StartDate DateTime,
Category int foreign key references Category(Id))

insert into Category values (1,'B Tech')
insert into Category values (2,'Poly Technic')
insert into Category values (3,'B Sc')


insert into Course values (1,'CSE','125000','07/18/2023',1)
insert into Course values (2,'Agriculture','05000','06/01/2023',2)
insert into Course values (3,'Statistics','65700','08/12/2023',3)
insert into Course values (4,'EEE','92300','07/01/2023',1)
insert into Course values (5,'Science','57000','06/25/2023',3)
insert into Course values (6,'Mech','82500','07/15/2023',1)

select * from Category
select * from Course

