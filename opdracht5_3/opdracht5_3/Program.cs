using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opdracht5_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the heigh from the cube: ");
            double height = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the lenght from the cube: ");
            double length = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the width from the cube: ");
            double width = double.Parse(Console.ReadLine());

            double result =Math.Round( length * width * height, 2) ;

            Console.WriteLine("The content from the cube = {0}",result);

        }
    }
}
