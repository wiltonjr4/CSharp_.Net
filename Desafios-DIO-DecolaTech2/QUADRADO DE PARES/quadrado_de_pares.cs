using System;

public class QUADRADO_DE_PARES
{
    int n = int.Parse(Console.ReadLine());
   
    for (int i = 1; i <= n; i++)
    {
        if (i % 2 == 0)
        {
            Console.WriteLine(Math.Pow(i, 2));
        }
    }
}
