using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week8_AccedemyA_Master_Core.Entities;

namespace Week8_AccedemyA_Master_Core.InterfaceRepository
{
    public interface IRepositoryCorso:IRepository<Corso> //questa interfaccia implementa quella corso
    {
        public Corso GetByCorso(string codice);
        Corso GetByCorso(Studente nuovoStudente);
    }
}
