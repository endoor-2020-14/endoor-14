using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Chapter4
{
    class Opdracht1
    {
        /**
         * description
         */
        public Opdracht1()
        {
            Console.Clear();


            Console.Write("Enter the first number please: ");
            int firstNumber = int.Parse(Console.ReadLine());

            Console.Write("Enter the second number please: ");
            int secondNumber = int.Parse(Console.ReadLine());

            if (firstNumber > secondNumber)
            {
                Console.WriteLine("{0} > {1}  the first number is the biggest number.", firstNumber, secondNumber);
            }
            else if (secondNumber > firstNumber)
            {
                Console.WriteLine("{0} > {1}  the second number is the biggest number.", secondNumber, firstNumber);
            }
            else
            {
                Console.WriteLine("{0} = {1} the numbers are equals.", firstNumber, secondNumber);
            }
            Console.ReadKey();
        }
    }
}