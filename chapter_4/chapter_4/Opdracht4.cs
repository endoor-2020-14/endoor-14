using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Chapter4
{
    class Opdracht4
    {
        /**
         * description
         */
        public Opdracht4()
        {
            Console.Clear();
            //ask users to enter numbers
            Console.Write("Enter the first number: ");
            int fNumber = int.Parse(Console.ReadLine());

            Console.Write("Enter the second number: ");
            int sNumber = int.Parse(Console.ReadLine());
            int resualt = fNumber % sNumber;
            //condition
            if (fNumber % sNumber == 0)
            {
                Console.WriteLine($"{fNumber}  % {sNumber} = {resualt}.\nthe {fNumber} is a multiple of {sNumber}");
            }
            else
            {
                Console.WriteLine($"{fNumber}  % {sNumber} = {resualt}.\nthe {fNumber} is not a multiple of {sNumber}");
            }
            Console.ReadKey();
        }
    }
}