Create Proc [Insert-Secretaria_TELEFONE]
@cpf int,
@TelefoneId int 

as 

insert into SECRETARIA_TELEFONE values (@cpf,@TelefoneId)