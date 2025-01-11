using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode75Solutions
{
    internal class GreatestCommonDiviser
    {
        //default constructor
        public GreatestCommonDiviser() { 
        }
        int GCD(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }
        string gcdOfStrings(string str1, string str2)
        {
            int x;


            if (str1 + str2 != str2 + str1)
            {
                return "";
            }
            else
            {
                x = GCD(str1.Length, str2.Length);
                return str1.Substring(0, x);
            }

            
        }
        public void Main(string[] args) {
            GreatestCommonDiviser gcd = new GreatestCommonDiviser();
            Console.WriteLine(gcd.gcdOfStrings("ABCABC", "ABC"));
            Console.WriteLine(gcd.gcdOfStrings("Leet", "code"));
        }
    }
}
