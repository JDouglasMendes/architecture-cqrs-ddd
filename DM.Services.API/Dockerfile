FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-buster-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
WORKDIR /src
COPY ["DM.Services.API/DM.Services.API.csproj", "DM.Services.API/"]
RUN dotnet restore "DM.Services.API/DM.Services.API.csproj"
COPY . .
WORKDIR "/src/DM.Services.API"
RUN dotnet build "DM.Services.API.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "DM.Services.API.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "DM.Services.API.dll"]