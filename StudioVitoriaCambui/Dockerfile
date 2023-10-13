FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["StudioVitoriaCambui/StudioVitoriaCambui.csproj", "StudioVitoriaCambui/"]
RUN dotnet restore "StudioVitoriaCambui/StudioVitoriaCambui.csproj"
COPY . .
WORKDIR "/src/StudioVitoriaCambui"
RUN dotnet build "StudioVitoriaCambui.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "StudioVitoriaCambui.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "StudioVitoriaCambui.dll"]
