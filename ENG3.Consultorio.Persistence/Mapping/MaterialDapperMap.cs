using Dapper.FluentMap.Dommel.Mapping;
using ENG3.Consultorio.Doman.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENG3.Consultorio.Persistence.Mapping
{
    public class MaterialDapperMap:DommelEntityMap<Material>
    {
        public MaterialDapperMap()
        {
            ToTable("MATERIAL");

            Map(p => p.Id)
                    .ToColumn("PK_MATERIAL")
                    .IsIdentity()
                    .IsKey();

            Map(p => p.Name)
                    .ToColumn("Nome");
        }
    }
}
