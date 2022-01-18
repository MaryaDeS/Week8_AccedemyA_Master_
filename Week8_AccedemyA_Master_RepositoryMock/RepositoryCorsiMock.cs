using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week8_AccedemyA_Master_Core.Entities;
using Week8_AccedemyA_Master_Core.InterfaceRepository;

namespace Week8_AccedemyA_Master_RepositoryMock
{
    public class RepositoryCorsiMock : IRepositoryCorso
    {

        public static List<Corso> Corsi = new List<Corso>()
        {
            new Corso()
            {CorsoCodice="C-01",
             Nome="Pre-Academy A",
             Descrizione="C#"
            },

            new Corso()
            {CorsoCodice="C-02",
             Nome="Academy A",
             Descrizione="C# Avanzato"
            }
        };

       


        public Corso Add(Corso item)
        {
            Corsi.Add(item);
            return item;
        }

        public bool Delete(Corso item)
        {
            Corsi.Remove(item);
            return true;
        }

        public IList<Corso> GetAll()
        {
            return Corsi;
        }

        public Corso GetByCorso(string codice)
        {
            return Corsi.FirstOrDefault(c=>c.CorsoCodice==codice);
        }

        public Corso GetByCorso(Studente nuovoStudente)
        {
            throw new NotImplementedException();
        }

        public Corso Update(Corso item)
        {
            foreach(var c in Corsi)
            {
                if(c.CorsoCodice==item.CorsoCodice)
                {
                    c.Nome=item.Nome;
                    c.Descrizione = item.Descrizione;
                    return c;
                }
            }return null;
        }
    }
}
