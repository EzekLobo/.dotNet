
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
       

    

    }

    static void ImprimirAdvogados(IEnumerable<Advogado> advogados)
    {
        foreach (var advogado in advogados)
        {
            Console.WriteLine($"Advogado: {advogado.Nome}, CPF: {advogado.CPF}, CNA: {advogado.CNA}");
        }
    }

   
}
