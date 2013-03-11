using System;
using System.Linq;

namespace School
{
    public class Person
    {
        private string name;
        
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
