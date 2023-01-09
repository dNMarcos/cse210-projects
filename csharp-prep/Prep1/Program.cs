using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your first name? ");
        string fname = Console.ReadLine();
        Console.Write("What is your second name? ");
        string sname = Console.ReadLine();
        Console.WriteLine($"Your name is {sname}, {fname} {sname}.");
    }
}