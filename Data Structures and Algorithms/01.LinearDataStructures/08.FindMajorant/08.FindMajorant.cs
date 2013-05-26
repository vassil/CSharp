using System;
using System.Collections.Generic;
using System.Linq;

public class FindMajorant
{
    public static void Main()
    {
        Console.WriteLine("Write a sequence of integer numbers separated by space or comma");

        Console.Write("Integers: ");

        string[] userInput = Console.ReadLine().Split(' ', ',');

        int[] sequence = new int[userInput.Length];

        for (int i = 0; i < userInput.Length; i++)
        {
            int number = int.Parse(userInput[i].Trim());
            sequence[i] = number;
        }

        int majorant = sequence.FindMajorant();

        Console.WriteLine("Majorant -> {0}", majorant);
    }
}