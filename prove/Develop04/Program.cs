using System;
namespace Develop04;
class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Activity Program!");
            Console.WriteLine("Choose an activity:");
            Console.WriteLine("1. Breathing");
            Console.WriteLine("2. Reflection");
            Console.WriteLine("3. Listing");

            int choice = Convert.ToInt32(Console.ReadLine());

            Activity activity;

            switch (choice)
            {
                case 1:
                    activity = new Breathing();
                    break;
                case 2:
                    activity = new Reflection();
                    break;
                case 3:
                    activity = new Listing();
                    break;
                default:
                    Console.WriteLine("Invalid choice. Exiting program.");
                    return;
            }

            activity.Run();

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }