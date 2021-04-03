create database HMS
create table rooms(
roomid int Identity(1,1) primary key,
roomNo int not null unique,
roomType varchar(200) not null,
bed varchar(200) not null,
price bigint not null,
booked varchar(30) default 'No', 
);
insert into rooms(roomNo,roomType,bed,price)values(5,'AC','Double',1000)
insert into rooms(roomNo,roomType,bed,price,booked)values(6,'Non-AC','Double',1000,'Yes')
insert into rooms(roomNo,roomType,bed,price,booked)values(9,'Non-AC','Single',500,'Yes')
select* from rooms

create table Customer(
c_id int Identity(1,1) primary key,
cname varchar(200) not null,
c_dob varchar(50) not null,
C_gender varchar(40) not null,
c_mobileNo bigint not null,
idproof varchar(250) not null,
c_address varchar(250) not null,
checkin varchar(250) not null,
checkout varchar(250),
chekout varchar(250) not null default 'No', 
roomid int not null,
foreign key (roomid) references rooms(roomid), 

);
insert into Customer(cname,c_dob,C_gender,c_mobileNo,idproof,c_address,checkin,checkout,chekout,roomid)
values('laiba',11-6-2002,'Female',0309-5141238,'567','349 E Block Lahore','2/4/2021','3/4/2021','Yes',1)
select* from Customer
drop database HMS
drop table rooms
drop table Customer
