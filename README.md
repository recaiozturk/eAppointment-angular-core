# E-Appointment System

## Project Description
This project aims to develop an e-appointment system to facilitate appointment management for patients, doctors, and staff. The system is built using modern software architectures and security standards.

## Technologies Used

### Backend
- **Language & Framework:** C#, .NET 8, Web API
- **Patterns:**
  - Result Pattern
  - CQRS Pattern
- **Libraries:**
  - Entity Framework Core
  - MediatR
  - AutoMapper
  - Scructer
  - Ardalis.SmartEnum
  - JwtBearer
  - TS.GenericRepository
  - TS.Result

### Frontend
- **Technology:** Angular, TypeScript
- **Libraries:**
  - DevExtreme
  - Form-Validate
  - SweetAlert
  - Jwt-Decode

## Installation & Setup

### 1. Clone the Repository
```sh
  git clone https://github.com/recaiozturk/eAppointment-angular-core.git
  cd eAppointment-angular-core
```

### 2. Database Configuration
- Open the **appsettings.json** file and update the database connection details:
```json
"ConnectionStrings": {  
  "SqlServer": "Data Source=<Database Server>;Initial Catalog=<Database Name>;Integrated Security=True;"  
} 
```

- **Create the database and apply migrations:**
```sh
cd eAppointmentServer.Infrastructure
Add-Migration InitialCreate
Update-Database
```

### 3. Running the Application
- **Start Backend**
```sh
cd eAppointmentServer.WebAPI
 dotnet run
```

- **Start Frontend**
```sh
cd eAppointment-angular-core/eApppointmentClient
npm install
ng serve
```

- Open the following URL in your browser to access the application:
```
http://localhost:4200
```

## Security & Authorization
- **JWT-based authentication** is implemented.
- Authorization is role-based to restrict access as needed.

## Contributing
If you would like to contribute, please submit a **pull request** or open an **issue**.


