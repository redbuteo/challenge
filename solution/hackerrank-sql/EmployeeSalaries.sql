--https://www.hackerrank.com/challenges/salary-of-employees
/*
Enter your query here.
Please append a semicolon ";" at the end of the query and enter your query in a single line to avoid error.
*/
select name 
from Employee
where salary > 2000 and months < 10
order by employee_id 