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
        public int Cpf { get; set; }
        public string Name { get; set; }
        public List<Contact> Contacts { get; set; }
        public int AddressId { get; set; }
        public Address Address { get; set; }
        public int LoginId { get; set; }
        public Login Login { get; set; }
        public Secretary()
        {
            Address = new Address();
            Contacts = new List<Contact>();
            Login = new Login();
        }
    }
}
