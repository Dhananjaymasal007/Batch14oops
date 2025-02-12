--table valued function

create function fn_getdata(@deptname varchar(50))
returns table
as
return
(


select e.EmpId,e.FirstName,e.LastName,e.DeptID,d.DeptName from employee e
 inner join  Department d
 on e.DeptID = d.DeptID where d.DeptName = @deptname
 )

 select * from [dbo].fn_getdata('IT')








 ---String Functions


 SELECT UPPER(FirstName) FROM Employee;

 SELECT LOWER(FirstName) FROM Employee;

 SELECT LEN(FirstName) FROM Employee;

 SELECT SUBSTRING(FirstName, 1, 3) FROM Employee;

 SELECT ROUND(Salary, 1) FROM Employee;
 SELECT ABS(Salary) FROM Employee;