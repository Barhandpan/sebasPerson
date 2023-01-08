using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sebasPerson
{
    internal class Personalities
    {
        string _personality;
        public string Personality
        {
            set { _personality = value; }
            get { return _personality; }
        }
        public Personalities() { }
        public Personalities(string _personality)
        {
            Personality = _personality;
        }
    }
}
