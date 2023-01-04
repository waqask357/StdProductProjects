using StdProductProjects.Data;
using StdProductProjects.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StdProductProjects.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult UserAccounts()
        {
            return View();
        }

        public void saveUser(UserModel model)
        {
            db.saveUser(model);
        }
    }
}