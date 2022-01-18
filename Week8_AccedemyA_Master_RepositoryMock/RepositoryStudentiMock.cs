using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week8_AccedemyA_Master_Core.Entities;
using Week8_AccedemyA_Master_Core.InterfaceRepository;

namespace Week8_AccedemyA_Master_RepositoryMock
{
    public class RepositoryStudentiMock : IRepositoryStudente
    {

        public static List<Studente> Studenti = new List<Studente>()
        {
            new Studente()
            {
                Nome="Maria",
                Cognome="De Stefano",
                Email="maria.destefano91@gmail.com",
                DataNascita= new DateTime(1991, 08, 21),
                TitoloStudio= "Fisica Subnucleare",
                CorsoCodice= "C-01",

            },

            new Studente()
            {
                Nome="Martina",
                Cognome="Del Pezzo",
                Email="martina.delpezzo1@gmail.com",
                DataNascita= new DateTime(1995, 08, 28),
                TitoloStudio= "BioInformatica",
                CorsoCodice= "C-02",

            }
        };
        public Studente Add(Studente item)
        {
            if(Studenti.Count==0)
            {
                item.ID=1;
            }
            else
            {
                int maxid = 1;
                foreach (var s in Studenti)
                {
                    if (s.ID>maxid)
                    {
                        maxid = s.ID;
                    }
                }
                item.ID=maxid+1;
            }
            Studenti.Add(item);
            return item;
        }

        public bool Delete(Studente item)
        {
            throw new NotImplementedException();
        }

        public bool Esiste(Studente studente)
        {
            foreach (var item in Studenti)
            {
                if(studente.Nome==item.Nome &&
                   studente.Cognome==item.Cognome &&
                   studente.Email==item.Email)
                {
                    return true;
                }
            }return false;
        }

        public IList<Studente> GetAll()
        {
            return Studenti;
        }

        public Studente GetById(int id)
        {
            throw new NotImplementedException();
        }

        

        public Studente Update(Studente item)
        {
            throw new NotImplementedException();
        }
    }
}
