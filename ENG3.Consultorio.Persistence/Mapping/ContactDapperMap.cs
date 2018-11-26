using Dapper.FluentMap.Dommel.Mapping;
using ENG3.Consultorio.Doman.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENG3.Consultorio.Persistence.Mapping
{
    class ContactDapperMap : DommelEntityMap<Contact>
    {
        public ContactDapperMap()
        {
            ToTable("TELEFONE");

            Map(p => p.Id)
                     .ToColumn("PK_TELEFONE")
                     .IsKey()
                     .IsIdentity();

            Map(p => p.ContactValue)
                     .ToColumn("TELEFONE");


            Map(p => p.Type)
                     .ToColumn("TYPE");

        }
    }
}
