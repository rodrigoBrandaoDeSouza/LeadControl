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