using System;
using System.Collections.Generic;
using System.Linq;

class Programa
{
    static List<ItemTarefa> tarefas = new List<ItemTarefa>();

    static void Main()
    {
        while (true)
        {
            Console.WriteLine("----- Sistema de Gerenciamento de Tarefas -----");
            Console.WriteLine("1. Criar Tarefa");
            Console.WriteLine("2. Listar Tarefas Pendentes");
            Console.WriteLine("3. Listar Tarefas Concluídas");
            Console.WriteLine("4. Marcar Tarefa como Concluída");
            Console.WriteLine("5. Excluir Tarefa");
            Console.WriteLine("6. Pesquisar Tarefas por Palavra-Chave");
            Console.WriteLine("7. Exibir Estatísticas");
            Console.WriteLine("8. Sair");

            Console.Write("Escolha uma opção: ");
            string? escolha = Console.ReadLine();

            switch (escolha)
            {
                case "1":
                    CriarTarefa();
                    break;
                case "2":
                    ListarTarefasPendentes();
                    break;
                case "3":
                    ListarTarefasConcluidas();
                    break;
                case "4":
                    MarcarTarefaComoConcluida();
                    break;
                case "5":
                    ExcluirTarefa();
                    break;
                case "6":
                    PesquisarTarefas();
                    break;
                case "7":
                    ExibirEstatisticas();
                    break;
                case "8":
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Opção inválida. Tente novamente.");
                    break;
            }
        }
    }

    static void CriarTarefa()
    {
        Console.Write("Título da Tarefa: ");
        string? titulo = Console.ReadLine();

        Console.Write("Descrição da Tarefa: ");
        string? descricao = Console.ReadLine();

        Console.Write("Data de Vencimento (dd/mm/yyyy): ");
        if (DateTime.TryParse(Console.ReadLine(), out DateTime dataVencimento))
        {
            ItemTarefa novaTarefa = new ItemTarefa(titulo, descricao, dataVencimento);
            tarefas.Add(novaTarefa);
            Console.WriteLine("Tarefa criada com sucesso!");
        }
        else
        {
            Console.WriteLine("Formato de data inválido. A tarefa não foi criada.");
        }
    }

    static void ListarTarefasPendentes()
    {
        var tarefasPendentes = tarefas.Where(t => !t.EstaConcluida);
        ImprimirTarefas("Tarefas Pendentes", tarefasPendentes);
    }

    static void ListarTarefasConcluidas()
    {
        var tarefasConcluidas = tarefas.Where(t => t.EstaConcluida);
        ImprimirTarefas("Tarefas Concluídas", tarefasConcluidas);
    }

    static void MarcarTarefaComoConcluida()
    {
        Console.Write("Informe o ID da tarefa a ser marcada como concluída: ");
        if (int.TryParse(Console.ReadLine(), out int idTarefa))
        {
            var tarefa = tarefas.FirstOrDefault(t => t.Id == idTarefa);
            if (tarefa != null)
            {
                tarefa.MarcarComoConcluida();
                Console.WriteLine("Tarefa marcada como concluída!");
            }
            else
            {
                Console.WriteLine("ID de tarefa inválido.");
            }
        }
        else
        {
            Console.WriteLine("ID de tarefa inválido.");
        }
    }

    static void ExcluirTarefa()
    {
        Console.Write("Informe o ID da tarefa a ser excluída: ");
        if (int.TryParse(Console.ReadLine(), out int idTarefa))
        {
            var tarefa = tarefas.FirstOrDefault(t => t.Id == idTarefa);
            if (tarefa != null)
            {
                tarefas.Remove(tarefa);
                Console.WriteLine("Tarefa excluída com sucesso!");
            }
            else
            {
                Console.WriteLine("ID de tarefa inválido.");
            }
        }
        else
        {
            Console.WriteLine("ID de tarefa inválido.");
        }
    }

    static void PesquisarTarefas()
    {
        Console.Write("Digite uma palavra-chave para pesquisa: ");
        string palavraChave = Console.ReadLine()?.ToLower() ?? string.Empty;
        var tarefasEncontradas = tarefas.Where(t => t.Titulo.ToLower().Contains(palavraChave) || t.Descricao.ToLower().Contains(palavraChave));
        ImprimirTarefas("Tarefas Encontradas", tarefasEncontradas);
    }

    static void ExibirEstatisticas()
    {
        Console.WriteLine($"Número de Tarefas Pendentes: {tarefas.Count(t => !t.EstaConcluida)}");
        Console.WriteLine($"Número de Tarefas Concluídas: {tarefas.Count(t => t.EstaConcluida)}");

        if (tarefas.Any())
        {
            var tarefaMaisAntiga = tarefas.OrderBy(t => t.DataVencimento).First();
            var tarefaMaisRecente = tarefas.OrderByDescending(t => t.DataVencimento).First();

            Console.WriteLine($"Tarefa mais antiga: {tarefaMaisAntiga}");
            Console.WriteLine($"Tarefa mais recente: {tarefaMaisRecente}");
        }
    }

    static void ImprimirTarefas(string cabecalho, IEnumerable<ItemTarefa> listaTarefas)
    {
        Console.WriteLine($"----- {cabecalho} -----");

        foreach (var tarefa in listaTarefas)
        {
            Console.WriteLine(tarefa);
        }

        Console.WriteLine();
    }
}

class ItemTarefa
{
    private static int contadorId = 1;

    public int Id { get; }
    public string Titulo { get; }
    public string Descricao { get; }
    public DateTime DataVencimento { get; }
    public bool EstaConcluida { get; private set; }

    public ItemTarefa(string titulo, string descricao, DateTime dataVencimento)
    {
        Id = contadorId++;
        Titulo = titulo;
        Descricao = descricao;
        DataVencimento = dataVencimento;
        EstaConcluida = false;
    }

    public void MarcarComoConcluida()
    {
        EstaConcluida = true;
    }

    public override string ToString()
    {
        return $"ID: {Id}, Título: {Titulo}, Descrição: {Descricao}, Data de Vencimento: {DataVencimento.ToShortDateString()}, Concluída: {EstaConcluida}";
    }
}
