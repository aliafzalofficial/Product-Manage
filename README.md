# 📦 Product Management System

A Blazor-based Product Management System designed to manage products, categories, and related business operations efficiently. Built as part of a semester project using clean architecture principles and ADO.NET for database operations.

---

## 🚀 Project Overview

The **Product Management System** is a web application that allows users to perform CRUD operations on products and categories with a focus on modularity, separation of concerns, and maintainability.

### ✨ Key Features

- View, add, update, and delete products
- Manage product categories
- Responsive UI using Blazor WebAssembly
- Backend powered by ADO.NET with a SQL Server database
- Follows a 3-tier architecture (Presentation, BLL, DAL)

---

## 🛠️ Technologies Used

- **Frontend**: Blazor WebAssembly (.NET 6/7)
- **Backend**: ASP.NET Core Web API
- **Data Access**: ADO.NET (no Entity Framework)
- **Database**: SQL Server
- **Architecture**: Clean Architecture (Layered: Presentation, Application, Domain, Infrastructure)
- **Authentication**: Google OAuth 2.0 via ASP.NET Core Identity
- **UI Framework**: Bootstrap 5 / CSS Grid / Flexbox

---

## ⚙️ Setup Instructions

### ✅ Prerequisites

Make sure you have the following installed:

- [.NET SDK 6.0 or 7.0](https://dotnet.microsoft.com/download)
- [Visual Studio 2022 or later](https://visualstudio.microsoft.com/)
- [SQL Server Express or LocalDB](https://www.microsoft.com/en-us/sql-server/sql-server-downloads)
- Git

---

### 🧪 Setup Steps

1. **Clone the repository**
   ```bash
   git clone https://github.com/aliafzalofficial/Product-Manage.git
   cd Product-Manage

2. **Set up the database**

Open SQL Server Management Studio (SSMS)
Create a database named ProductManageDb
Execute any .sql scripts provided to create tables and seed data

3. **Update the connection string**

Go to appsettings.json in:
BlazorCleanArchitecture.WebApi

Set your connection string like this:
"ConnectionStrings": {
  "DefaultConnection": "Server=.;Database=ProductManageDb;Trusted_Connection=True;"
}

4. **Access the App**
Open your browser and go to: https://localhost:7205/

🤝 Contribution
Feel free to fork the repository, make improvements, and submit pull requests. Contributions are always welcome!

