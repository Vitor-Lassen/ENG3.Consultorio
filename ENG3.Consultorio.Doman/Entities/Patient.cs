using ENG3.Consultorio.Doman.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENG3.Consultorio.Doman.Entities
{
    public class Patient
    {
        public long Cpf { get; set; }
        public string Name { get; set; }
        public List<Contact> Contacts { get; set; }
        public int AddressId { get; set; }
        public Address Address { get; set; }
        public int ConvenioId { get; set; }
        public Convenio Convenio { get; set; }

        public Patient()
        {
            Contacts = new List<Contact>();
            Address = new Address();
            Convenio = new Convenio();
        }

    }
}
