using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestFin
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = "ckfbc";
            bool res = isBeautifulString(s);
            Console.WriteLine(res);
        }

        static bool isBeautifulString(string inputString)
        {
            int[] count = new int[26];
            foreach (var s in inputString)
            {
                count[s - 97]++;
            }
            for (int i = 0; i < 25; ++i)
            {
                if (count[i] < count[i + 1]) return false;
            }
            return true;
        }
    }
}
