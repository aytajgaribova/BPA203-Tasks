CREATE DATABASE CompanyMM
USE CompanyMM
CREATE TABLE Employeees(
    Id int PRIMARY KEY IDENTITY,
    FirstName VARCHAR(255) NOT NULL,
    LastName VARCHAR(255) NOT NULL,
    BirthDate DATE CHECK(BirthDate> '1999.01.01'),
    Email VARCHAR(100) NOT NULL UNIQUE
);
CREATE TABLE  Projects(
    Id int PRIMARY KEY IDENTITY,
    ProjectName VARCHAR(100) NOT NULL, 
    StartDate DATE NOT NULL, 
    EndDate DATE
);
CREATE TABLE EmployeeProjects(
    Id int PRIMARY KEY IDENTITY,
    EmployeeID int FOREIGN  KEY REFERENCES Employeees(Id),
    ProjectID  int FOREIGN  KEY REFERENCES Projects(Id), 
    AssignedDate DATE NOT NULL
 );

INSERT INTO Employeees (FirstName, LastName, BirthDate, Email)
VALUES
('Kamran', 'Aliyev', '2000-05-12', 'kamranbb.aliyev@example.com'),
('Leyla', 'Mammadova', '2018-11-23', 'leyla.mammaddova@example.com'),
('Rashad', 'Huseynov', '2015-02-14', 'rashad.huseyhnov@example.com'),
('Nigar', 'Gasimova', '2012-07-30', 'nigar.gasimomva@example.com'),
('Elvin', 'Rahimov', '2005-09-19', 'elvin.rahimmov@example.com');

-- Projects
INSERT INTO Projects (ProjectName, StartDate, EndDate)
VALUES
('CRM Development', '2024-01-05', '2024-06-20'),
('Mobile App Upgrade', '2024-02-10', NULL),
('Data Analytics Platform', '2024-03-01', '2024-12-31');

-- EmployeeProjects 
INSERT INTO EmployeeProjects (EmployeeID, ProjectID, AssignedDate)
VALUES
(2, 1, '2024-01-10'),
(6, 1, '2024-01-15'),
(3, 2, '2024-02-20'),
(4, 3, '2024-03-10'),
(5, 2, '2024-02-25');

--1
SELECT * FROM Employeees
--2
SELECT * FROM Projects
--3
SELECT * FROM Employeees as e
JOIN EmployeeProjects as ep
on e.Id=ep.EmployeeID
JOIN Projects as p 
on ep.ProjectID=p.Id
--4
SELECT p.ProjectName, count( e.FirstName) FROM Employeees as e
JOIN EmployeeProjects as ep
on e.Id=ep.EmployeeID
JOIN Projects as p 
on ep.ProjectID=p.Id
GROUP BY p.ProjectName
--5
SELECT p.ProjectName, count( e.FirstName) FROM Employeees as e
JOIN EmployeeProjects as ep
on e.Id=ep.EmployeeID
JOIN Projects as p 
on ep.ProjectID=p.Id
GROUP BY p.ProjectName
HAVING count( e.FirstName)>1


--6
CREATE VIEW EmployeeProjectView
as
SELECT e.Id AS EmployeeID,e.FirstName,p.Id AS ProjectID,p.ProjectName, ep.AssignedDate FROM Employeees as e
JOIN EmployeeProjects as ep
on e.Id=ep.EmployeeID
JOIN Projects as p 
on ep.ProjectID=p.Id
SELECT * FROM EmployeeProjectView 
--7
SELECT * FROM EmployeeProjectView WHERE EmployeeID=2

--8
CREATE PROCEDURE sp_AssignEmployeeToProject(@empId int, @projId int)
AS
insert into EmployeeProjects VALUES(@empId, @projId, GETDATE());

--9
CREATE FUNCTION fn_GetProjectCount (@empId INT)
RETURNS INT
AS
BEGIN
    DECLARE @count INT;

    SELECT @count = COUNT(ProjectID) FROM EmployeeProjects
    WHERE EmployeeID = @empId;
    RETURN @count;
END;
GO

SELECT dbo.fn_GetProjectCount(1) AS ProjectCountForEmployee1;
 --10
 EXEC sp_AssignEmployeeToProject 1, 3;   
SELECT * FROM EmployeeProjects WHERE EmployeeID = 1;
--11
DELETE FROM EmployeeProjects WHERE EmployeeID = 3;
