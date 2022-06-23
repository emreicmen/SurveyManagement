using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonLayer
{
    //Sisteme giriş yapan kullanıcının bilgilerini almak için yazılmıştır
    public static class App
    {
        public static ICommon Common = new DefaultCommon();

    }
}
