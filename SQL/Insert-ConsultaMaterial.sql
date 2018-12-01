use DB_CONSULTORIO

go

create proc [Insert-ConsultaMaterial]
@consultaId int,
@materialId int 

as 


INSERT INTO [dbo].[CONSULTA_MATERIAL]
           ([FK_CONSULTA_ID]
           ,[FK_MATERIAL_ID])
     VALUES
           (@ConsultaId
           ,@materialId)
