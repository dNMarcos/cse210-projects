using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int mn = randomGenerator.Next(1,100);
        int count = 0;
        int gn = 0;
        string ans = "";
        while (ans == "yes")
        {
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
                count++;
                Console.WriteLine(count);
            }
            Console.WriteLine("Do you want to continue?");
            ans = Console.ReadLine();
        }
    }
}