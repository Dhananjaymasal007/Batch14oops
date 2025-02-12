


create table student(
Studentid int primary key,
Firstname nvarchar(50),
LastName nvarchar(50),
department nvarchar(50),
Marks decimal (10,2));

select * from student
insert into  student (Studentid,Firstname,LastName,department,Marks) 
values
(1,'Amit','Patil','CSE',62.00),
(2,'Amit1','Patil','CEVIL',89.00),
(3,'Amit2','Patil','ENTC',70.00),
(4,'Amit3','Patil','MECH',56.50),
(5,'Amit5','Patil','CSE',70.50),
(6,'Amit6','Patil','CSE',82.10)

--
select * from student  where   Studentid=2;



--clusterd index
create clustered index idx_studenttest
on  student(studentid)

--non clustereed index
create nonclustered index idx_marks
on student (marks)


select * from student where department ='CSE'