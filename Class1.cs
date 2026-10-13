using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace تمرین
{
    class Calculator
    {
        public int Sum(int a, int b)
        {
            return (a + b);
        }
        public int Sub(int a, int b)
        {
            return (a - b);
        }
        public int Mul(int a, int b)
        {
            return (a * b);
        }
        public float Div(float a, float b)
        {
            return (a / b);
        }
        public BigInteger Pow(int a, int b)
        {
            int count = 1;
            for (int i = 1; i <= b; i++)
            {
                count = count * a;
            }
            return count;
        }
        public float Sqrt(int a)
        {
            return (float)(Math.Sqrt(a));
        }
        public int Max(int a, int b)
        {
            int max;
            if (a > b)
            {
                max = a;
            }
            else
            {
                max = b;
            }
            return max;
        }
        public int Min(int a, int b)
        {
            int min;
            if (a < b)
            {
                min = a;
            }
            else
            {
                min = b;
            }
            return min;
        }
        public bool IsEven(int a)
        {
            if (a % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool IsPositive(int a)
        {
            if (a > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public float Avg(float a, float b, float c)
        {
            float avg = (a + b + c);
            return (avg / 3);
        }
    }
}
