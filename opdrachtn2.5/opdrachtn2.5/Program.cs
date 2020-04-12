using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opdrachtn2._5
{
    class Program
    {
        static void Main(string[] args)
        {
            int sPrice = 25000;
            double mLak = 0.05;
            double lBekleding = 0.05;
            int automaat = 1000;
            string name = "Ron Jansen";

            double mLakVerhogin = mLak * sPrice + sPrice;
            double lBekledingVerhoging = lBekleding * sPrice + mLakVerhogin;
            double totalZonderBTW = lBekledingVerhoging + automaat;

            double totalMetBTW = totalZonderBTW * 0.21 + totalZonderBTW;

            Console.WriteLine($" Meneer {name} De standaar price is = {sPrice}\n " +
                              $"voor Metalic Lak 5% is verhoogd op de standaard price = {mLakVerhogin}\n" +
                              $"voor Leren Bekleding 5% is ook verhoogd op de standaard price = {lBekledingVerhoging}\n" +
                              $"voor de automaat komt nog {automaat} bij\n" +
                              $"Samen zonder BTW = {totalZonderBTW}\n" +
                              $"komt nog 21% BTW op de total price\n" +
                              $"Total price met BTW = {totalMetBTW} ");



        }
    }
}
