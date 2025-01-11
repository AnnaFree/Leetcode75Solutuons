using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode75Solutions
{
    internal class CanPlaceFlowersSolution
    {
        public CanPlaceFlowersSolution() { }

        public bool CanPlaceFlowers(int[] flowerbed, int n) {
            /*You have a long flowerbed in which some of the plots are planted, and some are not. However, flowers cannot be planted in adjacent plots.
             Given an integer array flowerbed containing 0's and 1's, 
            where 0 means empty and 1 means not empty, 
            and an integer n, 
            return true if n new flowers can be planted in the flowerbed without violating the no-adjacent-flowers rule and false otherwise.*/
            int plantSpaces = 0; //to count the number of plants you can plant without breaking rules
            int[] tempFlowerbed = flowerbed; //temp flowerbed to change to simulate plotting and ensure that each plant that we can plant has space on each side
            for (int i = 0; i < flowerbed.Length; i++)
            {
                if (tempFlowerbed[i] == 0)
                {
                    bool leftOpen = (i == 0) || (flowerbed[i - 1] == 0);
                    bool rightOpen = (i == flowerbed.Length - 1) || (flowerbed[i + 1] == 0);
                    if (leftOpen == true && rightOpen == true)
                    {
                        tempFlowerbed[i] = 1;
                        plantSpaces++;
                    }

                }
                if (plantSpaces >= n) return true;

            }
            return plantSpaces >= n;


        }
    }
}
