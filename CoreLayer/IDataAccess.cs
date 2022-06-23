using EntityLayer.JunctionTables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CoreLayer
{
    //Metodları parametre tipi ve dönüş tipi bağımsız yapıp kulanılması gerekli yerlerde implemente edilmesi için tek çatıda topladık
    public interface IDataAccess<T>
    {
        List<T> List();
        List<T> List(Expression<Func<T, bool>> where);
        int Insert(T obj);
        IQueryable<T> ListQueryable();
        int Update(T obj);
        int Delete(T obj);
        int Save();
        T Find(Expression<Func<T, bool>> where);

    }
}
