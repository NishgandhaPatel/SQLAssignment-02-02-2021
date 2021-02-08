use DotNetAssignment;
create table MovieTable(MovieId int not null,MovieName varchar(30),Actor varchar(20),Tickets int)

insert into MovieTable values (1,'Yeh javani he diwani','Ranbir',90)
insert into MovieTable values (2,'KGF','Naveen Kumar Gowada',100)
insert into MovieTable values (3,'Bhaaghi 3','Tiger Shroff',150)
insert into MovieTable values (4,'Dil Bechara','Sushant Singh Rajput',200)
insert into MovieTable values (5,'Suryawanshi','Akshay Kumar',100)
insert into MovieTable values (6,'Kabir singh','Shahid kapoor',250)
delete from MovieTable where tickets=250
select * from MovieTable
---------------------------------------------------------
create proc sp_ShowMovieDetails
@movieid int
as
begin
select * from MovieTable
where MovieId=@movieid
end
execute sp_ShowMovieDetails 5
----------------------------------------------------
--------------------------------------------------------
create proc sp_ShowMovieNames
as
begin
select MovieId,MovieName from MovieTable
end
execute sp_ShowMovieNames
-------------------------------
alter proc sp_UpdateMovie
@movieid int,
@mname varchar(30),
@mactor varchar(20),
@mtickets int
as 
begin
update MovieTable set MovieName=@mname,Actor=@mactor,Tickets=@mtickets 
where MovieId=@movieid
end