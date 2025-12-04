CREATE DATABASE CompanyRelations;
USE CompanyRelations;
CREATE TABLE Departments (
    DepartmentID INT IDENTITY(1,1) PRIMARY KEY,
    DepartmentName VARCHAR(100) NOT NULL
);
CREATE TABLE Employees (
    EmployeeID INT IDENTITY(1,1) PRIMARY KEY,
    FirstName VARCHAR(50),
    LastName VARCHAR(50),
    Email VARCHAR(100),
    PhoneNumber VARCHAR(20),
    HireDate DATE,
    DepartmentID INT,
    FOREIGN KEY (DepartmentID) REFERENCES Departments(DepartmentID)
);
CREATE TABLE EmployeeDetails (
    EmployeeDetailID INT IDENTITY(1,1) PRIMARY KEY,
    EmployeeID INT NOT NULL,
    Address VARCHAR(200),
    DateOfBirth DATE,
    NationalID VARCHAR(20),
    FOREIGN KEY (EmployeeID) REFERENCES Employees(EmployeeID)
);
CREATE TABLE Roles (
    RoleID INT IDENTITY(1,1) PRIMARY KEY,
    RoleName VARCHAR(50) NOT NULL
);
CREATE TABLE EmployeeRoles (
    EmployeeID INT,
    RoleID INT,
    PRIMARY KEY (EmployeeID, RoleID),
    FOREIGN KEY (EmployeeID) REFERENCES Employees(EmployeeID),
    FOREIGN KEY (RoleID) REFERENCES Roles(RoleID)
);
CREATE TABLE Projects (
    ProjectID INT IDENTITY(1,1) PRIMARY KEY,
    ProjectName VARCHAR(100),
    StartDate DATE,
    EndDate DATE
);
CREATE TABLE EmployeeProjects (
    EmployeeID INT,
    ProjectID INT,
    PRIMARY KEY (EmployeeID, ProjectID),
    FOREIGN KEY (EmployeeID) REFERENCES Employees(EmployeeID),
    FOREIGN KEY (ProjectID) REFERENCES Projects(ProjectID)
);
CREATE TABLE SalaryHistory (
    SalaryHistoryID INT IDENTITY(1,1) PRIMARY KEY,
    EmployeeID INT NOT NULL,
    Salary DECIMAL(10,2) NOT NULL,
    EffectiveDate DATE NOT NULL,
    FOREIGN KEY (EmployeeID) REFERENCES Employees(EmployeeID)
);




