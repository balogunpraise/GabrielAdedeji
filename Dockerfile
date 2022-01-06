#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.
FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443
FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY *.sln .
#COPY ["CaveShells/CaveShells.csproj", "CaveShells/"]
COPY Gabriel/*.csproj Gabriel/
COPY Gabriel.Data/*.csproj Gabriel.Data/
COPY Gabriel.Models/*.csproj Gabriel.Models/
RUN dotnet restore Gabriel/*.csproj
COPY . .
WORKDIR /src/Gabriel
RUN dotnet build
FROM build AS publish
WORKDIR /src/Gabriel
RUN dotnet publish -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
#COPY --from=publish /src/CaveShells/wwwroot/data/Category.json data/
#COPY --from=publish /src/CaveShells/Data/JsonFiles/Category.json JsonFiles/
#COPY --from=publish /src/CaveShells/Data/JsonFiles/Images.json JsonFiles/ 
#COPY --from=publish /src/CaveShells/Data/JsonFiles/Product.json JsonFiles/
#ENTRYPOINT ["dotnet", "CaveShells.dll"]
CMD ASPNETCORE_URLS=http://*:$PORT dotnet Gabriel.dll