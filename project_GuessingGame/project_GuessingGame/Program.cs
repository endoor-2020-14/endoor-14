using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int answer = rand.Next(1, 101);

            
            
            Init();
            play(answer);

        }


        //Ask user to guess
        private static void Init()
        {

            Console.WriteLine("I'm thinking of a number between 1 and 100 ");
            Console.WriteLine("Try to guess what it is ?");
            
        }

        //Accept users guess until guess matches answer
        private static void play(int answer)

        {
            
            
            bool won = false;
            do

            {
                int guessNumber = int.Parse(Console.ReadLine());
                if (guessNumber > answer)
                {
                    Console.WriteLine("Too high!");
                }
                else if (guessNumber < answer)
                {
                    Console.WriteLine("Too low");
                }
                else
                {
                    Console.WriteLine("Congratultions! YOU WIN!");
                    won = true;
                }
            } while (won == false);
        }
    }

}
