using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace square_number
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("welcome");
            int a,b;
            Console.WriteLine("please enter a number :");
            a = Convert.ToInt16(Console.ReadLine());
            b = (a * a);
            Console.WriteLine("square of number = " + b);
            Console.WriteLine("thank you for using this program");

        }
    }
}
