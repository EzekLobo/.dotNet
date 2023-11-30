using System;

public class Advogado
{
    public string Nome { get; set; }
    public DateTime DataNascimento { get; set; }
    private string cpf;
    public string CPF
    {
        get => cpf;
        set => cpf = ValidarCPF(value) ? value : throw new ArgumentException("CPF inválido");
    }
    public string CNA { get; set; }

    public Advogado(string nome, DateTime dataNascimento, string cpf, string cna)
    {
        Nome = nome;
        DataNascimento = dataNascimento;
        CPF = cpf;
        CNA = cna;
    }

    private bool ValidarCPF(string cpf)
    {
        return cpf.Length == 11 && cpf.All(char.IsDigit);
    }
}
