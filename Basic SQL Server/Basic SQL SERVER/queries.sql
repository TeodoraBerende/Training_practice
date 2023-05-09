USE Company
GO

INSERT INTO Departments 
	Values (1,'Development'), 
		(2,'Testing'),
		(3,'Management'),
		(4,'HR');

INSERT INTO Addresses(Street, PostalCode, City, Country) 
	Values ('Aleea Detunata','400434', 'Cluj-Napoca', 'Romania'),
		('Strada Copernicus','400176', 'Cluj-Napoca', 'Romania'),
		('Strada I. C. Bratianu','030171', 'Bucuresti', 'Romania'),
		('Aleea Alexandru','011821', 'Bucuresti', 'Romania'),
		('Strada Maior Petru','400002', NULL, 'Romania');

INSERT INTO Employees(Name, Role, DepartmentId, AddressId)
	Values ('Andra Pop', 'Junior Developer', 1, 1),
		('Maria Zaharia', 'Senior Developer', 1, 2),
		('Cosmin Coman', 'Senior Developer', 1, 3),
		('Claudiu Ungureanu', 'Junior Tester', 2, 4),
		('Ioana Zmeu', 'Manager', 3, 5);

INSERT INTO dbo.Projects(ProjectName, Client, MoneyAllocated) 
	Values ('SushiApp','Jonh Smith',20000),
		('BT','Marius Radu',30500);

INSERT INTO EmployeesProjects(Employee,Project) 
	Values (1,1),(2,1),(5,1),(2,2),(4,2),(5,2);


GO

SELECT Name, Role
FROM Employees;

SELECT * FROM Employees;

Select * from EmployeesProjects;

--play
SELECT DISTINCT Project
FROM EmployeesProjects; 

SELECT * 
FROM Addresses
WHERE City = 'Bucuresti';

SELECT * 
FROM Addresses
WHERE City is NULL;

SELECT * 
FROM Employees
Order by Name DEsc; -- ASC/DESC

UPDATE Addresses
SET City = 'Cluj-Napoca'
WHERE City is NULL; -- Id = 5 or PostalCode = 400002


--play with next queries
SELECT e.Name, e.Role, d.Name as DepartmentName
FROM Employees e
INNER JOIN Departments d
	ON e.DepartmentId = d.Id;


Select * from Projects;

SELECT *
FROM Projects p
INNER JOIN EmployeesProjects ep
	ON p.Id = ep.Project
INNER JOIN Employees e
	ON e.Id = ep.Employee

WHERE p.ProjectName = 'SushiApp';

Select * From Departments;

DELETE Departments
WHERE Name = 'HR';

Insert into Departments Values(4,'HR');

Select * from Departments;
select * from Employees;

Select * 
From Departments d
INner Join Employees e
	ON d.Id = e.DepartmentId;

Select * 
From Departments d Left Join Employees e
	ON d.Id = e.DepartmentId;

Select * 
From Employees e Right Join Departments d 
	ON d.Id = e.DepartmentId;