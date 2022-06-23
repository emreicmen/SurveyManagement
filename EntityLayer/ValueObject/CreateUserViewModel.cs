using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.ValueObject
{
    //Kullanıcı kayıdı yapılırken gerekli alanlar
    public class CreatePollViewModel
    {
        [Required(ErrorMessage = "{0} field required")]
        public string PollTitle { get; set; }

        [Required(ErrorMessage = "{0} field required")]
        public string Question1 { get; set; }

        [Required(ErrorMessage = "{0} field required")]
        public string Question2 { get; set; }

        [Required(ErrorMessage = "{0} field required")]
        public string Question2Choise1 { get; set; }

        [Required(ErrorMessage = "{0} field required")]
        public string Question2Choise2 { get; set; }

        [Required(ErrorMessage = "{0} field required")]
        public string Question3 { get; set; }

        [Required(ErrorMessage = "{0} field required")]
        public string Question3Choise1 { get; set; }

        [Required(ErrorMessage = "{0} field required")]
        public string Question3Choise2 { get; set; }

        [Required(ErrorMessage = "{0} field required")]
        public string Question3Choise3 { get; set; }

        [Required(ErrorMessage = "{0} field required")]
        public string Question3Choise4 { get; set; }

        [Required(ErrorMessage = "{0} field required")]
        public string PollCreatedDate { get; set; }

        public List<Polls> Polls { get; set; }

    }
}
