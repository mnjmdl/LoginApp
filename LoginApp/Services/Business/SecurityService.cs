﻿using LoginApp.Models;
using LoginApp.Services.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LoginApp.Services.Business
{
    public class SecurityService
    {
        SecurityDAO daoService = new SecurityDAO();

        public bool Autthenticate(UserModel user)
        {
            return daoService.FindByUser(user);
        }
    }
}