CREATE TABLE Employees (
    EmployeeID INT PRIMARY KEY,
    FirstName VARCHAR(100) NOT NULL,
    LastName VARCHAR(100) NOT NULL
);

CREATE TABLE Projects (
    ProjectID INT PRIMARY KEY,
    Name VARCHAR(100) NOT NULL,
    CreationDate DATE NOT NULL,
    Status VARCHAR(10),
    ClosureDate DATE
);

CREATE TABLE Positions (
    PositionID INT PRIMARY KEY,
    Title VARCHAR(100) NOT NULL UNIQUE
);

CREATE TABLE EmployeeProjects (
    EmployeeID INT,
    ProjectID INT,
    PositionID INT,
    PRIMARY KEY (EmployeeID, ProjectID),
    FOREIGN KEY (EmployeeID) REFERENCES Employees(EmployeeID),
    FOREIGN KEY (ProjectID) REFERENCES Projects(ProjectID),
    FOREIGN KEY (PositionID) REFERENCES Positions(PositionID)
);

CREATE TABLE Tasks (
    TaskID INT PRIMARY KEY,
    ProjectID INT,
    Description VARCHAR(255) NOT NULL,
    Deadline DATE NOT NULL,
    Status VARCHAR(20),
    FOREIGN KEY (ProjectID) REFERENCES Projects(ProjectID)
);

CREATE TABLE EmployeeTasks (
    EmployeeID INT,
    TaskID INT,
    PRIMARY KEY (EmployeeID, TaskID),
    FOREIGN KEY (EmployeeID) REFERENCES Employees(EmployeeID),
    FOREIGN KEY (TaskID) REFERENCES Tasks(TaskID)
);

CREATE TABLE TaskStatusUpdates (
    TaskID INT,
    Status VARCHAR(20),
    UpdateDate DATE NOT NULL,
    UpdatedBy INT,
    PRIMARY KEY (TaskID, UpdateDate),
    FOREIGN KEY (TaskID) REFERENCES Tasks(TaskID),
    FOREIGN KEY (UpdatedBy) REFERENCES Employees(EmployeeID)
);
