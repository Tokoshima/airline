FROM mcr.microsoft.com/dotnet/core/aspnet:3.1 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:3.1 AS build
WORKDIR /src
COPY ["blazortest/blazortest.csproj", "blazortest/"]
RUN dotnet restore "blazortest/blazortest.csproj"
COPY . .
WORKDIR "/src/blazortest"
RUN dotnet build "blazortest.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "blazortest.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "blazortest.dll"]
