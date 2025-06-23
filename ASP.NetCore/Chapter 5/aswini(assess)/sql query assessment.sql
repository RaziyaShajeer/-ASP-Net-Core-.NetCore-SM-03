create database assess
use assess
create table employee(
employeeid int primary key,
name varchar(20),
deptid int,
salary int,
hiredate datetime)
insert into employee(employeeid,name,deptid,salary,hiredate)values(1,'alice',10,50000,'2021-01-15')
insert into employee(employeeid,name,deptid,salary,hiredate)values(2,'bob',20,60000,'2020-0-20')
insert into employee(employeeid,name,deptid,salary,hiredate)values(3,'charlie',30,70000,'2019-07-10')
insert into employee(employeeid,name,deptid,salary,hiredate)values(4,'david',40,80000,'2022-03-01')
insert into employee(employeeid,name,deptid,salary,hiredate)values(5,'eva',50,90000,'2023-06-12')
insert into employee(employeeid,name,deptid,salary,hiredate)values(6,'eva',50,90000,'2023-06-12')

select * from employee

create table department(
deptid int,
deptname varchar(20))
insert into department(deptid,deptname)values(10,'hr')
insert into department(deptid,deptname)values(20,'it')
insert into department(deptid,deptname)values(30,'sales')
insert into department(deptid,deptname)values(40,'finance')
select * from department
--1.list all employees  with their dept name
select employee.name,department.deptname
from employee
inner join department on employee.deptid=department.deptid
--2.show the salary of employees whose salary is above the avg salary of all employee
select employee.name
from
 employee
 where salary>
 --3.display dept that have more than one employee
 select department.deptname
 from department
 inner join employee on employee.deptid=department.deptid
 group by department.deptname
 having count(employee.employeeid)>1
 --4.list all dept even if they dont have any employee
 select department.deptname
 from department
 --5.create the copy of the same table
 create view  employeecopy 
 from employee as
 select * from employee
 --6.write a query to count the number of employee in each dept and and order the result by count in desending order
 select department.deptname,count(employee.employeeid)
 as  
 --7.show the top 2 highest paid employees in the it dept
--8.use a subquery to find employees whose salary is grater than the avg salaryb of the sales dept
--9.write  a query to update the slary of employees inthe hr mnagaer 10%
--10.find the employees who earns the highest salary in each dept
