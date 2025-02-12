--scalar function
create function fn_getfullname(@empid int)
returns varchar(100)
as 
begin
Declare @FullName varchar(100)

select @FullName = firstname +'_'+ lastname from employee

where Empid = @empid 

return @fullname

end

select dbo.fn_getfullname(1005)


select  * from employee where Empid=1005