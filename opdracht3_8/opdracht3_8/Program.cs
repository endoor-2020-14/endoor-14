using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opdracht3_8
{
    class Program
    {
        static void Main(string[] args)
        {
            //    Console.WriteLine("enter number from 10 to 100 ");
            //    int number = int.Parse(Console.ReadLine());
            //    int sum = 0;

            //    for (int i = 1; i <= number; i+=2)
            //    {
            //        Console.WriteLine(i);
            //        sum += i;

            //    }
            //    Console.WriteLine(sum);

            Console.WriteLine("Enter text less than 25 charachter");
            string sentence= (Console.ReadLine());

            string result="";
            char[] charachter = sentence.ToCharArray();
            int i = sentence.Length;
            while (i >=0 )
            {
                if(i == 2)
                {
                    result += charachter.ToString().ToUpper();
                    
                }
                else { result += charachter[i]; }
                i++;
            }
            Console.WriteLine(result);



        }

    }
}
