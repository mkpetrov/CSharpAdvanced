﻿using System;
using System.IO;

class OddLines
{
    static void Main()
    {
        using (StreamReader reader = new StreamReader("text.txt"))
        {
            string line;
            int lineCounter = 0;
            while ((line = reader.ReadLine()) != null)
            {
                if (lineCounter % 2 == 0)
                {
                    Console.WriteLine(line);
                }
                lineCounter++;
            }
        }
    }
}