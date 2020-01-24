using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EquazioniLibrary
{
    public class CalcoliCombinatori
    {
        public static long Fattoriale (int n)
        {
           if (n == 0)
            {
                return 1;
            }
           else if(n == 1)
            {
                return 1;
            }
            else
            {
                int Fattoriale = 1;
                for (int i = 2; i <= n; i++)
                {
                    Fattoriale *= i;
                }
                return Fattoriale;
            }
        }
    }
}
