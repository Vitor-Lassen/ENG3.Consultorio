using Dapper.FluentMap.Dommel.Mapping;
using ENG3.Consultorio.Doman.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENG3.Consultorio.Persistence.Mapping
{
   public class DoctorDapperMap : DommelEntityMap<Doctor>
    {
        public DoctorDapperMap()
        {
            ToTable("MEDICO");
            Map(p => p.Crm)
                     .ToColumn("PK_CRM")
                     .IsKey();

            Map(p => p.Name)
                     .ToColumn("NOME");

            Map(p => p.Specialty)
                     .ToColumn("ESPECIALIDADE");

            Map(p => p.LoginId)
                     .ToColumn("FK_LOGIN_ID");

            Map(p => p.AddressId)
                     .ToColumn("FK_ENDERECO_ID");

          
        }
    }
}
