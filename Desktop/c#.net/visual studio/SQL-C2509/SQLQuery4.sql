--USE DemoDB
--lab1 
--CREATE TABLE Sales (
--    SaleID INT PRIMARY KEY,        -- Unique identifier for each sale
--    ProductID INT,                 -- Identifier for each product
--    ProductName VARCHAR(100),       -- Name of the product
--    QuantitySold INT,              -- Quantity of the product sold
--    SaleAmount DECIMAL(10, 2),     -- Sale amount in currency (allowing two decimal places)
--    SaleDate DATE                  -- Date of the sale
----);

--INSERT INTO Sales (SaleID, ProductID, ProductName, QuantitySold, SaleAmount, SaleDate)
--VALUES 
--(1, 101, 'Laptop', 5, 5000, '2024-09-01'),
--(2, 102, 'Mouse', 10, 250, '2024-09-02'),
--(3, 101, 'Laptop', 3, 3000, '2024-09-03'),
--(4, 103, 'Keyboard', 8, 800, '2024-09-04'),
--(5, 102, 'Mouse', 6, 150, '2024-09-05');

--1.Calculate the total sales amount for all products (SUM):
--SELECT SUM(SaleAmount) AS TotalSalesAmount
--FROM Sales;

----2.Find the maximum quantity sold of any product (MAX):
--SELECT MAX(QuantitySold) AS MaxQuantitySold
--FROM Sales;
----3.Calculate the average sale amount per sale (AVG):
--SELECT AVG(SaleAmount) AS AvgSaleAmount
--FROM Sales;

----4.Find the minimum sale amount in the database (MIN):
--SELECT MIEmployeeID, EmployeeName, Department, Salary, HireDateN(SaleAmount) AS MinSaleAmount
--FROM Sales;

----5.Calculate the total quantity sold of a specific product, say "Laptop" (SUM with WHERE clause):

--SELECT SUM(QuantitySold) AS TotalLaptopsSold
--FROM Sales
--WHERE ProductName = 'Laptop';


--lab2 Employees
--create table Employee(
--EmployeeID int identity(1,1),
--EmployeeName varchar(50),
--Department varchar(50),
--Salary int,
--HireDate date
--)
--created table

--insert into Employee(EmployeeName, Department, Salary, HireDate)
--values
--('John Doe', 'IT', 5000, '2022-01-10'),
--('Jane Smith', 'HR', 6000, '2021-03-15'),
--('Bob Johnson', 'Finance', 5500, '2020-06-20'),
--('Alice Brown', 'IT', 6200, '2023-02-01'),
--('Charlie White', 'Marketing', 4800, '2023-03-10')
--inserted values

--select sum(Salary) as totalsalaryexpenditure from Employee
--selected total salary expenditure

--select max(Salary) as highestsalary from Employee
--selected highest salary

--select avg(Salary) as averagesalary from Employee
--selected average salary

--select min(Salary) as minsalary from Employee where Department = 'IT'
--selected minimum salary of IT

--select Department, count (*) as totalemployees from Employee
--group by Department
--selected and counted total number of employees in each department


--lab3 ******Inventory Management
--CREATE TABLE Inventory (
--    ProductID INT,
--    ProductName VARCHAR(50),
--    QuantityInStock INT,
--    ReorderLevel INT,
--    LastRestockDate DATE
--);
--INSERT INTO Inventory ( ProductName, QuantityInStock, ReorderLevel, LastRestockDate)
--VALUES
--( 'Monitor', 50, 10, '2024-08-25'),
--( 'Printer', 30, 5, '2024-09-01'),
--( 'Mouse', 100, 15, '2024-09-10'),
--( 'Keyboard', 80, 20, '2024-09-15'),
--( 'Laptop', 25, 5, '2024-09-20')

--1.Total Quantity of Products
--SELECT SUM(QuantityInStock) AS Total
--FROM Inventory;

