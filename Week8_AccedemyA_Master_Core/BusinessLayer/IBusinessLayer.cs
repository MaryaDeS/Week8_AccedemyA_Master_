using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week8_AccedemyA_Master_Core.Entities;

namespace Week8_AccedemyA_Master_Core.BusinessLayer
{
    //questa interfaccia la uso come collegamento userinterface e core
    //deve contenere tutti i metodi
    public interface IBusinessLayer
    {
        public List<Corso> GetAllCorso();
        public Esito AddNuovoCorso(Corso nuovoCorso);
        public Esito ModificaCorso(string? codice, string? nuovoNome, string? nuovaDescrizione);
        public Esito RimuoviCorso(string? codice);


        public List<Studente> GetAllStudente();
        public Esito AddNuovoStudente(Studente nuovoStudente);
    }
}
