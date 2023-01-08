using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using sebasPerson.ExtensionMethodsForExceptions;

namespace sebasPerson
{
    internal class Person 
    {
        int? _age;
        string? _id;
        List<Hobby> _hobbies;
        List<Personalities> _personalities;
        public static List<Person> people = new List<Person>();
        public static List<Person> People
        {
            set { people = value ?? new();}
            get { return people; }
        }
        public string Name { get; set; } = "";
        public int? Age
        {
            set { _age = value; }
            get { return _age; }
        }
        public string? Id
        {
            set { _id = value ?? "";}
            get { return _id; }
        }
        public List<Hobby> Hobbies
        {
            set { _hobbies = value ?? new(); }
            get { return _hobbies; }
        }
        public List<Personalities> Personalities
        {
            set { _personalities = value ?? new(); }
            get { return _personalities; }
        }
        public Person() { }
        public Person(string _name, int _age, string _id, List<Hobby> _hobbies, List<Personalities> _personalities)
        {
            Name = _name;
            Age = _age;
            Id = _id;
            Hobbies = _hobbies;
            Personalities = _personalities;
        }
        public void printPerson()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Age: {Age}");
            Console.WriteLine($"ID: {Id}");
            foreach (Hobby h in Hobbies)
            {
                Console.WriteLine($"Hobby:{h.HobbieName}");
                Console.WriteLine($"Avarage Hours Per Week: {h.AvarageHoursPerWeek}");
            }
            foreach (Personalities p in Personalities)
                Console.WriteLine($"Personalities: {p.Personality}");
            Console.WriteLine();
        } 
    }
}
