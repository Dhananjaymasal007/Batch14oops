--trigger

create trigger trg_afterinsertEmployee
on employee
after insert
as 
begin

insert into department values ('Test_Dept')

select * from department

end



select * from department where  deptid=103
-- call trigger
insert into employee values ('Sach'	,'Sharma'	,'1998-05-05',	'Test Engineer',	'72000.00',	105)



select * from  employee where deptid=103

