-- 01. names and salaries of the employees that
-- take the minimal salary in the company.
SELECT FirstName, 
	LastName,
	Salary 
FROM Employees
WHERE Salary =
(
	SELECT MIN(Salary)
	FROM Employees
);

-- 02. names and salaries of the employees that
-- have a salary that is up to 10% higher than 
-- the minimal salary for the company.
SELECT 
	FirstName,
	LastName,
	Salary 
FROM Employees
WHERE Salary > (SELECT MIN(Salary)
		FROM Employees)
	AND Salary <= (SELECT MIN(Salary) * 1.1
		FROM Employees);

-- 03. full name, salary and department of the
-- employees that take the minimal salary in their department.
SELECT 
	e.FirstName,
	e.LastName,
	e.Salary, dep.Name
FROM Employees emp
JOIN Departments dep
ON dep.DepartmentID = emp.DepartmentID
JOIN Employees e
ON e.DepartmentID = dep.DepartmentID
WHERE e.Salary = (SELECT MIN(em.Salary) 
				FROM Employees em 
				WHERE em.DepartmentID = e.DepartmentID)
GROUP BY e.DepartmentID, e.FirstName, e.LastName, e.Salary, dep.Name;

-- 04. average salary in the department #1.
SELECT AVG(Salary) AS [Average Salary in Department #1]
FROM Employees e
WHERE e.DepartmentID = 1;

--05. average salary in the "Sales" department.
SELECT d.Name AS [Department],
	AVG(Salary) AS [Average Salary]
FROM Employees e
JOIN Departments d
ON d.DepartmentID = e.DepartmentID
WHERE d.Name = 'Sales'
GROUP BY d.Name

-- 06. number of employees in the "Sales" department.
SELECT COUNT(*) AS [Number Of Employees],
	   dep.Name AS [Department]
FROM Employees emp
JOIN Departments d
ON emp.DepartmentID = dep.DepartmentID
WHERE d.Name = 'Sales'
Group BY d.Name


-- 07. number of all employees that have manager.
SELECT COUNT(*) AS [Number Of Employees], 'With Manager' AS [Manager]
FROM Employees e
JOIN Employees m
ON m.EmployeeID = e.ManagerID
WHERE e.ManagerID IS NOT NULL;

-- 08. number of all employees that have no manager.
SELECT COUNT(*) AS [Number Of Employees], 'Don`t Have Manager' AS [Manager]
FROM Employees e
LEFT JOIN Employees m
ON m.EmployeeID = e.ManagerID
WHERE e.ManagerID IS NULL;

-- 09. departments and the average salary for each of them.
SELECT d.Name, AVG(emp.Salary) AS [Average Salary]
FROM Departments d
JOIN Employees e
ON e.DepartmentID = d.DepartmentID
GROUP BY d.Name

-- 10. the count of all employees in each department and for each town.
SELECT COUNT(e.EmployeeID) AS [Employees Count],
	'department - ' + d.Name AS [Department Or Town Name]
FROM Departments d
JOIN Employees e
ON e.DepartmentID = d.DepartmentID
GROUP BY d.Name
UNION
SELECT COUNT(em.EmployeeID),
	'town - ' + t.Name
FROM Employees em
JOIN Addresses a
ON a.AddressID = em.AddressID
JOIN Towns t
ON t.TownID = a.TownID
GROUP BY t.Name

-- 11. all managers that have exactly 5 employees.
-- Display their first name and last name.
SELECT 
	m.FirstName,
	m.LastName
FROM Employees e 
JOIN Employees m
ON m.EmployeeID = e.ManagerID
GROUP BY m.FirstName, m.LastName
HAVING COUNT(manag.EmployeeID) = 6;

-- 12. all employees along with their managers.
SELECT e.FirstName + ' ' + e.LastName AS [Employee Name],
	 manag.FirstName + ' ' + manag.LastName AS [Manager Name]
FROM Employees e 
JOIN Employees m
ON m.EmployeeID = e.ManagerID;

-- 13. the names of all employees whose last name is 
-- exactly 5 characters long. 
-- Use the built-in LEN(str) function.
SELECT e.FirstName + ' ' + e.LastName AS [Employee Name (5 char.)]
FROM Employees e
GROUP BY e.FirstName, e.LastName
HAVING LEN(e.LastName) = 5;

-- 14. display the current date and time in the following format
-- "day.month.year hour:minutes:seconds:milliseconds". 
-- Search in Google to find how to format dates in SQL Server.
SELECT FORMAT(GETDATE(),'d.MM.yyyy') + '  ' + CONVERT(VARCHAR, GETDATE(), 114);

-- 15. create a table Users.
-- Users should have username, password, full name and last login time.
-- Choose appropriate data types for the table fields.
-- Define a primary key column with a primary key constraint.
-- Define the primary key column as identity to facilitate inserting records.
-- Define unique constraint to avoid repeating usernames.
-- Define a check constraint to ensure the password is at least 5 characters long.
CREATE TABLE [Users]
(
[ID] INT IDENTITY NOT NULL PRIMARY KEY,
[UserName] NVARCHAR(50) NOT NULL UNIQUE,
[PassWord] NVARCHAR(50) NOT NULL,
[FullName] NVARCHAR(50) NOT NULL,
[LastLogin] DATE NULL,
CHECK (LEN([PassWord]) >= 5)
)



-- 16. create a view that displays the users from the Users table 
-- that have been in the system today.
GO
CREATE VIEW [V_UsersToday] AS
SELECT DISTINCT 
	UserName,
	FullName,
	CONVERT(VARCHAR, LastLogin, 113) AS [Date Visited]
FROM Users
WHERE LastLogin = CAST(GETDATE() AS DATE);
GO
SELECT * FROM [Users Today];

-- 17. create a table Groups.Groups should have unique name 
-- (use unique constraint). Define primary key and identity column.
CREATE TABLE [Groups]
(
	[GroupsId] INT NOT NULL IDENTITY PRIMARY KEY,
	[Name] NVARCHAR(100) NOT NULL UNIQUE,
	CHECK (LEN([Name]) >= 3)
)

-- 18. add a column GroupID to the table Users.Fill some data in this 
-- new column and as well in the Groups table. Write a SQL statement 
-- to add a foreign key constraint between tables Users and Groups tables.
ALTER TABLE [Users]
	ADD [GroupsID] INT NULL;
 
ALTER TABLE [Users]
	ADD CONSTRAINT FK_Users_Groups
		FOREIGN KEY ([GroupsID]) REFERENCES Groups ([GroupsID]);

-- 19. insert several records in the Users and Groups tables.

INSERT INTO Users ([UserName], [PassWord], [FullName], [LastLogin]) 
VALUES ('Ivan', 'parola123', 'Ivan Ivanov', GETDATE());
INSERT INTO Users ([UserName], [PassWord], [FullName], [LastLogin]) 
VALUES ('Joro', 'test1421', 'Goergi Georgiev', GETDATE());
INSERT INTO Users ([UserName], [PassWord], [FullName], [LastLogin]) 
VALUES ('Jichka', 'tovaneeparola', 'Jichka Tokova', GETDATE());

INSERT INTO Groups([Name]) 
VALUES ('Morning Users');
INSERT INTO Groups([Name]) 
VALUES ('Mid Day Users');
INSERT INTO Groups([Name]) 
VALUES ('Evening Users');

-- 20. update some of the records in the Users and Groups tables.
UPDATE [Users]
SET [UserName] = 'Gogo', [FullName] = 'Georgi Ivanov'
WHERE [UserName] = 'Joro';
UPDATE [Users]
SET [UserName] = 'Ivanov', [FullName] = 'Ivan Georgiev'
WHERE [UserName] = 'Ivan';

UPDATE [Groups]
SET [Name] = 'Dunked Group'
WHERE [Name] = 'Evening Users';
UPDATE [Groups]
SET [Name] = 'Shiny Group'
WHERE [Name] = 'Morning Users';

-- 21. delete some of the records from the Users and Groups tables.
DELETE FROM [Users]
WHERE [UserName] = 'Gogo';
DELETE FROM [Users]
WHERE [UserName] = 'Ivanov';

DELETE FROM [Groups]
WHERE [Name] = 'Dunked Group';
DELETE FROM [Groups]
WHERE [Name] = 'Shiny Group';

-- 22. insert in the Users table the names of all employees from the Employees table.
-- Combine the first and last names as a full name. For username use the first letter
-- of the first name + the last name (in lowercase). Use the same for the password,
-- and NULL for last login time.

INSERT INTO Users ([UserName], [PassWord], [FullName], [LastLogin])
SELECT LOWER(LEFT(emp.FirstName, 1) + emp.LastName + CAST(emp.EmployeeID AS NVARCHAR(10))) AS UserName,
	LOWER(LEFT(emp.FirstName, 1) + emp.LastName + CAST(emp.EmployeeID AS NVARCHAR(10))) AS [PassWord],
	emp.FirstName + ' ' + emp.LastName AS [FullName], 
	NULL AS [LastLogin]
FROM Employees emp

-- 23. that changes the password to NULL for all users 
-- that have not been in the system since 10.03.2010.

UPDATE USERS
SET [LastLogin] = '2010-03-09'
WHERE RIGHT([UserName], 1) = '3'

UPDATE Users
SET [PassWord] = NULL
WHERE [LastLogin] <= '2010-03-10' 

-- 24. that deletes all users without passwords (NULL password).
DELETE FROM [Users]
WHERE [PassWord] IS NULL

-- 25. display the average employee salary by department and job title.
SELECT AVG(emp.Salary) AS [Averaeg Salary],
	dep.Name AS [Department Name],
	emp.JobTitle	
FROM Employees emp
JOIN Departments dep
ON dep.DepartmentID = emp.DepartmentID
GROUP BY dep.Name, emp.JobTitle;

-- 26. display the minimal employee salary by department and job title
-- along with the name of some of the employees that take it.
SELECT DISTINCT emp.Salary, dep.Name AS [Department Name], emp.JobTitle, emp.FirstName + ' ' + emp.LastName
FROM Employees emp
JOIN Departments dep
ON dep.DepartmentID = emp.DepartmentID
WHERE emp.EmployeeID =
	(SELECT TOP 1 e.EmployeeID
	FROM Employees e
	WHERE e.Salary = 
	(SELECT MIN(Salary) FROM Employees WHERE DepartmentID = dep.DepartmentID))

-- 27. display the town where maximal number of employees work.
-- a)
SELECT TOP 1 COUNT(a.AddressID) AS [Employees Working], t.Name
FROM Towns t
JOIN Addresses a
ON a.TownID = t.TownID
GROUP BY t.TownID, t.Name
ORDER BY [Employees Working] DESC
-- b)
SELECT TOP 1 t.Name AS [Town With max Employees]
FROM Towns t
JOIN Addresses a
ON a.TownID = t.TownID
GROUP BY t.TownID, t.Name
ORDER BY COUNT(a.AddressID) DESC

