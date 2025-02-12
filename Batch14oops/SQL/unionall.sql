--- Union and Union all
--union
select deptid from employee
union
select deptid from  [dbo].[Department]


--union all
 select deptid  from [dbo].[Employee]
 union all 
 select deptid from [dbo].[Department]



  select *  from [dbo].[Employee]?
 --union all 
 select * from [dbo].[Department]



select * from employee
select * from department