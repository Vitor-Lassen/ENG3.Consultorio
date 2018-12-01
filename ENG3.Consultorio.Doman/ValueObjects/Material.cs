using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENG3.Consultorio.Doman.ValueObjects
{
    public class Material
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Material(string name)
        {
            Name = name;
        }
    }
}
