FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY "WaBank.BE.ApiGateway.sln" .
COPY "WaBank.BE.ApiGateway.csproj" .
RUN dotnet restore "WaBank.BE.ApiGateway.sln"
COPY . .
RUN dotnet build "WaBank.BE.ApiGateway.sln" -c Release -o /app/build

FROM build as publish
RUN dotnet publish "WaBank.BE.ApiGateway.sln" -c Release -o /app/publish

FROM base as final
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "WaBank.BE.ApiGateway.dll"]