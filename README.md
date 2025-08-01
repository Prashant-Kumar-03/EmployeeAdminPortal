# 🧾 EmployeeAdminPortal

EmployeeAdminPortal is a backend RESTful API built with **ASP.NET Core 8.0** using **Visual Studio 2022**, connected to a **SQL Server** database (via **SSMS 21**) using **Entity Framework Core**. This project is designed to manage employee records and provides full **CRUD** (Create, Read, Update, Delete) functionality through well-defined HTTP endpoints.

---

## 💼 Purpose of the Project

The purpose of this project is to serve as a simple yet functional employee management system. It demonstrates how to:

- Connect an ASP.NET Core Web API to a SQL Server database using EF Core.
- Handle HTTP requests to perform CRUD operations.
- Use Data Transfer Objects (DTOs) for data input/output.
- Follow good RESTful API practices and proper routing.
- Use Swagger for testing and documenting API endpoints.

---

## ⚙️ Tech Stack

| Technology            | Version        |
|-----------------------|----------------|
| .NET Core             | 8.0            |
| ASP.NET Core Web API  | 8.0            |
| Entity Framework Core | 8.0.18         |
| SQL Server            | SSMS 21        |
| Visual Studio         | 2022           |


---

## 📁 Project Structure

```
EmployeeAdminPortal/
│
├── Controllers/
│   └── EmployeesController.cs
│
├── Data/
│   └── ApplicationDbContext.cs
│
├── Models/
│   ├── AddEmployeeDto.cs
│   ├── UpdateEmployeeDto.cs
│   └── Entities/
│       └── Employee.cs
│
├── appsettings.json
└── Program.cs
```

---

## ✨ Features

- Get all employees
- Get an employee by ID
- Add a new employee
- Update an existing employee
- Delete an employee
- Swagger API documentation

---

## 🚀 How to Run the Project

1. **Clone the repository**:
   ```bash
   git clone https://github.com/your-username/EmployeeAdminPortal.git
   cd EmployeeAdminPortal
   ```

2. **Open the solution** in Visual Studio 2022.

3. **Configure the connection string** in `appsettings.json`:
   ```json
   "ConnectionStrings": {
     "DefaultConnection": "Server=YOUR_SERVER;Database=EmployeeAdminDb;Trusted_Connection=True;TrustServerCertificate=True;"
   }
   ```

4. **Apply Migrations & Create the Database**:
   ```bash
   Add-Migration InitialCreate
   Update-Database
   ```

5. **Run the project** 
---

## 📄 API Endpoints

| HTTP Verb | Route                     | Description               |
|-----------|---------------------------|---------------------------|
| GET       | /api/employees            | Get all employees         |
| GET       | /api/employees/{id}       | Get employee by ID        |
| POST      | /api/employees            | Add new employee          |
| PUT       | /api/employees/{id}       | Update existing employee  |
| DELETE    | /api/employees/{id}       | Delete employee by ID     |

---

## 🧪 Sample JSON Payloads

### 🔹 POST `/api/employees`

```json
{
  "name": "John Doe",
  "email": "john.doe@example.com",
  "phone": "9876543210",
  "salary": 50000
}
```

### 🔹 PUT `/api/employees/{id}`

```json
{
  "name": "Jane Smith",
  "email": "jane.smith@example.com",
  "phone": "9123456789",
  "salary": 65000
}
```

---

## 📚 Swagger API Documentation

Once you run the project, Swagger is available at:

```
https://localhost:<port>/swagger
```

This provides a UI to test all the endpoints without using Postman or curl.

---

## 🛠 Future Enhancements

- Authentication & Authorization (JWT)
- Pagination & Filtering
- Logging & Global Exception Handling
- Frontend UI with Angular or React

---
## 👨‍💻 Author

**Prashant Kumar**  
📧 [prashant2003.hyd@gmail.com](mailto:prashant2003.hyd@gmail.com)  
🔗 [LinkedIn](https://www.linkedin.com/in/prashant-kumar-65844b2a3/)

---
