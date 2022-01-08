using System;

public class XENLONGAO
{
    var N = int.Parse(Console.ReadLine());

    for(int i = 0; i<N; i++)
    {
        var esf = int.Parse(Console.ReadLine());
        Console.WriteLine(esf - Math.Floor(Math.Sqrt(esf)));
    }
}
