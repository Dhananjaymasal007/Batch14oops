--scaler functions
Create  function Fn_getfullname(@eid int)
 returns varchar(100)
 as 
 begin
 declare @FullName varchar(200)

 select @FullName = firstName +' '+ lastName from employee

 where EmpId = @eid

 return @fullname

 End


 select * from Department
 --call function 
 select dbo.Fn_getfullname(1002)




 --call funcation and select querey
 select * ,dbo.Fn_getfullname(EmpId) as Full_Name from  [dbo].[Employee]