using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Chapter4
{
    class Opdracht3
    {
        /**
         * description
         */
        public Opdracht3()
        {
            Console.Clear();

            // ask to enter number
            Console.Write("Please enter number from 1 to 4: ");
            int number = int.Parse(Console.ReadLine());

            //condition
            switch (number)
            {
                case 1:
                    Console.WriteLine("klaveren");
                    break;
                case 2:
                    Console.WriteLine("Ruiten");
                    break;
                case 3:
                    Console.WriteLine("Hartrn");
                    break;
                case 4:
                    Console.WriteLine("Schoppen");
                    break;
                default:
                    Console.WriteLine("Please enter a valid number");
                    break;

            }
            Console.ReadKey();
        }
    }
}