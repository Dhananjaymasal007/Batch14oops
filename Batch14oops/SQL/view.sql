--create view

create view empinfo as select e.DeptID   from Employee e inner join department d 
on e.DeptID = d.DeptID


--alter view

alter 
 view empinfo as select e.DeptID ,e.FirstName,e.lastname  from Employee e inner join
 department d 
on e.DeptID = d.DeptID


--select view


select * from empinfo