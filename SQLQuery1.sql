create database LibraryDB
use LibraryDB
create table Books(
BookId int primary key,
Title varchar(25),
Author varchar(25),
Genre varchar(25),
Quantity int
)
insert into Books values(1,'Wild','Bears','Advanture',2)
select * from Books