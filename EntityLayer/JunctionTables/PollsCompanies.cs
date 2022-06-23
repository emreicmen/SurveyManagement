using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.JunctionTables
{
    //Database kısmında Polls ve Companies arasındaki ilişkili tablo 
    public class PollsCompanies
    {
        [ForeignKey("Polls")]
        public int PollID { get; set; }

        [ForeignKey("Companies")]
        public int CompanyID { get; set; }

        public virtual Companies Companies { get; set; }
        public virtual Polls Polls { get; set; }

    }
}
