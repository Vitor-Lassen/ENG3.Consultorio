create Proc [Select-Contacts-Paciente-byCpf]
@Cpf bigint 

as 

select t.* from DB_CONSULTORIO.dbo.Telefone t
inner join DB_CONSULTORIO.dbo.Paciente_TELEFONE x on t.PK_TELEFONE = x.FK_TELEFONE_ID
where x.FK_CPFPaciente_ID = @cpf