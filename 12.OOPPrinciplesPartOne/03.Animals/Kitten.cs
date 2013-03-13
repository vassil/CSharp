using System;

namespace Animals
{
    public class Kitten : Cat
    {
        public Kitten(string name, Sex sex, int age)
            : base(name, Sex.Female, age)
        {

        }
    }
}
