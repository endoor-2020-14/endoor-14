using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opdracht5._5
{
    class Program
    {
        static void Main(string[] args)
        {
            
            

            Console.WriteLine("Enter the length from your camper: ");
            double length = double.Parse(Console.ReadLine());
            
            Console.WriteLine("Enter the width from your camper: ");
            double width = double.Parse(Console.ReadLine());

            double vierkantMeter = 1.5;
            double square = length * width;
            double result = square * vierkantMeter * 12;
            // calculate after discount 20%
            double towYears = result * 2;
            double procent20 = towYears * 20 / 100;
            double amountAfterDiscount20 = towYears - procent20;

            // calculate after discount 30%
            double threeYears = result * 3;
            double procent30 = towYears * 30 / 100;
            double amountAfterDiscount30 = threeYears - procent30;

            Console.WriteLine("The price for one year is: {0}", result);
            Console.WriteLine("The price for tow years is: {0}" ,amountAfterDiscount20);
            Console.WriteLine("The price for three years is: {0}", amountAfterDiscount30);






        }
    }
}
