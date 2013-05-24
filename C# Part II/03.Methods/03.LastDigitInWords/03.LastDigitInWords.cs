﻿//Write a method that returns the last digit of given integer as an English word. Examples: 512  "two", 1024  "four", 12309  "nine".
using System;

class LastDigitInWords
{
    static int GetLastDigit(int n)
    {
        return n % 10;
    }
    static void Main()
    {
        int input = int.Parse(Console.ReadLine());
        Console.Write("{0} -> ", input);
        switch (GetLastDigit(input))
        {
            case 0: Console.WriteLine("Zero");
                break;
            case 1: Console.WriteLine("One");
                break;
            case 2: Console.WriteLine("Two");
                break;
            case 3: Console.WriteLine("Three");
                break;
            case 4: Console.WriteLine("Four");
                break;
            case 5: Console.WriteLine("Five");
                break;
            case 6: Console.WriteLine("Six");
                break;
            case 7: Console.WriteLine("Seven");
                break;
            case 8: Console.WriteLine("Eight");
                break;
            case 9: Console.WriteLine("Nine");
                break;
            default: Console.WriteLine("Error");
                break;
        }
    }
}