using Dapper.FluentMap.Dommel.Mapping;
using ENG3.Consultorio.Doman.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENG3.Consultorio.Persistence.Mapping
{
    class LoginDapperMap: DommelEntityMap<Login>
    {
        public LoginDapperMap()
        {
            ToTable("USUARIO");
            Map(p => p.Id)
                     .ToColumn("PK_USUARIO")
                     .IsKey()
                     .IsIdentity();

            Map(p => p.User)
                     .ToColumn("USUARIO");

            Map(p => p.Password)
                      .ToColumn("SENHA");


            Map(p => p.Access)
                      .ToColumn("ACESSO");
        }
    }
}
