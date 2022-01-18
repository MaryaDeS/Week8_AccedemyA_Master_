using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week8_AccedemyA_Master_Core;
using Week8_AccedemyA_Master_Core.Entities;
using Week8_AccedemyA_Master_Core.InterfaceRepository;

namespace Week8_AccedemyA_Master_RepositoryEF.RepositoryEF
{
    public class RepositoryCorsoEF :IRepositoryCorso
    {
        //public static Corso Create(Corso item)
        //{
        //    using (var ctx=new MasterContext())
        //    {
        //        ctx.Corsi.Add(item);
        //        ctx.SaveChanges();
        //    }
        //}
        public Corso Add(Corso item)
        {
            using (var ctx=new MasterContext())
            {
                ctx.Corsi.Add(item);
                ctx.SaveChanges();
            }
            return item;
        }

        public bool Delete(Corso item)
        {
           using (var ctx=new MasterContext())
            {
                ctx.Corsi.Remove(item);
                ctx.SaveChanges();
            }
           return true;
        }

        public IList<Corso> GetAll()
        {
            using (var ctx= new MasterContext())
            {
                return ctx.Corsi.Include(l => l.Lezioni).Include(s=>s.Studenti).ToList();
            }
        }

        public Corso GetByCorso(string codice)
        {
            throw new NotImplementedException();
        }

        public Corso GetByCorso(Studente nuovoStudente)
        {
            throw new NotImplementedException();
        }

        public Corso Update(Corso item)
        {
            using (var ctx=new MasterContext())
            {
                ctx.Corsi.Update(item);
                ctx.SaveChanges();
            }
            return item;
        }
    }
}
