using DataAccessLayer;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer
{
    //Arayüz ile Database arasındaki Customer işlerinde bağlantı katmanıdır

    public class CustomerManager : ManagerBase<Customers>
    {
        private Repository<Customers> repo_customers = new Repository<Customers>();

        public List<Customers> GetCustomers()
        {
            return repo_customers.List();
        }
    }
}
