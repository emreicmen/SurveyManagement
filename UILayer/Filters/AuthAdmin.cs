using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UILayer.Models;

namespace UILayer.Filters
{
    //Sadece admin yetkili işlemlerin yapılması için yazıldı
    public class AuthAdmin : FilterAttribute, IAuthorizationFilter
    {
        public void OnAuthorization(AuthorizationContext filterContext)
        {
            if (CurrentSession.User != null && CurrentSession.User.Authorization.ToString() != "admin")
            {
                filterContext.Result = new RedirectResult("/Home/AccessDenied");
            }
        }
    }
}