# Stage 1: build
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build

WORKDIR /src

# restore
COPY ["src/CarJournal/CarJournal.csproj", "CarJournal/"]
RUN dotnet restore 'CarJournal/CarJournal.csproj'

# Stage 2: publish
FROM build as publish
COPY ["src/CarJournal", "CarJournal/"]
WORKDIR /src/CarJournal
RUN dotnet publish 'CarJournal.csproj' -c Release --no-restore -o /app/publish

# Stage 3: run
FROM mcr.microsoft.com/dotnet/aspnet:8.0
ENV ASPNETCORE_HTTP_PORTS=5001
EXPOSE 5001
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT [ "dotnet", "CarJournal.dll"]