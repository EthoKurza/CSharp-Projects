using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroToEnums
{
    enum Day
    {
        Sunday,Monday,Tuesday,Wednesday,Thursday,Friday,Saturday
    }
    enum CardValue
    {
        Two =2,
        Three,Four,Five,Six,Seven,Eight,Nine,Ten,
        Jack,Queen,King,Ace
    }

    enum Suit
    {
        Spade,Club,Heart,Diamond
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Enter day number(0-6)");
            //int d = int.Parse(Console.ReadLine());

            //Day day = (Day) d;

            //Console.WriteLine("\nThe day is : {0}", day);


            Random rnd = new Random();
            for (int i = 1; i <= 10; i++)
            {
                CardValue cValue = (CardValue)rnd.Next(2, 15);     //will only generate numbers from 2-14(max not included)
                Suit suit = (Suit)rnd.Next(4);                      //will only generate from 0-3 (max value not included)

                Console.WriteLine("{0} of {1}", cValue, suit);
            }
        }
    }
}
