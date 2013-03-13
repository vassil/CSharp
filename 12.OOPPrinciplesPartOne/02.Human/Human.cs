﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Human
{
    public abstract class Human
    {
        private string firstName;
        private string secondName;

        public Human(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.secondName = lastName;
        }

        public string FirstName
        {
            get { return this.firstName; }
        }

        public string SecondName
        {
            get { return this.secondName; }
        }
    }
}
