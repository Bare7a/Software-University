SELECT e.FirstName,e.LastName,d.Name as [Department],e.HireDate
FROM Employees e
JOIN Departments d
ON e.DepartmentID=d.DepartmentID
WHERE 
(d.Name IN ('Sales', 'Finance')) AND 
(HireDate BETWEEN '1995' AND '2005')