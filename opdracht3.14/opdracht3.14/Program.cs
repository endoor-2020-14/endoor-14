using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opdracht3._14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number in decimal: ");
            int decimalNumber = int.Parse(Console.ReadLine());
            int x = decimalNumber;
            int remainder;
            string result = "";
            while (decimalNumber > 0)
            {
                remainder = decimalNumber % 2;
                decimalNumber /= 2;
                result = remainder.ToString() + result;
            }
                Console.WriteLine("BInary = {0}", result);

            
             result = "";
            

            while (x > 0)
            {
                remainder = x % 16;
                x /= 16;
                
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
            
            Console.WriteLine("Hexadecimal = {0}", result  );
        }
        
    }
}
