# ASP.NET Web API with Clean Architecture

This project is a sample of ASP.NET Web API in .NET 8.

## Whats Including

### Web API
* ASP.NET Web API in .NET 8
* **REST API** principles, **CRUD** operations
* Implementing **CQRS, and Clean Architecture** using best practices
* **Repository Pattern** implementation
* Developing **CQRS using MediatR, FluentValidation, and AutoMapper** libraries
* Using **Entity Framework Core ORM** and auto migrate to SQL Server when application run
* **Swagger Open API** implementation
* **MSSQL database** connection and containerization

### Docker Compose establishment with all services on docker;
- Containerization of worker
- Containerization of database
- Override Environment variables


At the root directory which include **docker-compose.yml** files, run below command:
```csharp
docker-compose -f docker-compose.yml -f docker-compose.override.yml up -d
```
