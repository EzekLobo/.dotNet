using System;

class Program
{
    static void Main()
    {
        int a = 0;
        int b = 1;

        // Primeiro número da série
        Console.WriteLine(a);

        // Segundo número da série
        Console.WriteLine(b);

        // Calcula o resto da série até passar de 100
        while (b <= 100)
        {
            int temp = a;
            a = b;
            b = temp + b;
            Console.WriteLine(b);
        }
    }
}
