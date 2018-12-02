using Dapper.FluentMap.Dommel.Mapping;
using ENG3.Consultorio.Doman.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENG3.Consultorio.Persistence.Mapping
{
    class ExameDapperRepository:DommelEntityMap<Exame>
    {
        public ExameDapperRepository()
        {
            ToTable("EXAME");

            Map(p => p.Id)
                   .ToColumn("PK_EXAME")
                   .IsKey()
                   .IsIdentity();

            Map(p => p.Date)
                   .ToColumn("DT_HR_INICIO");

            Map(p => p.Name)
                   .ToColumn("TIPO_EXAME");

            Map(p => p.ConsultaId)
                   .ToColumn("FK_CONSULTA_ID");

        }
    }
}
