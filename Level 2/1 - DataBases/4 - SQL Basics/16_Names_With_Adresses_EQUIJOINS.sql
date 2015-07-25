SELECT 
	e.FirstName,e.LastName, a.AddressText as Adress
FROM Employees e, Addresses a
WHERE e.AddressID = a.AddressID