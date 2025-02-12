
select * from employee --left
select * from department  -- right

--- Inner JOIN

select e.EmpId,e.FirstName,e.LastName,e.DeptID,d.DeptName from employee e
 inner join  Department d
 on e.DeptID = d.DeptID

 --Left JOIN
 select e.EMpid,e.FirstName,e.LastName,e.DeptID ,d.DeptName from  employee e 
 Left join  Department d 
 on e.DeptID = d.DeptID
 

 --right join

 select e.EMpid,e.FirstName,e.LastName,d.DeptID ,d.DeptName from  employee e 
 right  join  Department d 
 on e.DeptID = d.DeptID 


 ---full outer join
  select e.EMpid,e.FirstName,e.LastName,d.DeptID ,d.DeptName from  employee e 
 full outer join  Department d 
 on e.DeptID = d.DeptID 


 --- cross join
  select e.EMpid,e.FirstName,e.LastName,d.DeptID ,d.DeptName from  employee e 
 cross join  Department d 
 

 --self join
 select e1.FirstName,e1.LastName,e1.EmpId from employee e1
  join employee e2 on e1.DeptID =e2.DeptID and e1.EmpId =e2.EmpId
