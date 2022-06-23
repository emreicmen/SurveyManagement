using CommonLayer;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using UILayer.Models;

namespace UILayer.Init
{
    //Sisteme giriş yapan kullanıcının bilgilerinin alınması için yazılmıştır.
    public class WebCommon : ICommon
    {
        public int? GetCurrentUsersCompany()
        {
            SystemUsers user = CurrentSession.User;
            if (user != null)
            {
                return user.CompanyID;
            }
            else
            {
                return 0;
            }
        }

        public string GetCurrentUsername()
        {
            SystemUsers user = CurrentSession.User;
            if (user != null)
            {
                return user.UserName;
            }
            else
            {
                return "Worker";
            }
        }
    }
}