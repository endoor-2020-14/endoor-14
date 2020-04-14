using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opdracht4_14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first number: ");
            int fNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the second number");
            int sNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("Choos what do you want to do.\n1. Optellen \n2. Aftrekken \n3. Verminigvuldigen \n4. Delen \n5. Modulus");
            int choos = int.Parse(Console.ReadLine());

            if(choos == 1)
            {
                int result = fNumber + sNumber;
                Console.WriteLine($"{fNumber} + {sNumber} = {result} ");
            }
            else if (choos == 2)
            {
                int result = fNumber - sNumber;
                Console.WriteLine($"{fNumber} - {sNumber} = {result} ");
            }
            else if (choos == 3)
            {
                int result = fNumber * sNumber;
                Console.WriteLine($"{fNumber} * {sNumber} = {result} ");
            }
            else if (choos == 4)
            {
                if (sNumber == 0)
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine("Delen door nul is flauwkul");
                    Console.ResetColor();
                }
                else
                {
                    int result = fNumber / sNumber;
                    Console.WriteLine($"{fNumber} / {sNumber} = {result} ");
                }
                
            }
            else if (choos == 5)
            {

                if (sNumber == 0)
                {
                    Console.WriteLine("Modulus door nul is flauwkul");
                }
                else
                {
                    int result = fNumber % sNumber;
                    Console.WriteLine($"{fNumber} % {sNumber} = {result} ");
                }
            }
            else { Console.WriteLine("please inter a valid number"); }

        }
    }
}
