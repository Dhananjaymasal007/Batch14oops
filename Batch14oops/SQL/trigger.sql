create  TRIGGER trg_afteremployeeinsert
ON Employee
AFTER INSERT
AS
BEGIN
    INSERT INTO Department values ('test')
    select * from department
END;
select * from employee
select * from department


---drop trigger trg_afteremployeeinsert


--call trigger
delete  from Department where DeptName='test'

insert into employee values ('Dipak','Patil','2001-10-10','Backend Developer',257000,103)