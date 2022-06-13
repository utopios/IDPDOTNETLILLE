using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoursCSharpPOO.Classes
{
    class Calculatrice
    {
        public static void Addition(int a, int b, ref int total)
        {
            total += a;
            total += b;
            Console.WriteLine(total);
        }

        public static void Initialisation(out int a)
        {
            a = 1000;
            Console.WriteLine(a);
        }

        //public static void Addition(int[] tab)
        //{
        //    for(int i=0; i<tab.Length; i++)
        //    {
        //        tab[i] = 10;
        //    }
        //}

        public static int Addition(params int[] tab)
        {
            int total = 0;
            foreach(int i in tab)
            {
                total += i;
            }
            return total;
        }
    }
}
