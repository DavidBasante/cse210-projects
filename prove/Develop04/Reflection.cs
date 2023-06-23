using System;

namespace Develop04
{
     public class Reflection : Activity
    {
        protected override string GetName()
        {
            return "Reflection";
        }

        protected override string GetDescription()
        {
            return "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
        }

        protected override void ExecuteActivity()
        {
            Console.WriteLine("Starting reflection activity...");

            string[] prompts = {
                "Think of a time when you stood up for someone else.",
                "Think of a time when you did something really difficult.",
                "Think of a time when you helped someone in need.",
                "Think of a time when you did something truly selfless."
            };

            Random random = new Random();

            int remainingDuration = duration;
            while (remainingDuration > 0)
            {
                string prompt = prompts[random.Next(prompts.Length)];
                Console.WriteLine(prompt);

                // Add code to display spinner animation here

                string[] questions = {
                    "Why was this experience meaningful to you?",
                    "Have you ever done anything like this before?",
                    "How did you get started?",
                    "How did you feel when it was complete?",
                    "What made this time different than other times when you were not as successful?",
                    "What is your favorite thing about this experience?",
                    "What could you learn from this experience that applies to other situations?",
                    "What did you learn about yourself through this experience?",
                    "How can you keep this experience in mind in the future?"
                };

                foreach (string question in questions)
                {
                    Console.WriteLine(question);

                    // Add code to display spinner animation here

                    Thread.Sleep(2000); // Pause for 2 seconds
                    remainingDuration -= 2;
                }
            }
        }
    }
}