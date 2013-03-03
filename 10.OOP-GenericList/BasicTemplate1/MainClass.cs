using System;
class MainClass
{
    static void Main()
    {
        GenericList<int> list = new GenericList<int>(2);
        list.Add(1);
        list.Add(13);
        list.Add(12);

        Console.WriteLine(list);

        Console.WriteLine(list[2]);

        Console.WriteLine(list.Min<int>());

        Console.WriteLine(list.Max<int>());    
    }
}

