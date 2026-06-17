# Cricket Tournament Management System

## Semester Project

**Course:** Advanced Programming (COSC-5136)
**Semester:** Spring 2026

---

# Project Overview

The Cricket Tournament Management System is a Windows Forms application developed using C#, .NET, ADO.NET, and SQL Server.

The application allows users to manage:

* Teams
* Matches
* Player Performances
* Dashboard Statistics

The project follows the required architecture:

* **App.Core** – Models, Interfaces, Services
* **App.WindowsApp** – User Interface
* **SQL Server** – Data Storage
* **ADO.NET** – Database Access

---

# Technologies Used

* C#
* .NET Windows Forms
* SQL Server
* ADO.NET
* LiveCharts2
* Visual Studio 2022

---

# Project Structure

## App.Core

Contains:

### Models

* Team
* Match
* Performance

### Contracts

* ITeamService
* IMatchService
* IPerformanceService

### Services

* DbTeamService
* DbMatchService
* DbPerformanceService

---

## App.WindowsApp

Contains:

### Forms

* MainForm
* TeamForm
* MatchForm
* PerformanceForm

### Views

* DashboardView
* TeamsView
* MatchesView
* PerformanceView

---

# Features

## Team Management

* Add Team
* Edit Team
* View Team
* Delete Team
* Search Team
* Entry Fee Management

---

## Match Management

* Add Match
* Edit Match
* View Match
* Delete Match
* Status Filtering

Match Statuses:

* Scheduled
* Live
* Completed
* Cancelled

---

## Performance Management

### Batting Performance

* Runs
* Fours
* Sixes

### Bowling Performance

* Wickets
* Overs

Features:

* Add Performance
* Edit Performance
* View Performance
* Delete Performance
* Search Player Performance

---

## Dashboard

Displays:

* Total Teams
* Total Players
* Top 5 Batters
* Top 5 Bowlers

Data is loaded directly from the database.

---

# Database Setup

Open SQL Server Management Studio or Visual Studio SQL Server Object Explorer and execute the following script.

```sql
CREATE DATABASE CricketDB;
GO

USE CricketDB;
GO

CREATE TABLE Teams
(
    TeamId NVARCHAR(50) PRIMARY KEY,
    Name NVARCHAR(100) NOT NULL,
    Captain NVARCHAR(100) NOT NULL,
    EntryFee DECIMAL(18,2) NOT NULL
);


CREATE TABLE Matches
(
    MatchId NVARCHAR(50) PRIMARY KEY,
    Team1Id NVARCHAR(50) NOT NULL,
    Team2Id NVARCHAR(50) NOT NULL,
    Status NVARCHAR(50) NOT NULL
);

CREATE TABLE Performances
(
    PerformanceId NVARCHAR(50) PRIMARY KEY,
    PlayerId NVARCHAR(50) NULL,
    PlayerName NVARCHAR(100) NULL,
    TeamName NVARCHAR(100) NULL,
    Runs INT NOT NULL DEFAULT 0,
    Fours INT NOT NULL DEFAULT 0,
    Sixes INT NOT NULL DEFAULT 0,
    Wickets INT NOT NULL DEFAULT 0,
    Overs NVARCHAR(50) NULL
);
```

---

# Configuration

Open App.config and update the connection string according to your SQL Server configuration.

Example:

```xml
<connectionStrings>
  <add name="CricketDB"
       connectionString="Server=localhost,1433;Database=CricketDB;User Id=sa;Password=Sql@12345;TrustServerCertificate=True;"
       providerName="Microsoft.Data.SqlClient" />
</connectionStrings>
```

---

# Running the Project

1. Open the solution in Visual Studio 2022.
2. Restore NuGet packages.
3. Create the CricketDB database using the provided SQL script.
4. Update App.config if required.
5. Build the solution.
6. Run the application.

---

# CRUD Operations Implemented

All entities support:

* GetAll()
* GetById()
* Add()
* Update()
* Delete()

All SQL commands use parameterized queries through SqlParameter.

---

# Additional Features

Implemented recommended features:

* Team Search
* Player Performance Search
* Match Status Filter
* Dashboard Statistics
* Dashboard Reporting

---


# Notes

* Primary keys use NVARCHAR IDs.
* No foreign key constraints are used.
* Database access is implemented using ADO.NET.
* Connection strings are stored in App.config.
* All database connections are wrapped in using blocks.
* All queries use SqlParameter for security.

---

