select * from Employees

select * from products

-- select second highest unit price in the table
select Max( Products.UnitPrice ) from Products
where products.UnitPrice < (select MAX( Products.UnitPrice ) from Products) 

-- select top highest unit price in the table
select Max( products.unitprice ) from Products

-- find the Nth highest unit price using sub-query
select top 1 UnitPrice
from	(
		-- here highest 4th unit price will come --
		select distinct top 4 Products.UnitPrice
		from Products
		order by UnitPrice desc
		)
		AS RESULT
order by UnitPrice

-- find the Nth highest unit price using CTE ( comman table expression )

with RESULT1 as
(select UnitPrice , DENSE_RANK () over ( order by UnitPrice desc )
as DENSERANK
from Products)
select top 1 UnitPrice
from RESULT1
Where RESULT1.DENSERANK = 2 -- here you can change value
-- same query but order is change
select top 1 UnitPrice
from (select UnitPrice , DENSE_RANK () over ( order by UnitPrice desc )
as denserank
from Products) AS RESULT
Where RESULT.denserank = 5 -- here you can change value

-- if duplicate value exists in table this query will not work properly
-- for finding the Nth highest unit price  
with RESULT2 as
(select UnitPrice ,  ROW_NUMBER () over ( order by UnitPrice desc )
as  ROWNUMBER
from Products)
select top 1 UnitPrice
from RESULT2
Where RESULT2.ROWNUMBER = 12 -- 11 and 12 have duplicate value 
							 -- so it will give the same value 
							 -- on both positions 
-- creating table 
Create table departments
(
ID int primary key identity,
name nvarchar(50),
location nvarchar(50)
)
-- creating table
Create table Employees
(
	id int primary key identity,
	FirstName nvarchar(50),
	LastName nvarchar(50),
	Gender nvarchar(50),
	Salary int,
	DepartmentId int foreign key references Departments(ID)
)
-- inserting data
insert into departments values ('IT', 'New York')
insert into departments values ('HR', 'London')
insert into departments values ('Payroll', 'Sydney')
-- inserting data
insert into Employees values ('Mark', 'Hastings', 'Male', 60000 , 1)
insert into Employees values ('Steve', 'Pound', 'Male', 45000 , 3)
insert into Employees values ('Ben', 'Hoskins', 'Male', 70000 , 1)
insert into Employees values ('Philip', 'Hastings', 'Male', 45000 , 2)
insert into Employees values ('Mart', 'Lambeth', 'Female', 30000 , 2)
insert into Employees values ('Valarie', 'Vikings', 'Female', 35000 , 3)
insert into Employees values ('John', 'Stanmore', 'Male', 80000 , 1)

select * from Employees

select * from departments

delete from Employees where Employees.Id between 8 and 14

delete from Departments where Departments.Id between  4 and 6

-- Creating Table
Create Table Countries
(
Country nvarchar(50),
City nvarchar(50)
)

insert into Countries values ('USA','New York')
insert into Countries values ('USA','Houston')
insert into Countries values ('USA','Dallas')

insert into Countries values ('India','Hyderabad')
insert into Countries values ('India','Bangalore')
insert into Countries values ('India','New Delhi')

insert into Countries values ('UK','London')
insert into Countries values ('UK','Birmingham')
insert into Countries values ('UK','Manchester')

Select * from Countries

Drop table countries


-- transposing rows into columns  
select country, city1, city2, city3
from
(
select country , city,
		'city' + CAST(ROW_NUMBER() over ( partition by country order by country)
		as varchar(10))
		as ColumnSequence from Countries
)
Temp
PIVOT 
(
	max(city)
	for columnsequence in (city1,city2,city3)
)
piv


--practice
select * from Customers

-- select sample database
alter procedure EmployeeNameChange
@Id int = 0 ,
@FirstName nvarchar(40) = null ,
@LastName nvarchar(20) = null,
@Gender nvarchar(20) = null,
@Salary int = null,
@DepartmentId int = null
as
begin

if(@Id is null)
INSERT INTO Employees(FirstName,LastName,Gender,Salary,DepartmentId) Values(@FirstName,@LastName,@Gender,@Salary,@DepartmentId)
 else
	UPDATE sample.dbo.Employees SET
	FirstName = coalesce(@FirstName, FirstName)

	WHERE Id=@Id
END
GO

EXEC EmployeeNameChange  @Id = 35,  @FirstName = 'Stored 2 procedure working',
 @LastName = 'khan' , @Gender = 'male' , @Salary = '2500' , @DepartmentId = 5;

select * from Employees

insert into Sample.dbo.Employees values ('owais','khan',  '' , 60000 , '');

insert into Sample.dbo.Employees values ( '' , '' , '' , '' , '' )

delete from Employees where id between 17 and 18






