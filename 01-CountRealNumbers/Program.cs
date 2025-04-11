using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_CountRealNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] numbers = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            var counts = new SortedDictionary<double, int>();

            foreach (var item in numbers)
            {
                if (counts.ContainsKey(item))
                {
                    counts[item]++;
                }
                else
                {
                    counts[item] = 1;
                }
                
            }
           foreach (var num in counts.Keys)
            {
                Console.WriteLine($"{num} ->{counts[num]}");
            }
        }
    }
}
