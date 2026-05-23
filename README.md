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
<img width="1341" height="1037" alt="Swagger Get" src="https://github.com/user-attachments/assets/611dd681-3b1e-4355-ad53-20f56270f454" />
<img width="1345" height="1078" alt="Swagger Post" src="https://github.com/user-attachments/assets/617dbec5-5c7a-4456-b6ed-2d53879ac1ed" />
<img width="492" height="427" alt="Edit Work Order" src="https://github.com/user-attachments/assets/40710a98-57a1-4947-9df7-035902390050" />
<img width="457" height="408" alt="Create Order" src="https://github.com/user-attachments/assets/32e48909-f1f4-46ea-ae3d-6b7ab44e95f1" />
<img width="955" height="352" alt="Work Orders List" src="https://github.com/user-attachments/assets/4ecf689d-5f09-4a09-a479-35759ad23ad3" />

