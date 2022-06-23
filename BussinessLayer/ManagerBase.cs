﻿using CommonLayer;
using CoreLayer;
using DataAccessLayer;
using EntityLayer.JunctionTables;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer
{
    //Arayüz ile Database arasındaki işlemlerde tüm tabloalrda aynı fonskiyonlar kullanılabilir.Bu yüzden işlemleri
    //tek çatı altında topladık
    public abstract class ManagerBase<T> : IDataAccess<T> where T : class
    {
        private Repository<T> repo = new Repository<T>();

        public virtual int Delete(T obj)
        {
            return repo.Delete(obj);
        }

        public virtual T Find(Expression<Func<T, bool>> where)
        {
            return repo.Find(where);
        }

        public virtual int Insert(T obj)
        {
            return repo.Insert(obj);
        }

        public virtual List<T> List()
        {
            return repo.List();
        }

        public virtual List<T> List(Expression<Func<T, bool>> where)
        {
            return repo.List(where);
        }

        public virtual IQueryable<T> ListQueryable()
        {
            return repo.ListQueryable();
        }

        public virtual int Save()
        {
            return repo.Save();
        }

        public virtual int Update(T obj)
        {
            return repo.Update(obj);
        }
    }
}
