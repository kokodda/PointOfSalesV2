FROM mcr.microsoft.com/dotnet/core/aspnet:3.0-buster-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:3.0-buster AS build
WORKDIR /src
COPY ["PointOfSalesV2.Api/PointOfSalesV2.Api.csproj", "PointOfSalesV2.Api/"]
RUN dotnet restore "PointOfSalesV2.Api/PointOfSalesV2.Api.csproj"
COPY . .
WORKDIR "/src/PointOfSalesV2.Api"
RUN dotnet build "PointOfSalesV2.Api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "PointOfSalesV2.Api.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "PointOfSalesV2.Api.dll"]