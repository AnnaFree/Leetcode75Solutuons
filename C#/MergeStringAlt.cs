
namespace LeetCode75Solutions
{
    internal class MergeStringAlt
    {
        string mergeAlternately(string word1, string word2)
        {
            string merged = "";

            int i = 0, j = 0;


            while (i < word1.Length && j < word2.Length)
            {
                merged += word1[i++];
                merged += word2[j++];
            }
            while (i < word1.Length)
            {
                merged += word1[i++];
            }
            while (j < word2.Length)
            {
                merged += word2[j++];
            }

            return merged;
        }
        static void Main(string[] args)
        {
            string word1 = Console.ReadLine();
            string word2 = Console.ReadLine();
            MergeStringAlt program1 = new MergeStringAlt();
            Console.WriteLine(program1.mergeAlternately(word1, word2));

        }
    }
}
