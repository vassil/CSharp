﻿using System;
using System.Collections.Generic;
using System.IO;

public static class PathStorage
{
    public static void SavePathsToFile(IReadOnlyCollection<Point3D> seqOfPoints)
    {
        using (StreamWriter writePath = new StreamWriter("Path.txt"))
        {
            foreach (var path in seqOfPoints)
            {
                writePath.WriteLine(path);
            }
        }
    }

    public static void ReadPathsFromFile()
    {
        using (StreamReader readPath = new StreamReader("Path.txt"))
        {
            string content = readPath.ReadToEnd();
            Console.WriteLine(content);
        }
    }
}
