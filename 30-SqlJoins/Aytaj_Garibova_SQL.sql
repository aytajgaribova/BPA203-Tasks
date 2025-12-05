CREATE DATABASE CompanyDB;
USE CompanyDB;



CREATE TABLE Countries (
    Id INT IDENTITY PRIMARY KEY,
    Name VARCHAR(100) NOT NULL
);


CREATE TABLE Cities (
    Id INT IDENTITY PRIMARY KEY,
    Name VARCHAR(100) NOT NULL,
    CountryId INT NOT NULL,
    FOREIGN KEY (CountryId) REFERENCES Countries(Id)
);


CREATE TABLE Employees (
    Id INT IDENTITY PRIMARY KEY,
    Name VARCHAR(100) NOT NULL,
    Surname VARCHAR(100) NOT NULL,
    Age INT NOT NULL,
    Salary DECIMAL(10,2) NOT NULL,
    Position VARCHAR(100),
    CityId INT NOT NULL,
    IsDeleted BIT NOT NULL DEFAULT 0,
    FOREIGN KEY (CityId) REFERENCES Cities(Id)
);

INSERT INTO Countries (Name)
VALUES ('Azerbaijan'),
       ('Turkey'),
       ('USA');


INSERT INTO Cities (Name, CountryId)
VALUES ('Baku', 1),
       ('Ganja', 1),
       ('Istanbul', 2),
       ('Ankara', 2),
       ('New York', 3);


INSERT INTO Employees (Name, Surname, Age, Salary, Position, CityId, IsDeleted)
VALUES 
('Ali', 'Aliyev', 28, 1500, 'Developer', 1, 0),
('Aygun', 'Mammadova', 32, 2500, 'Manager', 2, 0),
('Murad', 'Huseynov', 24, 2200, 'Reseption', 3, 0),
('Leyla', 'Nuriyeva', 29, 1800, 'Reseption', 4, 1),  
('John', 'Smith', 40, 3000, 'Team Lead', 5, 0),
('Nigar', 'Taghizade', 26, 1200, 'Designer', 1, 1);  

SELECT e.Name,
       e.Surname,
       e.Age,
       e.Salary,
       e.Position,
       c.Name AS City,
       co.Name AS Country
FROM Employees e
JOIN Cities c ON e.CityId = c.Id
JOIN Countries co ON c.CountryId = co.Id;

SELECT e.Name,
       e.Surname,
       e.Salary,
       co.Name AS Country
FROM Employees e
JOIN Cities c ON e.CityId = c.Id
JOIN Countries co ON c.CountryId = co.Id
WHERE e.Salary > 2000;

SELECT c.Name AS City,
       co.Name AS Country
FROM Cities c
JOIN Countries co ON c.CountryId = co.Id;

SELECT e.Name,
       e.Surname,
       e.Age,
       e.Salary,
       e.Position,
       c.Name AS City,
       co.Name AS Country
FROM Employees e
JOIN Cities c ON e.CityId = c.Id
JOIN Countries co ON c.CountryId = co.Id
WHERE e.Position = 'Reseption';

SELECT e.Name,
       e.Surname,
       c.Name AS City,
       co.Name AS Country
FROM Employees e
JOIN Cities c ON e.CityId = c.Id
JOIN Countries co ON c.CountryId = co.Id
WHERE e.IsDeleted = 1;

