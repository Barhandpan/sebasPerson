﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using sebasPerson.ExtensionMethodsForExceptions;

namespace sebasPerson
{
    internal class FilteringOptions
    {
        public void filterByName(List<Person> people)
        {
            bool isValid = false;
            string input0 = "";
            Console.WriteLine("Please Write The Name");
            input0 = Console.ReadLine();
            input0 = input0.ContainOnlyLetters("Name");
            input0 = input0.Substring(0, 1).ToUpper() + input0.Substring(1).ToLower();
            var results = people.FindAll(p => p.Name == input0);
            foreach (var person in results)
            {
                person.printPerson();
            }
        }
        public void filterByFirstLetter(List<Person> people)
        {
            Console.WriteLine("Please Write The Letter");
            string input1 = Console.ReadLine();
            Console.WriteLine();
            input1 = input1.ContainOnlyLetter("First Letter");
            input1 = input1.Substring(0, 1).ToUpper();
            var results = people.FindAll(p => p.Name.StartsWith(input1));
            foreach (var person in results)
            {
                person.printPerson();
            }
        }
        public void filterByAge(List<Person> people)
        {
            Console.WriteLine("Please Write The Minimum Age");
            string input2 = Console.ReadLine();
            Console.WriteLine();
            input2 = input2.ContainOnlyNumbers("Age");
            int minAge = int.Parse(input2);
            Console.WriteLine("Please Write The Maximum Age");
            string input3 = Console.ReadLine();
            Console.WriteLine();
            input3 = input3.ContainOnlyNumbers("Age");
            int maxAge = int.Parse(input3);
            maxAge = maxAge.MinAgeAboveMaxAge(minAge);
            var results = people.FindAll(p => (p.Age >= minAge && p.Age <= maxAge));
            foreach (var person in results)
            {
                person.printPerson();
            }
        }
        public void filterByHobby(List<Person> people)
        {
            Console.WriteLine("Please Write The Hobby");
            string input4 = Console.ReadLine();
            Console.WriteLine();
            input4 = input4.ContainOnlyLetters("Hobby");
            var results = people.Where(p => p.Hobbies.Any(h => h.HobbieName == input4));
            foreach (var person in results)
            {
                person.printPerson();
            }
        }
        public void filterByPersonality(List<Person> people)
        {
            Console.WriteLine("Please Write The Personaly");
            string input5 = Console.ReadLine();
            Console.WriteLine();
            input5 = input5.ContainOnlyLetters("Personality");
            var results = people.Where(p => p.Personalities.Any(h => h.Personality == input5));
            foreach (var person in results)
            {
                person.printPerson();
            }
        }
    }
}
