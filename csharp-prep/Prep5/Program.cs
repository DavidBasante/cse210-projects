DisplayWelcome();

string name = PromptName();
int number = PromptNum();
int sqr = SquareNum(number);
DisplayResult(name, sqr);

static void DisplayWelcome(){
    System.Console.WriteLine("Welcome to the program!");
}

static string PromptName(){
    System.Console.WriteLine("What is your name: ");
    string name = Console.ReadLine();
    return name;
}

static int PromptNum(){
    System.Console.WriteLine("What is favorite number: ");
    int number = int.Parse(Console.ReadLine());
    return number;
}

static int SquareNum(int number){
    int sqr = number * number;
    return sqr;
}

static void DisplayResult(string name, int sqr){
    System.Console.WriteLine($"Brother {name}, the square of your number is {sqr}");
}
