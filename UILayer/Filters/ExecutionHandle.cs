using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace UILayer.Filters
{
    //Hata olduğunda burada verilen sayfaya yönelendirilmesi için yazıldı
    public class ExecutionHandle : FilterAttribute, IExceptionFilter
    {
        public void OnException(ExceptionContext filterContext)
        {
            filterContext.Controller.TempData["LastError"] = filterContext.Exception;

            filterContext.ExceptionHandled = true;
            filterContext.Result = new RedirectResult("/Home/ErrorView");
        }
    }
}