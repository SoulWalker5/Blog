using DAL.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository
{
    public interface IGenericRepository<T> where T : class
    {
        T FindById(int id);
        IEnumerable<T> GetAll();
        void Create(T item);
        void Remove(int id);
        void Update(T item);
    }
    public class GenericRepository<T> : IDisposable, IGenericRepository<T> where T : class
    {
        private readonly MyContext _ctx;
        public GenericRepository()
        {
            _ctx = new MyContext();
        }

        public void Create(T item)
        {
            _ctx.Set<T>().Add(item);
            _ctx.SaveChanges();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> GetAll()
        {
            var searachRes = _ctx.Set<T>();

            return searachRes;
        }

        public T FindById(int id)
        {
            var search = _ctx.Set<T>().Find(id);

            return search;
        }

        public void Remove(int id)
        {
            var tEntity = _ctx.Set<T>().Find(id);
            _ctx.Set<T>().Remove(tEntity);
            _ctx.SaveChanges();
        }

        public void Update(T item)
        {
            _ctx.Entry(item).State = EntityState.Modified;
            _ctx.SaveChanges();
        }
    }
}
