# QAirline

QAirline is a web-based application designed for managing and booking airline tickets. Built using **ASP.NET MVC**, it provides essential functionalities for an airline reservation system, including flight management, ticket booking, and user handling.

---

## Features

- **Flight Management**: CRUD operations for flight schedules.
- **Booking System**: Search, select, and book tickets for flights.
- **User Authentication**: Secure registration and login functionality.
- **Search Flights**: Search by origin, destination, and date.
- **Responsive UI**: Optimized for desktop and mobile.

---

## Technologies Used

- **Framework**: ASP.NET MVC
- **Language**: C#
- **Frontend**: HTML, CSS, JavaScript, Bootstrap
- **Database**: SQL Server
- **ORM**: Entity Framework

---

## Installation

### Prerequisites

1. Install [Visual Studio](https://visualstudio.microsoft.com/).
2. Install [.NET Framework](https://dotnet.microsoft.com/) or [.NET Core](https://dotnet.microsoft.com/download/dotnet-core).
3. Install SQL Server (optional if using localdb).

### Steps

1. Clone the repository:
   ```bash
   git clone https://github.com/btthanhk4/QAirline-Website.git
   ```

2. Navigate to the project directory:
   ```bash
   cd AirlinesReservationSystem
   ```

3. Open the project in Visual Studio.

4. Restore NuGet packages:
   - Go to `Tools > NuGet Package Manager > Manage NuGet Packages for Solution`.
   - Click `Restore`.

5. Update the database connection string in `appsettings.json`:
   ```json
   {
     "ConnectionStrings": {
       "DefaultConnection": "Server=YOUR_SERVER;Database=AirlinesDB;Trusted_Connection=True;"
     }
   }
   ```

6. Run the database migrations to set up the database:
   ```bash
   dotnet ef database update
   ```

7. Build and run the project:
   - Press `F5` in Visual Studio.
   - Alternatively, use:
     ```bash
     dotnet run
     ```

---

## Project Structure

```plaintext
AirlinesReservationSystem/
|-- Controllers/          # Handles HTTP requests
|-- Models/               # Contains data structures and database interaction
|-- Views/                # Razor templates for UI
|-- Migrations/           # Database migration files
|-- wwwroot/              # Static files (CSS, JS, Images)
|-- appsettings.json      # Configuration file
|-- Program.cs            # Application entry point
|-- Startup.cs            # Middleware and services configuration
```

---

## Usage

1. Access the application via `https://localhost:5001` or the configured URL.
2. Use the navigation menu to explore features:
   - **Search Flights**: Enter origin, destination, and date to find flights.
   - **Manage Flights**: Admins can add, edit, or delete flight schedules.
   - **Book Tickets**: Users can book tickets for available flights.
3. Register or log in to access user-specific features.

---

