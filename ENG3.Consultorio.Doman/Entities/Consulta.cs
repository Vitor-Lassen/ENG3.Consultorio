using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENG3.Consultorio.Doman.Entities
{
    public class Consulta
    {
        public int Id { get; set; }
        public Secretary Secretary { get; set; }
        public Doctor Doctor { get; set; }
        public Patient Patient { get; set; }
        public DateTime DateStart { get; set; }
        public DateTime DateEnd { get; set; }
        public string ConsultaType { get; set; }
        public double Price{ get; set; }
        public string PagamentType { get; set; }
        public bool Quitado { get; set; }
        public List<string> Materiais { get; set; }

    }
}
