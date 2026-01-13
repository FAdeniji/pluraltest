# ClinicFrontDesk

A multi-layered .NET application for managing clinic front desk operations, including appointments, invoices, patients, and more.

## Project Structure
- **ClinicFrontDesk.Api/**: ASP.NET Core Web API
- **ClinicFrontDesk.Application/**: Application layer interfaces and logic
- **ClinicFrontDesk.Domain/**: Domain entities
- **ClinicFrontDesk.Infrastructure/**: Persistence and services
- **ClinicFrontDesk.Tests/**: Unit and integration tests
- **docker-compose.yml**: Docker Compose configuration
- **Dockerfile**: Main Docker build file

## Prerequisites
- Docker and Docker Compose installed
- .NET 8 SDK (for local development)

## Running with Docker

1. **Build and start containers:**
   ```sh
   docker compose up -d
   ```
   This will build and start all services in detached mode.

2. **Stopping containers:**
   ```sh
   docker compose down
   ```

3. **Troubleshooting:**
   - If you see a port conflict (e.g., port 1433 is already in use), stop any existing containers or services using that port.
   - Platform warnings (amd64 vs arm64) can be ignored if containers start and run correctly.

## Running Tests

To run all tests:
```sh
dotnet test ClinicFrontDesk.Tests/ClinicFrontDesk.Tests.csproj
```

## Notes
- The API and database containers are defined in the docker-compose.yml file.
- For ARM-based Macs, you may see platform warnings; containers should still run unless there are architecture-specific issues.

## Contact
For issues or contributions, please open an issue or pull request on this repository.
