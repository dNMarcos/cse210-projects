using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        string UserName = PromptUserName();
        int UserNumber = PromtUserNumber();

        int SquaredNumber = SquareNumber(UserNumber);
        DisplayResult(UserName, SquaredNumber);

        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the Program");
        }
        static string PromptUserName()
        {
            Console.Write("Please enter your name: ");
            string name = Console.ReadLine();
            return name;
        }

        static int PromtUserNumber()
        {
            Console.Write("Please enter your favorite number: ");
            int number = int.Parse(Console.ReadLine());
            return number;
        }

        static int SquareNumber(int number)
        {
            int sq = number * number;
            return sq;
        }

        static void DisplayResult(string name, int sq)
        {
            Console.WriteLine($"{name}, the square of your number is {sq}");
        }
    }
}