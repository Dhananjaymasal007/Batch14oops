
-- Create a local temporary table
CREATE TABLE #EmployeeTemp (
    EmployeeID int,
    Name varchar(255),
    Department varchar(255)
);

-- Insert data into the temporary table
INSERT INTO #EmployeeTemp (EmployeeID, Name, Department)
VALUES (1, 'John Doe', 'Sales'),
       (2, 'Jane Smith', 'Marketing'),
       (3, 'Bob Brown', 'IT');

-- Select data from the temporary table
SELECT * FROM #EmployeeTemp;

-- Drop the temporary table
DROP TABLE #EmployeeTemp;


--obal Temporary Table Example


-- Create a global temporary table
CREATE TABLE ##EmployeeTempglobal (
    EmployeeID int,
    Name varchar(255),
    Department varchar(255)
);

-- Insert data into the temporary table
INSERT INTO ##EmployeeTempglobal (EmployeeID, Name, Department)
VALUES (1, 'John Doe', 'Sales'),
       (2, 'Jane Smith', 'Marketing'),
       (3, 'Bob Brown', 'IT');

-- Select data from the temporary table
SELECT * FROM ##EmployeeTempglobal;

-- Drop the temporary table
DROP TABLE ##EmployeeTempglobal;







---table variabl emust execute all query in one go


DECLARE @EmployeeTemp TABLE (
    EmployeeID int,
    Name varchar(255),
    Department varchar(255)
);

-- Insert data into the table variable
INSERT INTO @EmployeeTemp (EmployeeID, Name, Department)
VALUES (1, 'John Doe', 'Sales'),
       (2, 'Jane Smith', 'Marketing'),
       (3, 'Bob Brown', 'IT');

	   --- Select data from the table variable
SELECT * FROM @EmployeeTemp;