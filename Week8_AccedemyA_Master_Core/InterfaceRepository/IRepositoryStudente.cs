using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week8_AccedemyA_Master_Core.Entities;

namespace Week8_AccedemyA_Master_Core.InterfaceRepository
{
    public interface IRepositoryStudente:IRepository<Studente>
    {
        public Studente GetById(int id);

       public bool Esiste(Studente studente);
    }
}
