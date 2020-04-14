using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opdracht4_15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write(" Enter a Decimal number: ");
            int decimalNumber = int.Parse(Console.ReadLine());

            int hexDecimal = decimalNumber;
            int remainder;
            string result = string.Empty;
            while (decimalNumber > 0)
            {
                remainder = decimalNumber % 2;
                decimalNumber /= 2;
                result = remainder.ToString() + result;
            }
            Console.WriteLine("Binary:  {0}", result);

            result = string.Empty;

            while(hexDecimal > 0)
            {
                remainder = hexDecimal % 16;
                hexDecimal /= 16;
                switch (remainder)
                {
                    case 0:
                    case 1:
                    case 2:
                    case 3:
                    case 4:
                    case 5:
                    case 6:
                    case 7:
                    case 8:
                    case 9:

                        result = remainder.ToString() + result;
                        break;
                    case 10:
                        result = "A" + result;
                        break;
                    case 11:
                        result = "B" + result;
                        break;
                    case 12:
                        result = "C" + result;
                        break;
                    case 13:
                        result = "D" + result;
                        break;
                    case 14:
                        result = "E" + result;
                        break;
                    case 15:
                        result = "F" + result;
                        break;

                }
               
            }
            Console.WriteLine("Hexadecimaal: {0}",result);

        }
    }
}
