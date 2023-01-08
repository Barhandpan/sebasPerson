using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace sebasPerson.ExtensionMethodsForExceptions
{
    public static class ExtensionMethod
    {
        public static string ContainOnlyNumbers(this String var, string varLabel)
        {
            while (!(Regex.IsMatch(var, @"^\d+$")))
            {
                Console.WriteLine("{0} must contains only numbers", varLabel);
                string input = Console.ReadLine();
                var = input;
            }
            return var;
        }
        public static string ContainOnlyLetters(this String var, string varLabel)
        {

            while (!(Regex.IsMatch(var, @"^[a-zA-Z]+$")))
            {
                Console.WriteLine("{0} must contain only letters. Please Write The {0} Again", varLabel);
                string input = Console.ReadLine();
                var = input;
            }
            return var;
        }
        public static int WithinRange(this int var, string varLabel,int maxNum)
        {
            string input = "0";
            while (var <= 0 || var > maxNum || !(Regex.IsMatch(input, @"^\d+$")))
            {
                if (var <= 0 || var > maxNum)
                {
                    Console.WriteLine("{0} must be a positive integer and under {1}.", varLabel,maxNum);
                    input = Console.ReadLine();
                }
                if (!(Regex.IsMatch(input, @"^\d+$")))
                {
                    Console.WriteLine("{0} must contains only numbers", varLabel);
                    input = Console.ReadLine();
                }
                var = int.Parse(input);
            }
            return var;
        }
        public static string ContainOnlyLetter(this String letter, string varLabel)
        {
            while ((Regex.IsMatch(letter, @"^[a-zA-Z]+$")) && letter.Length != 1)
            {
                Console.WriteLine("{0} must contain only letters. Please Write The {0} Again", varLabel);
                string input = Console.ReadLine();
                letter = input;
            }
            return letter;
        }
        public static int MinAgeAboveMaxAge(this int maxAge, int minAge)
        {
            if (maxAge < minAge)
            {
                Console.WriteLine("Maximum age must be above the minimum age please define maximum age again");
                string input = Console.ReadLine();
                input = input.ContainOnlyNumbers("Maximum Age");
                maxAge = int.Parse(input);
            }
            return maxAge;
        }
    }
}
