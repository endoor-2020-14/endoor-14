using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Chapter4
{
    class Opdracht5
    {
       
        public Opdracht5()
        {
            Console.Clear();

            //ask to enter a score
            Console.Write("Enter you final score for this exam: ");
            double score = double.Parse(Console.ReadLine());

            // conditions

            if (score >= 90 && score <= 100)
            {
                Console.WriteLine($"You have grade A.\nCongratulatios! You passed the exam.");
            }
            else if (score >= 70 && score <= 89)
            {
                Console.WriteLine($"You have grade B.\nCongratulatios! You passed the exam.");
            }
            else if (score >= 60 && score <= 69)
            {
                Console.WriteLine($"You have grade C.\nCongratulations! You passed the exam.");
            }
            else if (score >= 50 && score <= 59)
            {
                Console.WriteLine($"You have grade D.\nSorry! You didn't passed the exam. You can better than this");
            }
            else if (score >= 1 && score <= 49)
            {
                Console.WriteLine($"You have grade F.\nSorry! You didn't passed the exam. You really need to study more than that");
            }
            else
            {
                Console.WriteLine("Invalid number. Please enter number from 1 to 100. ");
            }
            Console.ReadKey();
        }
    }
}