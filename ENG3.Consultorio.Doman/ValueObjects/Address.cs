using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENG3.Consultorio.Doman.ValueObjects
{
    public class Address
    {
        public int Id { get; set; }
        public int Cep { get; set; }
        public string Complemento { get; set; }
        public int Number { get; set; }
        public string AddressValue { get; set; }

    }
}
