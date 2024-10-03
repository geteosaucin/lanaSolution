# lanaSolution

# Projeto de Gestão de Alunos e Cursos

Este projeto é uma aplicação desktop desenvolvida em C# utilizando Windows Forms no Visual Studio 2022. A aplicação permite a gestão de alunos e cursos com autenticação de usuários.

## Tecnologias Utilizadas

- *Linguagem:* C#
- *Framework:* .NET Framework
- *Interface:* Windows Forms
- *Banco de Dados:* SQL Server

## Funcionalidades

- *Página de Login:*
  - Autenticação de usuários:
    - Acesso permitido somente a usuários com nome e senha cadastrados no banco de dados.
  
- *MDI (Multiple Document Interface):*
  - Cadastro de Alunos e Cursos:
    - Opções para criar, atualizar ou excluir registros.
  
  - Relatórios:
    - Visualização de dados de todos os usuários e alunos cadastrados.

## Estrutura do Projeto

/projeto │ ├── /Forms │ ├── LoginForm.cs │ ├── MDIForm.cs │ ├── CadastroAlunoForm.cs │ └── CadastroCursoForm.cs │ ├── /Models │ ├── Aluno.cs │ ├── Curso.cs │ └── Usuario.cs │ ├── /Data │ └── DatabaseConnection.cs │ └── Program.cs

## Como Executar o Projeto

1. Clone este repositório:
   git clone https://github.com/geteosaucin/lanaSolution
Abra o projeto no Visual Studio 2022.

Certifique-se de que o banco de dados SQL Server está configurado e com as tabelas necessárias.

Compile e execute a aplicação.

Acesse a página de login e utilize um usuário cadastrado para entrar.
