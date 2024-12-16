# Projeto UserManagement - API Backend

## Descrição

O **UserManagement** é um projeto de gerenciamento de usuários, implementado utilizando a arquitetura DDD (Domain-Driven Design). O projeto inclui uma API em ASP.NET Core que permite a criação, consulta e atualização de dados de usuários, com integração com o banco de dados SQL Server.

## Arquitetura

Este projeto segue o padrão DDD (Domain-Driven Design), o que significa que o código é estruturado de acordo com os principais conceitos do domínio de negócios. As camadas principais incluem:

- **Core**: Contém as entidades e lógicas do domínio.
- **Infrastructure**: Responsável pela implementação de acesso a dados e outras dependências externas (ex.: banco de dados).
- **API**: Contém a implementação da API que se comunica com o usuário final e faz uso das camadas Core e Infrastructure.

## Funcionalidades

- **Cadastro de usuários**: Permite cadastrar um novo usuário no sistema.
- **Consulta de usuários**: Permite consultar os dados de usuários cadastrados.
- **Atualização de usuários**: Permite editar os dados dos usuários existentes.

## Tecnologias Usadas

- **ASP.NET Core**: Framework principal para desenvolvimento da API.
- **Entity Framework Core**: ORM para interação com o banco de dados SQL Server.
- **SQL Server**: Banco de dados utilizado para armazenar as informações dos usuários.

## Como Rodar o Projeto

### Pré-requisitos

- **Visual Studio** ou **Visual Studio Code** instalado.
- **SQL Server** rodando e acessível para o projeto.
- Clone este repositório e abra a solução no seu ambiente de desenvolvimento.

### Passos para rodar a API
   
1. Abra o projeto no Visual Studio ou no Visual Studio Code.

2. Configure a string de conexão no arquivo `appsettings.json` com as informações do seu banco de dados SQL Server:

    ```json
    {
        "ConnectionStrings": {
            "DefaultConnection": "Server=localhost;Database=UserManagement;Trusted_Connection=True;"
        }
    }
    ```

3. Execute as migrations para criar o banco de dados e as tabelas necessárias.

4. Execute o projeto. A API estará disponível no **Swagger** ou no endereço configurado.

## Testando a API

A API pode ser testada utilizando o Swagger UI, que estará disponível automaticamente após a execução do projeto. Com o Swagger, você pode:

- Testar os endpoints de criação, consulta e atualização de usuários.
- Ver a documentação gerada automaticamente para os endpoints da API.

