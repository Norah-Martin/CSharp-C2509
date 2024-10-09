--lab1 create database and table
--CREATE DATABASE CompanyDB

--USE CompanyDB

--table named Employees with column
--CREATE TABLE Employees(EmployeeID INT NOT NULL PRIMARY KEY,
--						FirstName VARCHAR(50),
--						LastName VARCHAR(50),
--						Department VARCHAR(50),
--						Salary DECIMAL(10,2)) 

--lab2  insert data into table
--INSERT INTO Employees VALUES(1,'John','Doe','HR',50000)
--INSERT INTO Employees VALUES(2,'Jane','Smith','IT',60000)
--INSERT INTO Employees VALUES(3,'David','Lee','Marketing',55000)

---lab3 select and query data
--1 retrieve all emp records 
	--SELECT * FROM Employees
--2 retrieve all details of emp in IT and sal>5000
	/* SELECT FirstName,LastName,Salary
	FROM Employees
	WHERE Department='IT' AND Salary>5000 */
--3 Find highest salary 
	--SELECT MAX(Salary)
	--FROM Employees

---lab4 update data
--1 update salary of john to 55000
	/*UPDATE Employees
	SET Salary=55000
	WHERE FirstName ='John'

--2 change dept of Jane to Marketing
	UPDATE Employees
	SET Department='Marketing'
	WHERE FirstName='Jane' */

--SELECT *FROM Employees

--lab5 Delete data from a Table
--1 delete all recods of david lee
	/* DELETE 
	FROM Employees
	WHERE FirstName='David'
--2 delete emp where dept is marketing
		DELETE
		FROM Employees
		WHERE Department='Marketing' */
--SELECT *FROM Employees



--LAB6 PRODUCT MANAGEMENT
--1  Create table Prosucts and insert the values

/*
CREATE TABLE Products(ProductID INT NOT NULL PRIMARY KEY IDENTITY(1,1),
					 ProductName VARCHAR(50),
					 Category VARCHAR(50),
					 Price INT,
					 Stock INT)

INSERT INTO Products (ProductName, Category, Price, Stock)
VALUES 
('Laptop', 'Electronics', 1000, 50),
('Mouse', 'Electronics', 20, 200),
('Keyboard', 'Electronics', 30, 150),
('Printer', 'Electronics', 150, 75); */

--2  Select all columns from the Products table 
--SELECT * FROM Products

--3 Select products, sorted by their price in descending order.
-- SELECT *
--FROM Products
--ORDER BY Price DESC  

--4 Update the price of Mouse to 25
/* UPDATE Products
SET Price=25
WHERE ProductName='Mouse'   */

--5 Delete product 2 using id
/* DELETE 
FROM Products
WHERE ProductID=2  */

--6 select products sorted by product name in alphabetical order
--SELECT *
--FROM Products
--ORDER BY ProductName 

--Lab7  Library Management
-- CREATE TABLE Books(BookID INT NOT NULL PRIMARY KEY IDENTITY(1,1))
--ALTER TABLE Books
--ADD Title VARCHAR(100),Author VARCHAR(100),PublishedYear INT, AvailableCopies INT

--INSERT INTO Books(Title,Author,PublishedYear,AvailableCopies)
--VALUES
--('The Great Gatsby' ,'F. Scott Fitzgerald',1925,3),
--('1984 ' ,'George Orwell ',1949,2),
--('To Kill a Mockingbird' ,'Harper Lee',1960,5),
--('Brave New World ','Aldous Huxley ',1932,4)
--SELECT * FROM Books

--2.Update the available copies of "1984" to 5. 
--UPDATE Books
--SET AvailableCopies=5
--WHERE Title='1984'
--SELECT * FROM Books

--3 Delete the book with BookID 1 (The Great Gatsby). 
--DELETE
--FROM Books
--WHERE BookID=1
--SELECT * FROM Books

--4  Write a query to Select books published after 1950.
--SELECT *
--FROM Books
--WHERE PublishedYear>'1950'

--LAB 8 Customer Management
--CREATE TABLE Customers (CustomerID INT NOT NULL PRIMARY KEY IDENTITY(201,1),
--						CustomerName VARCHAR(50),
--						Email VARCHAR(50),
--						PhoneNumber VARCHAR (15))
--INSERT INTO Customers(CustomerName,Email,PhoneNumber)
--VALUES
--('Alice Johnson','alice@example.com','555-1234 '),
--('Bob Smith ','bob@example.com','555-5678 '),
--('Charlie Brown','charlies@example.com','555-8765' )
--SELECT * FROM Customers

--2 Insert a new customer
--INSERT INTO Customers VALUES('David Wilson','david@example.com','555-4321')
--SELECT * FROM Customers

--3 Update alice phone number
--UPDATE Customers
--SET PhoneNumber='5555-9999'
--WHERE CustomerName='Alice Johnson'
--SELECT * FROM Customers

--4 Delete customer with id=2
--DELETE
--FROM Customers
--WHERE CustomerID=202
--SELECT * FROM Customers

--lab9 Orders management
--Create Table Orders (OrderID INT PRIMARY KEY IDENTITY(301,1),
--					CustomerID INT,
--					OrderDate DATE,
--					TotalAmount Decimal(5,2))

--INSERT INTO Orders(CustomerID,OrderDate,TotalAmount )
--VALUES
--(201,'2024-09-01',250.00),
--(202,'2024-09-02',150.00),
--(203,'2024-09-03',200.00)
--SELECT *From Orders

--2  insert new value
--INSERT INTO Orders Values(204,'2024-09-04',300.00)
--SELECT *From Orders

--3 update orderid 201 to 275.00
--UPDATE Orders
--SET TotalAmount=275.00
--WHERE OrderID=302
--SELECT *From Orders

