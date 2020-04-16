using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opdracht6._5
{
    class Program
    {
        //call method
        static void Main(string[] args)
        {
            LegeRegel();

        }
        // create a method legeRegel
        static void LegeRegel()
        {
            
            int counter = 0;
            Console.WriteLine("Enter the number");
            int number = int.Parse(Console.ReadLine());
            // loop for counting lege regel
            do
            {
                Console.WriteLine("");
                counter++;
            } while (counter <= number);
        }
    }
}
