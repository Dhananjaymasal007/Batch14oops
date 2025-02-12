USE [Batch12Dotnet]
GO

/****** Object:  Table [dbo].[Department]    Script Date: 16-08-2024 22:03:01 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO
--create anothr table

CREATE TABLE [dbo].[Projectdetails](
	[projID] [int] IDENTITY(100,1) NOT NULL,
	[projName] [varchar](50) NOT NULL)
GO


--alter employee table to add new column
alter table employee 
add  projID int 

--add constraint

alter table employee 
add constraint  fk_projectid
foreign key (projID)
references Projectdetails (projID)


--drop constraint
alter table employee 
drop  constraint  fk_projectid





