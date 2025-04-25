create database db_Assessment
create table customers(CustomerID int primary key,CustomerName VARCHAR(20),city varchar(30))
insert into customers(CustomerID,CustomerName,city)
values(1,'Alice','Newyork')
insert into customers(CustomerID,CustomerName,city)
values(2,'Bob','Chicago')
insert into customers(CustomerID,CustomerName,city)
values(3,'Charlie','Los Angelas')
insert into customers(CustomerID,CustomerName,city)
values(4,'David','Houston')
select * from customers
select * from orders

create table orders(OrderID int primary key,
customers int,
foreign key(customers)references customers(customerid),
OrderDate int,
TotalAmount int)
insert into orders(OrderID,customers,OrderDate,TotalAmount)
values(101,1,2024-02-15,500)
insert into orders(OrderID,customers,OrderDate,TotalAmount)
values(102,2,2024-02-16,700)
insert into orders(OrderID,customers,OrderDate,TotalAmount)
values(103,1,2024-02-01,200)
insert into orders(OrderID,customers,OrderDate,TotalAmount)
values(104,3,2024-02-05,900)
insert into orders(OrderID,customers,OrderDate,TotalAmount)
values(105,2,2024-02-07,450)
update orders set orderdate=2024-03-01 where OrderID=103
update orders set orderdate=2024-03-05 where OrderID=104
update orders set orderdate=2024-03-07 where OrderID=105

alter table orders
alter column orderdate datetime 



select c.customername,sum(o.TotalAmount)
from customers c join orders o on c.Customerid=o.customers
group by c.CustomerName

select c.CustomerName,max(o.Totalamount)
from customers c join orders o on c.CustomerID=o.customers
group by c.CustomerID


select count(*)
FROM ORDERS
WHERE OrderDate='MARCH 2024'




