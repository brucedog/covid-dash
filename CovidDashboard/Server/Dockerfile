#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-buster-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
WORKDIR /src
COPY ["CovidDashboard/Server/CovidDashboard.Server.csproj", "CovidDashboard/Server/"]
COPY ["CovidDashboard/Shared/CovidDashboard.Shared.csproj", "CovidDashboard/Shared/"]
COPY ["CovidDashboard/Client/CovidDashboard.Client.csproj", "CovidDashboard/Client/"]
COPY ["CovidDashboard.Services/CovidDashboard.Services.csproj", "CovidDashboard.Services/"]
COPY ["CovidDashboard.Interfaces/CovidDashboard.Interfaces.csproj", "CovidDashboard.Interfaces/"]
RUN dotnet restore "CovidDashboard/Server/CovidDashboard.Server.csproj"
COPY . .
WORKDIR "/src/CovidDashboard/Server"
RUN dotnet build "CovidDashboard.Server.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "CovidDashboard.Server.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "CovidDashboard.Server.dll"]