----2. Highest Quantity 
--SELECT ProductName, QuantityInStock
--FROM Inventory
--WHERE QuantityInStock = (SELECT MAX(QuantityInStock) FROM Inventory);


----3.Average Reorder level
--SELECT AVG(ReorderLevel) AS Average
--FROM Inventory;

----4.Lowest Reorder Level
--SELECT ProductName, ReorderLevel
--FROM Inventory
--WHERE ReorderLevel = (SELECT MIN(ReorderLevel) FROM Inventory);


----5.total quantity less than reorder level
--SELECT SUM(QuantityInStock) AS Total
--FROM Inventory
--WHERE QuantityInStock < ReorderLevel;

--lab4 ********Customer Orders Database
--CREATE TABLE CustomerOrders (
--    OrderID INT,
--    CustomerID VARCHAR(10),
--    OrderDate DATE,
--    OrderAmount DECIMAL(10, 2),
--    QuantityOrdered INT
--);

--INSERT INTO CustomerOrders (OrderID, CustomerID, OrderDate, OrderAmount, QuantityOrdered)
--VALUES
--(501, 'C001', '2024-09-10', 1500, 3),
--(502, 'C002', '2024-09-11', 2000, 5),
--(503, 'C001', '2024-09-12', 1000, 2),
--(504, 'C003', '2024-09-13', 2500, 4),
--(505, 'C002', '2024-09-14', 3000, 6);

----1. total order amount 
--SELECT SUM(OrderAmount) AS Total
--FROM CustomerOrders

------2.avaerage order amount
--SELECT AVG(OrderAmount) AS Average
--FROM CustomerOrders

------3. maximum order amount
--SELECT MAX(OrderAmount) AS Maximum
--FROM CustomerOrders

------4. total quantity for all orders
--SELECT SUM(QuantityOrdered) AS Total
--FROM CustomerOrders

------5.minimum ordered amount
--SELECT MIN(OrderAmount) AS Minimum
--FROM CustomerOrders

--Lab6****Product Ratings Databases
-- Create the ProductRatings table
--CREATE TABLE ProductRatings (RatingID INT PRIMARY KEY,
--    ProductID VARCHAR(10),
--    CustomerID VARCHAR(10),
--    Rating INT ,
--    ReviewDate DATE
--);

---- Insert values into the ProductRatings table
--INSERT INTO ProductRatings (RatingID, ProductID, CustomerID, Rating, ReviewDate) 
--VALUES(1, 'P001', 'C001', 4, '2024-09-01'),
--(2, 'P002', 'C002', 5, '2024-09-02'),
--(3, 'P001', 'C003', 3, '2024-09-03'),
--(4, 'P003', 'C001', 2, '2024-09-04'),
--(5, 'P002', 'C004', 4, '2024-09-05');

--1. Average rating for each product
--SELECT ProductID,AVG(Rating) AS Rating
--FROM ProductRatings
--GROUP BY ProductID

----2.Highest rating 
--SELECT MAX(Rating) AS Maximum
--FROM ProductRatings

----3.Lowest rating
--SELECT MIN(Rating) AS Minimum
--FROM ProductRatings

----4.total number of rating for each product
--SELECT ProductID,COUNT(Rating) AS Rating
--FROM ProductRatings
--GROUP BY ProductID

----5.total number of products rated
--SELECT COUNT(DISTINCT ProductID) AS TotalProducts
--FROM ProductRatings;


--**SQL Server assignments and solutions using various SQL operators such as IN,
--BETWEEN, LIKE, AND, OR, NOT, etc.***

--Lab1 Using IN Operator
--SELECT EmployeeName
--FROM Employees
--WHERE Department IN('HR','IT','Finance')

--lab2 Using BETWEEN Operator
--UPDATE ProductRatings
--SET ProductName='Pen'
--WHERE ProductID='P003'

--ALTER TABLE ProductRatings
--ADD Price INT

--UPDATE ProductRatings
--SET Price=50000
----WHERE ProductID='P001'

