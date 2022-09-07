#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["Backend/TweetApp.Api/TweetApp.Api.csproj", "Backend/TweetApp.Api/"]
COPY ["Backend/TweetApp.Repository/TweetApp.Repository.csproj", "Backend/TweetApp.Repository/"]
COPY ["Backend/TweetApp.Service/TweetApp.Service.csproj", "Backend/TweetApp.Service/"]
COPY ["Backend/TweetApp.Model/TweetApp.Model.csproj", "Backend/TweetApp.Model/"]
RUN dotnet restore "Backend/TweetApp.Api/TweetApp.Api.csproj"
COPY . .
WORKDIR "/src/Backend/TweetApp.Api"
RUN dotnet build "TweetApp.Api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "TweetApp.Api.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "TweetApp.Api.dll"]