--4.delete orderid 302
--DELETE
--FROM Orders
--WHERE OrderID=302
--SELECT *From Orders

--5. Select orders with amount>200
--SELECT *
--FROM Orders
--WHERE TotalAmount>200

--6 select orderid and total amount of all orders
--SELECT OrderID,TotalAmount
--From Orders

--TYPES OF KEYS
--LAB10  PRIMARY KEY
--CREATE TABLE Students (StudentID INT PRIMARY KEY IDENTITY(1,1),
--						FirstName VARCHAR(30),
--						LastName VARCHAR(30),
--						Email VARCHAR(20))
--ALTER TABLE Students
--ALTER COLUMN Email VARCHAR(100)

--INSERT INTO Students(FirstName,LastName,Email)
--VALUES
--('John','Doe','john.doe@example.com'),
--('Jane','Smith','jane.smith@example.com'),
--('Mike','Johnson','mike.johnson@example.com')
--SELECT* FROM Students

--lab10 Foreign Key
--CREATE TABLE Courses(CourseID INT PRIMARY KEY,
--					CourseName VARCHAR(40))
--INSERT INTO Courses VALUES(1,'Science')
--INSERT INTO Courses VALUES(2,'Maths')

--SELECT *FROM Courses

--CREATE TABLE Enrollments(EnrollmentID INT PRIMARY KEY IDENTITY(100,1),
--StudentID INT,
--CourseID INT,
--FOREIGN KEY(StudentID) REFERENCES Students(StudentID),
--FOREIGN KEY(CourseID) REFERENCES Courses(CourseID))
					
--INSERT INTO Enrollments VALUES(4,2)
--SELECT *FROM Enrollments

--Lab12  Composite Key

--CREATE TABLE OrderDetails(OrderID INT IDENTITY(1,1),
--						 ProductID INT,
--						 ProductName VARCHAR(30),
--						 OrderName VARCHAR(30)
--						 PRIMARY KEY(OrderID,ProductID))
--INSERT INTO OrderDetails VALUES
--(1,'Cycle','Cycle_Deliver')
--INSERT INTO OrderDetails VALUES
--(4,'Phone','Phone_Deliver')
--SELECT * FROM OrderDetails

--Lab13 Candidate Key and Alternate Key--candidates for primary key,alternate keys are candiddate keys
--CREATE TABLE Users(UserID INT PRIMARY KEY,
--					Email VARCHAR(50) NOT NULL UNIQUE ,
--					Username VARCHAR(50) NOT NULL UNIQUE)


--INSERT INTO Users VALUES(1,'Norah@gmail.com','Norah')
--INSERT INTO Users VALUES(2,'Chelsa@gmail.com','Martin')
--INSERT INTO Users VALUES(3,'Maria@gmail.com','Maria')
--INSERT INTO Users VALUES(4,'Nora@gmail.com','Nora')

--SELECT * FROM Users

--lab14 Surrogate Key--primary key number not specified by user
--CREATE TABLE Products1(AutoID INT PRIMARY KEY IDENTITY(1,2),
--						ProductName VARCHAR(20),
--						Price INT)

--INSERT INTO Products1 VALUES('Phone',50000)
--INSERT INTO Products1 VALUES('Bottle',500)
--INSERT INTO Products1 VALUES('Pen',5)

--SELECT * FROM Products1

--lab15 Natural Key--meaningful values that identify records eg id_no
--CREATE TABLE Employees1(SSN INT PRIMARY KEY,
--						FirstName VARCHAR(20),
--						LastName VARCHAR(20),
--						Position VARCHAR(20))
--INSERT INTO Employees1 Values(1,'Norah','Martin','Junior')
--INSERT INTO Employees1 Values(2,'Chelsa','Martin','Senior')
--SELECT * FROM Employees1

--lab16 Unique Key--unique
--CREATE TABLE Customers1 (CustomerID INT PRIMARY KEY,
--						PhoneNumber VARCHAR(10) UNIQUE)
--INSERT INTO Customers1 VALUES(1,'123-456')
--INSERT INTO Customers1 VALUES(2,'123-654')

--SELECT * FROM Customers1

---VIEWS--lab17
--1.creating view
--CREATE VIEW EmployeeView AS
--SELECT FirstName,LastName,Department
--FROM Employees

--2.query the view--
--SELECT *
--FROM EmployeeView
--WHERE Department='Marketing'

--lab18  Updating data through view 
--1.creating view

--CREATE VIEW EditableEmployeeView AS
--SELECT EmployeeID,FirstName,LastName,Salary
--FROM Employees

--2. updating using view
--UPDATE EditableEmployeeView
--SET Salary=600000
--WHERE EmployeeID=3

--3.Verify the update
--SELECT * 
--FROM EditableEmployeeView

--lab19---- view with calculated column
--CREATE VIEW EmployeeSalaryBonusView AS
--SELECT FirstName,LastName,Salary,Salary*0.10 AS Bonus
--FROM Employees
--SELECT * FROM EmployeeSalaryBonusView 

--lab20---altering view
--ALTER VIEW EditableEmployeeView AS
--SELECT FirstName,LastName,Department,Salary
--FROM Employees

--DROP VIEW EditableEmployeeView

--CREATE VIEW EditableEmployeeView AS
--SELECT FirstName,LastName,Salary,Salary*2 AS NewSalary
--FROM Employees

--SELECT * FROM EditableEmployeeView

--LAB21 View WITH parameters
--CREATE VIEW FilteredEmployeeView AS
--SELECT EmployeeID,FirstName,LastName,Department
--FROM Employees

--SELECT *
--FROM FilteredEmployeeView
--WHERE Department='Marketing'

--lab22 Dropping a view
--DROP VIEW EmployeeView
--SELECT *
--FROM Employeeview





				