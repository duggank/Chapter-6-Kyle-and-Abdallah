using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exponent
{
    class Program
    {
        public static void SquareNumber(int user)
        {
            int square = 1;
            square = user * user;
            Console.WriteLine("The square value is {0}", square);
        }

        public static void CubeNumber(int user)
        {
            int cube = 1;
            cube = user * user * user;
            Console.WriteLine("The cubed value is {0}", cube);
        }

        static void Main(string[] args)
        {
            Console.Write("Please enter a value and I will square and cube it! ^_^  ");
            int user = Convert.ToInt32(Console.ReadLine());
            SquareNumber(user);
            Console.WriteLine();
            CubeNumber(user);
        }
    }
}
