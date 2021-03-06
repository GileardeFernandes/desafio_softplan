<h2>Desafio Softplan</h2>

## instalaΓ§Γ£o

| Ferramentas ambiente                               |
| ---------------------------------------------------|
|<a href="https://git-scm.com/">Git</a>              |
|<a href="https://code.visualstudio.com/">Vs Code</a>|
|<a href="https://insomnia.rest/">Insomnia</a>       |

<h2># π Tecnologias</h2>

.net core
.NET SDKs installed:
  5.0.201
EntityFrameworkCore.InMemory
 5.0.4
.EntityFrameworkCore.Relational
 5.0.4



#Estrutura API1
```
.
βββ API1.csproj
βββ appsettings.Development.json
βββ appsettings.jsonΒ          
βββ Controllers
βΒ Β  βββ TaxaJurosController.cs
βββ Domain
βΒ Β  βββ Models
βΒ Β  βΒ Β  βββ TaxaJuros.cs
βΒ Β  βββ Repositories
βΒ Β  βΒ Β  βββ ITaxaJurosRepository.cs
βΒ Β  βββ Services
βΒ Β      βββ ITaxaJurosService.cs
βββ Persistence
βΒ Β  βββ Contexts
βΒ Β  βΒ Β  βββ AppDBContext.cs
βΒ Β  βββ Repositories
βΒ Β      βββ BaseRepository.cs
βΒ Β      βββ TaxaJurosRepository.cs
βββ Program.cs
βββ Properties
βΒ Β  βββ launchSettings.json
βββ Services
βΒ Β  βββ TaxaJurosService.cs
βββ Startup.cs
```

#Estrutura API2

```
βββ API2.csproj
βββ appsettings.Development.json
βββ appsettings.json
βββ Controllers
βΒ Β  βββ CalculaJurosController.cs
βΒ Β  βββ ShowMeTheCodeController.cs
βββ Domain
βΒ Β  βββ Dtos
βΒ Β  βΒ Β  βββ DadosCalculoJurosDTO.cs
βΒ Β  βΒ Β  βββ TaxaJurosDTO.cs
βΒ Β  βββ Models
βΒ Β  βΒ Β  βββ ResultadoCalculoJuros.cs
βΒ Β  βββ Services
βΒ Β      βββ ICalculaJurosService.cs
βββ Program.cs
βββ Properties
βΒ Β  βββ launchSettings.json
βββ Services
βΒ Β  βββ ApiService.cs
βΒ Β  βββ CalculaJurosService.cs
βββ Startup.cs
```

#Estrutura XNIT TESTE

```
.
βββ API1TESTE.csproj
βββ Controller
βΒ Β  βββ TaxaJurosControllerTest.cs
βββ Service
    βββ TaxaJurosServiceFake.cs
```

Muito bem, agora que jΓ‘ sabemos um pouco da estrutura do nosso projeto,
vamos configurar nosso insomnia para testar nossas requisiΓ§Γ΅es, se vocΓͺ quiser
pode usar o de sua preferΓͺncia, clique no link para baixar e importar a estrutura das 
reaquisiΓ§Γ΅es: https://drive.google.com/drive/folders/1Wh6k6HeO8xfmD7bMVJejvyoIL837Q6I2?usp=sharing

Para importar, bastar ir atΓ© import/export

![image](https://user-images.githubusercontent.com/55728068/111513374-820c7800-872f-11eb-9ec5-7835614a9df7.png)

Agora vamos baixar nossos fontes, utilizando o bash ou outro terminal
de sua preferΓͺncia, vamos dar get no repositΓ³rio com o seguinte comando:

```
git clone https://github.com/GileardeFernandes/desafio_softplan.git

```

Agora vamos rodar nossas API's, navegamos primeiro atΓ© a pasta API1
e rodamos os seguintes comandos:

```
dotnet builder
dotnet run

```
Se tudo correr bem vocΓͺ verΓ‘ essa mensagem de saΓ­da:

![image](https://user-images.githubusercontent.com/55728068/111514534-98670380-8730-11eb-8959-b976ff2e78e7.png)

e poderΓ‘ acessar a documentaΓ§Γ£o da API com o link https://localhost:5001/swagger/index.html

![image](https://user-images.githubusercontent.com/55728068/111514879-ebd95180-8730-11eb-85da-4d00de8d9a74.png)

Agora vamos subir nossa API2, vamos atΓ© a pasta API2 e rodamos o mesmo comando:

```
dotnet builder
dotnet run

```
tudo dando certo, termos a seguinte mensagem no bash

![image](https://user-images.githubusercontent.com/55728068/111515208-45418080-8731-11eb-8f56-b5a08c338c41.png)

Bom, agora Γ© hora de testar nossas rotas, com a estrutura das requisiΓ§Γ΅es em mΓ£os,
vamos testar:

Rota(taxajuros)

![image](https://user-images.githubusercontent.com/55728068/111515454-8e91d000-8731-11eb-87e7-9611e21c51a6.png)

Rota(calculajuros)

![image](https://user-images.githubusercontent.com/55728068/111515581-ba14ba80-8731-11eb-8ac3-dfeaf63900fd.png)

Rota(showmethecode)

![image](https://user-images.githubusercontent.com/55728068/111516162-5b9c0c00-8732-11eb-8861-51a799a9d546.png)

Maravilha, vamos agora rodar o teste unitΓ‘rio na aplicaΓ§Γ£o API1TESTE,
dentro na pasta rodamos o comando

```
dotnet test

```
Receberemos em nosso bash o log no teste:
![image](https://user-images.githubusercontent.com/55728068/111516734-001e4e00-8733-11eb-9860-da1f9ecab24a.png)

Finalizamos nossos testes :) !!!!!! π π π π π π 









