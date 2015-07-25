SELECT 
	e.FirstName, 
	e.LastName, 
	e.FirstName+'.'+e.LastName+'@softuni.bg' as Email 
FROM Employees e