using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string myName = "Ivan";
            int myAge = 25;
            short myShoeSize = 44;
            Console.WriteLine("My name is {0},\nMy age is {1},\nMy shoe size is {2}", myName, myAge, myShoeSize);

            DaysOfWeek myFavouriteDay;
            myFavouriteDay = DaysOfWeek.friday;

            Console.WriteLine(myFavouriteDay);
        }

            enum DaysOfWeek : byte
            {
                    monday = 1,
                    tuesday,
                    wednesday,
                    thursday,
                    friday,
                    saturday,
                    sunday
            }


    }
}

