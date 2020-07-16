using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MTHeyzzenFlores
{
    public class Car
    {
        public String Name { get; private set; }

        public double Price { get; private set; }

        public Car(String name,double price)
        {
            Name = name;
            Price = price;
        }

        public Car()
        {
            Name = "";
            Price = 0.0;
        }

    }
}
