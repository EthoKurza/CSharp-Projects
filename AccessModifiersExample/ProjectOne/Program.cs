using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ProjectOne
{

    public class ProjectClass1
    {
        private int myPrivate;
        protected int myProtected;
        public int myPublic;

        internal int myInternalField;           //public field within the same package
        protected internal int myProtectedInternal;
    }


    public class ProjectClass2 : ProjectClass1
    {
        public int myProtectedField;
        public int myProtectedInternalField;

        public void myMethod()
        {
            ProjectClass2 deriveObj = new ProjectClass2();
            deriveObj.myProtected = 11;
            deriveObj.myPublic = 22;
            deriveObj.myInternalField = 33;
            deriveObj.myProtectedInternal = 44;


            ProjectClass1 baseObj = new ProjectClass1();
            
            baseObj.myPublic = 11;
            baseObj.myInternalField = 22;
            baseObj.myProtectedInternal = 33;
            
                
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
