using System;

class Program
{
    static void Main()
    {
        
        Console.Write("Enter the length of the first katet: ");
        double a = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the length of the second katet: ");
        double b = Convert.ToDouble(Console.ReadLine());

        
        double c = Math.Sqrt(a * a + b * b);
        double area = (a * b) / 2;

        
        Console.WriteLine("Hypotenuse: " + c);
        Console.WriteLine("Area: " + area);


        Console.WriteLine("Press any key to complete...");
        Console.ReadKey();
    }
}
