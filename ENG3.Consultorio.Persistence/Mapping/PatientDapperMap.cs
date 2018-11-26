using Dapper.FluentMap.Dommel.Mapping;
using ENG3.Consultorio.Doman.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENG3.Consultorio.Persistence.Mapping
{
    public class PatientDapperMap:DommelEntityMap<Patient>
    {
        public PatientDapperMap()
        {
            ToTable("PACIENTE");
            Map(p => p.Cpf)
                    .ToColumn("PK_CPFPACIENTE")
                    .IsKey();

            Map(p => p.Name)
                      .ToColumn("NOME");


            Map(p => p.AddressId)
                      .ToColumn("FK_ENDERECO_ID");


            Map(p => p.ConvenioId)
                      .ToColumn("FK_CONVENIO_ID");
        }
    }
}