-- 28. display the number of managers from each town.
SELECT COUNT(m.EmployeeID) AS [Managers Count], t.Name
FROM Employees e
JOIN Employees m 
ON m.EmployeeID = e.ManagerID
JOIN Addresses a
ON a.AddressID = m.AddressID
JOIN Towns t
ON t.TownID = a.TownID
GROUP BY t.TownID, t.Name

-- 29. Write a SQL to create table WorkHours to 
-- store work reports for each employee.
-- Each employee should have id, date, task, hours and comments. 
-- Don't forget to define identity, primary key and appropriate foreign key.
CREATE TABLE [WorkHours]
(
	[WorkHoursID] INT IDENTITY PRIMARY KEY,
	[EmployeeID] INT NOT NULL UNIQUE,
	[Date] DATE,
	[Tasks] NVARCHAR(MAX),
	[Hours] INT,
	[Comments] NVARCHAR(MAX)
	CONSTRAINT FK_WorkHours_Employees
		FOREIGN KEY ([EmployeeID]) REFERENCES Employees ([EmployeeID])
)

-- 30. Issue few SQL statements to insert, update and delete of some data in the table.
INSERT INTO [WorkHours] ([EmployeeID],[Date],[Tasks], [Hours], [Comments])
VALUES (1,
	GETDATE(),
	'Receate the DataBase. Drink coffee.',
	4,
	'Vary Good Employee'),
	(2,
	GETDATE(),
	'1.Drink coffee.2.Go to Sleep.',
	4,
	'Not so Good Employee'),
	(3,
	GETDATE(),
	'',
	4,
	'Good Employee');

