SELECT 
	e.FirstName,e.LastName, a.AddressText as Adress
FROM Employees e
INNER JOIN Addresses a
ON e.AddressID=a.AddressID