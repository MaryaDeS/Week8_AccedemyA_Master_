using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week8_AccedemyA_Master_Core.Entities
{
    public class Studente:Persona
    {
        public DateTime DataNascita { get; set; }
        public string? TitoloStudio { get; set; }

        //relazione 1:n tra studente e corso
        //FK verso corso
        public string? CorsoCodice { get; set; }
        public Corso? Corso { get; set; } //Navigation Property

        public override string ToString()
        {
            return base.ToString() + $"Nato il:{DataNascita.ToShortDateString} - Titolo di studio: {TitoloStudio}";


        }

        public static void Add(Studente item)
        {
            throw new NotImplementedException();
        }
    }
}
