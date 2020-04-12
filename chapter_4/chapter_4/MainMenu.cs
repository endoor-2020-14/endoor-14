using Chapter4;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace chapter_4
{
    class MainMenu
    {
        static void Main(string[] args)
        {
            int choice = 0;

            while (choice != 99)
            {
                Console.Clear();
                Console.Write("Geef het nummer van de opdracht die je uit wilt voeren (1 - 16, 99 = STOP): ");
                choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        new Opdracht1();
                        break;
                    case 2:
                        new Opdracht2();
                        break;
                    case 3:
                        new Opdracht3();
                        break;
                    case 4:
                        new Opdracht4();
                        break;
                    case 5:
                        new Opdracht5();
                        break;
                    case 6:
                        new Opdracht6();
                        break;
                    case 7:
                        new Opdracht7();
                        break;
                    case 9:
                        new Opdracht9();
                        break;
                    case 10:
                        new Opdracht10();
                        break;

                    default:
                        Console.WriteLine("Ongeldige keuze ...");
                        Thread.Sleep(1000);
                        break;
                }
            }
        }
    }

   
}
