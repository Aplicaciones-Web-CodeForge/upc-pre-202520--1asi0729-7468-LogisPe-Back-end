FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src
COPY LogisPe.Api/ ./LogisPe.Api/
RUN dotnet restore ./LogisPe.Api/LogisPe.Api.csproj
RUN dotnet publish ./LogisPe.Api/LogisPe.Api.csproj -c Release -o /app

FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS final
WORKDIR /app
COPY --from=build /app .
ENV ASPNETCORE_ENVIRONMENT=Production
EXPOSE 8080
CMD ["dotnet", "LogisPe.Api.dll"]