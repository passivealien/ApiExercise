# ApiExercise
Practice API<br />

Video Tutorial Basis<br />
  https://www.youtube.com/watch?v=5YB49OEmbbE&ab_channel=LesJackson<br />
  
Tools<br />
  Visual Studio Code - https://code.visualstudio.com<br />
  Insomnia - https://insomnia.rest/download or <br />
  Postman - https://www.postman.com/downloads/<br />
  SQL SERVER(EXPRESS ONLY) - https://www.microsoft.com/en-us/sql-server/sql-server-downloads<br />
  Docker Desktop - https://www.docker.com/products/docker-desktop/<br />

CLI commands<br />
  ---additional resources---<br />
  dotnet dev-certs https --trust<br />
  dotnet add package Microsoft.EntityFrameworkCore<br />
  dotnet add package Microsoft.EntityFrameworkCore.Design<br />
  dotnet add package Microsoft.EntityFrameworkCore.SQLServer<br />
  dotnet add package AutoMapper.Extensions.Microsoft.DependencyInjection<br />
  dotnet tool install --global dotnet-ef<br />

  ---admin information---<br />
  dotnet user-secrets init<br />
  dotnet user-secrets set "UserId" "sa"<br />
  dotnet user-secrets set "Password" "pa55w0rd!"<br />

  ---mock database migration commands---<br />
  dotnet ef migrations add initialmigration<br />
  dotnet ef database update<br />
