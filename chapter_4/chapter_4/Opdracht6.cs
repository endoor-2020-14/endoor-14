using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Chapter4
{
    class Opdracht6
    {
        
        public Opdracht6()
        {
            Console.Clear();
            //ask users to enter de gegevens van de metaaldraaibank
            Console.WriteLine("Enter de werkuren van de metaaldraaibank: ");
            int werkuren = int.Parse(Console.ReadLine());

            Console.WriteLine("Emter hoeveel jaar oud is de metaaldraaibank: ");
            int jaar = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter de aantaal storing per jaar: ");
            int storing = int.Parse(Console.ReadLine());

            if (werkuren > 10000 && jaar > 7 && storing > 25)
            {
                Console.WriteLine("De metaaldraaibank moet vervangen worden");
            }
            else { Console.WriteLine("De metaaldraaibank moet niet vervangen worden"); }
            Console.ReadKey();
        }
    }
}