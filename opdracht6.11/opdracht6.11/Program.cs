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
            double firstNumber;
            double secondNumber;
            // ask users to enter numbers
            Console.WriteLine("Enter first number: ");

            while (!double.TryParse(Console.ReadLine(), out firstNumber))
            {
                Console.WriteLine("i asked for number......");
                Console.WriteLine("Enter first number: ");
            }
            Console.WriteLine("Enter second number: ");
            while (!double.TryParse(Console.ReadLine(), out secondNumber))
            {
                Console.WriteLine("i asked for number......");
                Console.WriteLine("Enter fsecond number: ");
            }
            //  method calculating met twee parametrs and five outkomst
            double x;
            double z;
            double c;
            double v;
            double b;
            Calculating(firstNumber, secondNumber, out x, out z, out c, out v, out b);
            Console.WriteLine("{0} + {1} = {2}", firstNumber, secondNumber, x);
            Console.WriteLine("{0} - {1} = {2}", firstNumber, secondNumber, z);
            Console.WriteLine("{0} * {1} = {2}", firstNumber, secondNumber, c);
            Console.WriteLine("{0} / {1} = {2}", firstNumber, secondNumber, v);
            Console.WriteLine("{0} % {1} = {2}", firstNumber, secondNumber, b);
            Console.WriteLine("==================================================");
            Console.WriteLine();
            Console.WriteLine("==================================================");


            // choice for one operator
            Console.WriteLine("Choos from the list what do you want to do?\n1- ADD.\n2- Substract.\n3- Multiplay.\n4- Divided.\n5- Modulos.");
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
        //Sum two numbers
        static double ADD(double number1, double number2)
        {
            double result = number1 + number2;
            return result;
        }

        // Substract two numbers

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
        public static void Calculating(double number1, double number2, out double add, out double substract, out double multiplay,

            out double divided, out double modulos)
        {
            add = number1 + number2;
            substract = number1 - number2;
            multiplay = number1 * number2;
            divided = number1 / number2;
            modulos = number1 % number2;
        }

    }
}
