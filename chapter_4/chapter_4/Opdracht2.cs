using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Chapter4
{
    class Opdracht2
    {
        /**
         * description
         */
        public Opdracht2()
        {
            Console.Clear();

            Console.Write("Enter the first number please: ");
            int firstNumber = int.Parse(Console.ReadLine());

            Console.Write("Enter the second number please: ");
            int secondNumber = int.Parse(Console.ReadLine());

            Console.Write("Enter the third number please: ");
            int thirdNumber = int.Parse(Console.ReadLine());

            if (firstNumber > thirdNumber && secondNumber > thirdNumber)
            {
                Console.WriteLine("the third number {0} < {1} & {2}.", thirdNumber, firstNumber, secondNumber);
                Console.WriteLine("the third number is the smallist from all numbers");

            }
            else
            {
                Console.WriteLine("the third number is not the smallist number from all numbers");
            }
            Console.ReadKey();
        }
    }
}