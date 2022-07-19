using System;

class Patern 
{
    static void Main()
    {
        Console.WriteLine("Enter number:- ");
        int rows = Convert.ToInt32(Console.ReadLine());
        for (int i = 1; i <= rows; i++)
        {
            for (int j = 1; j <= rows - i; j++)
            {
                Console.Write(" ");
            }
            for (int k = 1; k <= i; k++)
            {
                Console.Write("*" + " ");
            }
            Console.WriteLine();
        }
        
    }
}

