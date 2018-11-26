using Dapper.FluentMap.Dommel.Mapping;
using ENG3.Consultorio.Doman.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENG3.Consultorio.Persistence.Mapping
{
    class SecretaryDapperMap:DommelEntityMap<Secretary>
    {
        public SecretaryDapperMap()
        {
            ToTable("SECRETARIA");

            Map(p => p.Cpf)
                     .ToColumn("PK_CPFSECRETARIA")
                     .IsKey();

            Map(p => p.Name)
                     .ToColumn("NOME");

            Map(p => p.LoginId)
                     .ToColumn("FK_LOGIN_ID");

            Map(p => p.AddressId)
                     .ToColumn("FK_ENDERECO_ID");
        }
    }
}
