using LoginApp.Models;
using LoginApp.Services.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LoginApp.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            return View("Login");
        }

        public string Login(UserModel userModel)
        {
            //return "Result :  UserName = " + userModel.UserName + "PW = " + userModel.Password;
            SecurityService securityService = new SecurityService();
            Boolean success = securityService.Autthenticate(userModel);

            if (success)
            {
                return "Successfully login.";
            }
            else
            {
                return "Failur";
            }
        }
    }
}