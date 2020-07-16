using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectOne;

namespace ProjectTwo
{


    public class ProjectTClass2 : ProjectClass1
    {
        public void MyMethod()
        {
            ProjectClass2 derivedObj = new ProjectClass2();
            derivedObj.myPublic = 11;
            derivedObj.myProtectedField = 22;
            derivedObj.myProtectedInternalField = 33;

            ProjectClass1 baseObj = new ProjectClass1();
            baseObj.myPublic = 11;

        }

    }
    class Program
    {

        static void Main(string[] args)
        {
        }
    }
}
