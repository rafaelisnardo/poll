# Poll RESTFul API

# Requisitos
### MSSQL Server Express
### .NET Core 3.1

# Instruções
Após executar o download dos arquivos deste repositorio, execute os seguintes passos no terminal para realizar o deploy da aplicação:

- Navegue até o diretório principal da aplicação;

- Execute o comando dotnet restore;

- Execute o comando dotnet build;

- Navegue até o diretório Poll.API;

- Edite o arquivo appsettings.json alterando o nome do servidor onde ficará hospedado o sql server express, User Id e Password;

- Execute então o comando dotnet publish --configuration Release;

- Navegue o diretório SQL e execute o arquivo Poll.sql para no SQL Management Studio para criar o database usado neste projeto;

- Após criado o database, navegue até o diretório Poll.API\bin\Release\netcoreapp3.1\publish;

- Copie todo o conteúdo para o diretório IIS onde será executado o projeto.
