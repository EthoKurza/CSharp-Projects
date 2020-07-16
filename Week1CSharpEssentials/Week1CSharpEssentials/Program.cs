using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1CSharpEssentials
{
    class Program
    {
        static int x;
        static void Main(string[] args)
        {
            //declaring and initializing variables
            
            //int double;             //doesnt work 
            int @double;            //works 
           
            int a = 9;
            int sum = a + x;

            /* must be uppercase because the text can be considered a number */

            double d = 23423.234;           //works because the numbers is always double
            //float f = 343.343;              //wont work beacause the number is of type double
            float f = 343.343F;             //works because we told the machine that this is a float with ending the number with a F
            decimal amount = 34543.435M;    //works the same way as above where decimal is M
            long l = 1234567891023450023L;  //tells the compiler that this is a long number

            //float and decimals are mostly used

            //to declare and initialize a constant you use:
            const int constNum = 1;         //java you use the data type final as a constants


            //type interface
            var num = 55;                   //automatically assigns the variable as an int
            var num2 = 55.55;                   //automatically assigns the variable as a double
            var num3 = "55";                   //automatically assigns the variable as a string

            //after the variable type has been initialized, it cannot be overwritten to a different type

            //you can place an @ symbol for a path name instad of using a lot of \ backslashes
            String str = "Hello \n World"; //works fine
            String str2 = @"Hello \n World";
            Console.WriteLine(str);
            Console.WriteLine(str2);


            //verbatim string literals
            int dogs = 30;
            int cats = 23;

            //old way
            String s = "There are " + dogs + " dogs and " + cats + " cats";
            Console.WriteLine(s);

            //string interpolation
            s = $"There are {dogs} dogs and {cats} cats";           // the $ or dollar sign declares that the string is an interpolation
                            //you can format it by putting "name: {variable_name, <number alignment>}"
                            //if the number alignment is positive its from the left to right and negative is right to left
            Console.WriteLine(s);



            int i = 20;
            int j = i;

            Console.WriteLine($"\ni ={i} j ={j}");

            i++;
            Console.WriteLine($"\ni ={i} j ={j}");


            //declare 2 types of objects
            Circle c1, c2;
            c1 = new Circle();

            Console.WriteLine(c1.radius);
            c1.radius = 30;
            Console.WriteLine(c1.radius);

            c2 = c1;
            Console.WriteLine(c2.radius);
            c2.radius = 50;
            Console.WriteLine(c2.radius);       //output 50
            Console.WriteLine(c1.radius);       //will also output 50, Why? c2 is referencing to c1's object (pointers)



            //Strings are immutable, this means that changing a string value cannot be changed instead it creates new object of type string


            /* Printing with .toString formatting  */
            decimal price = 2345.21M;
            Console.WriteLine(price.ToString("C"));           //C is the currency formatter

            decimal percentage = 0.4;
            Console.WriteLine(percentage.ToString("P"));     //P is percentage formatter

            int number = 15000;
            Console.WriteLine(number.ToString("N0"));   //N seperated the number in terms of thousands  with a  comma

            double payment = 432.5629;
            Console.WriteLine(payment.ToString("F3"));  //formats the number as a float number 

            //nullable data types
            int? n = null;
            String name = null;     //works fine, strings can be nullable


        } // main method

    }   //main class method

    class Circle
    {
        public int radius;
    }
}
