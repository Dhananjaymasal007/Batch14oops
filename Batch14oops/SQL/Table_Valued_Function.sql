--table valued function

create function fn_GetData(@deptname varchar(50))
returns table
as 
return
(

select e.empid,e.firstname,e.lastname,e.deptid,e.Position,e.Salary,d.deptname from employee e 
inner join Department d
on e.deptid = d.DeptID  where d.DeptName = @deptname

)


select * from [dbo].fn_GetData('IT')

--string functions


select upper(firstname),LOWER(lastname) ,len(lastname) as length_fisrname  from  employee


select substring(firstname,3,6) from employee


select round (Salary,3) from employee

select abs(salary) from employee

select * from [dbo].Department
select * from employee