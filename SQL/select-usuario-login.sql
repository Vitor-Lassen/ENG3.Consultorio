use DB_CONSULTORIO

go 

create proc [select-usuario-login]
@login nvarchar (10),
@password nvarchar(30)

as 
select * from USUARIO
where USUARIO = @login
and senha = @password 