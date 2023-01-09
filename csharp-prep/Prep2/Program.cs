using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your grade? ");
        string pgrade = Console.ReadLine();
        int perg = int.Parse(pgrade);
        string letter = "";
        if (perg >= 90)
        {
            letter = "A";
        }
        else if (perg >= 80)
        {
            letter = "B";
        }
        else if (perg >= 70)
        {
            letter = "C";
        }
        else if (perg >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        int plsormin = perg%10;
        string letter2 = "";
        if (plsormin >= 7 && letter != "A")
        {
            letter2 = "+";
        }
        else if (plsormin <= 3 && letter != "F")
        {
            letter2 = "-";
        }
        else
        {
            letter2 = "";
        }
        Console.WriteLine($"Your grade is: {letter}{letter2}.");

        if (perg >= 70)
        {
            Console.WriteLine("Congratulation, you pass the course! ");
        }
        else
        {
            Console.WriteLine("You fail the course, please take it again. ");
        }

    }
}