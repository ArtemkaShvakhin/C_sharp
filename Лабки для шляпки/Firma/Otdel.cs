using System;
using System.Collections.Generic;
using System.Text;

namespace Firma
{
    [Serializable]
    class Otdel
    {
       public string Name { get; set; }
        public int Age { get; set; }
        public string Rang { get; set; }
        public int Cost { get; set; }
        public Otdel() { }
        public Otdel(string Name, int Age, string Rang, int Cost)
        {
            this.Name = Name;
            this.Age = Age;
            this.Rang = Rang;
            this.Cost = Cost;
        }
        public override string ToString()
        {
            return Name;
        }
    }
}
