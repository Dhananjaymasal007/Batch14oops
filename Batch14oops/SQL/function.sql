--Table Valued Functions (TVF)


create Function Fn_GetEmpData(@deptname varchar(50))
returns table 
as 
return
(

select e.EmpId,e.FirstName,e.LastName,e.DeptID,d.DeptName from employee e inner join   department d 
on 
e.DeptID = d.DeptID where d.DeptName =@deptname

)





select * from [dbo].Fn_GetEmpData('IT')


exec 

select e.EmpId,e.FirstName,e.LastName,e.DeptID,d.DeptName,e.Salary from employee e inner join   department d 
on 
e.DeptID = d.DeptID where d.DeptName ='IT'


select * from dbo.employee
select * from dbo.Department