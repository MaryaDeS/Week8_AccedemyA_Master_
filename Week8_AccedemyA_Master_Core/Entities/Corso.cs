using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week8_AccedemyA_Master_Core.Entities
{
    public class Corso
    {
        public string? CorsoCodice { get; set; }
        public string? Nome { get; set; }
        public string? Descrizione { get; set; }

        //relazione 1:n tra studente e corso
        public IList<Studente> Studenti { get; set; }= new List<Studente>();  

        //relazione 1:n tra lezione e corso
        public IList<Lezione> Lezioni { get; set; }= new List<Lezione>();

        public override string ToString()
        {
            return $"{CorsoCodice} - {Nome} - {Descrizione}";
        }
    }
}
