DVLD-System – Driving & Vehicle License Department Management
📖 Description

DVLD-System is a Windows desktop application built with C# (.NET Framework, WinForms) and SQL Server.
It is designed to automate the processes of a Driving and Vehicle License Department (DVLD), replacing manual work with a modern digital solution.

The system follows a three-tier architecture:

Presentation layer (DVLD_V1.0) – graphical user interface using WinForms.

Business layer (DVLD_Buisness) – implements the core rules and logic for licenses, applicants, and services.

Data Access layer (DVLD_DataAccess) – handles SQL Server interactions using ADO.NET.

Database – SQL Server schema and data for applicants, licenses, and transactions.

🚀 Features

Applicant & People Management
Create, update, and search applicant records while preventing duplicates.

License Services
Issue new licenses, renew expiring ones, and replace lost or damaged licenses.

Testing Workflow
Manage vision, theory, and practical tests with scheduling and result tracking.

Fees & Payments
Automatic calculation of service fees with history tracking.

User & Security Management
Login system, role-based access, and auditing of user actions.

License Status Tracking
Monitor license states (active, expired, suspended, detained).

🛠️ Tech Stack

Language: C# (.NET Framework, WinForms)

Database: Microsoft SQL Server

Architecture: 3-tier (Presentation / Business / Data Access)

📂 Project Structure
DVLD-System/
├─ DVLD_V1.0/         # User Interface (WinForms)
├─ DVLD_Buisness/     # Business logic and domain rules
├─ DVLD_DataAccess/   # Database access layer (ADO.NET)
├─ Database/          # SQL Server backup and/or scripts
└─ README.md

⚡ Getting Started

Restore the database from the Database/ folder (use .bak file or scripts).

Update connection string in App.config with your SQL Server details.

Open the solution in Visual Studio.

Set DVLD_V1.0 as the startup project.

Build and run the solution.
