Para criar API .net

- Download SDK
  https://dotnet.microsoft.com/pt-br/download

- dotnet new webapi

- Verifique as extensões do AspNet e C#
dotnet new install Microsoft.DotNet.Web.ProjectTemplates.8.0 (caso necessário)
dotnet new install Microsoft.AspNetCore.Templates (caso necessário para última versão)

-Identação automática:
Alterar o Editor: Default Formatter para C#

- Instalar Entity Framewark
dotnet tool install --global dotnet-ef

- Instalar pacotes adicionais
dotnet add package Microsoft.EntityFrameworkCore.Design
dotnet add package Microsoft.EntityFrameworkCore.SqlServer (para SQL)

- Configurar Entities (para DB, para uso interno usar Model)
- Configurar Context
- Criar Conexão no Program.cs
configurar appsettings
AddDbContext

- Criar Controllers
criar construtor para receber o context
CRUD



