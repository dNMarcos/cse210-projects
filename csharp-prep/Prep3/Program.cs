using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int mn = randomGenerator.Next(1,100);

        int gn = 0;
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
    }
}