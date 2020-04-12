using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Chapter4
{
    class Opdracht10
    {
        /**
         * description
         */
        public Opdracht10()
        {
            Console.Clear();

            Console.WriteLine("Enter the number from the week: ");
            int number = int.Parse(Console.ReadLine());

            switch (number)
            {
                case 1:
                    Console.WriteLine("Maandag");
                    break;
                case 2:
                    Console.WriteLine("Dinsdag");
                    break;
                case 3:
                    Console.WriteLine("woensdag");
                    break;
                case 4:
                    Console.WriteLine("Donderdag");
                    break;
                case 5:
                    Console.WriteLine("Frijdag");
                    break;
                case 6:
                    Console.WriteLine("Zaterdag");
                    break;
                case 7:
                    Console.WriteLine("Zondag");
                    break;
            }
            Console.ReadKey();
        }
    }
}