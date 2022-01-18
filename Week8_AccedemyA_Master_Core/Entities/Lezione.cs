using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week8_AccedemyA_Master_Core.Entities
{
    public class Lezione
    {
        public int LezioneID { get; set; }
        public DateTime DataOraInizio { get; set; }
        public int Durata{ get; set; }
        public string? Aula { get; set; }

        //relazione uno a molti tra lezione e docenti
        //FK verso docente
        public int DocenteID { get; set; }
        public Docente? Docente { get; set; } //navigation property

        //relazione uno a molti lezione e corso
        //FK verso corso
        public string? CodiceCorso { get; set; }
        public Corso? Corso { get; set; }

        public override string ToString()
        {
            return $"lezione: {LezioneID} - Data: {DataOraInizio} - Aula:{Aula} - Durata in gg:{Durata}";
        }
    }
}
