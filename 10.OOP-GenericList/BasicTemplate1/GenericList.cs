﻿using System;
using System.Text;

public class GenericList<T>
{
    private T[] listElements;
    private int lastChangedElement = 0;

    //Constructor
    public GenericList(int numberOfElements)
    {
        this.listElements = new T[numberOfElements];
    }

    public void Add(T value) 
    {
        if (lastChangedElement==listElements.Length)
        {
            Array.Resize(ref this.listElements, this.listElements.Length * 2);
        }
        this.listElements[this.lastChangedElement] = value;
        this.lastChangedElement++;
    }

    public T this[int index] 
    {
        get 
        {
            if (index > listElements.Length)
            {
                throw new IndexOutOfRangeException("You can't acces an element bigger than the size of the list.");
            }
            else if (index < 0)
            {
                throw new IndexOutOfRangeException("You can't acces an element smaller than zero.");
            }
            else
            {
                return this.listElements[index];
            }
        }
    }

    public void Clear() 
    {
        this.listElements = new T[this.listElements.Length];
    }

    public int Find(T value)
    {
        for (int i = 0; i < listElements.Length; i++)
        {
            if ((dynamic)this.listElements[i] == value)
            {
                return i;
            }
            else
            {
                Console.WriteLine("No such element");
                return -1;
            }
        }
        return -1;
    }

    public override string ToString()
    {
        StringBuilder list = new StringBuilder();

        for (int i = 0; i < this.listElements.Length; i++)
        {
            list.AppendFormat("{0}, ", this.listElements[i]);
        }

        return list.ToString();
    }

    public T Min<T>() where T : IComparable<T>
    {
        dynamic minElement = this.listElements[0];

        for (int i = 1; i < listElements.Length; i++)
        {
            if (minElement.CompareTo(listElements[i]) > 0)
            {
                minElement = listElements[i];
            }
        }

        return minElement;
    }

    public T Max<T>() where T : IComparable<T>
    {
        dynamic maxElement = this.listElements[0];

        for (int i = 1; i < listElements.Length; i++)
        {
            if (maxElement.CompareTo(listElements[i]) < 0)
            {
                maxElement = listElements[i];
            }
        }

        return maxElement;
    }
}