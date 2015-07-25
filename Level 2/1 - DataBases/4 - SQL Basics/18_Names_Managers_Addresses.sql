SELECT 
	e.FirstName,
	e.LastName,
	m.FirstName as [ManagerFirstName],
	m.LastName as [MangerLastName],
	a.AddressText as [Address]
	
FROM Employees e
INNER JOIN Employees m
ON e.ManagerID=m.EmployeeID
INNER JOIN Addresses a
ON e.AddressID = a.AddressID