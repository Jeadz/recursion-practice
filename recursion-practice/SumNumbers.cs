using System;

namespace recursion_practice
{
    public class SumNumbers
    {
        
        public  int sumRange( int n)
        {
            // BASIC CASE
            int tottalSum;
            if(n == 1)
            {
                return(1);
            }
            else
            {
                tottalSum = n + sumRange(n - 1);
            }
            return tottalSum;
        }
    }
}
