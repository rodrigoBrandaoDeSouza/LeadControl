# Lead Control

Lead Control é uma interface do usuário de gerenciamento de leads para uma empresa.

## Instalação

### Back End
1 - Com o Visual Studio abra o projeto LeadAPI.sln, que esta na pasta LeadControl-backend.

2 - Use o Nuget-package manager console para rodar criar o banco através da migration.

```bash
update-database
```
3 - Rode o projeto (F5).

### Front End
4 - Abra o projeto front-end no VS Code, e verifique o endereço da URL no arquivo lead-service.ts, e certifique que está apontando para a porta que o visual studio hospedou o projeto da api (padrão ```https://localhost:7156```)

```bash
..\LeadControl\LeadControl-frontend\src\app\services\lead-service.ts
```
5 - O projeto deve ser aberto com Google Chrome, sem a utilização de CORS, segue o [link](https://alfilatov.com/posts/run-chrome-without-cors/) com o tutorial. 

6 - Rode o projeto no visual studio code utilizando o comando
```bash
ng-serve
```

