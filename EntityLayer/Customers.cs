using EntityLayer.JunctionTables;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    //Database'deki Customers tablosu
    public class Customers 
    {
        [Key]
        public int CustomerID { get; set; }

        public string Name { get; set; }

        public string Surname { get; set; }

        public string Email { get; set; }

        public string PhoneNumber { get; set; }

        public int Age { get; set; }

        public string Education { get; set; }

        public string Country { get; set; }

        public string City { get; set; }

        public string Gender { get; set; }


        //İlişki
        public virtual List<CustomersPolls> CustomersPolls { get; set; }


    }
}
