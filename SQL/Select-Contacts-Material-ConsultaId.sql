use DB_CONSULTORIO
go

create Proc [Select-Contacts-Material-ConsultaId]
@ConsultaId int

as 

select m.* from DB_CONSULTORIO.dbo.MATERIAL m
inner join DB_CONSULTORIO.dbo.CONSULTA_MATERIAL x on x.FK_MATERIAL_ID = m.PK_MATERIAL
where x.FK_CONSULTA_ID = @ConsultaId