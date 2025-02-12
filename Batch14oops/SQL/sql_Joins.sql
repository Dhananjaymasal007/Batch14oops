
select * from employee

select * from Department
insert into Department values('IT')
 update employee set Position='Data Anlyst', Salary='27000' ,DeptID=101
 where EmpId in(1004,1005)


 --inner join
 SELECT e.EmpId, e.FirstName, d.DeptName,d.DeptID
FROM Employee e
INNER JOIN Department d ON e.DeptID = d.DeptID;

--left join 
SELECT e.EmpId, e.FirstName, d.DeptName,d.DeptID
FROM Employee e
LEFT JOIN  Department d ON e.DeptID = d.DeptID;


--right  join 
SELECT e.EmpId, e.FirstName, d.DeptName,d.DeptID
FROM Employee e
right JOIN  Department d ON e.DeptID = d.DeptID;


--full oouteer join
SELECT e.EmpId, e.FirstName, d.DeptName,d.DeptID
FROM Employee e
FULL OUTER JOIN  Department d ON e.DeptID = d.DeptID;

--cross join
SELECT e.EmpId, e.FirstName,e.LastName, d.DeptName
FROM Employee e
CROSS JOIN Department d;


--self join

SELECT e1.FirstName AS Employee1, e2.FirstName AS Employee2, d.DeptName
FROM Employee e1
INNER JOIN Employee e2 ON e1.DeptID = e2.DeptID AND e1.EmpId != e2.EmpId
INNER JOIN Department d ON e1.DeptID = d.DeptID;