INSERT INTO [WorkHours] ([EmployeeID],[Date],[Tasks], [Hours], [Comments])
VALUES (3, GETDATE(), '1.Task.2TAsk', 3, 'Some Comment');

UPDATE [WorkHours]
SET [Tasks] = '1.Big Task. 2.Smaller Task'
WHERE EmployeeID = 3;

DELETE FROM [WorkHours]
WHERE EmployeeID = 3;

-- 31. Define a table WorkHoursLogs to track all changes in the WorkHours table with triggers.
-- For each change keep the old record data, the new record data and the command (insert / update / delete).
CREATE TABLE [WorkHoursLogs]
(
	[WorkHoursLogsId] INT IDENTITY PRIMARY KEY,
	[WorkHoursID] INT,
	[ComandType] NVARCHAR(6) NOT NULL,
	[OldData] NVARCHAR(MAX),
	[NewData] NVARCHAR(MAX),
)
GO

CREATE TRIGGER tr_WorkHoursLogs 
ON [WorkHours] 
FOR UPDATE, INSERT, DELETE
AS
BEGIN
	DECLARE @action as NVARCHAR(6);
    SET @action = 'INSERT';

	DECLARE @workHoursID INT;
	SET @workHoursID = (SELECT i.WorkHoursID FROM INSERTED i);

    IF EXISTS(SELECT * FROM DELETED)
    BEGIN
		SET @workHoursID = (SELECT d.WorkHoursID FROM DELETED d);
        SET @action =
            CASE
                WHEN EXISTS(SELECT * FROM INSERTED) THEN 'UPDATE'
                ELSE 'DELETE'  
            END
    END

	INSERT INTO dbo.WorkHoursLogs
	(	    
		dbo.WorkHoursLogs.WorkHoursID,
		dbo.WorkHoursLogs.ComandType,
		dbo.WorkHoursLogs.OldData,
		dbo.WorkHoursLogs.NewData
	)
	VALUES
	(	   
		@workHoursID,
		@action,
		(SELECT 'Tasks:'+ d.Tasks +
			',Comments:' + d.Comments 
			FROM DELETED d),
		(SELECT 'Tasks:'+ i.Tasks +
			',Comments:' + i.Comments 
			FROM INSERTED i)
	)
