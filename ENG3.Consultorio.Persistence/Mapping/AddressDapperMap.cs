using Dapper.FluentMap.Dommel.Mapping;
using ENG3.Consultorio.Doman.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENG3.Consultorio.Persistence.Mapping
{
    public class AddressDapperMap : DommelEntityMap<Address>
    {
        public AddressDapperMap()
        {
            ToTable("ENDERECO");

            Map(p => p.Id)
                     .ToColumn("PK_ENDERECO")
                     .IsIdentity()
                     .IsKey();

            Map(p => p.Cep)
                      .ToColumn("CEP");

            Map(p => p.Number)
                      .ToColumn("NUMERO");

            Map(p => p.Complemento)
                      .ToColumn("COMPLEMENTO");

            Map(p => p.AddressValue)
                     .Ignore();
        }
    }
}
