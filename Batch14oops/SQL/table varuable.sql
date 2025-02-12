--- Table Variable

Declare @Employeetemp Table(
Empid int,
EmpName varchar(50),
Department Varchar(50));


--insert data into global temp table
insert into @Employeetemp(Empid,EmpName,Department) values
(105,'Sachin','Production'),
(106,'Dipak','IT')


select * from  @Employeetemp

select * from [dbo].[##EmployeeTempGlobal]