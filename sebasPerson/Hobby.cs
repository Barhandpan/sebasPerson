using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sebasPerson
{
    internal class Hobby
    {
        int _avarageHoursPerWeek;
        string _hobbieName;
        public int AvarageHoursPerWeek
        {
            set { _avarageHoursPerWeek = value; }
            get { return _avarageHoursPerWeek; }
        }
        public string HobbieName
        {
            set { _hobbieName = value; }
            get { return _hobbieName; }
        }
        public Hobby(int avrHours, string name)
        {
            HobbieName = name;
            AvarageHoursPerWeek = avrHours;
        }
    }
}
