using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction f = new Fraction();
        Console.WriteLine(f.GetFractionString());

        Fraction fd = new Fraction();
        Console.WriteLine(fd.GetDecimalValue());

        Fraction ft = new Fraction(5);
        Console.WriteLine(ft.GetFractionString());
        Console.WriteLine(ft.GetDecimalValue());

        Fraction fth = new Fraction(3,4);
        Console.WriteLine(fth.GetFractionString());
        Console.WriteLine(fth.GetDecimalValue());

        Fraction fon = new Fraction(1,3);
        Console.WriteLine(fon.GetFractionString());
        Console.WriteLine(fon.GetDecimalValue());    
        
        /*Console.WriteLine("Hello Learning003 World!");*/
    }
}