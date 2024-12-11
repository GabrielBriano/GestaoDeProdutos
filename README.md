# **Gestão de Produtos**

Uma aplicação completa para gerenciamento de produtos, com funcionalidades de cadastro, edição, exclusão e listagem, utilizando uma API em **ASP.NET Core** e um front-end em **Delphi (VCL)**.

---

## **Pré-requisitos**

Certifique-se de ter as seguintes ferramentas instaladas antes de iniciar o projeto:

### API Backend:
- [.NET SDK](https://dotnet.microsoft.com/) (versão 8.0 usada nesse projeto)
- PostgreSQL

### Front-End Delphi:
- [Delphi IDE](https://www.embarcadero.com/) (Delphi Community Edition)

---

## **Configuração do Projeto**

### 1. Clonar o Repositório

```bash
git clone https://github.com/GabrielBriano/GestaoDeProdutos.git
```

---

### 2. Configurar o Backend (API)

1. **Acesse a pasta da API:**

   ```bash
   cd GerenciamentoAPI.Api/GerenciamentoAPI
   ```

2. **Configurar a String de Conexão:**

   No arquivo `appsettings.json`, configure a conexão com o banco de dados PostgreSQL:

   ```json
   {
       "ConnectionStrings": {
           "DefaultConnection": "Host=localhost;Database=ProductDB;Username=postgres;Password=123"
       }
   }
   ```

3. **Executar as Migrações do Banco de Dados:**

   ```bash
   dotnet ef migrations add InitialCreate
   dotnet ef database update
   ```

4. **Iniciar o Servidor:**

   ```bash
   dotnet run
   ```

5. **Testar a API:**

   Acesse o **Swagger** no navegador para testar os endpoints:

   ```
   http://localhost:7047/swagger
   ```

---

### 3. Configurar o Front-End (Delphi)

1. **Abrir o Projeto no Delphi:**
   - Navegue até a pasta `FrontEnd` e abra o arquivo `.dproj`.

2. **Configurar a URL da API:**
   No código, localize a constante `API_BASE_URL` e configure a URL correta:

   ```pascal
   const
       API_BASE_URL = 'http://localhost:7047/api/products';
   ```

3. **Compilar o Projeto:**
   Compile o projeto no Delphi. Certifique-se de que não há erros antes de executar.

4. **Executar o Front-End:**
   Execute o aplicativo no Delphi para testar as funcionalidades de cadastro, edição, exclusão e listagem de produtos.

---


## **Estrutura do Projeto**

### Backend (API):
- **Linguagem:** C# (.NET Core)
- **Banco de Dados:** PostgreSQL
- **Principais Arquivos:**
  - `Program.cs`: Configuração principal da API
  - `Controllers/ProductsController.cs`: Controlador responsável pelas operações CRUD
  - `Data/AppDbContext.cs`: Contexto do banco de dados
  - `Models/Product.cs`: Modelo do produto

### Front-End (Delphi):
- **Linguagem:** Delphi (VCL)
- **Principais Arquivos:**
  - `MainForm.dfm`: Interface gráfica
  - `MainForm.pas`: Código do front-end

---
