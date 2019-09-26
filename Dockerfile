FROM microsoft/dotnet:2.1-sdk-alpine AS build-env
WORKDIR /app

FROM mcr.microsoft.com/dotnet/core/sdk:2.2-stretch AS build
WORKDIR /src
COPY ["src/Project.Api.WebApi/Project.Api.WebApi.csproj", "src/Project.Api.WebApi/"]
RUN dotnet restore "src/Project.Api.WebApi/Project.Api.WebApi.csproj"
COPY . .
WORKDIR "/src/src/Project.Api.WebApi"
RUN dotnet build "Project.Api.WebApi.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "Project.Api.WebApi.csproj" -c Release -o /app

FROM microsoft/dotnet:2.1-aspnetcore-runtime-alpine
WORKDIR /app
EXPOSE 33001
COPY --from=build-env /app/out .