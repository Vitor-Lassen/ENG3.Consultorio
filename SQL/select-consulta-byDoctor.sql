use DB_CONSULTORIO

go

create proc [select-consulta-byDate]
@doctorId int 

as 

select * from CONSULTA
where FK_MEDICO_ID = @doctorId
and DT_HR_INICIO > getdate()