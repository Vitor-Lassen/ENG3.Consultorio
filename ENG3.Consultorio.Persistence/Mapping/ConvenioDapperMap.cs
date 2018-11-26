using Dapper.FluentMap.Dommel.Mapping;
using ENG3.Consultorio.Doman.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENG3.Consultorio.Persistence.Mapping
{
    public class ConvenioDapperMap:DommelEntityMap<Convenio>
    {
        public ConvenioDapperMap()
        {
            ToTable("CONVENIO");

            Map(p => p.Id)
                      .ToColumn("PK_CONVENIO")
                      .IsKey()
                      .IsIdentity();

            Map(p => p.Name)
                      .ToColumn("NOME");
        }
    }
}
