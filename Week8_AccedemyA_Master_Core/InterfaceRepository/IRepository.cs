using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week8_AccedemyA_Master_Core
{
    public interface IRepository<T>
    {
        //operazioni "in comune a tutte le entità" o operazioni base che sono le CRUD
        public IList<T> GetAll(); //mi prende tutto di quella entità
        public T Add(T item); //questi sono i metodi CRUD
        public T Update(T item);
        public bool Delete(T item);
    }
}
