# 🚗 Car Journal

A Blazor Server Side application for tracking car expenses and maintenance

## Tech Stack
 
|||
|---|---|
| **Framework** | .NET 8 / Blazor Server |
| **ORM** | Entity Framework Core |
| **Database** | PostgreSQL 16 |
| **Container** | Docker |
 
---

## Getting Started
 
### Prerequisites
 
- [.NET 8 SDK](https://dotnet.microsoft.com/download)
- [Docker](https://www.docker.com/products/docker-desktop)

### 1. Configure environment

```bash
cp .env.example .env
```
 
Edit `.env` if needed (default values work out of the box for local development).


### 2. Start the database
 
```bash
docker compose up -d
```
 
### 3. Apply migrations
 
```bash
dotnet ef database update
```
 
> First time? Install EF CLI tool:
> ```bash
> dotnet tool install --global dotnet-ef
> ```


### 4. Run

```bash
# navigate to the project folder first
cd ./src/CarJournal/ 

# restore dependencies
dotnet restore

# build and run
dotnet run
```

---
 
## Running Fully in Docker
 
If you don't want to install .NET locally:
 
```bash
cp .env.example .env
docker compose -f docker-compose.prod.yml up --build
```
 
App will be available at **http://localhost:5001**
 
---

## Useful Commands
 
```bash
# Start database
docker compose up -d
 
# Stop database (data is preserved)
docker compose stop
 
# Reset database completely
docker compose down -v
 
# dotnet-ef or dotnet ef
# Add a new migration 
dotnet ef migrations add MigrationName
 
# Apply migrations
dotnet ef database update
 
# Revert last migration
dotnet ef migrations remove
```
 
---

## Project Structure
 
```
src/
└── CarJournal/
    ├── Infrastructure/      
        ├── Persistence/      # Database
    ├── Data/            # DbContext, models
    ├── Migrations/      # EF migrations
    └── appsettings.json
docker-compose.yml       # Dev: DB only
docker-compose.prod.yml  # Prod: full stack
.env.example             # Environment template
```
