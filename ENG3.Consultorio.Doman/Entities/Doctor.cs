using ENG3.Consultorio.Doman.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENG3.Consultorio.Doman.Entities
{
    public class Doctor
    {
        public int Crm { get; set; }
        public string Name { get; set; }
        public string Specialty{ get; set; }
        public Login Login { get; set; }
        public int LoginId { get; set; }
        public Address Address { get; set; }
        public int AddressId { get; set; }

    }
}
