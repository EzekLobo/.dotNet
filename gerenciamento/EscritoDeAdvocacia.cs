public class EscritorioDeAdvocacia
{
    private List<Advogado> advogados;
    private List<Cliente> clientes;

    public EscritorioDeAdvocacia()
    {
        advogados = new List<Advogado>();
        clientes = new List<Cliente>();
    }

    public void AdicionarAdvogado(Advogado advogado)
    {
        advogados.Add(advogado);
    }
public void AdicionarCliente(Cliente cliente)
    {
        clientes.Add(cliente);
    }





}