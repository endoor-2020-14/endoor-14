using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opdracht5_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your Full Name: ");
            string name = Console.ReadLine();

            //int count = name.Length;
            //Console.WriteLine(count);
            Console.WriteLine("The length from your your full name is: " + name.Replace(" ", "").Length);
        }
    }
}
 