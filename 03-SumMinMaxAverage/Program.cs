using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_SumMinMaxAverage
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] num = new int[n];
            for (int i = 0; i < n; i++)
            {
              num[i] = int.Parse(Console.ReadLine());
            }
            int minValue = num.Min();
            int maxValue = num.Max();
            int sum = num.Sum();
            double average = num.Average();

            Console.WriteLine("Sum = " + sum);
            Console.WriteLine("Min = " + minValue);
            Console.WriteLine("Max = " + maxValue);
            Console.WriteLine("Average = " + average);




        }
    }
}
