using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENG3.Consultorio.Doman.Entities
{
    class Doctor
    {
        public int Crm { get; set; }
        public string Name { get; set; }
        public string Specialty{ get; set; }
        public Login Login { get; set; }

    }
}
