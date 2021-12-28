using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project8.DataAccess.Methods.CheckLength
{
    public class CheckInputLength
    {
        static public bool ILength(string input)
        {
            if (input.Length > 10)
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
