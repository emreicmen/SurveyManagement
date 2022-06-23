using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.JunctionTables
{
    //Database kısmında Customers ve Polls arasındaki ilişkili tablo 
    public class CustomersPolls
    {
        [ForeignKey("Customers")]
        public int CustomerID { get; set; }

        [ForeignKey("Polls")]
        public int  PollID { get; set; }

        public virtual Customers Customers { get; set; }
        public virtual Polls Polls { get; set; }


    }
}
