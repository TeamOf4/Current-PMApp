using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringChecker
{
    public class StringTest
    {
        public bool CheckString(string input, string input2)
        {
            if (input == "" || input2 == "")
            {
                return false;
            }

            else if (input == input2)
            {
                return true;
            }
            else
            {
                return false;
            }          
        }
    }
}
