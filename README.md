# 👩‍💼 Employee Management System

The **Employee Management System (EMS)** is a web-based application built using **.NET Core MVC** and **SQL Server** that allows organizations to manage employee data efficiently. It provides CRUD operations for employees and departments, along with features like search, sorting, authentication, and role-based access.

---

## 🚀 Features

- 👤 Add, Edit, View, and Delete Employee Records  
- 🏢 Department Management  
- 🔎 Search & Filter by Name, Department, or Role  
- 📅 Track Joining Dates and Designations  
- 🔐 User Authentication (Login/Logout)  
- 📊 Dashboard with basic employee statistics  
- 📥 Export data to PDF/Excel (optional)

---

## 🧑‍💻 Technologies Used

| Layer        | Technology                |
|--------------|---------------------------|
| Frontend     | HTML5, CSS3, Bootstrap 5, Razor Views|
| Backend      | .NET Core, C#|
| Database     | SQL Server |
| ORM          | Entity Framework|
| Authentication | Forms Authentication or ASP.NET Identity|

---

## 📂 Project Structure

```bash
/EmployeeManagementSystem
│
├── Controllers          # Handles HTTP requests
├── Models               # C# classes for Employee, Department, etc.
├── Views                # Razor Pages for UI
├── DAL                  # Data access layer (DbContext)
├── Migrations           # EF Code-First Migrations (if used)
├── Content              # CSS/Bootstrap
├── Scripts              # JavaScript/jQuery
├── App_Data             # SQL Scripts / LocalDB
├── web.config           # Application config
└── README.md            # Documentation file
