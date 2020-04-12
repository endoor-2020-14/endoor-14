using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opdracht_2._4
{
    class Program
    {
        static void Main(string[] args)
        {
            // info van de gebruiker over de auto vragen
            Console.Write("Kenteken van de auto invoeren:");
            String kenteken = Console.ReadLine();

            Console.Write("wat is het merk van de auto: ");
            string merk = Console.ReadLine();

            Console.Write("wat is de model van de auto: ");
            string model = Console.ReadLine();

            Console.Write("Wat is de bouwjaar van de auto: ");
            int bouwJaar = Int32.Parse(Console.ReadLine());

            int autoLeefTijd = DateTime.Now.Year - bouwJaar;

            // Console.WriteLine("De " + merk + " " + model  + " met als kenteken " + kenteken + " is "  + autoLeefTijd  + " " + "jaar oud");
            Console.WriteLine($"De {merk} {model} met als kenteken {kenteken} is {autoLeefTijd} jaar oud.");
        }
    }
}
