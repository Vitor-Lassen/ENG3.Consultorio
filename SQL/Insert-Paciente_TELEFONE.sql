Create Proc [Insert-Paciente_TELEFONE]
@cpf bigint,
@TelefoneId int 

as 

insert into Paciente_TELEFONE values (@cpf,@TelefoneId)