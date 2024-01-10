using System;

class Programa
{
    static void Main()
    {
        GerenciadorEstoque gerenciadorEstoque = new GerenciadorEstoque();

        while (true)
        {
            Console.WriteLine("1. Cadastrar Produto");
            Console.WriteLine("2. Consultar Produto por Código");
            Console.WriteLine("3. Atualizar Estoque");
            Console.WriteLine("4. Relatórios");
            Console.WriteLine("5. Sair");

            Console.Write("Escolha uma opção: ");
            int opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    gerenciadorEstoque.CadastrarProduto();
                    break;
                case 2:
                    gerenciadorEstoque.ConsultarProduto();
                    break;
                case 3:
                    gerenciadorEstoque.AtualizarEstoque();
                    break;
                case 4:
                    gerenciadorEstoque.GerarRelatorios();
                    break;
                case 5:
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Opção inválida. Tente novamente.");
                    break;
            }
        }
    }
}
