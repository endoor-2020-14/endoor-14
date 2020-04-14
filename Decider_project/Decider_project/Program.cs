using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decider_project
{
    class Program
    {
        static void Main(string[] args)
        {

            
            Console.WriteLine("What is your yes or no question?");
            Console.ReadLine();
            
            // random number
            Random random = new Random();
            int roll = random.Next(10);

            switch (roll)
            {
                case 0:
                    Console.WriteLine(" Yes, I think you should.");
                    break;
                case 1:
                    Console.WriteLine("No, I don't think so. ");
                    break;
                case 2:
                    Console.WriteLine("Do it but change the way so yes");
                    break;
                case 3:
                    Console.WriteLine("All aigns point to no.");
                    break;
                case 4:
                    Console.WriteLine("My answer is no.");
                    break;
                case 5:
                    Console.WriteLine("The logic say yes.");
                    break;
                case 6:
                    Console.WriteLine("that's cool yes do it.");
                    break;
                case 7:
                    Console.WriteLine(" definitely No.");
                    break;
                case 8:
                    Console.WriteLine("In this circumstances No.");
                    break;
                case 9:
                    Console.WriteLine("Don;t do it please");
                    break;
            }       }
    }
}
