FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src

COPY ["WorkOrderManagement.csproj", "./"]
RUN dotnet restore "WorkOrderManagement.csproj"

COPY . .
RUN dotnet publish "WorkOrderManagement.csproj" -c Release -o /app/publish

FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS final
WORKDIR /app

COPY --from=build /app/publish .

EXPOSE 8080

ENTRYPOINT ["dotnet", "WorkOrderManagement.dll"]