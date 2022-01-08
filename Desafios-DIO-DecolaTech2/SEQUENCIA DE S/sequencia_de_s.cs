using System;

public class SEQUENCIA_DE_S
{
    double S = 0;
    for(double i = 1; i <= 100; i++)
    {
        S += 1 / i;
    }
    Console.WriteLine(Math.Round(S, 2));
}
