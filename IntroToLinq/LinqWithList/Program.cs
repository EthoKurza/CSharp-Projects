using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqWithList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<String> colours = new List<string>();

            colours.Add("RusT");
            colours.Add("grEeN");
            colours.Add("Yellow");
            colours.Add("rEd");

            //another way of declaring and initilizing a list
            //List<String> colours = new List<string>
            //{
            //    "red",
            //    "blue",
            //    "greem"
            //};

            var startsWithR = from colour in colours
                              let uppercaseStr = colour.ToUpper()
                              where uppercaseStr.StartsWith("R")
                              orderby uppercaseStr
                              select uppercaseStr;

            foreach (var c in startsWithR)
                Console.WriteLine(c);

            Console.WriteLine("\n\n");
            //modify list
            colours.Add("rUBy");
            colours.Add("BroWn");

            //deferred execution, means , when you write your linq, the linq variable is executed again when it is called
            foreach (var c in startsWithR)
                Console.WriteLine(c);       //outputs with update sort



        }
    }
}
