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