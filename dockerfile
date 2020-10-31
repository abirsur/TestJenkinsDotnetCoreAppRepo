#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-buster-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
WORKDIR /src
COPY ["WAPP15092020TA/WAPP15092020TA.csproj", "WAPP15092020TA/"]
RUN dotnet restore "WAPP15092020TA/WAPP15092020TA.csproj"
COPY . .
WORKDIR "/src/WAPP15092020TA"
RUN dotnet build "WAPP15092020TA.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "WAPP15092020TA.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "WAPP15092020TA.dll"]
