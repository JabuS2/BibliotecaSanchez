# Gerenciamento de Biblioteca

## Visão Geral do Projeto

Este projeto permite o cadastro, busca e listagem de livros e autores. Inclui testes automatizados para garantir o funcionamento correto.

## Tecnologias Utilizadas

- **Linguagem**: C#
- **IDE**: Visual Studio
- **Banco de Dados**: SQL Server (produção), PostgreSQL (desenvolvimento)
- **Gerenciador de BD**: DBeaver
- **Testes Automatizados**: Selenium

## Configuração do Ambiente

### Requisitos de Sistema

- Windows 10 ou superior
- Visual Studio 2019 ou superior
- SQL Server 2019
- PostgreSQL 13
- DBeaver 21.0 ou superior
- Selenium WebDriver

### Passos para Configuração

1. **Instalar Visual Studio**
   - Baixe e instale o Visual Studio.
   - Selecione as workloads de desenvolvimento em C# e .NET.

2. **Instalar SQL Server e PostgreSQL**
   - Baixe e instale o SQL Server.
   - Baixe e instale o PostgreSQL.

3. **Instalar DBeaver**
   - Baixe e instale o DBeaver.

4. **Clonar o Repositório**
   - Entre no link: [https://github.com/JabuS2/BibliotecaSanchez](https://github.com/JabuS2/BibliotecaSanchez)
   - Clone o repositório.

5. **Instalar Dependências do Projeto**
   - Abra o projeto no Visual Studio.
   - Abra o Package Manager Console no Visual Studio através do menu Tools > NuGet Package Manager > Package Manager Console.
   - Execute o comando `Update-Package -reinstall` para instalar todas as dependências listadas no arquivo de projeto (.csproj).

## Banco de Dados

1. **Configuração do Entity Framework**
   - Use o Entity Framework Core para gerenciar a criação e migração do banco de dados.
   - Configure as conexões de banco de dados no arquivo `appsettings.json`.

2. **Adicionar Migrations e Atualizar o Banco de Dados**
   - No Package Manager Console, execute os seguintes comandos:
     ```sh
     Add-Migration NomeDaMigration
     Update-Database
     ```

## Funcionalidades

### Cadastro de Livros

- Permite excluir, editar e cadastrar novos livros especificando título, ano de publicação e autores associados.

### Cadastro de Autores

- Permite excluir, editar e cadastrar novos autores especificando nome e data de nascimento.

### Relacionamento entre Livros e Autores

- Utiliza-se a tabela de junção `AutorLivro` para associar livros e autores.

### Listagem e Pesquisa

- Permite listar e pesquisar livros e autores cadastrados.

## Testes Automatizados

### Ferramentas Utilizadas

- Selenium WebDriver para automação dos testes de interface.

### Instruções para Realizar os Testes

1. Clone o repositório da nossa cópia web simplificada: [https://github.com/JabuS2/BibliotecaWeb-TesteAutomatizado](https://github.com/JabuS2/BibliotecaWeb-TesteAutomatizado)
2. Configure a String de conexão da mesma forma que foi mostrado anteriormente.
3. Instale as dependências da mesma forma que foi mostrado anteriormente.
4. Inicie a aplicação.
5. Clone o repositório do nosso teste unitário: [https://github.com/JabuS2/Selenium-Automatizado](https://github.com/JabuS2/Selenium-Automatizado)
6. Configure a String de conexão da mesma forma que foi mostrado anteriormente.
7. Instale as dependências da mesma forma que foi mostrado anteriormente.
8. Configure a porta correta.
9. Execute os testes.
