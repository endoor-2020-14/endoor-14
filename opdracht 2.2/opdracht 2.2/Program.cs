using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opdracht_2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            // vraag de gebruiker om zijn gewicht en lengte to typen

            Console.Write("Mag u gewicht in Kg typen alstublieft: ");
            double gewicht = Double.Parse(Console.ReadLine());
            gewicht = Math.Round(gewicht, 1);

            Console.Write("Mag u lengte in cm invoeren: ");
            double lengte = double.Parse(Console.ReadLine());

            //berekenen BMI

            double BMI = gewicht / (lengte * lengte);
            BMI = Math.Round(BMI, 1);
            //print BMI

            Console.WriteLine("Jou BMI is = " + BMI);

        }
    }
}
