using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeString
{
    public class Kata
    {
        public bool PrimeString(string s)
        {
            if (s.Length == 4 && s.Substring(0, 2) == s.Substring(2, 2))
                return false;

            return true;
        }
    }
}
