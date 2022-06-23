using EntityLayer.JunctionTables;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{

    //Database'deki Polls Tablosu
    public class Polls 
    {
        [Key]
        public int PollID { get; set; }

        public string PollTitle { get; set; }

        public int? Question1Type { get; set; }
        public string Question1 { get; set; }
        public string Answer1 { get; set; }

        public int? Question2Type { get; set; }
        public string Question2 { get; set; }
        public string Question2Choise1 { get; set; }
        public string Question2Choise2 { get; set; }
        public string Answer2 { get; set; }


        public int? Question3Type { get; set; }
        public string Question3 { get; set; }
        public string Question3Choise1 { get; set; }
        public string Question3Choise2 { get; set; }
        public string Question3Choise3 { get; set; }
        public string Question3Choise4 { get; set; }
        public string Answer3 { get; set; }

        public string PollCreatedDate { get; set; }

        public string PollCompletedDate { get; set; }

        public bool IsCompleted { get; set; }


        //İlişkiler
        public virtual List<CustomersPolls> CustomersPolls { get; set; }

        public virtual List<PollsCompanies> PollsCompanies { get; set; }



    }
}
