# syntax=docker/dockerfile:1
FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build-env
WORKDIR /app
COPY *.sln ./
# Copy csproj and restore as distinct layers
#COPY *.csproj ./

COPY ["Gabriel/Gabriel.csproj", "Gabriel/"]
#COPY ["Gabriel/Gabriel.Db", "Gabriel/"]

RUN dotnet restore "Gabriel/Gabriel.csproj"
COPY . ./
RUN dotnet publish -c Release -o out

# Build runtime image
FROM mcr.microsoft.com/dotnet/aspnet:5.0
WORKDIR /app
COPY --from=build-env /app/out .
ENTRYPOINT ["dotnet", "Gabriel.dll"]