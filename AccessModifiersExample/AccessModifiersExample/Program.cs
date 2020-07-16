using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifiersExample
{

    public class MyBaseClass
    {
        private int myPrivateField;
        protected int myProtectedField;
        public int myPublicField;
    }

    public class MyDerivedClass : MyBaseClass
    {
        public void MyMethod()
        {
            this.myProtectedField = 11;
            this.myPublicField = 22;

            MyDerivedClass derivedObj = new MyDerivedClass();
            derivedObj.myPublicField = 44;
            derivedObj.myProtectedField = 33;   //only accesable in the derived class

            MyBaseClass baseObj = new MyBaseClass();
            baseObj.myPublicField = 55;


        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            MyDerivedClass derivedObj = new MyDerivedClass();
            derivedObj.myPublicField = 66;

            MyBaseClass baseObj = new MyBaseClass();
            baseObj.myPublicField = 77;
        }
    }
}
