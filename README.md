Antes de começar, certifique-se de ter as seguintes ferramentas instaladas:
API Backend:
	.NET SDK (versão 6.0 ou superior)
   PostgreSQL

Front-End Delphi:
	Delphi IDE (Delphi Community Edition)


Configuração do Projeto:
Faça o clone do repositório em sua máquina local: 
https://github.com/GabrielBriano/GestaoDeProdutos.git


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
