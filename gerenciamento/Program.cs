
public class Program{
    public class Pessoa
{
    public string Nome { get; set; }
    public DateTime DataNascimento { get; set; }
    public string CPF { get; set; }

    public Pessoa(string nome, DateTime dataNascimento, string cpf)
    {
        Nome = nome;
        DataNascimento = dataNascimento;
        CPF = cpf;
    }
}

public class Advogado : Pessoa
{
    public string OAB { get; set; }

    public Advogado(string nome, DateTime dataNascimento, string cpf, string oab)
        : base(nome, dataNascimento, cpf)
    {
        OAB = oab;
    }
}

public class Cliente : Pessoa
{
    public string EstadoCivil { get; set; }
    public string Profissao { get; set; }

    public Cliente(string nome, DateTime dataNascimento, string cpf, string estadoCivil, string profissao)
        : base(nome, dataNascimento, cpf)
    {
        EstadoCivil = estadoCivil;
        Profissao = profissao;
    }
}

public class EscritorioDeAdvocacia
{
    private List<Advogado> advogados;
    private List<Cliente> clientes;

    public EscritorioDeAdvocacia()
    {
        advogados = new List<Advogado>();
        clientes = new List<Cliente>();
    }

    public void AdicionarA




}