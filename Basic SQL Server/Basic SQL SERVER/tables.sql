USE master
IF EXISTS(SELECT * FROM sys.databases WHERE NAME='Company')
	DROP DATABASE Company
CREATE DATABASE Company
GO

USE Company
Go

--You can also say AddressId or code
CREATE TABLE Addresses(Id INT IDENTITY(1,1) PRIMARY KEY, Street NVARCHAR(100), PostalCode VARCHAR(6), City NVARCHAR(30), Country NVARCHAR(30));

CREATE TABLE Departments(Id INT PRIMARY KEY, Name NVARCHAR(20) NOT NULL UNIQUE);

CREATE TABLE Employees(Id INT IDENTITY(1,1) PRIMARY KEY, Name NVARCHAR(50), Role NVARCHAR(20), DepartmentId INT NOT NULL REFERENCES Departments(Id), 
	AddressId INT UNIQUE REFERENCES Addresses(Id));

CREATE TABLE Projects (Id INT IDENTITY(1,1) PRIMARY KEY, ProjectName NVARCHAR(50) NOT NULL, Client NVARCHAR(50) NOT NULL, MoneyAllocated MONEY NOT NULL);

CREATE TABLE EmployeesProjects(Employee INT NOT NULL REFERENCES Employees(Id), Project INT NOT NULL REFERENCES Projects(Id), PRIMARY KEY(Employee,Project));

/*

DROP TABLE EmployeesProjects;
DROP TABLE Employees;
DROP TABLE Projects;
DROP TABLE Addresses;
DROP TABLE Departments;

*/