# 🖥️ Sistema de Gerenciamento de Computadores

Este projeto tem o objetivo de facilitar a comunicação entre professores e técnicos, de maneira que os técnicos possam visualizar todas solicitações de atenção em computadores de salas específicas, melhorando a eficiência de aprendizado dos alunos da instituição.

---

## ⌨️ Funcionalidades

- Cadastro de Computadores por nome e ID
- Cadastro de Salas por computador no sistema
- Gerador de Solicitações para notificar problemas com uma máquina
- Listagem de todas solicitações em um lugar
- Edição da lista com a opção de excluir solicitações

---

## 💻 Tecnologias Utilizadas

- C# (lógica de programação e backend)
- HTML5, CSS3 e JavaScript (frontend)
- MySQL (banco de dados)
- Padrão de arquitetura MVC
- Visual Studio Code (ambiente de desenvolvimento)

---

## 🚀 Como executar o projeto localmente

### Pré-requisitos ###

- Ter o [Visual Studio Code](https://code.visualstudio.com/) instalado
- Ter o [MySQL Server](https://dev.mysql.com/downloads/mysql/) instalado e rodando
- Ter o .NET SDK instalado (caso o projeto utilize .NET Core ou similar)

### Passos ###

1. Crie ou acesse uma pasta (de preferência vazia.)

2. Acesse o git bash no diretório escolhido

3. Clone o repositório com o link:
git clone https://github.com/Trustingtag/Projeto_Dotnet8.git

4. Abra o diretório no VScode

### Rodando o programa ###

1. No MySQL crie a database "projeto_ds"
2. No terminal digite: "dotnet ef migrations add Teste1"
3. Após digite: "dotnet ef database update"
4. Inicie o programa utilizando o "dotnet watch"

---

## 📁 Estrutura do Projeto (MVC) ##

```
/Projeto_Dotnet8
├── /bin
├── /Controllers
    └──ComputadorController.cs
    └──PrincipalController.cs
    └──SalaController.cs
├── /Data
    └── BancoContext.cs
├── Migrations
├── /Models
    └── ComputadorModel.cs
    └── ErrorViewModel.cs
    └── MensagemModels.cs
    └── SalaModels.cs
├── /Views
        Computador
            └── CriarPC.cshtml
        Principal
            └── Criar.cshtml
            └── Deletar.cshtml
            └── Editar.cshtml
            └── Index.cshtml
            └── Listar.cshtml
├── Shared
├── /wwwroot (arquivos estáticos como CSS e JS)
├── appsettings.json
├── Program.cs```


## 🤝 Contribuidores

- Ryan Marcel Sousa Santos 
- Leonardo Araujo Oliveira

---

## 📬 Contato

Para dúvidas ou sugestões:
- 📧 ryan.m.santos@ba.estudante.senai.br
- 📧 leonardo.a.oliveira6@ba.estudante.senai.br
- 🌐 https://github.com/Ryan-Marcel
- 🌐 https://github.com/Trustingtag