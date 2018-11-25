using Dapper.FluentMap;
using Dapper.FluentMap.Dommel;
using ENG3.Consultorio.Persistence.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENG3.Consultorio.Persistence.Configurations
{
    public static class RegisterMappings
    {
        public static void Register()
        {
            FluentMapper.Initialize(config =>
            {
                config.AddMap(new LoginDapperMap());
                config.ForDommel();
            });
        }
    }
}
