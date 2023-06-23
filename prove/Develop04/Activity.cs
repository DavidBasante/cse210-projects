using System;
namespace Develop04
{
    public abstract class Activity
    {
        protected int duration; 

        public Activity()
        {
            duration = 0;
        }

        public void Run()
        {
            DisplayStartingMessage();
            Thread.Sleep(2000); 

            ExecuteActivity();

            DisplayEndingMessage();
            Thread.Sleep(2000); 
        }

        protected virtual void DisplayStartingMessage()
        {
            Console.WriteLine("Starting Activity: " + GetName());
            Console.WriteLine(GetDescription());
            Console.Write("Enter the duration (in seconds): ");
            duration = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Prepare to begin...");
            Thread.Sleep(2000); 
        }

        protected virtual void DisplayEndingMessage()
        {
            Console.WriteLine("Good job! You have completed the activity: " + GetName());
            Console.WriteLine("Duration: " + duration + " seconds");
            Thread.Sleep(2000); 
        }

        protected abstract string GetName();

        protected abstract string GetDescription();

        protected abstract void ExecuteActivity();
    }
}