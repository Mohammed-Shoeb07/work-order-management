# Work Order Management System

A simple ASP.NET Core Razor Pages application for managing work orders.

## Features

- Create, edit, delete, and view work orders
- SQL Server database using Entity Framework Core
- Swagger API documentation
- Dockerized setup using Docker Compose
- Persistent SQL Server container storage
- Form validation for required fields

## Technologies Used

- ASP.NET Core 8
- Razor Pages
- Entity Framework Core
- SQL Server
- Swagger
- Docker & Docker Compose

## Run Locally with Docker

Clone the repository:
```bash
git clone https://github.com/Mohammed-Shoeb07/work-order-management.git
cd work-order-management
```
Run the application:
```bash
docker compose up --build
```

## Notes
The SQL Server password inside `docker-compose.yml` is a demo-only local development password used for easy project setup.

Open the application:

- Main App:
  http://localhost:8080/WorkOrders

- Swagger API:
  http://localhost:8080/swagger

## Project Structure

- `Pages/WorkOrders` → Razor Pages CRUD UI
- `Controllers` → API Controllers
- `Data` → Database context
- `Models` → Entity models
- `Migrations` → Entity Framework migrations

## Screenshots
<img width="955" height="352" alt="Work Orders List" src="https://github.com/user-attachments/assets/2b431cff-ce03-4287-8597-ebf4d7c29404" />
<img width="457" height="408" alt="Create Order" src="https://github.com/user-attachments/assets/436aba76-821a-491e-8946-7ee1bc3e9db9" />
<img width="492" height="427" alt="Edit Work Order" src="https://github.com/user-attachments/assets/667d9358-8f97-4286-a6d8-73c64d0c1338" />
<img width="1345" height="1078" alt="Swagger Post" src="https://github.com/user-attachments/assets/b979e617-e417-4379-885f-9b5d78c2ab06" />
<img width="1341" height="1037" alt="Swagger Get" src="https://github.com/user-attachments/assets/b0d7b689-5e5e-4d7f-b4c1-e7b7994b21e3" />



