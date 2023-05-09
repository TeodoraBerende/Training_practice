USE Company
GO

--drop procedure AddNewEmployee;
CREATE PROCEDURE AddNewEmployee(@name NVARCHAR(50), @role NVARCHAR(20), @street NVARCHAR(100), @postalCode VARCHAR(6)
	, @city NVARCHAR(30), @country NVARCHAR(30), @department NVARCHAR(20))
AS
	DECLARE @departmentId INT = (SELECT Id from Departments WHERE Name=@department);
	IF @departmentId IS NOT NULL
		BEGIN
			INSERT INTO Addresses (Street, PostalCode, City, Country) 
				VALUES(@street, @postalCode, @city, @country);

			--get the id of the inserted address
			DECLARE @addressId INT = IDENT_CURRENT('Addresses');

			INSERT INTO Employees(Name, Role, DepartmentId, AddressId)
				VALUES(@name, @role, @departmentId, @addressId);

			
			SELECT e.Id, e.Name, e.Role, d.Name, a.Street +', ' + a.PostalCode +', ' + a.City +', ' + a.Country as Address
			FROM Employees e
			INNER JOIN Departments d
				ON e.DepartmentId = d.Id
			INNER JOIN Addresses a
				ON e.AddressId = a.Id;
			
		END
	ELSE
		PRINT 'Department does not exist';
GO

Select * from Departments;
	
EXEC AddNewEmployee 'Adrian Muresan','Senior Tester','Aleea Azur', '400357', 'Cluj-Napoca', 'Romania', 'Front-End';
EXEC AddNewEmployee 'Adrian Muresan','Senior Tester','Aleea Azur', '400357', 'Cluj-Napoca', 'Romania', 'Development';
EXEC AddNewEmployee 'Adriana Pop','Senior Tester','Aleea Azur', '400359', 'Cluj-Napoca', 'Romania', 'Development';


SELECT e.Id, e.Name, e.Role, d.Name, a.Street +', ' + a.PostalCode +', ' + a.City +', ' + a.Country as Address
	FROM Employees e
	INNER JOIN Departments d
		ON e.DepartmentId = d.Id
	INNER JOIN Addresses a
		ON e.AddressId = a.Id;

go

CREATE FUNCTION EmployeesOnProject(@projectName NVARCHAR(50))
RETURNS TABLE
AS
RETURN
	SELECT e.Name, e.Role, d.Name as Department, p.ProjectName
	FROM Employees e
	INNER JOIN Departments d
		ON e.DepartmentId = d.Id
	INNER JOIN EmployeesProjects ep
		ON e.Id = ep.Employee
	INNER JOIN Projects p
		ON ep.Project = p.Id
	WHERE p.ProjectName = @projectName;
go


SELECT * FROM EmployeesOnProject('BT');
SELECT * FROM EmployeesOnProject('SushiApp');

CREATE FUNCTION Profit(@projectName NVARCHAR(50))
RETURNS MONEY
AS
BEGIN
	DECLARE @nrOfEmployees INT = (SELECT COUNT(*) 
								FROM EmployeesProjects ep
								INNER JOIN Projects p
									ON ep.Project = p.Id
								WHERE p.ProjectName = @projectName);

	DECLARE @profit MONEY = (SELECT p.MoneyAllocated - @nrOfEmployees * 1000
							FROM Projects p
							WHERE p.ProjectName = @projectName);
	RETURN @profit;
END
go

SELECT dbo.Profit('BT') as Profit;

SELECT dbo.Profit('SushiApp') as Profit, p.Client
FROM Projects p
WHERE p.ProjectName = 'SushiApp';
