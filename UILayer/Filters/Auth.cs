using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UILayer.Models;

namespace UILayer.Filters
{
    //Kullanıcı girişi yapılmadan işlemlerin gerçekleştirilmesini engellemek ve link yazarak erişimi engellemek için yazıldı.

    public class Auth : FilterAttribute, IAuthorizationFilter
    {
        public void OnAuthorization(AuthorizationContext filterContext)
        {
            if (CurrentSession.User == null)
            {
                filterContext.Result = new RedirectResult("/Home/Login");
            }
        }
    }
}