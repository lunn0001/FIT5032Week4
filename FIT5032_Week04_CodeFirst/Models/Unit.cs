using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FIT5032_Week04_CodeFirst.Models
{
    public class Unit
    {
        public int Id { get; set; }

        public String UnitName { get; set; }

        public virtual Student Student { get; set; }

    }
}