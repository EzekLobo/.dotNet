using System;
using System.Collections.Generic;
using System.Linq;


public class EscritorioAdvocacia
{
    private List<Advogado> advogados = new List<Advogado>();
    private List<Cliente> clientes = new List<Cliente>();

    public void AdicionarAdvogado(Advogado advogado)
    {
        if (!advogados.Any(a => a.CPF == advogado.CPF) && !advogados.Any(a => a.CNA == advogado.CNA))
        {
            advogados.Add(advogado);
            Console.WriteLine($"Advogado {advogado.Nome} adicionado com sucesso.");
        }
        else
        {
            Console.WriteLine("CPF ou CNA já existentes. Advogado não adicionado.");
        }
    }
      //lembrar dos bagulho aqui
    

    private int CalcularIdade(DateTime dataNascimento)
    {
        var hoje = DateTime.Now;
        var idade = hoje.Year - dataNascimento.Year;

        if (hoje.Month < dataNascimento.Month || (hoje.Month == dataNascimento.Month && hoje.Day < dataNascimento.Day))
        {
            idade--;
        }

        return idade;
    }
}
