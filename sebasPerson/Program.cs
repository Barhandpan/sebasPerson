// See https://aka.ms/new-console-template for more information
using sebasPerson;
Person person1 = new Person("Zur", 34, "2567853", new List<Hobby>() { new Hobby(8, "Sleeping"), new Hobby(2, "Vollyball") }, new List<Personalities>() { new Personalities("Smart"), new Personalities("Humble") });
Person person2 = new Person("Ofir", 25, "28547321", new List<Hobby>() { new Hobby(12, "Kahzahian Singers"), new Hobby(20, "Play Pokemon") }, new List<Personalities>() { new Personalities("Funny"), new Personalities("Friendly") });
Person person3 = new Person("Sebastian", 30, "4003332", new List<Hobby>() { new Hobby(15, "Eat Sofganiot"), new Hobby(10, "Soccer") }, new List<Personalities>() { new Personalities("Inteligent"), new Personalities("Precisly") });
Person person4 = new Person("Bar", 29, "204322201", new List<Hobby>() { new Hobby(20, "Music"), new Hobby(20, "Play Yu gi Oh") }, new List<Personalities>() { new Personalities("Talented") });
Person person5 = new Person("Artiyum", 25, "5432156", new List<Hobby>() { new Hobby(5, "Athletics") }, new List<Personalities>() { new Personalities("Silent"), new Personalities("Shy") });
List<Person> people = new ();
people.Add(person1);
people.Add(person2);
people.Add(person3);
people.Add(person4);
people.Add(person5);
CustomersProcess customerProcess = new();
customerProcess.process(people);
















