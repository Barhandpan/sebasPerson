using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using sebasPerson.ExtensionMethodsForExceptions;

namespace sebasPerson
{
    internal class CustomerDecisionEventSender
    {
        public void addPerson(List<Person> people)
        {
            Person newPerson = new();
            Console.WriteLine("Please Write The Name of The Person You Would Like To Add");
            string personName = Console.ReadLine();
            Console.WriteLine();
            personName = personName.ContainOnlyLetters("Name");
            newPerson.Name = personName;
            Console.WriteLine("Please Write The Age of The Person You Would Like To Add");
            string input = Console.ReadLine();
            Console.WriteLine();
            input = input.ContainOnlyNumbers("Age");
            int personAge = int.Parse(input);
            personAge = personAge.WithinRange("Age", 120);
            newPerson.Age = personAge;
            Console.WriteLine("Please Write The ID of The Person You Would Like To Add");
            string personID = Console.ReadLine();
            Console.WriteLine();
            personID = personID.ContainOnlyNumbers("ID");
            newPerson.Id = personID;
            string hobby = "";
            List<Hobby> personHobbies = new();
            while (hobby != "OK")
            {
                Console.WriteLine("Please Write The Hobbies of The Person You Would Like To Add");
                Console.WriteLine("When You Finish Write 'OK' ");
                hobby = Console.ReadLine();
                Console.WriteLine();
                hobby = hobby.ContainOnlyLetters("Hobby");
                hobby = hobby.Trim().ToUpper();
                if (hobby != "OK")
                {
                    Console.WriteLine("Please Write How Many Hours He Invest In This Hobby Per Week");
                    string input1 = Console.ReadLine();
                    Console.WriteLine();
                    input1 = input1.ContainOnlyNumbers("Hours");
                    int hoursPerWeek = int.Parse(input1);
                    hoursPerWeek = hoursPerWeek.WithinRange("Hours", 168);
                    Hobby newHobby = new Hobby(hoursPerWeek, hobby);
                    personHobbies.Add(newHobby);
                }
            }
            newPerson.Hobbies = personHobbies;
            string personality = "";
            List<Personalities> personPersonalities = new();
            while (personality != "OK")
            {
                Console.WriteLine("Please Write The Personalities of The Person You Would Like To Add");
                Console.WriteLine("When You Finish Write 'OK' ");
                personality = Console.ReadLine();
                Console.WriteLine();
                personality = personality.ContainOnlyLetters("Personality");
                personality = personality?.Trim().ToUpper();
                Personalities newPersonalty = new Personalities(personality);
                if(personality != "OK")
                    personPersonalities.Add(newPersonalty);
            }
            newPerson.Personalities = personPersonalities;
            people.Add(newPerson);
            OnCustomerDecision();
        }
        public void removePerson(List<Person> people)
        {
            Console.WriteLine("Please Write The ID Of The Person That You Want To Remove");
            string input = Console.ReadLine();
            Console.WriteLine();
            input = input.ContainOnlyNumbers("ID");
            if (people.FindAll(person => person.Id == input).Count() == 0)
                Console.WriteLine("Can't Find a Person That Match This ID");
            else
            {
                people.RemoveAll(person => person.Id == input);
                OnCustomerDecision();
            }
            Console.WriteLine();
        }
        public void printWithFiltering(List<Person> people)
        {
            Console.WriteLine("Please Select From The Following Options How Would You Like To Filter The List");
            Console.WriteLine("1.Filter By Name");
            Console.WriteLine("2.Filter By First Letter");
            Console.WriteLine("3.Filter By Age");
            Console.WriteLine("4.Filter By Hobby");
            Console.WriteLine("5.Filter By Personality");
            string input = Console.ReadLine();
            Console.WriteLine();
            FilteringOptions filterOptions = new FilteringOptions();
            int customerResult = int.Parse(input);
            if (customerResult == 1)
            {
                CustomersProcess.FilterPrintHandler filterPrintHandler = filterOptions.filterByName;
                CustomersProcess.FilterPrintWithDelegate(people, filterPrintHandler);
            }
            if (customerResult == 2)
            {
                CustomersProcess.FilterPrintHandler filterPrintHandler = filterOptions.filterByFirstLetter;
                CustomersProcess.FilterPrintWithDelegate(people, filterPrintHandler);
            }
            if (customerResult == 3)
            {
                CustomersProcess.FilterPrintHandler filterPrintHandler = filterOptions.filterByAge;
                CustomersProcess.FilterPrintWithDelegate(people, filterPrintHandler);
            }
            if (customerResult == 4)
            {
                CustomersProcess.FilterPrintHandler filterPrintHandler = filterOptions.filterByHobby;
                CustomersProcess.FilterPrintWithDelegate(people, filterPrintHandler);
            }
            if (customerResult == 5)
            {
                CustomersProcess.FilterPrintHandler filterPrintHandler = filterOptions.filterByPersonality;
                CustomersProcess.FilterPrintWithDelegate(people, filterPrintHandler);
            }
            OnCustomerDecision();
        }
        public void printPeople(List<Person> people)
        {
            foreach (Person p in people)
            {
                p.printPerson();
            }
            OnCustomerDecision();
        }
        public event EventHandler CustomerDecision;
        protected virtual void OnCustomerDecision()
        {
            CustomerDecision?.Invoke(this, EventArgs.Empty);
        }
    }
}
