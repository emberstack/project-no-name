#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/core/runtime:3.1-buster-slim-arm32v7 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
WORKDIR /src
COPY ["ProjectNoName.SerialPortDetector/ProjectNoName.SerialPortDetector.csproj", "ProjectNoName.SerialPortDetector/"]
RUN dotnet restore "ProjectNoName.SerialPortDetector/ProjectNoName.SerialPortDetector.csproj"
COPY . .
WORKDIR "/src/ProjectNoName.SerialPortDetector"
RUN dotnet build "ProjectNoName.SerialPortDetector.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "ProjectNoName.SerialPortDetector.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "ProjectNoName.SerialPortDetector.dll"]