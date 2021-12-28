using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project8.DataAccess.Methods.CheckValidation
{
  public class IsFieldValid
    {
       static int num;

        static public bool isInputVlid(string input)
        {
            for (int i = 0; i < input.Length; i++)
            {
                if (int.TryParse(input[i].ToString(), out num) == true)
                {
                    return false;
                }

            }
            return true;
        }
    }
}
