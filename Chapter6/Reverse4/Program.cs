using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Reverse4
{
    class Program
    {
        public static void Reverse1(int two, int three, int four, int one)
        {
            Console.WriteLine("Altered: {0}  {1}  {2}  {3}", two, three, four, one);
        }

        static void Main(string[] args)
        {
            int one, two, three, four;
            one = 1;
            two = 2;
            three = 3;
            four = 4;

            Console.WriteLine("Original: {0}  {1}  {2}  {3}", one, two, three, four);

            Reverse1(two, three, four, one);
        }
    }
}
