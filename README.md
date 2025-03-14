# 💡 Online Exam API - README

## ➡️ Introduction
This project is an **Online Exam API** built using **ASP.NET Core** and **Entity Framework Core**. It provides functionalities for managing users, roles, exams, questions, options, results, and exam participants. The project follows **RESTful API principles** and utilizes **MSSQL** as the database.

---

## ➡️ Entity Framework Core
**Entity Framework Core (EF Core)** is a modern object-relational mapper (ORM) for .NET applications. It simplifies data access by allowing developers to work with database entities using **C# objects** instead of writing raw SQL queries.

### 🔑 Key Features of EF Core:
- **Code-First Approach**: Define models in C# and generate the database schema.
- **Migrations**: Version control the database schema and apply changes.
- **LINQ Queries**: Query the database using LINQ expressions.
- **Change Tracking**: Detect and track entity changes automatically.
- **Lazy & Eager Loading**: Optimize data retrieval strategies.

This project uses **EF Core** to define and manage the entities for the Online Exam API.

---

## 🏫📚 SchoolDB (Database)
**SchoolDB** is the **SQL Server database** used for this project. It stores all the entities related to the Online Exam API.

### 💡 Tables in SchoolDB:
- ⚪**Users** : Stores user details such as username, email, and password.
- ⚪**Roles**: Defines roles like Student, Teacher, and Admin.
- ⚪**Persons**: Contains personal details linked to users.
- ⚪**Exams**: Stores exam details such as title, duration, and subject.
- ⚪**Questions**: Represents questions for an exam.
- ⚪**Options**: Stores multiple-choice options for each question.
- ⚪**Results**: Keeps track of students' scores.
- ⚪**ExamParticipants**: Links users to exams they participate in.

The database schema is maintained and updated using **Entity Framework Migrations**.

---

## 🕚 Getting Started
### Prerequisites:
- **.NET 7+**
- **SQL Server (MSSQL)**
- **Entity Framework Core**

### Setup Instructions:
1. Clone the repository:
   ```sh
   git clone https://github.com/your-repo/OnlineExamAPI.git
   ```
2. Navigate to the project folder:
   ```sh
   cd OnlineExamAPI
   ```
3. Restore dependencies:
   ```sh
   dotnet restore
   ```
4. Update the database:
   ```sh
   dotnet ef database update
   ```
5. Run the application:
   ```sh
   dotnet run
   ```

---

## 🔨 API Endpoints
| Method | Endpoint | Description |
|--------|---------|-------------|
| GET | /api/users | Get all users |
| POST | /api/users | Create a new user |
| GET | /api/exams | Get all exams |
| POST | /api/exams | Create a new exam |
| GET | /api/questions/{id} | Get a question by ID |
| POST | /api/results | Submit an exam result |

---

## Conclusion
This **Online Exam API** efficiently manages exam-related data using **Entity Framework Core** and **MSSQL (SchoolDB)**. It ensures seamless interaction with the database through EF Core's powerful features.

Happy Coding! 🚀

For more Info contact me on Mail : sabagg790@gmial.com
