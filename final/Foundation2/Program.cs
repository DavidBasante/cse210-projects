using System;
namespace Foundation2;
class Program
{
    static void Main(string[] args)
    {
        Character character = new Character("Logan Oliver", 29, "Male", "Brazilian Jiu Jitsu");

        System.Console.WriteLine("Name: " + character.GetName());
        System.Console.WriteLine("Age: " + character.GetAge());
        System.Console.WriteLine("Gender: " + character.GetGender());
        System.Console.WriteLine("Fighting Style: " + character.GetFightingStyle());
    }
}