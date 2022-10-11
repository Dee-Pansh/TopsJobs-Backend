#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["JobSeeker/ResumeServices.csproj", "JobSeeker/"]
RUN dotnet restore "JobSeeker/ResumeServices.csproj"
COPY . .
WORKDIR "/src/JobSeeker"
RUN dotnet build "ResumeServices.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "ResumeServices.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "ResumeServices.dll"]