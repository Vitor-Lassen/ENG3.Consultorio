use DB_CONSULTORIO

go

create proc [select-consulta-byDate]
@date datetime

as 

select * from CONSULTA
where  DT_HR_INICIO =DT_HR_INICIO