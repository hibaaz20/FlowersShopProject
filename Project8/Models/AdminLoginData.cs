using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace HackerU_MidProject2.Tables
{
    public class AdminLoginData
    {
     [Key]
        public string AdminName { get; set; }
        public string AdminPassword { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

    }
}
