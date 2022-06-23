using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.ValueObject
{
    //Sisteme kullanıcı kayıdı yaparken gerekli ViewModel
    public class RegisterViewModel
    {

        [Required(ErrorMessage = "{0} field required"),
         StringLength(25, ErrorMessage = "{0} field must be max {1} character")]
        public string Username { get; set; }


        [Required(ErrorMessage = "{0} field required"),
            StringLength(70, ErrorMessage = "{0} field must be max {1} character"),
            EmailAddress(ErrorMessage = "{0} type active email address")]
        public string Email { get; set; }


        [Required(ErrorMessage = "{0} field required"),
            StringLength(25, ErrorMessage = "{0} field must be max {1} character")]
        public string Password { get; set; }


        [Required(ErrorMessage = "{0} field required"),
            StringLength(50, ErrorMessage = "{0} field must be max {1} character")]
        public string Name { get; set; }

        [Required(ErrorMessage = "{0} field required"),
            StringLength(50, ErrorMessage = "{0} field must be max {1} character")]
        public string Surname { get; set; }

        [Required(ErrorMessage = "{0} field required")]
        public int CompanyID { get; set; }

        [Required(ErrorMessage = "{0} field required")]
        public string Country { get; set; }

        [Required(ErrorMessage = "{0} field required")]
        public string City { get; set; }

        [Required(ErrorMessage = "{0} field required")]
        public int Age { get; set; }

        [Required(ErrorMessage = "{0} field required")]
        public string Authorization { get; set; }
    }
}
