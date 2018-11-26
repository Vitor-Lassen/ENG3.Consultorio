Create Proc [Insert-MEDICO_TELEFONE]
@Crm int,
@TelefoneId int 

as 

insert into MEDICO_TELEFONE values (@Crm,@TelefoneId)