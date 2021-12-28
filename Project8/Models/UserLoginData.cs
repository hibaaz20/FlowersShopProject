using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace HackerU_MidProject2.Tables
{
    public class UserLoginData
    {
       
        public string FirstName { get; set; }
        public string LastName { get; set; } 
     [Key]
        public string UserName { get; set; }
        public string UserPassword { get; set; }

    }
}
