Create Proc [Insert-Secretaria_TELEFONE]
@cpf bigint,
@TelefoneId int 

as 

insert into SECRETARIA_TELEFONE values (@cpf,@TelefoneId)