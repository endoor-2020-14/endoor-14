using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Change.Maker
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Ënter originl amount in euros and cents: ");
            //double amount = double.Parse(Console.ReadLine()); //21.67

            //int r = (int)(amount * 100); //2167

            //int euro2 = 200;
            //int euro1 = 100;
            //int cent50 = 50;
            //int cent20 = 20;
            //int cent10 = 10;
            //int cent5 = 5;
            //int cent2 = 2;
            //int cent1 = 1;
            //double aantalmunten = 0;

            ////2167

            //int delen200 = r / euro2;   //2167 / 200      10
            //int modolus200 = r % euro2;  // 167
            //int delen100 = modolus200 / euro1; //167 / 100    1
            //int modolus100 = modolus200 % euro1; //67
            //int delen50 = modolus100 / cent50; //67 / 50     1
            //int modolus50 = modolus100 % cent50; //17 
            //int delen20 = modolus50 / cent20; //17
            //int modolus20 = modolus50 % cent20;//17
            //int delen10 = modolus20 / cent10;//            1
            //int modolus10 = modolus20 % cent10;//7
            //int delen5 = modolus10 / cent5;          //1
            //int modolus5 = modolus10 % cent5;//  2
            //int delen2 = modolus5 / cent2;//           1
            //int modolus2 = modolus5 % cent2;
            //int delen1 = modolus2 / cent1;

            //aantalmunten = delen200 + delen100 + delen50 + delen20 + delen10 + delen5 + delen2 + delen1;

            //Console.WriteLine("antal minimum number of coins is : " + aantalmunten);





            ////////////// ik probeer met for loop maar lukt het niet mag voor mij even checken alsjeblieft



            Console.WriteLine("Ënter originl amount in euros and cents: ");
            double amount = double.Parse(Console.ReadLine()); 

            int r = (int)(amount * 100);
            int towEuro = 0;
            int oneEuro = 0;
            int fiftigCent = 0;
            int twentyCent = 0;
            int tienCent = 0;
            int fiveCent = 0;
            int oneCent = 0;
            for(int i =0; r!=0;  i++ )
            {
               if (r >= 200)
               {
                    r -= 200;
                    towEuro++;

               }
               else if (r >= 100)
               {
                    r -= 100;
                    oneEuro++;

               }
               else if (r >= 50)
               {
                    r -= 50;
                    fiftigCent++;
               }
                else if (r >= 20)
                {
                    r -= 20;
                    twentyCent++;
                }
                else if (r >= 10)
                {
                    r -= 10;
                    tienCent++;
                }
                else if (r >= 5)
                {
                    r -= 5;
                    fiveCent++;
                }
                else if (r >= 1)
                {
                    r -= 1;
                    oneCent++;
                }

            }
            int result = towEuro + oneEuro + fiftigCent + twentyCent + tienCent + fiveCent + oneCent;
            Console.WriteLine(result);
        }
    }
}
