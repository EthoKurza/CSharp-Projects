using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroToLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] intArr = { 3, 5, 7, 6, 4, 7, 8, 9, 3, 2, 4};

            Console.WriteLine($"This is the original array:\n");

            foreach(var i in intArr)
                Console.Write($"{i}  ");
            Console.WriteLine("\n\n");

            Console.WriteLine($"Min: {intArr.Min()} | Max: {intArr.Max()} | Avg: {intArr.Average():F2} ");

            // number greater than 4
            var filtered = from num in intArr
                           where num > 4
                           select num;

            Console.WriteLine($"This is array numbers greater than 4:\n");

            foreach (var i in filtered)
                Console.Write($"{i}  ");
            Console.WriteLine("\n\n");


            //sort the original array
            var sorted = from num in intArr
                         orderby num descending
                         select num;

            Console.WriteLine($"This is the sorted original array:\n");

            foreach (var i in sorted)
                Console.Write($"{i}  ");
            Console.WriteLine("\n\n");

            //sort the numbers that are greater than 4
            var sortedFiltered = from num in intArr
                                 where num > 4
                                 orderby num
                                 select num;

            Console.WriteLine($"This is the sorted and only numbers greater than 4:\n");

            foreach (var i in sortedFiltered)
                Console.Write($"{i}  ");
            Console.WriteLine("\n\n");

        }
    }
}
