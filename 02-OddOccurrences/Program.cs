using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_OddOccurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().ToLower().Split(' ').ToArray();

            var dict = new Dictionary<string, int>();

            foreach (var item in words)
            {
                if (dict.ContainsKey(item))
                {
                    dict[item]++;
                }
                else
                {
                    dict[item] = 1;
                }
            }
            List<string> oddCountWords = new List<string>();
            foreach (var word in dict)
            {
                if (word.Value % 2 != 0)
                {
                    oddCountWords.Add(word.Key);
                }
            }
            Console.WriteLine(String.Join(", ", oddCountWords));
        }
    }
}
