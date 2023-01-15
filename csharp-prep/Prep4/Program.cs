using System;
using System.Collections.Generic;


class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a List of number, type 0 when finished.");
        List<int> game = new List<int>();
        
        int usernumb = 1;
        while(usernumb != 0)
        {
            Console.WriteLine("Enter a number: ");
            usernumb = int.Parse(Console.ReadLine());
            game.Add(usernumb);
        }

        int sum = 0;
        foreach(int numbers in game)
        {
            sum += numbers;
        }

        Console.WriteLine($" The sum is: {sum}");
        float total = Convert.ToSingle(sum) / game.Count;
        Console.WriteLine($" The average is: {total}");

        Console.WriteLine($"The largest number is: {game.Max()}");

        int minp = game[0];
        foreach(int minumb in game)
        {
            if((minumb < minp) && (minumb > 0))
            {
                minp = minumb;
                Console.WriteLine($"The smallest positive number is: {minp}");
            }
        }

        List<int> games = game.OrderBy(number2 => number2).ToList();
        foreach(int numbers in games)
        {
            Console.WriteLine($"The sorted list is: {numbers}");
        } 
    }
}