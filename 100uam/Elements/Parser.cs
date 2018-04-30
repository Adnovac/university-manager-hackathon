using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _100uam.Elements
{
    class Parser
    {
        public string ParseNumber(string numberToParse)
        {
            string number = numberToParse;
                char[] charArray1 = number.ToCharArray();
                Array.Reverse(charArray1);
                number = new string(charArray1);
                number = System.Text.RegularExpressions.Regex.Replace(number, ".{3}", "$0 ");
                char[] charArray2 = number.ToCharArray();
                Array.Reverse(charArray2);
                number = new string(charArray2);
                return number;
        }
    }
}
