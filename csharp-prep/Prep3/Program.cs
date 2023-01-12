using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is the magic number?");
        string magi_n = Console.ReadLine();
        int maginumb = int.Parse(magi_n);

        Console.WriteLine("What is your guess?");
        int guess_n = int.Parse(Console.ReadLine());

        while(guess_n == maginumb)
        {
            if(guess_n > maginumb)
            {
                Console.WriteLine("Lower");
            }
            else if(guess_n < maginumb)
            {
                Console.WriteLine("Higher");
            }
            else
            {
                Console.WriteLine("Congratulations you guessed the magic number");
            }
        }
        
    }
}