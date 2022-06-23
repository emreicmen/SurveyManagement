using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonLayer
{
    //Sisteme giriş yapan kullanıcının bilgilerininin alınamaması durumunda değerlerin default olarak belirleneceği fonksiyonların yazıldığı sınıftır
    public class DefaultCommon : ICommon
    {
        public string GetCurrentUsername()
        {
            return "system";
        }

        public int? GetCurrentUsersCompany()
        {
            return 0;
        }
    }
}
