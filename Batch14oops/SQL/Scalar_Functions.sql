---scalar functions


alter  function fn_getfullname(@id int)
returns varchar(50)
as 
begin

declare @FullName varchar(200)

select @FullName = Upper( FirstName)  + '_' + Upper( LastName) from employee

where empid = @id
return @FullName
 
 
 End



 --call function
 select dbo.fn_getfullname(1000)

 select * from employee