END
GO

-- 32. Start a database transaction, delete all employees from the
-- 'Sales' department along with all dependent records from the pother tables.
-- At the end rollback the transaction.

SELECT 'ALTER TABLE ' +  OBJECT_SCHEMA_NAME(parent_object_id) +
    '.[' + OBJECT_NAME(parent_object_id) + 
    '] DROP CONSTRAINT ' + name AS Query
INTO #QueryTable
FROM sys.foreign_keys
WHERE referenced_object_id = object_id('EMPLOYEES')

SELECT *
FROM #QueryTable

BEGIN TRAN
DECLARE empCursor CURSOR READ_ONLY FOR
  SELECT Query FROM #QueryTable

OPEN empCursor
DECLARE @query char(100)
FETCH NEXT FROM empCursor INTO @query

WHILE @@FETCH_STATUS = 0
  BEGIN
    EXEC(@query)
    FETCH NEXT FROM empCursor 
    INTO @query
  END

CLOSE empCursor
DEALLOCATE empCursor

DECLARE @salesDepartmentID INT;
SET @salesDepartmentID = (SELECT d.DepartmentID FROM Departments d WHERE d.Name = 'Sales');

DELETE FROM Employees 
WHERE DepartmentID = @salesDepartmentID;

ROLLBACK TRAN

-- Problem 33. Start a database transaction and drop the table EmployeesProjects.
-- Then how you could restore back the lost table data?

-- a)
BEGIN TRAN
DROP TABLE EmployeesProjects
ROLLBACK TRAN
GO

SELECT * FROM EmployeesProjects

-- b)
SELECT *
INTO #TempEmployeesProjects
FROM EmployeesProjects

DROP EmployeesProjects
SELECT *
INTO EmployeesProjects
FROM #TempEmployeesProjects




-- 34. Find how to use temporary tables in SQL Server.
-- Using temporary tables backup all records from EmployeesProjects
-- and restore them back after dropping and re-creating the table.
SELECT *
INTO #Temp1
FROM EmployeesProjects

DROP TABLE EmployeesProjects

SELECT *
INTO EmployeesProjects
FROM #Temp1 

SELECT *
FROM EmployeesProjects
GO
