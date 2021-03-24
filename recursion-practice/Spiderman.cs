using System;
using System.Collections.Generic;
using System.Text;

namespace recursion_practice
{
    class Spiderman
    {
        public int Ways(int buildings)
        {
            if(buildings == 1 || buildings == 2)
            {
                return 1;
            }
            else
            {
                return Ways(buildings - 1) + Ways(buildings - 2);
            }
        }
    }
}
