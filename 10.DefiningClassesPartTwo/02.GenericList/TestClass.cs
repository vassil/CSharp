using System;
class MainClass
{
    static void Main()
    {
        GenericList<int> list = new GenericList<int>(2);
        list.Add(1);
        list.Add(13);
        list.Add(12);

        Console.WriteLine("Generic list contains: {0}",list);

        Console.WriteLine("Second element of the list is {0}", list[2]);

        Console.WriteLine("Smallest element in the list is {0}", list.Min<int>());

        Console.WriteLine("Biggest element in the list is {0}", list.Max<int>());
    }
}

