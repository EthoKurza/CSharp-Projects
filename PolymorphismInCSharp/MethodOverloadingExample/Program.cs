using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverloadingExample
{
    class Program
    {
        static void Main(string[] args)
        {
            //Add();
            
            // compiler is aware which method should be called this is also known as method? polymorphism or method overloading
        }

        static void Add(int n1, int n2)
        {

        }

        /**
         * You cannot overload methods based on return types, hence the code below cannot work
         * or its not allowed
         * same with params keyword (ie. array inputs)
         * because the compiler doesnt know which methods it would have to call
         
        static int Add(int n1, int n2)
        {
            return 0;
        }
        */
        static void Add(String s1, String s2)
        {

        }

        static void Add(int n1, int n2, out int sum)//out int sum is  a pass by reference parameter(its like a reference)
        {

        }

        static void Add(int n1, int n2, int n3)
        {

        }


    }
}
