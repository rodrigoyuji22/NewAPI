# NewAPI
## 📋 Descrição
Projeto backend em ASP.NET Core que oferece uma **API RESTful** para gerenciamento de tarefas pessoais. Cada usuário pode se cadastrar, autenticar e gerenciar suas próprias tasks de forma segura e isolada.

## 🚀 Funcionalidades e tecnologias utilizadas

- ✅ Cadastro e login de usuários
- ✅ Autenticação com **JWT (JSON Web Token)**
- ✅ CRUD completo de tarefas por usuário autenticado
- ✅ Validações robustas com **FluentValidation**
- ✅ Mapeamento de objetos com **AutoMapper**
- ✅ Acesso a dados com **Entity Framework Core**
- ✅ Separação em camadas (Controller, Service, Repository, DTOs)

## Versão dos pacotes
AutoMapper — versão 14.0.0
FluentValidation.AspNetCore — versão 11.3.1
JetBrains.Annotations — versão 2025.1.0-eap1
Microsoft.AspNetCore.Authentication.JwtBearer — versão 8.0.13
Microsoft.AspNetCore.Identity.EntityFrameworkCore — versão 8.0.13
Microsoft.EntityFrameworkCore.Design — versão 8.0.13
Pomelo.EntityFrameworkCore.MySql — versão 8.0.3
Swashbuckle.AspNetCore — versão 6.6.2


## ⚙️ Endpoints

- `POST /User/register` – Cadastra usuário 
- `POST /User/login` – Faz login do usuário retornando um token JWT em forma de string
- `POST /Task/create` – Cria uma tarefa associada ao user com base no token 
- `GET /Task` – Retorna uma lista de tasks do user
- `PUT /Task` – Atualiza uma task com um Json do corpo da requisição
- `DELETE /Task/{id}` – Remove uma task 


---
### Pré-requisitos

- [.NET SDK](https://dotnet.microsoft.com/download)
- [MySQL](https://dev.mysql.com/downloads/installer/)

### Passos

```bash
# Clone o repositório
git clone https://github.com/rodrigoyuji22/NewAPI.git
cd NewAPI

# Restaure os pacotes
dotnet restore

# Execute a aplicação
dotnet run
```

## 📫 Contato

- LinkedIn: [Rodrigo Koike](https://www.linkedin.com/in/rodrigo-koike-83018a2b4/)
- Email: rodrigoyujikoike@gmail.com


## License

This project is licensed under the terms of the [MIT License](LICENSE).
