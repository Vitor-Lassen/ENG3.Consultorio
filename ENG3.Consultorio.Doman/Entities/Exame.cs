using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENG3.Consultorio.Doman.Entities
{
    public class Exame
    {
        public int Id { get; set; }
        public Consulta Consulta { get; set; }
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public List<string> Materiais { get; set; }
    }
}
