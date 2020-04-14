using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opdracht5._4
{
    class Program
    {
        static void Main(string[] args)
        {

            double dollar = 1.09376;
            double British = 0.87694;
            double Australian = 1.72258;
            double syrian = 561.071;
            double russia = 80.7147;

            Console.WriteLine(" choos the valuta that you want to change \n1- Dollar \n2- British Pound\n3- Australian Dollar\n4- Syrian Pound\n5- Russian Ruble");
            int choice = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the number that you want convert: ");
            double amount = double.Parse(Console.ReadLine());

            if (choice == 1)
            {
                Console.WriteLine("the amount in USA dollar is: " + amount * dollar);
            }
            else if (choice == 2)
            {
                Console.WriteLine("the amount in British Pound  is: " + amount * British );
            }
            else if (choice == 3)
            {
                Console.WriteLine("the amount in Australian dollar  is: " + amount * Australian);
            }
            else if (choice == 4)
            {
                Console.WriteLine("the amount in Syrian Pound  is: " + amount * syrian);
            }
            else if (choice == 5)
            {
                Console.WriteLine("the amount in Russian ruble  is: " + amount * russia);
            }
            else { Console.WriteLine("please inter a valid choice"); }





        }
    }
}
