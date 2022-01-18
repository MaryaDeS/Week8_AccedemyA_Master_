using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week8_AccedemyA_Master_Core.Entities;
using Week8_AccedemyA_Master_Core.InterfaceRepository;

namespace Week8_AccedemyA_Master_RepositoryEF.RepositoryEF
{
    public class RepositoryStudentiEF : IRepositoryStudente
    {
        public Studente Add(Studente item)
        {
           using (var ctx=new MasterContext())
            {
                ctx.Studenti.Add(item);
                ctx.SaveChanges();
            }return item;
        }

        public bool Delete(Studente item)
        {
            using (var ctx = new MasterContext())
            {
                ctx.Studenti.Remove(item);
                ctx.SaveChanges();
            }
            return true;
        }

        public bool Esiste(Studente studente)
        {
            throw new NotImplementedException();
        }

        public IList<Studente> GetAll()
        {
            using (var ctx = new MasterContext())
            {
                return ctx.Studenti.ToList();
            }
            
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
