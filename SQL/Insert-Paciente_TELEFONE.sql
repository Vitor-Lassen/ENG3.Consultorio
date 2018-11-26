Create Proc [Insert-Paciente_TELEFONE]
@cpf int,
@TelefoneId int 

as 

insert into Paciente_TELEFONE values (@cpf,@TelefoneId)