using System;
using System.Numerics;

namespace تمرین
{
    class Program
    {
        static void Main()
        {
            Calculator c = new Calculator();
            Console.WriteLine("Operations:1.Addition 2.Subtraction 3.Multiplication 4.Division 5.Power 6.Radical 7.Maximum 8.Minimum 9.Evenness of a number 10.Positiveness of a number 11.Average of three numbers Choose one.");
            int a = int.Parse(Console.ReadLine());
            int res;
            Boolean tea;
            double te;
            while (a < 1 || a > 11)
            {
                a = int.Parse(Console.ReadLine());

                if (a < 1 || a > 11)
                {
                    Console.WriteLine("Invalid choice. Enter a number between 1 and 11:");
                }
            }
            switch (a)
            {
                case 1:
                    Console.WriteLine("Please enter two numbers to add: ");
                    int s = int.Parse(Console.ReadLine());
                    int d = int.Parse(Console.ReadLine());
                    res = c.Sum(s, d);
                    Console.WriteLine(res);
                    break;
                case 2:
                    Console.WriteLine("Please enter two numbers to subtract: ");
                    int f = int.Parse(Console.ReadLine());
                    int g = int.Parse(Console.ReadLine());
                    res = c.Sub(f, g);
                    Console.WriteLine(res);
                    break;
                case 3:
                    Console.WriteLine("Please enter two numbers to multiply: ");
                    int h = int.Parse(Console.ReadLine());
                    int j = int.Parse(Console.ReadLine());
                    res = c.Mul(h, j);
                    Console.WriteLine(res);
                    break;
                case 4:
                    Console.WriteLine("Please enter two numbers to divide: ");
                    float k = float.Parse(Console.ReadLine());
                    float l = float.Parse(Console.ReadLine());
                    float tee = c.Div(k, l);
                    Console.WriteLine(tee);
                    break;
                case 5:
                    Console.WriteLine("Enter the first number for the base and the second number for the exponent : ");
                    int z = int.Parse(Console.ReadLine());
                    int x = int.Parse(Console.ReadLine());
                    BigInteger resw = c.Pow(z, x);
                    Console.WriteLine(resw);
                    break;
                case 6:
                    Console.WriteLine("Please enter a number to get the radical: ");
                    int q = int.Parse(Console.ReadLine());
                    float ter = c.Sqrt(q);
                    Console.WriteLine(ter);
                    break;
                case 7:
                    Console.WriteLine("Please enter two numbers to find the maximum: ");
                    int b = int.Parse(Console.ReadLine());
                    int v = int.Parse(Console.ReadLine());
                    res = c.Max(b, v);
                    Console.WriteLine(res);
                    break;
                case 8:
                    Console.WriteLine("Please enter two numbers to find the minimum: ");
                    int n = int.Parse(Console.ReadLine());
                    int m = int.Parse(Console.ReadLine());
                    res = c.Min(n, m);
                    Console.WriteLine(res);
                    break;
                case 9:
                    Console.WriteLine("Please enter a number to prove an even number: ");
                    int w = int.Parse(Console.ReadLine());
                    tea = c.IsEven(w);
                    Console.WriteLine(tea);
                    break;
                case 10:
                    Console.WriteLine("Please enter a number to prove that the number is positive: ");
                    int e = int.Parse(Console.ReadLine());
                    tea = c.IsPositive(e);
                    Console.WriteLine(tea);
                    break;
                case 11:
                    Console.WriteLine("Please enter three numbers to average: ");
                    float r = float.Parse(Console.ReadLine());
                    float t = float.Parse(Console.ReadLine());
                    float y = float.Parse(Console.ReadLine());
                    float ress = c.Avg(r, t, y);
                    Console.WriteLine(ress);
                    break;
            }


        }
    }
}