using CommonLayer;
using DataAccessLayer;
using EntityLayer;
using EntityLayer.JunctionTables;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer
{
    //Arayüz ile Database arasındaki Poll işlerinde bağlantı katmanıdır
    public class PollManager : ManagerBase<Polls>
    {
        private Repository<Polls> repo_polls = new Repository<Polls>();

        public List<Polls> GetPolls()
        {
            return repo_polls.List();
        }
    }
}
