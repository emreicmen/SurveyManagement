using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    //Database'deki QuestionTypes Tablosu
    public class QuestionTypes
    {
        [Key]
        public int QuestionTypeID { get; set; }

        public string TypeName { get; set; }
    }
}
