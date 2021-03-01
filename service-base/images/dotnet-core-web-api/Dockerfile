ARG VERSION=3.1-alpine

FROM mcr.microsoft.com/dotnet/core/aspnet:$VERSION AS base
FROM mcr.microsoft.com/dotnet/core/sdk:$VERSION AS build
# ./Service1.Api/Service1.Api.csproj
ARG PROJECT_PATH

# Simple Docker File (Un-optimised)
WORKDIR /
COPY . .

# Build and publish
RUN dotnet publish $PROJECT_PATH -c Release -o /app/publish

# Prepare the final copying only what we need.
FROM base as final
# Service1.Api.dll
ARG ENTRYPOINT

COPY --from=build /app/publish .
ENV ASPNETCORE_URLS=http://+:8000

# needs to be an ENV for use in entrypoint
ENV ENTRYPOINT=$ENTRYPOINT

EXPOSE 8000
ENTRYPOINT dotnet $ENTRYPOINT