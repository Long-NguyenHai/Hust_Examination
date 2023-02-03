# TEDU Exam Project

## Application URLs:
- Identity STS: https://localhost:5001
- Exam API: https://localhost:5002
- Exam Web Admin Client: https://localhost:6001
- Exam Web App Client (Portal): https://localhost:6002
- Identity Admin: https://localhost:6003

## Docker Command Examples
- SQL Server image: docker run -e "ACCEPT_EULA=Y" -e "MSSQL_SA_PASSWORD=Admin@123$" -p 1433:1433 -d mcr.microsoft.com/mssql/server:2019-latest

- docker ps or docker container ls

- Mongo Image: docker run -d --name mongodb -e MONGO_INITDB_ROOT_USERNAME=mongoadmin -e MONGO_INITDB_ROOT_PASSWORD=Admin@123$ -p 127.0.0.1:27017:27017 mongo

- iex ((New-Object System.Net.WebClient).DownloadString('https://raw.githubusercontent.com/IdentityServer/IdentityServer4.Quickstart.UI/main/getmain.ps1'))


## Drop database 
USE master;
GO

ALTER DATABASE [Identity] SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
GO
DROP DATABASE [Identity];
GO

## Packages References
- https://github.com/serilog/serilog/wiki/Getting-Started
- https://github.com/IdentityServer/IdentityServer4.Quickstart.UI
- https://mudblazor.com/
- https://github.com/Garderoben/MudBlazor.Templates

## References URLS
- https://samwalpole.com/using-scoped-services-inside-singletons
- https://docs.microsoft.com/en-us/aspnet/core/fundamentals/dependency-injection?view=aspnetcore-5.0