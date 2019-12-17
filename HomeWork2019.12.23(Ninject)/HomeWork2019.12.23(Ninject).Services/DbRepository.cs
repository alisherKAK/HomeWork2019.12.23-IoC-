using HomeWork2019._12._23_Ninject_.AbstractModels;
using System.Collections.Generic;
using System.Data.Entity;

namespace HomeWork2019._12._23_1_.Services
{
    public class DbRepository<T> : IRepository<T> where T : class, IEntity
    {
        private readonly DbContext _context;
        public DbRepository(DbContext context)
        {
            _context = context;
        }

        public void Add(T item)
        {
            _context.Set<T>().Add(item);
            _context.SaveChanges();
        }

        public void Delete(T item)
        {
            _context.Set<T>().Remove(item);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            T item = _context.Set<T>().Find(id);
            Delete(item);
        }

        public IEnumerable<T> GetAll()
        {
            return _context.Set<T>();
        }

        public void Update(T item)
        {
            _context.Set<T>().Remove(item);
            _context.Set<T>().Add(item);
            _context.SaveChanges();
        }
    }
}
