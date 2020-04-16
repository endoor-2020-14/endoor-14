using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opdracht6._7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number");
            int number = int.Parse(Console.ReadLine());
           
            Console.Write(Fibonacci(number)); 
        }

        public static string Fibonacci(int n)
        {
            string result ="";
            int x = 0;
            int y = 1;
            int z ;
            for (int i = 0; i <= n; i++)
            {

                z = x;
                x = y;
                y += z;
                result +=  z.ToString() +" ";
            }
            
            return result ; 
      
        }
    }
}
