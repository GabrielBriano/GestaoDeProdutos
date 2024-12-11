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

<br>
Configurar o Backend (API):<br>
Acesse a pasta da API: cd GerenciamentoAPI.Api/GerenciamentoAPI<br>

<br>
Configurar a String de Conexão:<br>
	No arquivo appsettings.json, configure a conexão com seu banco de dados PostgreSQL:<br>
<br>
	"ConnectionStrings": {<br>
  		"DefaultConnection": "Host=localhost;Database=ProductDB;Username=postgres;Password=suaSenha"<br>
	}<br>

<br>
Executar as Migrações do Banco de Dados:<br>
	dotnet ef migrations add InitialCreate<br>
	dotnet ef database update<br>

<br>
Iniciar o Servidor:<br>
	Compile e execute a API com o comando: dotnet run<br>

<br>
Testar a API:<br>
	Acesse o Swagger no navegador para testar os endpoints: http://localhost:7047/swagger<br>

<br>
Configurar o Front-End (Delphi)<br>

Abra o Projeto no Delphi:<br>

Acesse a pasta FrontEnd e abra o arquivo .dproj no Delphi.<br>

Configurar a URL da API:<br>

No código, localize a constante API_BASE_URL e configure a URL da API:<br>
<br>
const<br>
  API_BASE_URL = 'http://localhost:7047/api/products';<br>
<br>
Compilar o Projeto:<br>

Compile o projeto no Delphi. Certifique-se de que não há erros antes de executar.<br>

Executar o Front-End:<br>

Execute o aplicativo no Delphi para testar as funcionalidades de cadastro, edição, exclusão e listagem de produtos.
