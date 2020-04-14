using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opdracht4_13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number that you would check: ");
            int number = int.Parse(Console.ReadLine());

            int x =(int) Math.Pow(number, 2);
            if (x % 10 == number)
            {
                Console.WriteLine("The number is automotf");
            }
            else { Console.WriteLine("this number is not automorf"); }
        }
    }
}
