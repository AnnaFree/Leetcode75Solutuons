using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode75Solutions
{
    internal class reverseVowels
    {
        public string ReverseVowels(string s)
        {
            List<char> vowels = new List<char>();
            List<int> position = new List<int>();
            StringBuilder sb = new StringBuilder(s);
            for (int i = 0; i < s.Length; i++)
            {

                char c = Char.ToLower(s[i]);
                if (c.Equals('a') || c.Equals('e') || c.Equals('i') || c.Equals('o') || c.Equals('u'))
                {
                    vowels.Add(s[i]);
                    position.Add(i);
                }
            }
            int reverseCount = 0;
            for(int i = vowels.Count-1; i >= 0; i--)
            {
                sb[position[i]] = vowels[reverseCount];
                reverseCount++;
            }
            return sb.ToString(); ;
        }
    }
}
