using System;
using System.Collections.Generic;
using System.Linq;

public class GerenciadorEstoque
{
    private List<Produto> estoque = new List<Produto>();

    public void CadastrarProduto()
    {
        Produto produto = new Produto();

        try
        {
            Console.Write("Código do Produto: ");
            produto.Codigo = int.Parse(Console.ReadLine());

            Console.Write("Nome do Produto: ");
            produto.Nome = Console.ReadLine();

            Console.Write("Quantidade em Estoque: ");
            produto.Quantidade = int.Parse(Console.ReadLine());

            Console.Write("Preço Unitário: ");
            produto.Preco = double.Parse(Console.ReadLine());

            estoque.Add(produto);
            Console.WriteLine("Produto cadastrado com sucesso!");
        }
        catch (FormatException)
        {
            Console.WriteLine("Erro: formato inválido. Certifique-se de inserir valores numéricos corretos.");
        }
    }

    public void ConsultarProduto()
    {
        try
        {
            Console.Write("Digite o código do produto: ");
            int codigoConsulta = int.Parse(Console.ReadLine());

            Produto produto = estoque.SingleOrDefault(p => p.Codigo == codigoConsulta);

            if (produto == null)
            {
                throw new ProdutoNaoEncontradoException();
            }

            Console.WriteLine($"Produto encontrado:\nCódigo: {produto.Codigo}, Nome: {produto.Nome}, Quantidade: {produto.Quantidade}, Preço: {produto.Preco:C}");
        }
        catch (FormatException)
        {
            Console.WriteLine("Erro: formato inválido. Certifique-se de inserir um código numérico.");
        }
        catch (ProdutoNaoEncontradoException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

    public void AtualizarEstoque()
    {
        try
        {
            Console.Write("Digite o código do produto: ");
            int codigoAtualizacao = int.Parse(Console.ReadLine());

            Produto produto = estoque.SingleOrDefault(p => p.Codigo == codigoAtualizacao);

            if (produto == null)
            {
                throw new ProdutoNaoEncontradoException();
            }

            Console.Write("Digite a quantidade a ser adicionada (+) ou removida (-): ");
            int quantidadeAtualizacao = int.Parse(Console.ReadLine());

            if (produto.Quantidade + quantidadeAtualizacao < 0)
            {
                throw new EstoqueInsuficienteException();
            }

            produto.Quantidade += quantidadeAtualizacao;
            Console.WriteLine("Estoque atualizado com sucesso!");
        }
        catch (FormatException)
        {
            Console.WriteLine("Erro: formato inválido. Certifique-se de inserir valores numéricos corretos.");
        }
        catch (ProdutoNaoEncontradoException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (EstoqueInsuficienteException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

    public void GerarRelatorios()
    {
        Console.Write("Informe o limite de quantidade para o relatório 1: ");
        int limiteQuantidade = int.Parse(Console.ReadLine());

        var relatorio1 = estoque.Where(p => p.Quantidade < limiteQuantidade);
        ImprimirRelatorio("Relatório 1 - Produtos com quantidade abaixo do limite:", relatorio1);

        Console.Write("Informe o valor mínimo para o relatório 2: ");
        double minimo = double.Parse(Console.ReadLine());
        Console.Write("Informe o valor máximo para o relatório 2: ");
        double maximo = double.Parse(Console.ReadLine());

        var relatorio2 = estoque.Where(p => p.Preco >= minimo && p.Preco <= maximo);
        ImprimirRelatorio("Relatório 2 - Produtos com valor entre mínimo e máximo:", relatorio2);

        var relatorio3 = from produto in estoque
                         let valorTotalProduto = produto.Quantidade * produto.Preco
                         select new
                         {
                             produto.Nome,
                             produto.Quantidade,
                             ValorTotal = valorTotalProduto
                         };

        Console.WriteLine("Relatório 3 - Valor total do estoque e valor total de cada produto:");
        foreach (var item in relatorio3)
        {
            Console.WriteLine($"Produto: {item.Nome}, Quantidade: {item.Quantidade}, Valor Total: {item.ValorTotal:C}");
        }
    }

    private void ImprimirRelatorio(string titulo, IEnumerable<Produto> relatorio)
    {
        Console.WriteLine(titulo);
        foreach (var produto in relatorio)
        {
            Console.WriteLine($"Código: {produto.Codigo}, Nome: {produto.Nome}, Quantidade: {produto.Quantidade}, Preço: {produto.Preco:C}");
        }
    }
}
