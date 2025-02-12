


--Aggrigate Functions

select  * from employee

1) Count - it will count the no of record in the tables

select count(salary) from employee  -- where empid= 101

2) sum --it will calculate the total for perticular column
 
 select sum(salary) from  employee

3) avg -  it will calculate average


select avg(salary) from employee



select min(salary) from employee

select max(salary) from employee



--string funcations


select upper('hello')

select LOWER('HELLO')

select SUBSTRING('Hello World',7,3);

select concat('hello','_','World')

select replace('Hello world', 'world1','SQL')




--Date Functions


select getdate() 


select current_timestamp

select  DATEDIFF(year,'2000-01-01','2025-01-01')


select --DATE_ADD('2025-10-10', interval 10 Day);


select DATEADD(DAY,2,'2025-02-04') As  Dateadd;




