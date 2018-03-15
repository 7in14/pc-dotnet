FROM microsoft/aspnetcore:2.0-nanoserver-sac2016 AS base
WORKDIR /app
EXPOSE 80

FROM microsoft/aspnetcore-build:2.0-nanoserver-sac2016 AS build
WORKDIR /src
COPY 7in14.sln ./
COPY 7in14/7in14.csproj 7in14/
RUN dotnet restore -nowarn:msb3202,nu1503
COPY . .
WORKDIR /src/7in14
RUN dotnet build -c Release -o /app

FROM build AS publish
RUN dotnet publish -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "7in14.dll"]
