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

                //If either the start or step are negative numbers or zero, tell the user:
                if (start<= 1||step<= 1)
                {
                    Console.WriteLine("Out-of-range start or step. Try again.");
                    continue;
                }

                //If the step number is bigger than the start, tell the user:
                if (step > start || start == step)
                {
                    Console.WriteLine("Start must be higher than step. Try again.");
                    continue;
                }

                //If dividing start by step doesn't equal 0, tell the user:
                if ( start % step != 0)
                {
                    Console.WriteLine("Start not divisible by step. Try again.");
                    continue;
                }
                //Else divide the start number by subtracting the step number till it reaches 0
                else
                {
                    while (start >= 0)
                    {
                    Console.WriteLine(start);
                    start -= step;
                    }
                    break;
                }
            }
        }
    }
}
