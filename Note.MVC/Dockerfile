#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:3.1 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:3.1 AS build
WORKDIR /src
COPY ["Note.MVC/Note.MVC.csproj", "Note.MVC/"]
RUN dotnet restore "Note.MVC/Note.MVC.csproj"
COPY . .
WORKDIR "/src/Note.MVC"
RUN dotnet build "Note.MVC.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Note.MVC.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Note.MVC.dll"]