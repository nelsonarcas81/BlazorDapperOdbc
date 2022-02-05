#Blazor #Dapper #Odbc #DBF
<h1 aling="center"> Blazor acessando dados através ODBC </h1>

Este é um pequeno exemplo para acessar fontes de dados ODBC através de um projeto Blazor Server, alterando apenas a string de conexão, sem alterar nada em código.

<h3>Pré-requisitos</h3>
Para utilização você precisa ter instalado o driver ODBC correspondete a fonte de dados que será conectada.

<h3>Testes realizados</h3>
Foram realizados os testes com as fontes odbc abaixo, dentro da pasta scripts existe o arquivo "Strings_Connections.txt" com os exemplos

<table>
  <tr>
    <th>Fonte</th>
    <th>Driver ODBC</th>
  </tr>
  <tr>
    <td>Visual FoxPro DBF</td>
    <td>Advantage StreamlineSQL ODBC</td>
  </tr>
  <tr>
    <td>Access</td>
    <td>Microsoft Access Driver (*.mdb, *.accdb)</td>
  </tr>
  <tr>
    <td>Sqlite</td>
    <td>SQLite3 ODBC Driver</td>
  </tr>
  <tr>
    <td>Sql Server</td>
    <td>SQL Server</td>
  </tr>
  <tr>
    <td>MySql</td>
    <td>MySQL ODBC 8.0 ANSI Driver</td>
  </tr>
  <tr>
    <td>PostgreS</td>
    <td>PostgreSQL ANSI</td>
  </tr>
</table>

<h3>Scripts</h3>
Para os exemplos com o banco relacional está disponível o script para cada banco na pasta Scripts

Para os exemplos para conexão com arquivo está disponivel dentro de cada pasta
<ul>
  <li>Sqlite</li>
  <li>Access</li>
  <li>Dbfs</li>
</ul>
