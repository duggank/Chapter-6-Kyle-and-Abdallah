using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Reverse3
{
    class Program
    {
        public static void Reverse(int firstInt, int middleInt, int lastInt)
        {
            Console.WriteLine("Altered: {0}  {1}  {2}", firstInt, middleInt, lastInt);
        }

        static void Main(string[] args)
        {
            int firstInt, middleInt, lastInt;
            firstInt = 5;
            middleInt = 10;
            lastInt = 15;

            Console.WriteLine("Otiginal: {0}  {1}  {2}", firstInt, middleInt, lastInt);

            Reverse(lastInt, middleInt, firstInt);
        }
    }
}
