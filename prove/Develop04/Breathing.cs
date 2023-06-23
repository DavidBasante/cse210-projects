using System;

namespace Develop04
{
       public class Breathing : Activity
    {
        protected override string GetName()
        {
            return "Breathing";
        }

        protected override string GetDescription()
        {
            return "This activity will help you relax. Breathing in and out slowly. Focus on your breathing.";
        }

        protected override void ExecuteActivity()
        {
            Console.WriteLine("Starting breathing activity...");

            int remainingDuration = duration;
            while (remainingDuration > 0)
            {
                Console.WriteLine("Breathe in...");
                Thread.Sleep(1000); // Pause for 1 second
                Console.WriteLine("Breathe out...");
                Thread.Sleep(1000); // Pause for 1 second
                remainingDuration -= 2;
            }
        }
    }
}