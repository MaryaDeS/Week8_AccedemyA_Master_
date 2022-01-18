using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week8_AccedemyA_Master_Core.Entities
{
    public class Docente:Persona
    {
        public string? Telefono { get; set; }

        public IList<Lezione> Lezioni { get; set; } = new List<Lezione>(); //ogni volta che ho un IList va inizializzata

        public override string ToString()
        {
            return base.ToString() + $"Telefono:{Telefono}";
        }
    }
}
