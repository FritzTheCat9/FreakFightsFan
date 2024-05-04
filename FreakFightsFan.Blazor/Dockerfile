FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /app
COPY ["FreakFightsFan.Blazor/FreakFightsFan.Blazor.csproj", "FreakFightsFan.Blazor/"]
COPY ["FreakFightsFan.Shared/FreakFightsFan.Shared.csproj", "FreakFightsFan.Shared/"]
RUN dotnet restore "./FreakFightsFan.Blazor/FreakFightsFan.Blazor.csproj"
COPY . .
WORKDIR "/app/FreakFightsFan.Blazor"
RUN dotnet build "./FreakFightsFan.Blazor.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "./FreakFightsFan.Blazor.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM nginx:alpine
EXPOSE 80
EXPOSE 443
WORKDIR /usr/share/nginx/html
# Copy published app files
COPY --from=publish /app/publish/wwwroot/ .
# Copy nginx.conf file
COPY ./FreakFightsFan.Blazor/nginx.conf /etc/nginx/nginx.conf