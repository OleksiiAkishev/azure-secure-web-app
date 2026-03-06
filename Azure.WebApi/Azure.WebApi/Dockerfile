FROM mcr.microsoft.com/dotnet/sdk:9.0 AS build
WORKDIR /app
COPY Azure.WebApi/Azure.WebApi/Azure.WebApi.csproj .
RUN dotnet restore Azure.WebApi.csproj
COPY Azure.WebApi/Azure.WebApi .
RUN dotnet publish Azure.WebApi.csproj -c Release -o /app/build

FROM mcr.microsoft.com/dotnet/aspnet:9.0 AS runtime
RUN addgroup --system --gid 10000 appgroup && \
    adduser --system --uid 10000 --ingroup appgroup appuser
ENV ASPNETCORE_ENVIRONMENT=Production
ENV ASPNETCORE_URLS=http://+:8080;https://+:8443
WORKDIR /app
COPY --from=build --chown=appuser:appgroup /app/build .
USER appuser
ENTRYPOINT ["dotnet", "Azure.WebApi.dll"]
