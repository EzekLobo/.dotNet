
using System;

using System;

public class Cliente
{
    public string Nome { get; set; }
    public DateTime DataNascimento { get; set; }
    private string cpf;
    public string CPF
    {
        get => cpf;
        set => cpf = ValidarCPF(value) ? value : throw new ArgumentException("CPF inválido");
    }
    public EstadoCivil EstadoCivil { get; set; }
    public string Profissao { get; set; }

    public Cliente(string nome, DateTime dataNascimento, string cpf, EstadoCivil estadoCivil, string profissao)
    {
        Nome = nome;
        DataNascimento = dataNascimento;
        CPF = cpf;
        EstadoCivil = estadoCivil;
        Profissao = profissao;
    }

    private bool ValidarCPF(string cpf)
    {
        return cpf.Length == 11 && cpf.All(char.IsDigit);
    }
    
}
