using System;

class Program
{
    static void Main(string[] args)
    {
        int gn = 0;
        string answ = " ";
        while (answ == "yes")
        {
            Random randomGenerator = new Random();
            int mn = randomGenerator.Next(1,100);
            while (gn != mn)
            {
                Console.WriteLine("what is your guess?");
                string guess = Console.ReadLine();
                gn = int.Parse(guess);
                
                if (gn < mn)
                {
                    Console.WriteLine("Higher");
                }
                else if (gn > mn)
                {
                    Console.WriteLine("Lower");
                }
                else
                {
                    Console.WriteLine("Congratulation");
                }
            }
            Console.WriteLine("Do you want to continue?");
            answ = Console.ReadLine();
        }
    }
}