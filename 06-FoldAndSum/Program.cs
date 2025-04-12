using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_FoldAndSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int k = input.Length / 4;

            int[] leftArr = input.Take(k).Reverse().ToArray();
            int[] rightArr = input.Reverse().Take(k).ToArray();

            int[] leftSide = leftArr.Concat(rightArr).ToArray();

            int[] rightSide = input.Skip(k).Take(2 * k).ToArray();

            var sum = leftSide.Select((x,index) => x + rightSide[index]);

            Console.WriteLine(String.Join(" ", sum));
        }
    }
}
