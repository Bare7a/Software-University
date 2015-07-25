SELECT 
	e.FirstName,e.LastName,
	m.FirstName as [ManagerFirstName], 
	m.LastName as [ManagerLastName]
FROM Employees e
LEFT OUTER JOIN Employees m
ON e.ManagerID=m.EmployeeID