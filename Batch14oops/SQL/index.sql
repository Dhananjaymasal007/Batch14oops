CREATE TABLE Person (
    EmployeeID INT PRIMARY KEY,
    FirstName NVARCHAR(50),
    LastName NVARCHAR(50),
    Department NVARCHAR(50),
    Salary DECIMAL(10, 2)
);

CREATE NONCLUSTERED INDEX idx_Department
ON Employees_TEST (Department);

CREATE CLUSTERED INDEX idx_EmployeeTEST
ON Employees_TEST (EmployeeID);

INSERT INTO Employees_TEST (EmployeeID, FirstName, LastName, Department, Salary)
VALUES 
    (1, 'John', 'Doe', 'Sales', 55000.00),
    (2, 'Jane', 'Smith', 'HR', 60000.00),
    (3, 'Alice', 'Brown', 'IT', 75000.00),
    (4, 'Bob', 'Johnson', 'Sales', 52000.00),
    (5, 'Charlie', 'Davis', 'Finance', 58000.00);


SELECT FirstName, LastName
FROM Employees_TEST
WHERE Department = 'Sales';

SELECT * 
FROM Employees_TEST
WHERE EmployeeID = 3;