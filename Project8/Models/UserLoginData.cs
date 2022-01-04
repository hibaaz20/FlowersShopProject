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

        [MaxLength(10), Required]
        public string FirstName { get; set; }

        [MaxLength(10), Required]
        public string LastName { get; set; }

        [Key, MaxLength(10), Required]
        public string UserName { get; set; }

        [MaxLength(15), MinLength(5), Required]
        public string UserPassword { get; set; }

    }
}
