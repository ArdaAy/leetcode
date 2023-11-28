/* Write your T-SQL query statement below */

/* Time Limit Exceeded
SELECT 
    t2.product_name,
    t1.year,
    t1.price
FROM Sales t1,Product t2
WHERE t1.product_id = t2.product_id
*/

/* Time Limit Exceeded
SELECT 
    t2.product_name,
    t1.year,
    t1.price
FROM Sales t1
LEFT OUTER JOIN Product t2 ON t1.product_id = t2.product_id
*/
/* 6608ms */
SELECT 
    t2.product_name,
    t1.year,
    t1.price
FROM Sales t1
INNER JOIN Product t2 ON t1.product_id = t2.product_id
