# Get base SDK Image from microsoft and create working directory where our app will reside
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build-env
WORKDIR /app
EXPOSE 5000

# Copy the .csproj file (containing the dependencies, and specifics on how the code runs) and restore any them.
COPY *.csproj ./
RUN dotnet restore

# Copy everything else and build ( the out is the folder that contains the app build dll)
COPY . ./
RUN dotnet publish -c Release -o out

# Generate the runtime image; only retrieve asp.net runtime image --> keeps image small and efficient
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS final-env
WORKDIR /app

COPY --from=build-env /app/out .

ENTRYPOINT [ "dotnet", "Commander.dll" ]