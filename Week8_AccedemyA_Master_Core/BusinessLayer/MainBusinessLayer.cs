using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week8_AccedemyA_Master_Core.Entities;
using Week8_AccedemyA_Master_Core.InterfaceRepository;

namespace Week8_AccedemyA_Master_Core.BusinessLayer
{
    public class MainBusinessLayer : IBusinessLayer
    {
        //qui mi creo una variabile
        //private readonly IRepositoryCorso corsiRepo;
        //private readonly IRepositoryStudente studentiRepo;

        //faccio il costruttore 
        //public MainBusinessLayer(IRepositoryCorso corsi, IRepositoryStudente studenti) //in input ha Irepositorycorsi
        //{
        //    corsiRepo = corsi;
        //    studentiRepo = studenti;
        //}

       

        public Esito AddNuovoCorso(Corso nuovoCorso)
        {
            //controllo se il codice inserito è già esistente
            //devo accedere al mio database al mio corsiRepo e vedere se c'è un corso con quel codice
            //corsiRepo.GetAll().FirstOrDefault(c=>c.CorsoCodice == nuovoCorso.CorsoCodice);
            //posso sfruttare il getByCode
            Corso corsoesistente=corsiRepo.GetByCorso(nuovoCorso.CorsoCodice);
            if (corsoesistente == null)
            {
                corsiRepo.Add(nuovoCorso);
                return new Esito { Messaggio = "Corso Aggiunto Correttamente", Ok = true };
            }
            else
            {
                return new Esito { Messaggio = "Codice già in uso", Ok = false };
            }
            
        }

        

        public List<Corso> GetAllCorso()
        {
            return corsiRepo.GetAll().ToList();
        }

        public List<Studente> GetAllStudente()
        {
            return studentiRepo.GetAll().ToList();
        }

        public Esito ModificaCorso(string? codice, string? nuovoNome, string? nuovaDescrizione)
        {
            var corsoEsistente=corsiRepo.GetByCorso(codice);
            //il var fa prendere il tipo in automatico
            if (corsoEsistente == null)
            {
                return new Esito {Messaggio= "Non esiste alcun corso con questo codice", Ok = false };
            }else
            {
                corsoEsistente.Nome = nuovoNome;
                corsoEsistente.Descrizione = nuovaDescrizione;
                corsiRepo.Update(corsoEsistente);
                return new Esito {Messaggio ="Corso modificato correttamente", Ok = true};  
            }
        }

        public Esito RimuoviCorso(string? codice)
        {
            var corsoEsistente = corsiRepo.GetByCorso(codice);
            //il var fa prendere il tipo in automatico
            if (corsoEsistente == null)
            {
                return new Esito { Messaggio = "Non esiste alcun corso con questo codice", Ok = false };
            }
            else
            {
                corsiRepo.Delete(corsoEsistente);
                return new Esito { Messaggio = "Corso eliminato correttamente", Ok = true };
            }
        }

        public Esito AddNuovoStudente(Studente nuovoStudente)
        {
            //controllo input
            

            if (studentiRepo.Esiste(nuovoStudente))
            {
                return new Esito { Messaggio = "Studente già esistente nel Db" , Ok=false};
            }
            studentiRepo.Add(nuovoStudente);
            return new Esito { Messaggio = "Studente aggiunto correttamente", Ok = true };


        }
    }
}
