<h2>Desafio Softplan</h2>

## instalação

| Ferramentas ambiente                               |
| ---------------------------------------------------|
|<a href="https://git-scm.com/">Git</a>              |
|<a href="https://code.visualstudio.com/">Vs Code</a>|
|<a href="https://insomnia.rest/">Insomnia</a>       |

<h2># 🚀 Tecnologias</h2>

#.net core
.NET SDKs installed:
  5.0.201
.EntityFrameworkCore.InMemory
 5.0.4
.EntityFrameworkCore.Relational
 5.0.4

#Estrutura API1
```
.
├── API1.csproj
├── appsettings.Development.json
├── appsettings.json          
├── Controllers
│   └── TaxaJurosController.cs
├── Domain
│   ├── Models
│   │   └── TaxaJuros.cs
│   ├── Repositories
│   │   └── ITaxaJurosRepository.cs
│   └── Services
│       └── ITaxaJurosService.cs
├── Persistence
│   ├── Contexts
│   │   └── AppDBContext.cs
│   └── Repositories
│       ├── BaseRepository.cs
│       └── TaxaJurosRepository.cs
├── Program.cs
├── Properties
│   └── launchSettings.json
├── Services
│   └── TaxaJurosService.cs
└── Startup.cs
```

#Estrutura API2

```
├── API2.csproj
├── appsettings.Development.json
├── appsettings.json
├── Controllers
│   ├── CalculaJurosController.cs
│   └── ShowMeTheCodeController.cs
├── Domain
│   ├── Dtos
│   │   ├── DadosCalculoJurosDTO.cs
│   │   └── TaxaJurosDTO.cs
│   ├── Models
│   │   └── ResultadoCalculoJuros.cs
│   └── Services
│       └── ICalculaJurosService.cs
├── Program.cs
├── Properties
│   └── launchSettings.json
├── Services
│   ├── ApiService.cs
│   └── CalculaJurosService.cs
└── Startup.cs
```

#Estrutura XNIT TESTE

```
.
├── API1TESTE.csproj
├── Controller
│   └── TaxaJurosControllerTest.cs
└── Service
    └── TaxaJurosServiceFake.cs
```

Muito bem, agora que já sabemos um pouco da estrutura do nosso projeto,
vamos configurar nosso insomnia para testar nossas requisições, se você quiser
pode usar o de sua preferência, clique no link para baixar e importar a estrutura das 
reaquisições: https://drive.google.com/drive/folders/1Wh6k6HeO8xfmD7bMVJejvyoIL837Q6I2?usp=sharing

Para importar, bastar ir até import/export

![image](https://user-images.githubusercontent.com/55728068/111513374-820c7800-872f-11eb-9ec5-7835614a9df7.png)

Agora vamos baixar nossos fontes, utilizando o bash ou outro terminal
de sua preferência, vamos dar get no repositório com o seguinte comando:

```
git clone https://github.com/GileardeFernandes/desafio_softplan.git

```

Agora vamos rodar nossas API's, navegamos primeiro até a pasta API1
e rodamos os seguintes comandos:

```
dotnet builder
dotnet run

```
Se tudo correr bem você verá essa mensagem de saída:

![image](https://user-images.githubusercontent.com/55728068/111514534-98670380-8730-11eb-8959-b976ff2e78e7.png)

e poderá acessar a documentação da API com o link https://localhost:5001/swagger/index.html

![image](https://user-images.githubusercontent.com/55728068/111514879-ebd95180-8730-11eb-85da-4d00de8d9a74.png)

Agora vamos subir nossa API2, vamos até a pasta API2 e rodamos o mesmo comando:

```
dotnet builder
dotnet run

```
tudo dando certo, termos a seguinte mensagem no bash

![image](https://user-images.githubusercontent.com/55728068/111515208-45418080-8731-11eb-8f56-b5a08c338c41.png)

Bom, agora é hora de testar nossas rotas, com a estrutura das requisições em mãos,
vamos testar:

Rota(taxajuros)

![image](https://user-images.githubusercontent.com/55728068/111515454-8e91d000-8731-11eb-87e7-9611e21c51a6.png)

Rota(calculajuros)

![image](https://user-images.githubusercontent.com/55728068/111515581-ba14ba80-8731-11eb-8ac3-dfeaf63900fd.png)

Rota(showmethecode)

![image](https://user-images.githubusercontent.com/55728068/111516162-5b9c0c00-8732-11eb-8861-51a799a9d546.png)

Maravilha, vamos agora rodar o teste unitário na aplicação API1TESTE,
dentro na pasta rodamos o comando

```
dotnet test

```
Receberemos em nosso bash o log no teste:
![image](https://user-images.githubusercontent.com/55728068/111516734-001e4e00-8733-11eb-9860-da1f9ecab24a.png)

Finalizamos nossos testes :) !!!!!! 🚀 🚀 🚀 🚀 🚀 🚀 









