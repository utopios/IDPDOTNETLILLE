﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoursCSharpPOO.Classes
{
    
    public class Tools
    {
        private IDice _dice;
        public Tools()
        {

        }

        public Tools(IDice dice)
        {
            _dice = dice;
        }

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

        public static void EnvoieMail(decimal prix)
        {
            Console.WriteLine("Mail envoyé "+prix);
        }

        public static void EnvoieMail()
        {
            Console.WriteLine("Mail envoyé ");
        }

        public static void EnvoieSMS(decimal prix)
        {
            Console.WriteLine("SMS envoyé "+prix);
        }

        public string ConvertCivility(int a)
        {
            if(a == 1)
            {
                return "Mme.";
            }
            else if(a == 2)
            {
                return "M.";
            }
            else
            {
                return null;
            }
        }

        //private int getRandom(int max)
        //{
        //    return new Random().Next(1, max);
        //}

        //public int Dice()
        //{
        //    return getRandom(7);
        //}

        public string GetElement()
        {
            string[] tab = new string[] { "e1", "e2", "e3", "e4", "e5", "e6" };

            return tab[_dice.GetRandom() - 1];
        }
    }
}
