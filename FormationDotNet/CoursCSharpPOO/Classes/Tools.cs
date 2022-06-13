using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoursCSharpPOO.Classes
{
    
    class Tools
    {
        public static decimal ParseDecimal(string value)
        {
            decimal result = 0;
            try
            {
                result = Convert.ToDecimal(value);
            }catch(Exception ex)
            {
                result = 0;
            }
            return result;
        }

        public static bool ParseDecimal(string value, out decimal variable)
        {
            bool result = false;
            try
            {
                variable = Convert.ToDecimal(value);
                result = true;
            }
            catch (Exception ex)
            {
                variable = 0;
            }
            return result;
        }

        //public static void Afficher(int a)
        //{
        //    Console.WriteLine(a);
        //}
        //public static void Afficher(int a, int b)
        //{
        //    Console.WriteLine(a);
        //    Console.WriteLine(b);
        //}

        public static void Afficher(string message, params int[] tab)
        {
            Console.WriteLine(message);
            for(int i = 0; i < tab.Length; i++)
            {
                Console.WriteLine(tab[i]);
            }
        }

        public static int Multiplication(int a, int b)
        {
            return a * b;
        }
    }
}
