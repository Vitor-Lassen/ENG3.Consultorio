using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENG3.Consultorio.Doman.Entities
{
    public class Login
    {
        public int Id { get; set; }
        public string User { get; set; }
        public string Password { get; set; }
        public char Access { get; set; }
    }
}
