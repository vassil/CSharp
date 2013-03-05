using System;
using System.Text;

public static class SubstringExtension
{
    public static StringBuilder Substring(this StringBuilder text, int startIndex, int length)
    {
        if (startIndex + length > text.Length)
        {
            throw new ArgumentOutOfRangeException("Index and length must refer to a location within the string.");
        }

        StringBuilder substring = new StringBuilder();

        for (int i = startIndex; i < startIndex + length; i++)
        {
            substring.Append(text[i]);
        }

        return substring;
    }

    public static StringBuilder Substring(this StringBuilder text, int startIndex)
    {
        if (startIndex > text.Length)
        {
            throw new ArgumentOutOfRangeException("Index and length must refer to a location within the string.");
        }

        StringBuilder substring = new StringBuilder();

        for (int i = startIndex; i < text.Length; i++)
        {
            substring.Append(text[i]);
        }

        return substring;
    }
    static void Main()
    {
        StringBuilder text = new StringBuilder();
        text.Append("123456789");

        Console.WriteLine(text.Substring(3, 3));
        Console.WriteLine(text.Substring(3));
    }
}

