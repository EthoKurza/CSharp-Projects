using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverridingExample
{
    class BaseClass
    {
        public virtual void Show()
        {
            Console.WriteLine("Base class Show Method");
        }
    }

    class DerivedClass : BaseClass
    {
        //public new void Show()      //new doesnt involve polymorphism
        public override void Show()
        {
            Console.WriteLine("Derived class Show Method");
        }
    }

    class Program
    {


        static void Main(string[] args)
        {
            BaseClass baseObj = new BaseClass();
            baseObj.Show();

            baseObj = new DerivedClass();           // will call the same baseClass method because we declared the variable in the derivedClass as new, which involves no polymorphism
            baseObj.Show();

            DerivedClass devObj = new DerivedClass();
            devObj.Show();


        }
    }
}
