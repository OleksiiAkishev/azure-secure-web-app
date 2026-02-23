FROM mcr.microsoft.com/dotnet/sdk:9.0 AS build
WORKDIR /app
COPY Azure.WebApi/Azure.WebApi/Azure.WebApi.csproj .
RUN dotnet restore Azure.WebApi.csproj
COPY Azure.WebApi/Azure.WebApi .
RUN dotnet build Azure.WebApi.csproj -c Release -o /app/build

FROM mcr.microsoft.com/dotnet/aspnet:9.0 AS runtime
ENV ASPNETCORE_ENVIRONMENT=Production
ENV ASPNETCORE_URLS=http://+:8080;https://+:8443
WORKDIR /app
COPY --from=build /app/build .
ENTRYPOINT ["dotnet", "Azure.WebApi.dll"]