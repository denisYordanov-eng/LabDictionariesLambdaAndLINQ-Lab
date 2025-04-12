using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_ShortWordsSorted
{
    class Program
    {
        static void Main(string[] args)
        {
            //. , : ; ( )[ ] " ' \ / ! ? (space).
            char[] separators = { ' ', '.', ':', ';', '(', ')', '/', '\\', '!', '?', ',' };
            string[] text = Console.ReadLine()
                .ToLower()
                .Split(separators)
                .ToArray();

            var result = text
            .Where(w => w != "")
            .Where(w => w.Length < 5)
            .OrderBy(w => w)
            .Distinct();

            Console.WriteLine(String.Join(", ", result));
        }
    }
}
