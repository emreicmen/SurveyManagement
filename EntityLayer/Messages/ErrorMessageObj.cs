using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Messages
{
    public class ErrorMessageObj
    {
        //Hata alındığında hatayı mesajı daha rahat yonetmek için yazılan sınıf
        public ErrorMessageCode Code { get; set; }
        public string Message { get; set; }
    }
}
