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
    //Database'deki Companies tablosu
    public class Companies 
    {
        [Key]
        public int CompanyID { get; set; }

        public string Name { get; set; }

        public string Country { get; set; }

        public string City { get; set; }

        public string Address { get; set; }

        public string PhoneNumber { get; set; }

        public string PostalCode { get; set; }


        //İlişki
        public virtual List<PollsCompanies> PollsCompanies { get; set; }

    }
}
