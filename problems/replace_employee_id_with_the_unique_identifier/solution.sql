/* Write your T-SQL query statement below */
SELECT 
    (SELECT t2.unique_id FROM EmployeeUNI t2 WHERE t1.id = t2.id) as unique_id,
    t1.name
FROM Employees t1
