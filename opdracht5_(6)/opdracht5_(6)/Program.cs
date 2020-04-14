using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opdracht5__6_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your study number: ");
            string studyNumber = Console.ReadLine();

            Console.WriteLine("Enter your first and last name: ");
            string name = Console.ReadLine();

            Console.WriteLine("Enter your first degree for Netherlands: ");

            double nFirst = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter your second degree for Netherlands: ");
            double nSecond = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter your first degree for English : ");
            double eFirst = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter your degree second for English : ");
            double eSecond = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter your first degree for WIS : ");
            double wFirst = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter your second degree for WIS : ");
            double wSecond = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter your first degree for PRG : ");
            double pFirst = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter your second degree for PRG : ");
            double pSecond = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter your first degree for DBD : ");
            double dFirst = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter your second degree for DBD : ");
            double dSecond = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter your first degree for ALG : ");
            double aFirst = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter your second degree for ALG : ");
            double aSecond = double.Parse(Console.ReadLine());

            double avgNL = (nFirst + nSecond) / 2;
            double avgEN = (eFirst + eSecond) / 2;
            double avgW = (wFirst + wSecond) / 2;
            double avgP = ((pFirst + (pSecond + pSecond)) / 3);
            double avgD = ((dFirst + (dSecond + dSecond)) / 3);
            double avgA = ((aFirst + (aSecond + aSecond)) / 3);


            Console.WriteLine("Study Number: " + studyNumber + "\nFirst and last name: " + name);
            Console.WriteLine();
            Console.WriteLine("First degree(NL): " + nFirst + "  Second degree (NL): " + nSecond + "  The average from (NL) = " + avgNL);
            Console.WriteLine();
            Console.WriteLine("First degree(EN): " + eFirst + "  Second degree (EN): " + eSecond + "  The average from (EN) = " + avgEN);
            Console.WriteLine();
            Console.WriteLine("First degree(WIS): " + wFirst + "  Second degree (WIS): " + wSecond + "  The average from (WIS) = " + avgW);
            Console.WriteLine();
            Console.WriteLine("First degree(PRG): " + pFirst + "  Second degree (PRG): " + pSecond + "  The average from (PRG) = " + avgP);
            Console.WriteLine();
            Console.WriteLine("First degree(DBD): " + dFirst + "  Second degree (DBD): " + dSecond + "  The average from (DBD) = " + avgD);
            Console.WriteLine();
            Console.WriteLine("First degree(ALG): " + aFirst + "  Second degree (ALG): " + aSecond + "  The average from (ALG) =  " + avgA);

            double sum = avgNL + avgEN + avgW + avgP + avgD + avgA;
            double avg = Math.Round(sum / 6, 1);

            Console.WriteLine("The average is: {0}", avg);

        }
    }
}
