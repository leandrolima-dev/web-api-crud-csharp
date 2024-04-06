# WebApiBase

# WEB API com .NET e SQL Server | CRUD | Repository Pattern

Este projeto, é uma `API` web, de gerenciamento de funcionários, com operações `CRUD` (`Create`, `Read`, `Update`, `Delete`) implementadas em `C#`.

## Imagem da API 🔗

[![Print API rodando no swagger](assets/images/api_swagger.png)](URL_do_Link)

## Recursos

A `API` fornece os seguintes endpoints:

- `GET` /Funcionario: Retorna todos os funcionários
- `POST` /Funcionario: Cria um novo funcionário
- `GET` /Funcionario/{id}: Retorna um funcionário pelo ID
- `PUT` /Funcionario/atualizaFuncionario: Inativa um funcionário
- `PUT` /Funcionario/inativaFuncionario: Atualiza os dados de um funcionário
- `DELETE` /Funcionario/deletaFuncionario: Deleta um funcionário

## Tecnologias Utilizadas

- [![.NET Badge](https://img.shields.io/badge/.NET-5C2D91?style=for-the-badge&logo=.net&logoColor=white)](https://dotnet.microsoft.com/)

- [![C#](https://img.shields.io/badge/csharp-%230078D7.svg?style=for-the-badge&logo=csharp&logoColor=white)](https://docs.microsoft.com/en-us/dotnet/csharp/)

- [![SQL Server Badge](https://img.shields.io/badge/SQL%20Server-CC2927?style=for-the-badge&logo=microsoft-sql-server&logoColor=white)](https://www.microsoft.com/en-us/sql-server)

- [![Entity Framework Badge](https://img.shields.io/badge/Entity%20Framework-512BD4?style=for-the-badge&logo=entity-framework&logoColor=white)](https://docs.microsoft.com/en-us/ef/)

- [![Swagger Badge](https://img.shields.io/badge/Swagger-85EA2D?style=for-the-badge&logo=swagger&logoColor=black)](https://swagger.io/)

- [![Visual Studio Badge](https://img.shields.io/badge/Visual%20Studio-5C2D91?style=for-the-badge&logo=visual-studio&logoColor=white)](https://visualstudio.microsoft.com/)

- [![Git Badge](https://img.shields.io/badge/Git-F05032?style=for-the-badge&logo=git&logoColor=white)](https://git-scm.com/)

- [![GitHub Badge](https://img.shields.io/badge/GitHub-181717?style=for-the-badge&logo=github&logoColor=white)](https://github.com/)

## Como Executar o Projeto 💻

1. Clone o repositório para a sua máquina local usando `git clone`.
2. Navegue até o diretório do projeto: `cd /exemplo`
3. Abra no Visual Studio ou Visual Studio Code.
4. No Visual Studio, pressione `F5` para iniciar a depuração.
5. No Visual Studio Code, você pode usar o comando `dotnet run` no terminal.
6. A API estará rodando em `https://localhost:<porta>/swagger` onde você pode ver e testar todos os endpoints disponíveis.

## Atenção⚠️

- Configuração do `Banco de Dados`

Antes de executar o projeto, certifique-se de que a string de conexão do banco de dados esteja corretamente configurada no arquivo `appsettings.json`, de acordo com os parâmetros do SQL Server na sua máquina.

Isso permitirá que você acesse o Swagger para interagir com a `API`.

## Licença

[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](https://opensource.org/licenses/MIT)

Feito com ♥ by Leandro Lima👋
