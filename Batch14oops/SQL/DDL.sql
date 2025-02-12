--DDL
--1) Create Table

create table Employee(
Empid int identity (1000,1) primary key,
FirstName varchar(30),
LastName Varchar(30),
DateOfBirth Date,
Position Varchar(100),
Salary Decimal (18,2),
deptid int,
);

--Insert 


---
create table Department(
DeptID int identity(100,1) primary key,
DeptName varchar(50) not null)


select * from department

insert into Employee values ('sachin','Sharma','2002-10-10','Softwaare Engineer',41000,102),
('Rajesh','Desai','1998-01-10','Team Lead',74000,103)


---syntax

---insert into table_name (column1,column2,column3) values (value1,value2,value3)








--Alter table add column

alter table employee
add DeptName varchar(20);

 ---alater table drop column
 alter table employee
 drop column deptName

 --alter table alter column to update datatype

 alter table employee
 alter column deptid varchar(30);



 alter table employee 
 Rename column deptname to Dept_Name;



-- truncate table
 truncate table employee

 

 ---drop table
 drop table employee

select * from employee  
 

 --DDL
 --1)create alter truncate drop


 ---update command

 
 update employee set salary= null where empid =1001
 select * from employee where deptid =102


 --delete command

  select * from employee

    delete from employee where empid in (1000,
1001,
1003,
1004)
  

  select firstname,lastname,salary from employee

  -- conctnation

  select concat('Mr.',firstname,' ',lastname) AS FullName,position AS Designaiton,salary  from employee




