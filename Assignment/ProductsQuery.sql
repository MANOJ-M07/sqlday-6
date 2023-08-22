create database ProductInventoryDB
USE ProductInventoryDB

CREATE TABLE Products (
    Productid INT PRIMARY KEY IDENTITY(1,1),
    ProductName NVARCHAR(255),
    Price FLOAT,
    Quantity INT,
    MfDate DATE,
    ExpDate DATE
)


INSERT INTO Products (ProductName, Price, Quantity, MfDate, ExpDate)
VALUES ('iphone', 120000.30, 2, '2023-09-18', '2025-09-19');

INSERT INTO Products (ProductName, Price, Quantity, MfDate, ExpDate)
VALUES ('Mac', 100000.30, 1, '2023-09-18', '2025-09-19');

INSERT INTO Products (ProductName, Price, Quantity, MfDate, ExpDate)
VALUES ('bike', 220000.30, 1, '2023-09-18', '2025-09-19');

INSERT INTO Products (ProductName, Price, Quantity, MfDate, ExpDate)
VALUES ('Car', 1200000.30, 1, '2023-09-18', '2025-09-19');

INSERT INTO Products (ProductName, Price, Quantity, MfDate, ExpDate)
VALUES ('ipad', 20000.30, 1, '2023-09-18', '2025-09-19');


select * from Products
