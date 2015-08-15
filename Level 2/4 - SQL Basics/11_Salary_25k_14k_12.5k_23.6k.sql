SELECT 
	e.FirstName, 
	e.LastName,
	e.Salary 
FROM Employees e 
WHERE Salary IN (25000,14000,12500,23600)