using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sebasPerson
{
    internal class CustomersProcess
    {
        public delegate void FilterPrintHandler(List<Person> people);
        public static void FilterPrintWithDelegate(List<Person> people, FilterPrintHandler filterPrintHandler)
        {
            filterPrintHandler(people);
        }
        public void process(List<Person> people)
        {
            int customerRequest = 0;
            while (customerRequest != 8)
            {
                bool isValidAnswer = false;
                string input = "";
                while (!isValidAnswer)
                {
                    Console.WriteLine("Welcome To The DataBase Of Talpiot-HiTech");
                    Console.WriteLine("Choose One Of The Following Options");
                    Console.WriteLine("1. Print All People");
                    Console.WriteLine("2. Print People By Filtering");
                    Console.WriteLine("3. Add Person");
                    Console.WriteLine("4. Remove Person");
                    Console.WriteLine("When You Want To Finish Please Press '8' ");
                    input = Console.ReadLine();
                    Console.WriteLine();
                    input = input.Trim();
                    while (!isValidAnswer)
                    {
                        switch (input)
                        {
                            case "1": isValidAnswer = true; break;
                            case "2": isValidAnswer = true; break;
                            case "3": isValidAnswer = true; break;
                            case "4": isValidAnswer = true; break;
                            case "8": Console.WriteLine("Bye Bye Thank You For Using Our App ");
                                      isValidAnswer = true; break;
                            default:
                                isValidAnswer = false;
                                Console.WriteLine("Invalid Input Please Try Again");
                                input = Console.ReadLine();
                                input = input.Trim();
                                break;
                        }
                    }
                }             
                customerRequest = int.Parse(input);
                CustomerDecisionEventSender customerDecisionEventSender = new();
                if (customerRequest == 1)
                {    
                    EventSubscriber eventSubscriber = new();
                    customerDecisionEventSender.CustomerDecision += eventSubscriber.OnCustomerDecision;
                    customerDecisionEventSender.printPeople(people);

                }
                if (customerRequest == 2)
                {
                    EventSubscriberSecond eventSubscriberSecond = new();
                    customerDecisionEventSender.CustomerDecision += eventSubscriberSecond.OnCustomerDecision;
                    customerDecisionEventSender.printWithFiltering(people);

                }
                if (customerRequest == 3)
                {
                    EventSubscriberThird eventSubscriberThird = new();
                    customerDecisionEventSender.CustomerDecision += eventSubscriberThird.OnCustomerDecision;
                    customerDecisionEventSender.addPerson(people);
                }
                if (customerRequest == 4)
                {
                    EventSubscriberFourth eventSubscriberFourth = new();
                    customerDecisionEventSender.CustomerDecision += eventSubscriberFourth.OnCustomerDecision;
                    customerDecisionEventSender.removePerson(people);
                }
            }
        }
    }
}
