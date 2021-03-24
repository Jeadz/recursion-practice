using System;
using System.Collections.Generic;
using System.Text;

namespace recursion_practice
{
    class IsPrime
    {
        public bool FindPrime(int n, int cont = 2)
        {
            if(n % cont == 0 || n < 2)
            {
                return false;
            }
            else if(cont > n / 2)
            {
                return true;
            }
            return FindPrime(n, cont + 1);
        }
    }
}
