using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Chapter4
{
    class Opdracht7
    {
        /**
         * description
         */
        public Opdracht7()
        {
            Console.Clear();
            // declare variable ( Day / Time)
            string Day = DateTime.Now.DayOfWeek.ToString();
            int Time = DateTime.Now.Hour;
            // define helper variable 
            string msg = "";

            if (Time > 0 && Time <= 12)
            {
                msg += "Goedemorgen";
                
            }
            else if (Time > 12 && Time < 18)
            {
                
                msg += "Goedemiddag";
            }
            else
            {
                msg += "Goedeavond";
                 
            }

            if (Day == "Saturday" || Day == "Sunday")
            {
                msg += " Vandag het is weekend";
            }

            else
            {
                msg += " Vandag is een werkdag";
            }
            Console.WriteLine(msg);
            Console.ReadKey();

        }
    }
}