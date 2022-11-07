# ApiExercise
Practice API

Video Tutorial Basis
  https://www.youtube.com/watch?v=5YB49OEmbbE&ab_channel=LesJackson
  
Tools
  Visual Studio Code - https://code.visualstudio.com
  Insomnia - https://insomnia.rest/download or Postman - https://www.postman.com/downloads/
  SQL SERVER(EXPRESS ONLY) - https://www.microsoft.com/en-us/sql-server/sql-server-downloads
  Docker Desktop - https://www.docker.com/products/docker-desktop/

CLI commands
  ---additional resources---
  dotnet dev-certs https --trust
  dotnet add package Microsoft.EntityFrameworkCore
  dotnet add package Microsoft.EntityFrameworkCore.Design
  dotnet add package Microsoft.EntityFrameworkCore.SQLServer
  dotnet add package AutoMapper.Extensions.Microsoft.DependencyInjection
  dotnet tool install --global dotnet-ef

  ---admin information---
  dotnet user-secrets init
  dotnet user-secrets set "UserId" "sa"
  dotnet user-secrets set "Password" "pa55w0rd!"

  ---mock database migration commands---
  dotnet ef migrations add initialmigration
  dotnet ef database update
