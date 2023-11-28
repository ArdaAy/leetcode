/* Write your T-SQL query statement below */
SELECT ID
FROM Weather t1
WHERE
    (
    SELECT 
        t2.temperature 
    FROM Weather t2 
    WHERE 
        t2.recordDate = dateadd(day,-1,t1.recordDate)
    ) < t1.temperature