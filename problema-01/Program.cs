﻿using System;

class Program
{
    static void Main()
    {
        for (int i = 0; i <= 30; i++)
        {
            if (i % 3 == 0 || i % 4 == 0)
            {
                Console.WriteLine(i);
            }
        }
    }
}
