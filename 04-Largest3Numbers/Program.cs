using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Largest3Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            var orderList = list.OrderByDescending(x => x).Take(3);

            Console.WriteLine(String.Join(" ", orderList));
        }
    }
}
