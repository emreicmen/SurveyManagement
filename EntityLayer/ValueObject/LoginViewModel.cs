using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.ValueObject
{
    //Kullanıcı girişi yapılırken gerekli alanlar
    public class LoginViewModel
    {
        [Required(ErrorMessage = "{0} field required")]
        public string Username { get; set; }


        [Required(ErrorMessage = "{0} field required"), DataType(DataType.Password)]
        public string Password { get; set; }

    }
}
