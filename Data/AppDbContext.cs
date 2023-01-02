using StdProductProjects.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace StdProductProjects.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(): base("StudentsProject")
        {

        }

        public DbSet<UserModel> UserTable { get; set; }
    }
}