﻿//Declare two string variables and assign them with following value:
//The "use" of quotations causes difficulties.
//    Do the above in two different ways: with and without using quoted strings.

using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.WriteLine(@"The ""use"" of quotations causes difficulties.");
        Console.WriteLine("The \"use\" of quotations causes difficulties.");
    }
}