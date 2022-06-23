using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonLayer
{
    //Sisteme giriş yapan kullanıcının bilgilerini almak için yazılmıştır
    public interface ICommon
    {
        int? GetCurrentUsersCompany();

        string GetCurrentUsername();

    }
}
