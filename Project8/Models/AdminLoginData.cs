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
        [Key, MaxLength(10), Required]
        public string AdminName { get; set; }

        [MaxLength(15), MinLength(5), Required]
        public string AdminPassword { get; set; }

        [MaxLength(10), Required]
        public string FirstName { get; set; }

        [MaxLength(10), Required]
        public string LastName { get; set; }

    }
}
