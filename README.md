# API de Vídeos 🎥

Este é um projeto de API de Vídeos que estou desenvolvendo como parte dos meus estudos.

## Objetivo: Estudos 📚

O principal objetivo desse projeto é aprimorar meus conhecimentos em desenvolvimento de APIs e práticas de programação. Estou explorando diversos conceitos, como autenticação, permissões de usuário e gestão de recursos.

## Explorando com o Postman

Durante o desenvolvimento, estou utilizando o [Postman](https://www.postman.com/) para testar e explorar a API. Com o Postman, é possível realizar consultas aos endpoints, enviar solicitações HTTP e verificar as respostas.

Se você também está interessado em aprender mais sobre APIs e deseja testar a API de Vídeos, baixe o Postman e experimente!

# Configurando a API em sua máquina
#### Siga os passos abaixo para executar a aplicação em seu ambiente:
<li>Ter instalado em sua máquina o vscode, visual studio 2022 ou qualquer outro "gerenciador de códigos"</li>
<li>Ter o POSTGRESQL instalado em sua máquina, para isso siga os passos de como instalar [PostgreSQL](https://www.postgresql.org/download/). Neste projeto utilize a versão 15.00.</li>
<li>Verificar o arquivo 'appsettings.json', nele contém as connection strings, devem ser configuradas para execução do projeto. </li>

```
"Server=127.0.0.1;Port=5432;Database=video;User Id=[SEU ID];Password=[SUA SENHA];"
```
<li>Por fim, executar a update das migrations. 

```
Update-database -Context UsuarioDbContext
```

# Para utilizar a API, siga os comandos descritos abaixo: 
## Cadastrando Usuários 📝 ༼ つ ◕_◕ ༽つ
> Para cadastrar um usuário primeiro utilize o seguinte link: 📹
```
https://localhost:7279/Usuario/cadastro
```
> Logo em seguida adicione as seguintes informações no campo de atribuições do .JSON: 
```
{
    "Username" : "Nome de exemplo",
    "DataNascimento" : "1900-01-01",
    "PerfilUsuario" : 1,
    "Password" : "Senha123@"
    "RePassword" : "Senha123@"
}
```

### Utilize os seguintes perfis de usuário:
```
1 - Administrador
2 - Gerente 
3 - Usuario
Acima de 4 visitantes 
```

## Efetuando Login 🔑 (●'◡'●)
> Para efetuar o login basta seguir os passos infracitados:
```
https://localhost:7279/Usuario/login
```
> Logo em seguida adicione as seguintes informações no campo de atribuições do .JSON:
```
{
    "Username" : "Nome de exemplo",
    "Password" : "Senha123@"
}
```

## Cadastrando vídeos 🎬 (┬┬﹏┬┬) 
> Será descrito em breve

## Visualizando vídeos 📺 (┬┬﹏┬┬) 
> Será descrito em breve


## Cadastrando Categorias 🗂️ (┬┬﹏┬┬) 
> Será descrito em breve

## Visualizando Visualizando 📂 (┬┬﹏┬┬) 
> Será descrito em breve


