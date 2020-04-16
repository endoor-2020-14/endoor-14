using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_TripPlanner
{
    class Program
    {
        static void Main(string[] args)
        {
            Greeting();
            TravelTimeAndBudget();
            TimeDifference();
            Area();
            
        }

        // Greeting User
        static string Greeting()
        {
            Console.WriteLine("Welcome to Trip Planner!");
            Console.Write("What is your full name? ");
            string name = Console.ReadLine();
            Console.WriteLine("Hello, " + name);

            Console.Write("What is your travel destination? ");
            string destination = Console.ReadLine();
            Console.WriteLine(destination + " sounds great this time of year!");
            return destination;
        }
        // Travel Time And BUdget
        static void TravelTimeAndBudget()
        {
            Console.Write("How many days are you going to spend destination {0}? ");
            int days = int.Parse(Console.ReadLine());

            Console.Write("What is your total budget for the trip in euro? ");
            double budget = double.Parse(Console.ReadLine());
            Console.Write("what is the currency symbol for your destination? ");
            string currencySymbol = (Console.ReadLine());

            Console.WriteLine("How many {0}  are there in 1 EUR: ", currencySymbol);
            double rate = double.Parse(Console.ReadLine());

            int hour = days * 24;
            int minute = hour * 60;
            Console.WriteLine("If you are traveling for {0} days that is tha same as {1} hours or {2} minutes. ", days, hour, minute);

            double dailyInEuro = budget / days;
            Console.WriteLine("If you are going to spend {0} that means daily you can spend up to {1} in EUR. ", budget, String.Format("{0:n2}", dailyInEuro));

            double total = rate * budget;
            double perDay = total / days;

            Console.WriteLine("Your total budget in {0}  is {1} which per day is {2}. ", currencySymbol, String.Format("{0:n2}", total), String.Format("{0:n2}", perDay));
        }
        // Time Difference
        public static void TimeDifference()
        {
            Console.Write("What's the difference in hour, between your home and your destination? ");
            int TimeDiff = int.Parse(Console.ReadLine());

            int TimeDiffMidnight = (24 + TimeDiff) % 24;
            int TimeDiffnoon = (12 + TimeDiff) % 24;
            Console.WriteLine("That means that when it is midnight at home it will be {0}:00 in your travel destination and when it is noon at home it will be {1}:00", TimeDiffMidnight, TimeDiffnoon);

        }
        //Area/Country
        public static void Area()
        {
            Console.WriteLine("What is the area of your destination country/region in square kilometers ? ");
            double kilometers = double.Parse(Console.ReadLine());
            double Mile = kilometers * 0.386102159;
            Console.WriteLine("In miles that is {0}", String.Format("{0:n2}", Mile));

        }





        
    }
}
