using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroToFunctionsMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 10;
            String s = "hello";
            int[] a = { 1, 2, 3, 4 };

            Console.WriteLine("Before Changes: ");
            Console.WriteLine("i = " + i);
            Console.WriteLine("string: " + s);
            Console.WriteLine("a: " + a[0]);


            //change i value
            ChangeValues(ref i,s,a);

            Console.WriteLine("\nAfter Changes: ");
            Console.WriteLine("i = " + i);              //doesnt change because its pass by value
            Console.WriteLine("string: " + s);      
            Console.WriteLine("a: " + a[0]);            //changes because its a pass by reference



            //calculate
            int n1 = 20, n2 = 30;
            int sum, mul;
            calculate(n1, n2, out sum, out mul);
            Console.WriteLine("sum is " + sum + "\nmul is " + mul);

            Console.WriteLine("\n\nEnter a Number");
            //int n = int.Parse(Console.ReadLine());

            if (int.TryParse(Console.ReadLine(), out int n))
                Console.WriteLine("n = " + n);
            else
                Console.WriteLine("Invalid ");


            //Parameter Arrays
            int[] arr = new int[3];
            arr[0] = 100;
            arr[1] = 200;
            arr[2] = 300;

            PrintArray(arr);
            PrintArray(1,2,3,4,5,6,7,8,9,10);


            //Person Info

            PersonInfo("John", 34);
            PersonInfo(age: 34, name: "Anna");      //named arguments

            PersonInfo("Bob");      //optional argument works only if a data is set in the method parameter
        }

        static void PersonInfo(String name, int age = 21)       //by adding a default value to the variables, it makes it an optional parameter
        {
            //some logic
        }


        static void PrintArray(params int[] array)
        {
            Console.WriteLine("\n\nNumber of Items: " + array.Length);
            foreach (int i in array) {
                Console.WriteLine(i +" ");
                Console.WriteLine();
            }
        }

        static void ChangeValues(ref int num,String str,int[] array)    //ref means reference
        {

            num += 100;
            str = str + " - 100";
            array[0] = 100;

        }

        static void calculate(int x, int y, out int sum, out int mul)
        {
            sum = x + y;
            mul = x * y;

        }
    }
}
