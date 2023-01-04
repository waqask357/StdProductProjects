using StdProductProjects.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StdProductProjects.Data
{
    public class db
    {
        static AppDbContext context = new AppDbContext();

        public static void saveUser(UserModel model)
        {
            context.UserTable.Add(model);
            context.SaveChanges();
        }
    }
}