using System;

public class SEQUENCIA_DE_IJ
{
    for (int i = 1; i <= 9; i++)
    {
        while (i % 2 != 0)
        { 
            for (int j = 7; j > 4; j--)
            {
                Console.WriteLine($"I={i} J={j}");
            }
            break;
        }
    }
}
