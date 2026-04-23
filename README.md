### Kias Kar Kompany

### 1. Description

This is a basic ASP.NET Core MVC web application for managing vehicle and manufacturer data. It allows users to create, view, update, and delete records for both vehicles and manufacturers using a SQL Server database.

### 2. Setup Instructions (Beginner-Friendly)

Follow these steps to run the application locally:

### Step 1: Clone the Repository

```bash
git clone https://github.com/mickymouse777/Kias_Kar_Kompany.git
cd Kias_Kar_Kompany
```

### Step 2: Open the Project

* Open Visual Studio
* Click **Open a project or solution**
* Select the `.sln` file

### Step 3: Configure Database Connection

Open `appsettings.json` and ensure the connection string is:

```json
"ConnectionStrings": {
  "Kias_Kar_KompanyContext": "Server=(localdb)\\mssqllocaldb;Database=Kias_Kar_Kompany;Trusted_Connection=True;MultipleActiveResultSets=true"
}
```

### Step 4: Run Database Migrations

Open Package Manager Console and run:

```bash
Add-Migration InitialCreate
Update-Database
```

### Step 5: Run the Application

* Press **F5** or click **Start**
* The app will open in your browser (localhost)

---

## 3. Usage Instructions

Use the following actions in the browser to test functionality:

### Manufacturers

* Create: `/Manufacturers/Create`
* View All: `/Manufacturers`
* Edit: `/Manufacturers/Edit/{id}`
* Delete: `/Manufacturers/Delete/{id}`

### Vehicles

* Create: `/Vehicles/Create`
* View All: `/Vehicles`
* Details: `/Vehicles/Details/{id}`
* Edit: `/Vehicles/Edit/{id}`
* Delete: `/Vehicles/Delete/{id}`

Replace `{id}` with an actual record ID (e.g., `/Vehicles/Edit/1`).

---

## 4. Project Status and Features

### Current Functionality

* CRUD operations for Vehicles
* CRUD operations for Manufacturers
* Entity Framework Core integration
* SQL Server LocalDB support
* MVC architecture with Razor Views

### Project Stage

* Completed basic functional requirements
* Suitable for academic submission or further extension

### Future Improvements

* Add Manufacturer dropdown in Vehicle forms
* Add validation enhancements
* Improve UI styling (Bootstrap)
* Add authentication and user roles
* Image upload instead of URL input
