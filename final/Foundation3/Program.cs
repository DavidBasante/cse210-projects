using System;
namespace Foundation3;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the address details:");
        Console.Write("Street: ");
        string street = Console.ReadLine();
        Console.Write("City: ");
        string city = Console.ReadLine();
        Console.Write("State/Province: ");
        string state = Console.ReadLine();
        Console.Write("Country: ");
        string country = Console.ReadLine();

        Address address1 = new Address(street, city, state, country);

    }
}