--SELECT ProductName,Price
--FROM ProductRatings
--WHERE Price BETWEEN 100 AND 500

----lab3--whose name start with 'a' in EmployeeNmae Table
--SELECT EmployeeName
--FROM Employees
--WHERE EmployeeName LIKE 'A%'

----lab4--Using IN Operator in CustomerOrders
--SELECT OrderID
--FROM CustomerOrders
--WHERE OrderDate IN('2024-09-10','2023-02-01','2024-09-12')

----lab5--Using NOT BETWEEN in ProductRatings
--SELECT ProductName,Price
--FROM ProductRatings
--WHERE Price NOT BETWEEN 100 AND 500

----lab6--Using OR Operator in CustomerOrders
--SELECT OrderID
--FROM CustomerOrders
--WHERE OrderAmount>500 OR OrderAmount<1000

----lab7--Using NOT IN in Employee Table
--SELECT EmployeeName
--FROM Employees
--WHERE Department NOT IN('HR','IT')

---Lab8--Orders Placed in 2023 Using BETWEEN and AND Operators
--SELECT OrderID
--FROM CustomerOrders
--WHERE OrderDate BETWEEN '2024-01-01' AND '2024-12-31'

---Lab9--Who Do Not Have 'John' in Their Name Using NOT LIKE Operator
--SELECT EmployeeName
--FROM Employees
--WHERE EmployeeName NOT LIKE '%John%'

--lab10--products that are either in Customerid>2 or have a price less than 100. 
--SELECT * FROM ProductRatings
--SELECT * FROM CustomerOrders
--SELECT Pro.ProductName
--FROM ProductRatings AS Pro ,CustomerOrders
--WHERE CustomerOrders.CustomerID>'C003' OR Pro.Price<100


--**Alter Table Command-----THEORY  ***
--Lab1----Adding A new Column
--ALTER TABLE Employees
--ADD Email VARCHAR(40)

----Lab2----Dropping a Column
--ALTER TABLE Employees
--DROP COLUMN Email

----SELECT * FROM Employees
----Lab3----Modifying Column Datatype
--ALTER TABLE Employees
--ALTER COLUMN Salary DECIMAL(10,2)

----Lab4---Adding a Primary Key
--ALTER TABLE Employees
--DROP CONSTRAINT PK__Employee__7AD04FF11222D3C0

--ALTER TABLE Employees
--ADD CONSTRAINT PK_Employees PRIMARY KEY(EmployeeID)

--ALTER TABLE Employees
--DROP CONSTRAINT PK_Employees

--LAB6 Adding a foreign key
--CASE 1::::TO ADD a foreign key first u need to add the column (if column not there) and add constarint
--created table department
--CREATE TABLE Department(EmployeeID INT,
--						DepartmentID INT PRIMARY KEY IDENTITY(100,2),
--						Department VARCHAR(50))

----adding column deptID to Employee since there was no column
--ALTER TABLE Employees
--ADD DepartmentID INT

----Adding foreign key by Altering the employee
--ALTER TABLE Employees
--ADD CONSTRAINT FK_Emp_Dep
--FOREIGN KEY(DepartmentID) REFERENCES Department(DepartmentID)

----CASE 2:::::Adding employeeID as foreign key in department table
----here already we have given the EmployeeID INT int create table
----so just need to alter the table only

--ALTER TABLE Department
--ADD CONSTRAINT FK_Dept_Emp
--FOREIGN KEY(EmployeeID)REFERENCES Employees(EmployeeID) 

----LAB7....Dropping a foreign key
--ALTER TABLE Employees
--DROP CONSTRAINT FK_Emp_Dep


--LAB8--Renaming Column
--EXEC SP_RENAME 'Employees.EmployeeName','FullName','COLUMN';

----LAB9--Adding defualt constraint
--ALTER TABLE Employees
--ADD CONSTRAINT DF
--DEFAULT GETDATE() FOR HIREDATE;

