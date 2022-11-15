FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 5193
EXPOSE 7226

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["OpenApiDiscriminator/OpenApiDiscriminator.csproj", "OpenApiDiscriminator/"]
RUN dotnet restore "OpenApiDiscriminator/OpenApiDiscriminator.csproj"
COPY . .
WORKDIR "/src/OpenApiDiscriminator"
RUN dotnet build "OpenApiDiscriminator.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "OpenApiDiscriminator.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "OpenApiDiscriminator.dll"]
