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
- ⚪**ClassTeacher** : Stores user details such as username, email, and password.
- ⚪**Grade**: Defines roles like Student, Teacher, and Admin.
- ⚪**Journal**: Contains personal details linked to users.
- ⚪**Pupil**: Stores exam details such as title, duration, and subject.
- ⚪**Role**: Represents questions for an exam.
- ⚪**Schedule**: Stores multiple-choice options for each question.
- ⚪**School**: Keeps track of students' scores.
- ⚪**Subject**: Links users to exams they participate in.
- ⚪**Teacher**: Keeps track of students' scores.
- ⚪**Subject**: Links users to exams they participate in.
- ⚪**AttendanceStatus**: Keeps track of students' scores.
- ⚪**TeacherSubject**: Links users to exams they participate in.

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

## 🔨 Entity framewok Entities
| layer | Entity name | Description |
|--------|---------|-------------|
| Data Layer | /DATA/ClassTeacher | ClassTeacher Entitiy |
| Data Layer | /DATA/Grade | Grade Entitiy |
| Data Layer | /DATA/Journal | Journal Entitiy |
| Data Layer | /DATA/Pupil | Pupil Entitiy |
| Data Layer | /DATA/Role/{id} | Role Entitiy |
| Data Layer | /DATA/Schedule | Schedule Entitiy |
| Data Layer | /DATA/School/{id} | School Entitiy |
| Data Layer | /DATA/Subject | Subject Entitiy |
| Data Layer | /DATA/Teacher/{id} | Teacher Entitiy |
| Data Layer | /DATA/AttendanceStatus | AttendanceStatus Entity |
| Data Layer | /DATA/TeacherSubject | TeacherSubject Entity |

<br>

## 🔨 Entity Classes Configuration
| Entity Name | Configuration | Description |
|--------|---------|-------------|
| Class Entity | /Class/ClassConfiguration | ClassTeacher Entitiy |
| Journal Entity | /Journal/JournalConfiguration | Grade Entitiy |
| Pupil Entity | /Pupil/PupilConfiguration | Journal Entitiy |
| Role Entity | /Role/RoleConfiguration | Pupil Entitiy |
| Schedule Entity | /Schedule/ScheduleConfiguration/{id} | Role Entitiy |
| School Entity | /School/SchoolConfiguration | Schedule Entitiy |
| Teacher Entity | /Teacher/TeacherConfiguration/{id} | School Entitiy |
| Journal Entity | /Journal/JournalConfiguration | Subject Entitiy |
| Journal Entity | /DATA/Teacher/{id} | Teacher Entitiy |
| Journal Entity | /DATA/AttendanceStatus | AttendanceStatus Entity |
| Journal Entity | /DATA/TeacherSubject | TeacherSubject Entity |

<br>


## ✅  Conclusion
This **Online Exam API** efficiently manages exam-related data using **Entity Framework Core** and **MSSQL (SchoolDB)**. It ensures seamless interaction with the database through EF Core's powerful features.

Happy Coding! 🚀

For more Info contact me on Mail : 📤 sabagg790@gmial.com
