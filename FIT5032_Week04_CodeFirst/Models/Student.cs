using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FIT5032_Week04_CodeFirst.Models
{
    public class Student
    {
        public int Id { get; set; }
        
        public String StudentName { get; set; }

        public List<Unit> Units { get; set; }
        

    }
}