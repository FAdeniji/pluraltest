FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src
COPY ["ClinicFrontDesk.Api/ClinicFrontDesk.Api.csproj", "ClinicFrontDesk.Api/"]
COPY ["ClinicFrontDesk.Application/ClinicFrontDesk.Application.csproj", "ClinicFrontDesk.Application/"]
COPY ["ClinicFrontDesk.Domain/ClinicFrontDesk.Domain.csproj", "ClinicFrontDesk.Domain/"]
COPY ["ClinicFrontDesk.Infrastructure/ClinicFrontDesk.Infrastructure.csproj", "ClinicFrontDesk.Infrastructure/"]
RUN dotnet restore "ClinicFrontDesk.Api/ClinicFrontDesk.Api.csproj"
COPY . .
WORKDIR "/src/ClinicFrontDesk.Api"
RUN dotnet build "ClinicFrontDesk.Api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "ClinicFrontDesk.Api.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "ClinicFrontDesk.Api.dll"]