----Lab10----ADDING UNIQUE
--ALTER TABLE Employees
--ADD CONSTRAINT UQ_FullName UNIQUE(FullName)

----lab11--Droppping unique
--ALTER TABLE Employees
--DROP CONSTRAINT UQ_FullName


---ALTER TABLE ASSIGNMENTS LABS----
--Lab1  Add A  new column
--ALTER TABLE Employees
--ADD DateOfBirth DATE

----Lab2 Modify Column Data type
--ALTER TABLE CustomerOrders
--ALTER COLUMN CustomerID VARCHAR(100)

----Lab3 and lab9  Add a Primary key and Drop a primary key
----deleting primary key already in table
----ALTER TABLE Department
----DROP CONSTRAINT DepartmentID


----adding a primary key
----ALTER TABLE Department
----ADD CONSTRAINT PK_DeptID
----PRIMARY KEY (DepartmentID)

----Lab4 Drop a Column
--ALTER TABLE Employees
--DROP COLUMN DateOFBirth

----Lab5  Add a foreign key
----adding employee id to customerOrders
----ALTER TABLE CustomerOrders
----ADD EmployeeID INT;

--ALTER TABLE CustomerOrders
--ADD CONSTRAINT FK_Emop_Cust
--FOREIGN KEY (EmployeeID) REFERENCES Employees(EmployeeID)

----Lab6 Drop a Foreign key
--ALTER TABLE CustomerOrders
--DROP CONSTRAINT FK_Emop_Cust

----Lab7 Rename a column
----EXEC sp_rename 'Employees.FullName','EmployeeName','COLUMN'

----Lab8 Add defualt values
----USING Update
--ALTER TABLE Employees
--ADD Status VARCHAR(10) DEFAULT 'Active'

--UPDATE Employees
--SET Status='Active'
--SELECT * FROM Employees

----not using update
--ALTER TABLE Employees
--ADD STATE VARCHAR(10)
--ALTER TABLE Employees
--ADD CONSTRAINT Status_Active
--DEFAULT 'Active' FOR STATE
--select * from employees

----Lab9 Dropping primary key
----ALTER TABLE SALE
----DROP CONSTRAINT PK__Sale__1EE3C41F655F753A

----Lab10 Add a UNIQUE Constraint
--ALTER TABLE Employees
--ADD Email VARCHAR(20)

--ALTER TABLE Employees
--ADD CONSTRAINT UQ_Email UNIQUE(Email)

--DELETE
--FROM Employees
--WHERE EmployeeID=6

----lab11---ADD A check constraint
--ALTER TABLE Employees
--ADD CONSTRAINT CK CHECK (Salary>1000)


------lab12---DROP A constraint
--ALTER TABLE Employees
--DROP CONSTRAINT CK



---**LAB  SUBQUERIES***------------

--Lab1 Retrieve Employees Who Earn More Than the Average Salary 
--SELECT EmployeeName,Salary
--FROM Employees
--WHERE SALARY>(SELECT AVG(SALARY)
--			  FROM Employees)

----Lab2 Find Departments with More Than 5 Employees  
----EXEC sp_rename'Employees.Department','Dep','COLUMN'

----UPDATE Employees
----SET Dep='IT'
----WHERE EmployeeID IN(1,2,3,4,5)
--SELECT *
--FROM Employees

--SELECT DISTINCT Dep
--FROM Employees
--WHERE Dep IN(SELECT Dep
--				FROM Employees
--				GROUP BY Dep
--				HAVING COUNT(Dep)>=3)

----Lab3---Retrieve Products with a Price Higher Than the Maximum Price of Category '2'
----	CREATE TABLE Products(ProductID INT PRIMARY KEY,
----						  ProductName VARCHAR(20),
----						  Price INT)
----	INSERT INTO Products (ProductID, ProductName, Price)
----VALUES 
----(1, 'Laptop', 75000),
----(2, 'Smartphone', 30000),
----(3, 'Headphones', 1500),
----(4, 'Monitor', 10000);


