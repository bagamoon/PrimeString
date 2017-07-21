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
            if (s.Length <= 1)
                return true;

            if (s.Length == 2)
                return s[0] != s[1];

            for (int i = 0; i <= s.Length / 2; i++)
            {
                var count = s.Split(new string[] {s.Substring(0, i)}, StringSplitOptions.RemoveEmptyEntries).Length;
                if (count == 0)
                    return false;
            }

            return true;
        }
    }
}
