using Dapper.FluentMap.Dommel.Mapping;
using ENG3.Consultorio.Doman.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENG3.Consultorio.Persistence.Mapping
{
    class ConsultaDapperMap:DommelEntityMap<Consulta>
    {
        public ConsultaDapperMap()
        {
            ToTable("CONSULTA");

            Map(p => p.Id)
                   .ToColumn("PK_CONSULTA")
                   .IsKey()
                   .IsIdentity();

            Map(p => p.DateStart)
                   .ToColumn("DT_HR_INICIO");

            Map(p => p.DateEnd)
                   .ToColumn("DT_HR_FIM");

            Map(p => p.ConsultaType)
                   .ToColumn("TIPO_CONSULTA");

            Map(p => p.Price)
                   .ToColumn("VALOR");

            Map(p => p.PagamentType)
                   .ToColumn("TIPO_PAGAMENTO");

            Map(p => p.Quitado)
                   .ToColumn("QUITADO");

            Map(p => p.SecretaryId)
                   .ToColumn("FK_SECRETARIA_ID");

            Map(p => p.DoctorId)
                   .ToColumn("FK_MEDICO_ID");

            Map(p => p.PatientId)
                    .ToColumn("FK_PACIENTE_ID");

        }
    }
}
