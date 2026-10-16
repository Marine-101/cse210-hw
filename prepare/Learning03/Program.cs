using System;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        Fraction fraction1 = new Fraction();
        Console.WriteLine(fraction1.GetFractionString());
        Console.WriteLine(fraction1.GetDecimalValue());

        Fraction fraction2 = new Fraction(5);
        Console.WriteLine(fraction2.GetFractionString());
        Console.WriteLine(fraction2.GetDecimalValue());

        Fraction fraction3 = new Fraction(3,4);
        Console.WriteLine(fraction3.GetFractionString());
        Console.WriteLine(fraction3.GetDecimalValue());

        Fraction fraction4 = new Fraction(1,3);
        Console.WriteLine(fraction4.GetFractionString());
        Console.WriteLine(fraction4.GetDecimalValue());

        fraction3.SetTop(6);
        fraction3.SetBottom(7);
        Console.WriteLine(fraction3.GetFractionString());
        Console.WriteLine(fraction3.GetDecimalValue());
        Console.WriteLine(fraction3.GetTop());
        Console.WriteLine(fraction3.GetBottom());

        Random random = new Random();
        Fraction randomFraction = new Fraction();
        for (int i = 1; i <= 20; i++)
        {
            int top = random.Next(1,11);
            int bottom = random.Next(1,11);

            randomFraction.SetTop(top);
            randomFraction.SetBottom(bottom);
            Console.WriteLine($"{i}: Fraction: {randomFraction.GetFractionString()} Number: {randomFraction.GetDecimalValue()}");
        }
    }
}