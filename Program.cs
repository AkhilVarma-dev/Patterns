﻿using System;

class Pattern
 {
     static void Main()
    {
        for (int i = 1; i <= 5; i++ )
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write(j + " ");
            }
            Console.WriteLine();
            
        }

    }

}

