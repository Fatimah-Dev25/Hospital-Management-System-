# 🏥 Hospital Management System

A **desktop-based Hospital Management System** built with **C# (.NET Framework, WinForms)** and **SQL Server** using **Layered Architecture**.  
This system helps manage hospital operations such as patients, doctors, appointments, billing, and medical records efficiently.

> ⚠️ Note: The system uses a **local SQL Server database**. SQL scripts are provided to create the database, tables, stored procedures, and sample data.  

---

## 📋 Features
- 👨‍⚕️ **Patient Management**: Add, update, search, and filter patients.  
- 🧑‍⚕️ **Doctor Management**: Manage doctor details and availability.  
- 📅 **Appointment Scheduling**: Book, cancel, and track patient appointments.  
- 💳 **Billing System**: Generate and manage invoices.  
- 📑 **Medical Records**: Store and retrieve patient medical history.  
- 🔐 **User Roles & Permissions**: Control access to system modules.  
- 📊 **Reports (Planned in V2)**: Insights and statistics for hospital operations.  

---

## 🛠️ Technologies Used
- **C# (.NET Framework, WinForms)**  
- **SQL Server** (Local database)  
- **ADO.NET** for database connectivity  
- **Stored Procedures** for database operations and performance optimization  
- **DTOs (Data Transfer Objects)** for structured data exchange between layers  
- **Layered Architecture** (DAL, BLL, UI)  

---

## 🗄️ Database Design
- Local SQL Server database with normalized tables.  
- Tables include: Patients, Doctors, Appointments, Billing, Medical Records.  
- **Stored Procedures** created for insert, update, delete, and select operations.  
- SQL scripts are provided in `/DatabaseScripts/` to create the database, tables, stored procedures, and insert **sample data**.  

---
## 🎥 Demo Video
Watch a short demo of the system setup and usage here:  
👉 [Project Demo Video](https://youtu.be/your-video-link)

---

## 🚀 How to Run the Project
1. Clone the repository:
   ```bash
   git clone https://github.com/YourUsername/Hospital-Management-System.git
