/*database name: libraryManagement*/

create table loginTable(
id int not null identity(1,1) primary key,
username varchar(150) not null,
pass varchar(150) not null
)

insert into loginTable (username, pass) values ('dy', 'pass');
insert into loginTable (username, pass) values ('kim', 'pass');

select * from loginTable



create table NewBook(
bid int not null identity(1, 1) primary key,
bName varchar(250) not null,
bAuthor varchar(250) not null,
bPubl varchar(250) not null,
bPDate varchar(250) not null,
bPrice bigint not null,
bQuan bigint not null
)

select * from NewBook;

create table NewStudent(
stuid int  not null identity(1, 1) primary key,
sName varchar(250) not null,
sEnroll varchar(250) not null,
sDepart varchar(250) not null,
sSemester varchar(250) not null,
sContact bigint not null,
sEmail varchar(250) not null
)

select * from NewStudent

create table IRBook(
id int not null identity(1, 1) primary key,
sEnroll varchar(250) not null,
sName varchar(250) not null,
sDepart varchar(250) not null,
sSemes varchar(250) not null,
sContact bigint not null,
sEmail varchar(250) not null,
bName varchar(250) not null,
IssueDate varchar(250) not null,
returnDate varchar(250) not null
);

select * from IRBook

/*ALTER TABLE table_name
ALTER COLUMN column_name datatype;*/

alter table IRBook
alter column returnDate varchar(250)

/*update NewBook set bQuan = bQuan + 2*/

delete NewBook where bName = 'hi'
