using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;


namespace LeetCode75Solutions
{
    internal class CandyArray
    {
        public IList<bool> KidsWithCandies(int[] candies, int extraCandies)
        {
            List<bool> result = new List<bool>();
            int moreCandyFlag = 0;
            for(int i = 0; i < candies.Length; i++)
            {
                
                for(int j = 0; j < candies.Length; j++)
                {
                    if ((candies[i]+extraCandies) >= candies[j])
                    {
                        moreCandyFlag++;
                    }
                    
                }
                if (moreCandyFlag == candies.Length)
                {
                    result.Add(true);
                }
                else
                {
                    result.Add(false);
                }
                moreCandyFlag = 0;
            }
            return result;
        }
        public void Main(string[] args) {
           
        }
    }
}
