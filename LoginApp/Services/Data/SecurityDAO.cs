using LoginApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LoginApp.Services.Data
{
    public class SecurityDAO
    {
        internal bool FindByUser(UserModel user)
        {
            //if(user.UserName=="Admin" && user.Password == "Secret")
            //{
            //    return true;
            //}
            //else
            //{
            //    return false;
            // }

            return (user.UserName == "Admin" && user.Password == "Secret");
        }
    }
}