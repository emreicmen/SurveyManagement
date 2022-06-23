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

    //Database'deki SystemUsers Tablosu
    public class SystemUsers 
    {
        [Key]
        public int SystemUserID { get; set; }

        public string Authorization { get; set; }

        public string Name { get; set; }

        public string Surname { get; set; }

        public int  Age { get; set; }

        public string City { get; set; }

        public string Country { get; set; }

        public string UserName { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }


        //Relations
        [ForeignKey("Companies")]
        public int? CompanyID { get; set; }
        public virtual Companies Companies { get; set; }


        public virtual List<Polls> Polls { get; set; }



    }
}
