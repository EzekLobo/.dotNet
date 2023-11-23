using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite um número: ");
        int num = Convert.ToInt32(Console.ReadLine());
        long[] fatoriais = new long[num + 1];
        fatoriais[0] = 1;
        for (int i = 1; i <= num; i++)
        {
            fatoriais[i] = i * fatoriais[i - 1];
        }
        Console.WriteLine($"O fatorial de {num} é {fatoriais[num]}");
    }
}
