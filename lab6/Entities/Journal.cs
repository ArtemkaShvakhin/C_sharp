using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6
{
    class Event
    {
        private string _name, _description;
        public Event(string name, string description)
        {
            _name = name;
            _description = description;
        }
        public string GetName
        {
            get { return _name; }
        }
        public string GetDescription
        {
            get { return _description; }
        }
    }
    class Journal
    {
        private MyCustomCollections<Event> Events = new MyCustomCollections<Event>();
        public void AddEvent(string name, string description)
        {
            Events.Add(new Event(name, description));
        }
        public void PrintEvents()
        { 
            for (int i = 0; i < Events.Count(); ++i)
            {
                Console.WriteLine($"Name: {Events[i].GetName}" + "\t" + $"Description: {Events[i].GetDescription}");
            }
        }
    }
}
