using System;

namespace PerfectCountdown
{
    public class Program
    {
        private static void Main(string[] args)
        {
            while (true)
            {
                //Ask user for a Starting number for the countdown
                Console.WriteLine("Start number:");
                int start = int.Parse(Console.ReadLine());
                //Ask user for a step number for countdown
                Console.WriteLine("Step number:");
                int step = int.Parse(Console.ReadLine());

                if (step > start)
                {
                    Console.WriteLine("Out-of-range start or step. Try again.");
                }
            }
        }
    }
}
