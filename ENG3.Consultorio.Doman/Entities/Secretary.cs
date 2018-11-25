using ENG3.Consultorio.Doman.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENG3.Consultorio.Doman.Entities
{
    public class Secretary
    {
        public string Cpf { get; set; }
        public string Name { get; set; }
        public List<Contact> Contacts { get; set; }
        public Address Address { get; set; }
        public Login Login { get; set; }
    }
}
