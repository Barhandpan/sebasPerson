using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sebasPerson
{
    internal class EventSubscriber
    {
        public void OnCustomerDecision(object source, EventArgs eventArgs)
        {
            Console.WriteLine("Here Are The List Of People You Requested");
            Console.WriteLine();
        }
    }
    public class EventSubscriberSecond
    {
        public void OnCustomerDecision(object source, EventArgs eventArgs)
        {
            Console.WriteLine($" Here is The Filtered List Of People As You Requested");
            Console.WriteLine();
        }
    }
    public class EventSubscriberThird
    {
        public void OnCustomerDecision(object source, EventArgs eventArgs)
        {
            Console.WriteLine($" A Person As Been Added To The List");
            Console.WriteLine();
        }
    }
    public class EventSubscriberFourth
    {
        public void OnCustomerDecision(object source, EventArgs eventArgs)
        {
            Console.WriteLine($" A Person As Been Removed From The List");
            Console.WriteLine();
        }
    }
}
