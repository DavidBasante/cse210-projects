using System;
namespace Develop04
{
        public class Listing : Activity
    {
        protected override string GetName()
        {
            return "Listing";
        }

        protected override string GetDescription()
        {
            return "This activity will help you reflect on the good things.";
        }

        protected override void ExecuteActivity()
        {
            Console.WriteLine("Starting listing activity...");

            string[] prompts = {
                "Who are people that you appreciate?",
                "What are personal strengths of yours?",
                "Who are people that you have helped this week?",
                "When have you felt the Holy Ghost this month?",
                "Who are some of your personal heroes?"
            };

            Random random = new Random();
            string prompt = prompts[random.Next(prompts.Length)];
            Console.WriteLine(prompt);

            // Add code to display countdown timer animation here

            Console.WriteLine("Start listing items:");

            int itemCount = 0;
            int remainingDuration = duration;
            while (remainingDuration > 0)
            {
                string item = Console.ReadLine();
                if (!string.IsNullOrEmpty(item))
                {
                    itemCount++;
                }
                remainingDuration--;
            }

            Console.WriteLine("You listed " + itemCount + " items.");
        }
    }
}