using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project8.DataAccess.Methods.CheckLength
{
   public class CheckPasswordLength
    {
        static public bool PLength(string pw)
        {
            if (pw.Length > 20)
            {
                return false;
            }
            else if (pw.Length < 5)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
