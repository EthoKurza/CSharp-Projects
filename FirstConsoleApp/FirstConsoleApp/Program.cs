using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //getting name
            Console.WriteLine("What is your name?: ");          //C# syntax of System.out.println()
            String name = Console.ReadLine();                   //C# syntax of Scanner.nextLine()
                                                                //theres also readkey > which reads a key as soon as its pressed
                                                                //read is also another option
                                                                //readline reads the whole line

            Console.WriteLine("How old are you?: ");
            int age = int.Parse(Console.ReadLine());            //C# syntax of Integer.parseInt()

            Console.WriteLine("Hi " + name + "! \nAs of age "+age+" \nWelcome to C# \n");
            for(int i = 1; i <=50; i++)
            {
                int check = i % 2;
                if(check == 0)
                {
                    Console.WriteLine(i);
                }
            }
            
        }
    }
}
