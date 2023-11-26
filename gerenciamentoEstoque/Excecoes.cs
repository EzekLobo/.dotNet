using System;

public class ProdutoNaoEncontradoException : Exception
{
    public ProdutoNaoEncontradoException() : base("Erro: Produto não encontrado.")
    {
    }
}

public class EstoqueInsuficienteException : Exception
{
    public EstoqueInsuficienteException() : base("Erro: Quantidade em estoque insuficiente para a operação.")
    {
    }
}
