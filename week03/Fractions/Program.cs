using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction fraction= new Fraction();
        
        Console.WriteLine(fraction.GetFractionString());

        Fraction fraction1=new Fraction(5);
        Console.WriteLine(fraction1.GetFractionString());

        Fraction fraction2=new Fraction(6,1);
        Console.WriteLine(fraction2.GetFractionString());
        fraction2.SetBottom(6);
        Console.WriteLine(fraction2.GetBottom());
        Console.WriteLine(fraction2.GetFractionString());
        fraction2.SetTop(3);
        fraction2.SetBottom(4);
        Console.WriteLine(fraction2.GetDecimalValue());
        
    }
}