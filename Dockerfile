FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["hello-copilot.csproj", "./"]
RUN dotnet restore "hello-copilot.csproj"
COPY . .
WORKDIR "/src/."
RUN dotnet build "hello-copilot.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "hello-copilot.csproj" -c Release -o /app/publish

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 5023
ENV ASPNETCORE_URLS=http://+:5023

WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "hello-copilot.dll"]