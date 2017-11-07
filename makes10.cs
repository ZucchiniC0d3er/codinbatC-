/**
 * Eric Pacheco
 * 11/6/17
 * coding bat makes 10 exercise in C#
 **/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coddingBat
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(makes10(9, 9));
        }
        public static bool makes10(int a, int b)
        {
            int sum = a + b;
            if(a == 10 || b == 10 || sum == 10)
            {
                return true;
            }
            return false;
        }
    }
}
