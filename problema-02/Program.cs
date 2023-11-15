using System;

class Program
{
    static void Main()
    {
        // sbyte: Este é um tipo de dado integral assinado que armazena valores de -128 a 127.
        sbyte a = -100;
        Console.WriteLine($"sbyte: {a}");

        // byte: Este é um tipo de dado integral sem sinal que armazena valores de 0 a 255.
        byte b = 200;
        Console.WriteLine($"byte: {b}");

        // short: Este é um tipo de dado integral assinado que armazena valores de -32,768 a 32,767.
        short c = -30000;
        Console.WriteLine($"short: {c}");

        // ushort: Este é um tipo de dado integral sem sinal que armazena valores de 0 a 65,535.
        ushort d = 60000;
        Console.WriteLine($"ushort: {d}");

        // int: Este é um tipo de dado integral assinado que armazena valores de -2,147,483,648 a 2,147,483,647.
        int e = -2000000000;
        Console.WriteLine($"int: {e}");

        // uint: Este é um tipo de dado integral sem sinal que armazena valores de 0 a 4,294,967,295.
        uint f = 4000000000;
        Console.WriteLine($"uint: {f}");

        // long: Este é um tipo de dado integral assinado que armazena valores de -9,223,372,036,854,775,808 a 9,223,372,036,854,775,807.
        long g = -8000000000000000000;
        Console.WriteLine($"long: {g}");

        // ulong: Este é um tipo de dado integral sem sinal que armazena valores de 0 a 18,446,744,073,709,551,615.
        ulong h = 16000000000000000000;
        Console.WriteLine($"ulong: {h}");
    }
}
