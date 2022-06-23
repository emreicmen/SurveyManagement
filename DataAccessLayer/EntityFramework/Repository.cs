using CoreLayer;
using EntityLayer;
using EntityLayer.JunctionTables;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    //Tüm Managerlar'da benzer fonksiyonalar kullanılacağı için bu fonksiyonları tek yerde topladık.Clean code için.
    public class Repository<T> : RepositoryBase where T : class
    {
        private DbSet<T> _objectSet;
        public Repository()
        {
            _objectSet = context.Set<T>();
        }
        public List<T> List()
        {
            return _objectSet.ToList();
        }

        public List<T> List(Expression<Func<T,bool>> where)
        {
            return _objectSet.Where(where).ToList();
        }

        public IQueryable<T> ListQueryable()
        {
            return _objectSet.AsQueryable<T>();
        }

        public IQueryable<T> ListQueryableUsersPolls()
        {
            return _objectSet.AsQueryable<T>();
        }

        public int Insert(T obj)
        {
            _objectSet.Add(obj);
            return Save();
        }

        public int Update(T obj)
        {
            return Save();
        }

        public int Delete(T obj)
        {
            _objectSet.Remove(obj);
            return Save();
        }

        public int Save()
        {
            return context.SaveChanges();
        }

        public T Find(Expression<Func<T, bool>> where)
        {
            return _objectSet.FirstOrDefault(where);
        }
    }
}
