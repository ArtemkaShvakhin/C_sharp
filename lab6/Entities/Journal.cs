using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6
{
    class Event
    {
        private string _name, _discription;
        public Event(string name, string description)
        {
            _name = name;
            _discription = description;
        }
        public string Name { get; set; }
        public string Description { get; set; }
    }
    class Journal
    {
        private MyCustomCollections<Event> Events = new MyCustomCollections<Event>();
        public void AddEvent(string name, string description)
        {
            Events.Add(new Event(name, description));
            for (int i = 0; i < Events.Count(); ++i)
            {
                Console.WriteLine($"Name: {Events[i].Name}" + "\t" + $"Description: {Events[i].Description}");
            }
        }
    }
}
