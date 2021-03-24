using System;

namespace recursion_practice
{
    class Program
    {
        static void Main(string [] args)
        {
            SumNumbers point1 = new SumNumbers();
            SumDigits point2 = new SumDigits();
            IsPrime point3 = new IsPrime();
            Spiderman point4 = new Spiderman();

            int numPoint1 = 5;
            int numPoint2 = 25;
            int numPoint3 = 12;
            int numPoint4 = 4;
            //Console.WriteLine("The sum of numbers from 1 to " + numPoint1 + ": "+ point1.sumRange(numPoint1));
            //Console.WriteLine("The Sum of digits of " + numPoint2 + " = " + point2.TottalSumDigits(numPoint2));
            /*if(point3.FindPrime(numPoint3) == true)
            {
                Console.WriteLine("The number " + numPoint3 + "  is a prime number.");
            }
            else
            {
                Console.WriteLine("The number " + numPoint3 + "  not is a prime number.");
            }*/
            Console.WriteLine("Spiderman has " + point4.Ways(numPoint4) + " ways to jump buildings");
           
        }
    }
}
