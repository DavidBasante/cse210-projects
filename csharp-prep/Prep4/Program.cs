using System.Collections.Generic;

List<int> num = new List<int>();

int number = -1;

while(number != 0){
    Console.Write("Enter a number (Type 0 to quit): ");
    number = int.Parse(Console.ReadLine());

    if(number != 0){

        num.Add(number);
    }

}

int all = 0;
foreach (int numbers in num){
    all++;
}

Console.WriteLine($"Total of numbers:{all}");


int largest = num[0];
foreach(int numbers in num){
    if(numbers > largest){
        largest = numbers;
   }
}
Console.WriteLine($"The largest number is {largest}");

Console.ReadKey();