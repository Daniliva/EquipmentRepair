# Equipment Repair Application

## Overview

This is a test application for testing design on WinForm Represents CRUD operations on three tables in the database. 

This application is divided into two parts: conditional DAL and conditional UI

## Database Schema

The application uses a SQL Server database with the following tables:

### EquipmentTypes Table

```sql
CREATE TABLE EquipmentTypes (
    EquipmentTypeID INT PRIMARY KEY IDENTITY(1,1), -- Equipment Type Code
    Country NVARCHAR(100) NOT NULL,                -- Country
    ManufactureYear INT NOT NULL,                  -- Year of Manufacture
    Brand NVARCHAR(100) NOT NULL                   -- Brand
);
```
### RepairTypes Table
```sql
CREATE TABLE RepairTypes (
    RepairTypeID INT PRIMARY KEY IDENTITY(1,1),    -- Repair Code
    Name NVARCHAR(200) NOT NULL,                   -- Name
    Duration INT NOT NULL,                         -- Duration (in days)
    Cost DECIMAL(10, 2) NOT NULL,                  -- Cost
    Notes NVARCHAR(MAX)                            -- Notes
);
```
### RepairRecords Table
```sql
CREATE TABLE RepairRecords (
    RegistrationNumber INT PRIMARY KEY IDENTITY(1,1), -- Registration Number
    EquipmentTypeID INT NOT NULL,                      -- Foreign Key for Equipment Type
    RepairTypeID INT NOT NULL,                         -- Foreign Key for Repair Type
    StartDate DATE NOT NULL,                           -- Start Date of Repair
    RepairQuality NVARCHAR(50),                        -- Quality of the Repair
    CONSTRAINT FK_RepairRecords_EquipmentTypes FOREIGN KEY (EquipmentTypeID)
        REFERENCES EquipmentTypes(EquipmentTypeID)
        ON DELETE NO ACTION,  -- Prevents deletion if there are related records
    CONSTRAINT FK_RepairRecords_RepairTypes FOREIGN KEY (RepairTypeID)
        REFERENCES RepairTypes(RepairTypeID)
        ON DELETE NO ACTION   -- Prevents deletion if there are related records
);
```

## Features

- **Equipment Classification**: Classifies all equipment by country of manufacture, manufacture year, and brand.
- **Repair Types**: Each repair type has a name, duration, cost, and optional notes.
- **Repair Records**: Logs each repair event, associating it with specific equipment types and repair types, along with the start date and repair quality.

## Getting Started

### Prerequisites

- .NET 8.0 or later
- Visual Studio or any .NET IDE
- SQL Server (Local or Remote)

### Installation

1. Clone the repository:
   ```bash
   git clone <repository-url>
   cd EquipmentRepair
   ```

2. Open the solution in Visual Studio.

3. Set up the SQL Server database:
   - Run the SQL scripts provided in the `DatabaseScripts` folder to create the tables.

4. Update the connection string in `App.config`:
   ```xml
   <connectionStrings>
       <add name="RepairDatabase"
            connectionString="YOUR CONNECTION STRING"
            providerName="System.Data.SqlClient" />
   </connectionStrings>
   ```

5. Build the solution.

6. Run the application.

## Usage

- Use the user interface to manage equipment types, repair types, and repair records.
- Navigate through the application to add, update, or delete records as needed.



