# Lead Control

Lead Control é uma interface do usuário de gerenciamento de leads para uma empresa.

## Instalação

### Back End
1 - Com o Visual Studio abra o projeto LeadAPI.sln, que esta na pasta LeadControl-backend.

2 - Use o Nuget-package manager console para rodar criar o banco através da migration.

```bash
update-database
```
3 -Após criar o banco, executar o arquivo Insert-inicial.sql, que está na pasta database-script.

```bash
insert into  [Status] (id, [Description])
values(NEWID(), 'Accepted'),(NEWID(), 'Invited'), (NEWID(), 'Declined');

insert into  [Leads] (id,FirstName, LastName, [Description], Email, Phone, Price, Suburb, JobId,Category)
values
(NEWID(), 'Rodrigo','Brandao','Precisa desenvolver um software','rodrigo@email.com','(45)999947551',1320.0,'Panorama','11245', 'Desenvolvedors'),
(NEWID(), 'João','Silva','Precisa pintar o muro','joao@email.com','(45)999947551',850.0,'Centro','11246', 'Pintores'),
(NEWID(), 'Sandro','Silva','Precisa instalar um ar-condicionado','sandro@email.com','(45)999947551',150.0,'Lagos','11247', 'Eletrecistas'),
(NEWID(), 'Maria','Salete','Precisa de uma faxineira, para limpeza pesada','maria@email.com','(45)999947551',80.0,'Jardim das Flores','11248', 'Diaristas'),
(NEWID(), 'Ana','Lucia','Precisa corrigir um TCC','ana@email.com','(45)999947551',1400.0,'Centro','11249', 'Corretores');

insert into LeadStatus (Id, LeadId, StatusId)
select
NEWID(), 
l.Id,
(select id from status where [Description] = 'Invited')
from Leads l 
```

4 - Rode o projeto (F5).

### Front End
5 - Abra o projeto front-end no VS Code, e verifique o endereço da URL no arquivo lead-service.ts, e certifique que está apontando para a porta que o visual studio hospedou o projeto da api (padrão ```https://localhost:7156```)

```bash
..\LeadControl\LeadControl-frontend\src\app\services\lead-service.ts
```
6 - O projeto deve ser aberto com Google Chrome, sem a utilização de CORS, segue o [link](https://alfilatov.com/posts/run-chrome-without-cors/) com o tutorial. 

7 - Rode o projeto no visual studio code utilizando o comando
```bash
ng-serve
```

