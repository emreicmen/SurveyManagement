using DataAccessLayer;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer
{
    //Arayüz ile Database Company SystemUser işlerinde bağlantı katmanıdır
    public class CompanyManager : ManagerBase<Companies>
    {
        private Repository<Companies> repo_companies = new Repository<Companies>();

        public List<Companies> GetCompanies()
        {
            return repo_companies.List();
        }
    }
}
