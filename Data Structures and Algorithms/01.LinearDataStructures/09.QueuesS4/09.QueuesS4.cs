using System;
using System.Collections.Generic;
public class QueuesS4
{
    public static void Main()
    {
        Console.Write("Enter a digit for N: ");
        int n = int.Parse(Console.ReadLine());

        Queue<int> sequence = new Queue<int>();

        int lastIndex = n;
        sequence.Enqueue(n);

        Console.WriteLine("These are the first 50 elements of the sequence");
        for (int i = 0; i < 50; i++)
        {
            lastIndex = sequence.Dequeue();
            Console.WriteLine("{0} ", lastIndex);

            sequence.Enqueue(lastIndex + 1);
            sequence.Enqueue((2 * lastIndex) + 1);
            sequence.Enqueue(lastIndex + 2);
        }

    }
}