----CREATE TABLE Categories(CategoryID INT PRIMARY KEY,
----							CategoryName VARCHAR(50),
----							ProductID INT,
----							FOREIGN KEY (ProductID)REFERENCES Products(ProductID))
----INSERT INTO Categories (CategoryID, CategoryName, ProductID)
----VALUES 
----(1, 'Electronics', 1),  -- Assuming ProductID 1 exists
----(2, 'Mobile Devices', 2), -- Assuming ProductID 2 exists
----(3, 'Audio', 3),         -- Assuming ProductID 3 exists
----(4, 'Monitors', 4);    
--SELECT * FROM Products
--SELECT * FROM Categories
--SELECT ProductName,Price
--FROM Products
--WHERE Price>(SELECT MAX(Price)
--			FROM Products AS P,Categories AS C
--			WHERE C.CategoryID=2 AND P.ProductID=C.ProductID)


----Lab4. Retrieve Employees Who Work in Departments with Average Salary Higher Than 50,00
----SELECT *
----FROM Employees
--SELECT EmployeeName,Salary
--FROM Employees
--WHERE Dep IN(SELECT Dep
--			FROM Employees
--			GROUP BY Dep
--			HAVING AVG(Salary)>50000)

----lab5.Find Employees Who Earn More Than Their Department's Average Salary
--SELECT EmployeeName,Salary
--FROM Employees
--WHERE Salary>(SELECT AVG(SALARY)
--			 FROM Employees
--			 WHERE Dep=Employees.Dep)
----			 

----Lab6.Find Customers Who Have Not Placed Any Orders
--SELECT DISTINCT EmployeeName
--FROM Employees AS E, CustomerOrders AS C 
--WHERE E.EmployeeID NOT IN(SELECT EmployeeID
--						  FROM CustomerOrders)

----Lab7.Retrieve Top 3 Highest-Paid Employees in Each Department
--SELECT TOP 3*
--FROM Employees 
--WHERE EmployeeID IN (SELECT EmployeeID 
--					FROM Employees
--					GROUP BY Dep)

----Lab8.Find Products That Have Never Been Ordered
--ALTER TABLE CustomerOrders
--ADD ProudctID INT

--SELECT * FROM Products
--SELECT * FROM CustomerOrders

--SELECT  ProductName
--FROM Products
--WHERE ProductID NOT IN(SELECT DISTINCT ProductID
--						FROM CustomerOrders)


--ASSIGNMENT 3 JOIN----
--Lab1---Retrieve Employees and Their Department Names (INNER JOIN) 
--all matching tables in both tables
SELECT * FROM Employees
SELECT * FROM Department

SELECT Employees.EmployeeName,Department.Department
FROM Employees INNER JOIN Department
ON Employees.EmployeeID=Department.EmployeeID
		
--Lab2--Retrieve All Employees and Their Department Names, Including Those Without Departments (LEFT JOIN) 
--all employess and dept null
SELECT * FROM Employees
SELECT * FROM Department

SELECT E.EmployeeName,D.Department
FROM Employees E LEFT OUTER JOIN Department D
ON E.EmployeeID=D.EmployeeID

--Lab3--Retrieve All Departments and the Employees Working in Them (RIGHT JOIN) 
--dept and employees null
SELECT * FROM Employees
SELECT * FROM Department	

SELECT D.Department,E.EmployeeName
FROM Employees AS E RIGHT OUTER JOIN Department D
ON E.EmployeeID=D.EmployeeID

--Lab4--Retrieve All Employees and Departments, Including Those Without Matches (FULLOUTER JOIN) 

SELECT * FROM Employees
SELECT * FROM Department

SELECT E.EmployeeName,D.Department
FROM Employees AS E FULL OUTER JOIN Department AS D
ON E.EmployeeID=D.EmployeeID
			 
