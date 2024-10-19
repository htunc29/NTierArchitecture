using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repostories
{
    public class GenericRepository<T> : IGenericDal<T> where T : class
    {
        Context c = new Context();
        public void Delete(T t)
        {
            c.Set<T>().Remove(t);
            c.SaveChanges();
        }

        public T GetById(int id)
        {
            return c.Set<T>().Find(id);
        }

        public void Insert(T t)
        {
           c.Set<T>().Add(t);
            c.SaveChanges();
        }

        public List<T> List()
        {
            return c.Set<T>().ToList();
        }

        public void Update(T t)
        {
            c.Set<T>().AddOrUpdate(t);
            c.SaveChanges();
        }
    }
}
