SELECT 
	TOP 5 e.Salary, 
	e.FirstName + ' '+ e.LastName as [Full Name],
	e.JobTitle
FROM Employees e
ORDER BY e.Salary DESC