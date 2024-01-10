using System;
using System.IO;

class Program
{
    static void Main()
    {
        Console.Write("Digite o caminho do arquivo: ");
        string path = Console.ReadLine();

        try
        {
            string text = File.ReadAllText(path);
            Console.WriteLine("Conteúdo do arquivo:");
            Console.WriteLine(text);
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("Erro: Arquivo não encontrado.");
        }
        catch (IOException)
        {
            Console.WriteLine("Erro: Não foi possível ler o arquivo.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Erro: {ex.Message}");
        }
    }
}
