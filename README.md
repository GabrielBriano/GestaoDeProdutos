Antes de começar, certifique-se de ter as seguintes ferramentas instaladas:<br>
API Backend:<br>
	.NET SDK (versão 6.0 ou superior)<br>
   PostgreSQL<br>
<br>
Front-End Delphi:<br>
	Delphi IDE (Delphi Community Edition)<br>

<br>
Configuração do Projeto:<br>
Faça o clone do repositório em sua máquina local: <br>
https://github.com/GabrielBriano/GestaoDeProdutos.git<br>


Configurar o Backend (API):
Acesse a pasta da API: cd seu-repositorio/API


Configurar a String de Conexão:
	No arquivo appsettings.json, configure a conexão com seu banco de dados PostgreSQL:

	"ConnectionStrings": {
  		"DefaultConnection": "Host=localhost;Database=ProductDB;Username=postgres;Password=suaSenha"
	}


Executar as Migrações do Banco de Dados:
	dotnet ef migrations add InitialCreate
	dotnet ef database update


Iniciar o Servidor:
	Compile e execute a API com o comando: dotnet run


Testar a API:
	Acesse o Swagger no navegador para testar os endpoints: http://localhost:5000/swagger

 3. Configurar o Front-End (Delphi)

Abra o Projeto no Delphi:

Acesse a pasta FrontEnd e abra o arquivo .dproj no Delphi.

Configurar a URL da API:

No código, localize a constante API_BASE_URL e configure a URL da API:

const
  API_BASE_URL = 'http://localhost:5000/api/products';

Compilar o Projeto:

Compile o projeto no Delphi. Certifique-se de que não há erros antes de executar.

Executar o Front-End:

Execute o aplicativo no Delphi para testar as funcionalidades de cadastro, edição, exclusão e listagem de produtos.
