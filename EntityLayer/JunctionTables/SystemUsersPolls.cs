using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.JunctionTables
{
    //Database kısmında SystemUsers ve Polls arasındaki ilişkili tablo 
    public class SystemUsersPolls
    {

        [ForeignKey("SystemUsers")]
        public int UserID { get; set; }

        [ForeignKey("Polls")]
        public int PollID { get; set; }

        public string Question1SystemUsersComment { get; set; }
        public string Question2SystemUsersComment { get; set; }
        public string Question3SystemUsersComment { get; set; }

        public virtual Polls Polls { get; set; }
        public virtual SystemUsers SystemUsers { get; set; }

    }
}
