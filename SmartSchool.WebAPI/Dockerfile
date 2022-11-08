# syntax=docker/dockerfile:1
FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build-env
WORKDIR /api
    
# Copy csproj and restore as distinct layers
COPY *.csproj ./
RUN dotnet restore
    
# Copy everything else and build
COPY . ./
RUN dotnet publish -c Release -o out

# If you run Debian or Ubuntu, you also need to install locales to have locale-gen with
# RUN apt-get -y install locales
RUN apt-get update
RUN apt-get install libc-l10n locales locales-all

# Set the locale
RUN locale-gen pt_PT.UTF-8  
ENV LANG pt_PT.UTF-8  
ENV LANGUAGE pt_PT:en  
ENV LC_ALL pt_PT.UTF-8  

# Build runtime image
FROM mcr.microsoft.com/dotnet/aspnet:6.0
WORKDIR /api
COPY --from=build-env /api/out .
ENTRYPOINT ["dotnet", "SmartSchool.WebAPI.dll"]

