FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
USER $APP_UID
WORKDIR /app
EXPOSE 8080
EXPOSE 8081

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["NTierApplication.Web/NTierApplication.Web.csproj", "NTierApplication.Web/"]
RUN dotnet restore "NTierApplication.Web/NTierApplication.Web.csproj"
COPY . .
WORKDIR "/src/NTierApplication.Web"
RUN dotnet build "NTierApplication.Web.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "NTierApplication.Web.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "NTierApplication.Web.dll"]
