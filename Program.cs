using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int answer;
            bool done = false;
            List<int> Numbers = new List<int>();

            Console.WriteLine("This program has you enter a min and a max then you have to enter inbetween your numbers");
            Console.WriteLine("Please enter a minimum value");
            int min = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter a naximum value");
            int max = Convert.ToInt32(Console.ReadLine());
            while (!done)
            {
                Console.WriteLine("Please enter a number inbetween the values you have chosen");
                answer = Convert.ToInt32(Console.ReadLine());
                if (answer > max || answer < min)
                {
                    Console.WriteLine("You didn't do what I asked try again");
                }
                else
                {
                    Console.WriteLine("Good job!");
                    done = true;
                }
            }


            Console.WriteLine("This program will tell you your average amoungst your gardes");
            Console.WriteLine("Please enter the amount of grades you're about to input.");
            int amount = Convert.ToInt32(Console.ReadLine());

            while (!done)
            {
                Console.WriteLine("Please enter a grade");

                int sub = amount - 1;
                if (amount == 0)
                {
                    done = true;
                    Console.WriteLine("This is your average", );
                } 
            }

            Console.ReadLine();
        }
    }
}
