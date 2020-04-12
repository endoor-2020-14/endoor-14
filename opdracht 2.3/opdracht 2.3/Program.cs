using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opdracht_2._3
{
    class Program
    {
        static void Main(string[] args)
        {
            // getal number 1 invoeren door de gebruiker

            Console.Write("Type de eerste getal: ");
            int num1 = Int32.Parse(Console.ReadLine());

            // getal number 2 invoeren door de gebruiker

            Console.Write("Type de twede getal: ");
            int num2 = Int32.Parse(Console.ReadLine());

            // berekening 

            Console.WriteLine($"{num1} + {num2} =  {num1 + num2}");
            Console.WriteLine($"{num1} - {num2} =  {num1 - num2}");
            Console.WriteLine($"{num2} - {num1} =  {num2 - num1}");
            Console.WriteLine($"{num1} * {num2} =  {num1 * num2}");
            Console.WriteLine($"{num1} / {num2} =  {num1 / num2}");
            Console.WriteLine($"{num2} / {num1} =  {num2 / num1}");
            Console.WriteLine($"{num1} % {num2} =  {num1 % num2}");
            Console.WriteLine($"{num2} % {num1} =  {num2 - num1}");



        }
    }
}
