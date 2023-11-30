
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        EscritorioAdvocacia escritorio = new EscritorioAdvocacia();

        List<Advogado> advogados = new List<Advogado>
        {
            new Advogado("José", new DateTime(1985, 10, 15), "12345678901", "CNA123"),
            new Advogado("Maria", new DateTime(1990, 5, 20), "98765432101", "CNA456")
        };

        List<Cliente> clientes = new List<Cliente>
        {
            new Cliente("João", new DateTime(1988, 3, 25), "11122233344", EstadoCivil.Solteiro, "Engenheiro"),
            new Cliente("Ana", new DateTime(1995, 8, 10), "55566677788", EstadoCivil.Casado, "Médico")
        };

        Console.WriteLine("Relatório 1: Advogados com idade entre 30 e 40 anos");
        var advogadosPorIdade = escritorio.ObterAdvogadosPorIdade(30, 40);
        ImprimirAdvogados(advogadosPorIdade);

    

    }

    static void ImprimirAdvogados(IEnumerable<Advogado> advogados)
    {
        foreach (var advogado in advogados)
        {
            Console.WriteLine($"Advogado: {advogado.Nome}, CPF: {advogado.CPF}, CNA: {advogado.CNA}");
        }
    }

   
}
