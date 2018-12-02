use DB_CONSULTORIO

go 

create proc [select-exame-byConsultaId]
@consultaid int 

as 

select e.* 
from DB_CONSULTORIO.dbo.EXAME e
where e.FK_CONSULTA_ID = @consultaid