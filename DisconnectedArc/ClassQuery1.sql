create database EmpsDb
use EmpsDb
create table Emps
(Id int primary key,
Fname nvarchar(50) not null,
Lname nvarchar(50)not null,
Designation nvarchar(50),
salary float)

insert into Emps values (1,'Ajay','kumar','developer',97000.90)
insert into Emps values (2,'Vijay','kumar','developer',99000.90)
insert into Emps values (3,'Nishi','vats','developer',94000.90)
insert into Emps values (9,'Kurnal','Garg','developer',87000.90)

insert into Emps (Id,Fname,Lname,salary)values (5,'Raj','kumar',970000.90)
insert into Emps values (12,'Ajay','kumar','developer',97000.90)
insert into Emps (Id,Fname,Lname,Designation,salary)values (13,'Naina','kumar','Manager',970000.90)
insert into Emps values (15,'Ajay','kumar','HR',97000.90)
delete from Emps where Id>=20
select * from Emps

