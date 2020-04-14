 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opdracht5._2
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter your birthdate: ");
            DateTime birthDate1= DateTime.Parse(Console.ReadLine());

            Console.WriteLine("Enter the birthdate from your partner: ");
            DateTime birthDate2 = DateTime.Parse(Console.ReadLine());

            int diff = (birthDate1 - birthDate2).Days;
            diff = Math.Abs(diff);


            Console.WriteLine("Tht difference between them is: {0}",diff);



            //TimeSpan diff = (birthDateMan - birthDateWoman);
            //Console.Writeline(diff.Day);


            //String diff1 = (birthDateMan - birthDateWoman).TotalDays.ToString();


        }
    }
}