--Lab5--Retrieve Orders and the Customers Who Placed Them (INNER JOIN) 
--both matching
SELECT * FROM CustomerOrders
SELECT * FROM Employees

SELECT C.OrderID,E.EmployeeName AS CustomerName
FROM CustomerOrders C INNER JOIN Employees E
ON C.EmployeeID=E.EmployeeID

--Lab6--Retrieve Orders and Customers, Including Customers Without Orders (LEFT JOIN
--cutomer and order null
--SELECT * FROM CustomerOrders
--SELECT * FROM Employees


--SELECT E.EmployeeName AS CustomerName,C.OrderID
--FROM Employees E LEFT OUTER JOIN CustomerOrders C
--ON E.EmployeeID=C.EmployeeID

--Lab7--Retrieve Products and Their Categories (INNER JOIN) 
--matching table
SELECT * FROM Products
SELECT * FROM Categories

SELECT P.ProductName,C.CategoryName
FROM Products P INNER JOIN Categories C
ON P.ProductID=C.ProductID

--Lab8--Retrieve All Categories and Products, Including Categories Without Products (RIGHT JOIN)
--categories and prodcuts null
SELECT * FROM Products
SELECT * FROM Categories

SELECT C.CategoryName,P.ProductName AS Products
FROM Categories C RIGHT OUTER JOIN Products P
ON C.CategoryID=P.CategoryID

--Lab9--Retrieve Employees and Their Managers (Self-Join)
--ALTER TABLE Employees
--ADD ManagerID INT

--UPDATE Employees
--SET ManagerID=2
--WHERE EmployeeID IN(4,5)

--SELECT * FROM Employees

--SELECT E.EmployeeName,M.EmployeeName
--FROM Employees E JOIN Employees M
--ON M.EmployeeID=E.ManagerID

--Lab10---Get All Possible Combinations of Products and Orders (CROSS JOIN) 
--SELECT P.ProductName,O.OrderID
--FROM Products P CROSS JOIN CustomerOrders O 


---ASSIGNMENTS OF GROUP BY AND HAVING

--Lab1--Find the Average Salary in Each Department 
SELECT Dep,AVG(Salary)AS AVG
FROM Employees 
GROUP BY Dep
HAVING AVG(Salary)>50000

--Lab2 --Count the Number of Employees in Each Department 
--Only display departments that have more than 2 employees.
--SELECT * FROM Department
--SELECT * FROM Employees
SELECT D.Department,COUNT(E.EmployeeID) AS COUNT
FROM Employees E
JOIN 
Department D ON E.EmployeeID=D.EmployeeID
GROUP BY D.Department
HAVING COUNT(E.EmployeeID)>=2

--Lab3---Find the Maximum and Minimum Salary in Each Department
-- Only include departments where the minimum salary is greater than 30,000
SELECT D.Department,MAX(E.Salary)AS MAX,MIN(E.Salary) AS MIN
FROM Employees E JOIN 
Department D ON E.EmployeeID=D.EmployeeID
GROUP BY D.Department
HAVING MIN(Salary)>30000

--Lab4--Find the Total Sales by Each Salesperson
SELECT * FROM Employees
SELECT * FROM Sales
SELECT E.EmployeeName AS Salesperson,SUM(S.QuantitySold) AS Sold
FROM Employees E
JOIN
Sales S ON E.EmployeeID=S.EmployeeID
GROUP BY E.EmployeeName
HAVING SUM(S.QuantitySold)>10000

--lab5--Find the Number of Orders by Each Customer --Quantity Ordered greater than 3SELECT * FROM EmployeesSELECT * FROM CustomerOrdersSELECT EmployeeName,SUM(QuantityOrdered) AS TotalFROM Employees E JOINCustomerOrders C ON E.EmployeeID=C.EmployeeIDGROUP BY E.EmployeeID,E.EmployeeNameHAVING SUM(QuantityOrdered)>3