FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src
COPY ["ClinicFrontDesk.csproj", "."]
RUN dotnet restore "./ClinicFrontDesk.csproj"
COPY . .
WORKDIR "/src/"
RUN dotnet build "ClinicFrontDesk.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "ClinicFrontDesk.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "ClinicFrontDesk.dll"]
