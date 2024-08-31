# NBA Players CRUD App - ASP.NET Core 8 Backend

This repository contains the backend code for the NBA Players CRUD application, built using ASP.NET Core 8 WEB API. The API provides endpoints to perform CRUD operations on NBA player data.

## Features

-   **CRUD API:** Endpoints for Creating, Reading, Updating, and Deleting NBA player records.
-   **Entity Framework Core:** Utilizes EF Core for database interactions.
-   **CORS Support:** Configured to allow cross-origin requests from the Angular frontend.
-   **Swagger Documentation:** Integrated Swagger UI for easy API testing and documentation.
-   **HTTPS Support:** Secure API communication using HTTPS.

## Getting Started

### Prerequisites

-   [.NET SDK](https://dotnet.microsoft.com/download) (v8.0)
-   [SQL Server](https://www.microsoft.com/en-us/sql-server/sql-server-downloads) or any compatible database

### Installation

1.  Clone the repository:    
    `git clone https://github.com/Talha-Tahir2001/NBAPlayersCrud.API.git` 
    
2.  Navigate to the project directory:
    `cd NBAPlayersCrud.API` 
    
3.  Restore the dependencies:
    `dotnet restore` 
    

### Running the Application

1.  Update the database connection string in `appsettings.json`.
2.  Apply migrations and update the database:
    `dotnet ef database update` 
    
3.  Run the application:
    `dotnet run` 
    
4.  The API will be available at `https://localhost:Your-Port-No/api/`.

### Swagger UI

The API comes with Swagger UI for easy testing. Once the application is running, navigate to `https://localhost:Your-Port-No/swagger` to explore and test the API endpoints.

### License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.
