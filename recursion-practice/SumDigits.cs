using System;
using System.Collections.Generic;
using System.Text;

namespace recursion_practice
{
    public class SumDigits
    {
       
        public  int TottalSumDigits(int number)
        {
            //BASIC CASE
            if (number == 0)
            {
                return 0;
            }
            else
            {
                int operation = number % 10;
                return operation + TottalSumDigits(number / 10);
            }
        }

    }
}
