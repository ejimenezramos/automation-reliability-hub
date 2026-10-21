FROM mcr.microsoft.com/dotnet/sdk:10.0.401-noble AS build
WORKDIR /src
COPY global.json ./
COPY apps/api/Hub.Api.csproj apps/api/
RUN dotnet restore apps/api/Hub.Api.csproj
COPY apps/api/ apps/api/
RUN dotnet publish apps/api/Hub.Api.csproj --configuration Release --no-restore --output /app/publish

FROM mcr.microsoft.com/dotnet/aspnet:10.0.13-noble AS runtime
WORKDIR /app

COPY --from=build /app/publish ./

ENV ASPNETCORE_HTTP_PORTS=8080
EXPOSE 8080

USER $APP_UID
ENTRYPOINT ["dotnet", "Hub.Api.dll"]
