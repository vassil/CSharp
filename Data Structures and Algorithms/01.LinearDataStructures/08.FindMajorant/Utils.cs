using System;
using System.Collections.Generic;
using System.Linq;

public static class Utils
{
    public static int FindMajorant(this int[] array)
    {
        int majorantFormula = (array.Length / 2) + 1;
        int counter = 0;
        int theMajorant = 0;

        for (int i = 0; i < array.Length; i++)
        {
            for (int j = 0; j < array.Length; j++)
            {
                if (array[i] == array[j])
                {
                    counter++;
                }
            }
           
            if (counter == majorantFormula)
            {
                return array[i];
            }
            else
            {
                counter = 0;
            }
        }
        return -1;
    }
}