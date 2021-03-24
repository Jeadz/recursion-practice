using System;

namespace recursion_practice
{
    class Program
    {
        static void Main(string [] args)
        {
            SumNumbers point1 = new SumNumbers();
            SumDigits point2 = new SumDigits();

            int numPoint1 = 5;
            int numPoint2 = 25;
            //Console.WriteLine("The sum of numbers from 1 to " + numPoint1 + ": "+ point1.sumRange(numPoint1));
            Console.WriteLine("The Sum of digits of " + numPoint2 + " = " + point2.TottalSumDigits(numPoint2));

        }
    }
}
