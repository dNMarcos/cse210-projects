using System;

class Program
{
    static void Main(string[] args)
    {
        int cont = 0;
        int gn = 0;
        string answ = "Y";
        while (answ == "Y")
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
                cont = cont + 1;
                
            }
            Console.WriteLine($"The number of intents were: {cont}");
            Console.WriteLine("Do you want to continue? (Y/N)");
            answ = Console.ReadLine();

        }
    }
}