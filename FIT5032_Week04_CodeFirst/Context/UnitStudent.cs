using FIT5032_Week04_CodeFirst.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace FIT5032_Week04_CodeFirst.Context
{
    public class UnitStudent : DbContext
    {
        public DbSet<Student> Students { get; set; }

        public DbSet<Unit> Units { get; set; }
    }
}