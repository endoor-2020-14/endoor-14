using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opdracht6._11
{
    class Program
    {
        static void Main(string[] args)
        {
            // ask users to enter numbers
            Console.WriteLine("Enter first number: ");
            double firstNumber = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number: ");
            double secondNumber = double.Parse(Console.ReadLine());
            // choice for one operator
            Console.WriteLine("Choos from the list waht do you want to do?\n1- ADD.\n2- Substract.\n3- Multiplay.\n4- Divided.\n5- Modulos.");
            int choos = int.Parse(Console.ReadLine());
            switch (choos)
            {
                case 1:
                   Console.WriteLine(ADD(firstNumber, secondNumber));

                    break;
                case 2:
                   Console.WriteLine(Substracting(firstNumber, secondNumber));
                    break;
                case 3:
                   Console.WriteLine(Multiplay(firstNumber, secondNumber));
                    break;
                case 4:
                    if (secondNumber == 0) 
                    {
                        Console.WriteLine("kan niet delen door 0.");
                    }
                    else
                    {
                        Console.WriteLine(Divided(firstNumber, secondNumber));
                    }
                    break;
                case 5:
                    if (secondNumber == 0)
                    {
                        Console.WriteLine("kan niet Modulos door 0.");
                    }
                    else
                    {
                       Console.WriteLine(Modulos(firstNumber, secondNumber));
                    }
                    break;
            }
        }
         /// <summary>
         /// ADD two numbers
         /// </summary>
         /// <param name="number1"></param>
         /// <param name="number2"></param>
         /// <returns></returns>
        
        static double ADD(double number1, double number2)
        {
            double result = number1 + number2;
            return result;
        }
        /// <summary>
        /// Substract two numbers
        /// </summary>
        /// <param name="number1"></param>
        /// <param name="number2"></param>
        /// <returns></returns>
        static double Substracting(double number1, double number2)
        {
            double result = number1 - number2;
            return result;
        }
        //method multiplay  numbers
        static double Multiplay(double number1, double number2)
        {
            double result = number1 * number2;
            return result;
        }
        //method divided numbers
        static double Divided(double number1, double number2)
        {
            double result = number1 / number2;
            return result;
        }//method modulos numbers
        static double Modulos(double number1, double number2)
        {
            double result = number1 % number2;
            return result;
        }

    }
}
