using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    //Context oluşturma işlemini bir yeden yönetmek için bu sınıf yazılmıştır.
    public class RepositoryBase
    {
        protected static DatabaseContext context;
        protected static object _lockSync = new object();
        protected RepositoryBase()
        {
            CreateContext();
        }
        public static DatabaseContext CreateContext()
        {
            if (context == null)
            {
                //Multi thread işlemlerinde context oluşturma işlemi çökerse uygulama da çöker.Bunu önlemek için lock işlemi yaptık
                lock (_lockSync)
                {
                    if (context == null)
                    {
                        context = new DatabaseContext();
                    }
                }
            }
            return context;
        }
    }
}
