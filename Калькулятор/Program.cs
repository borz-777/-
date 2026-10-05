using Subjects;
using System;

class Program
{
    static void Main()
    {
        Subjects.Math clsmath = new Subjects.Math();

        Console.WriteLine("first number");
        int num1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("second number");
        int num2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("mult: " + clsmath.mult(num1, num2));
        Console.WriteLine("sum: " + clsmath.sum(num1, num2));
        Console.WriteLine("div: " + clsmath.div(num1, num2));
        Console.WriteLine("subtraction: " + clsmath.subtraction(num1, num2));
    }
}