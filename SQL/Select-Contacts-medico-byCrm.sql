Create Proc [Select-Contacts-medico-byCrm]
@crm int 

as 

select t.* from DB_CONSULTORIO.dbo.Telefone t
inner join DB_CONSULTORIO.dbo.MEDICO_TELEFONE x on t.PK_TELEFONE = x.FK_TELEFONE_ID
where x.FK_CRM = @crm