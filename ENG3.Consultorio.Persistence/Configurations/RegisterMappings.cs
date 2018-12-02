﻿using Dapper.FluentMap;
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
                config.AddMap(new AddressDapperMap());
                config.AddMap(new ContactDapperMap());
                config.AddMap(new DoctorDapperMap());
                config.AddMap(new SecretaryDapperMap());
                config.AddMap(new PatientDapperMap());
                config.AddMap(new ConvenioDapperMap());
                config.AddMap(new ConsultaDapperMap());
                config.AddMap(new MaterialDapperMap());
                config.AddMap(new ExameDapperRepository());
                config.ForDommel();
            });
        }
    }
}
