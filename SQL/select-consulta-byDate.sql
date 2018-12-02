use DB_CONSULTORIO

go

create proc [select-consulta-byDate]
@date date

as 

select * from CONSULTA
where CONVERT(date, DT_HR_INICIO) =@date