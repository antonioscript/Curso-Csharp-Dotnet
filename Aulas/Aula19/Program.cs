namespace Aula19;
using System.IO;

public class Program
{
    public static void Main()
    {
        //1. Estrutura
        string path = @"C:\Users\Antônio Rocha\source\repos\Youtube\Curso-Csharp-Dotnet\Aulas\Aula19\";
        string fileName = "shopping_list.txt";
        string filePath = path + fileName;

        List<string> shoopingList = new List<string>();

        //Lógica
        if (File.Exists(filePath)) 
        { 
            shoopingList.AddRange(File.ReadAllLines(filePath));
        }

        while (true)
        {
            Console.WriteLine("\n=== Lista de Compras ===");
            Console.WriteLine("1. Adicionar item");
            Console.WriteLine("2. Remover item");
            Console.WriteLine("3. Exibir Lista");
            Console.WriteLine("4. Exportar lista em .txt");
            Console.WriteLine("Escolha um número para continuar:");

            string choiceUser = Console.ReadLine();

            switch(choiceUser)
            {
                case "1":
                    Console.WriteLine("Digite o nome do item para adicionar: ");
                    string itemInsert = Console.ReadLine();

                    if (!string.IsNullOrEmpty(itemInsert))
                    {
                        shoopingList.Add(itemInsert);
                        Console.WriteLine($"Item '{itemInsert}' adicionado com sucesso!");
                    }
                    else
                    {
                        Console.WriteLine("O item não pode ser vazio!");
                    }
                break;

                case "2":
                    Console.WriteLine("Digite o nome do item para remover: ");
                    string itemToRemove = Console.ReadLine();

                    if (shoopingList.Remove(itemToRemove))
                    {
                        Console.WriteLine($"Item '{itemToRemove}' Removido com sucesso!");
                    }
                    else
                    {
                        Console.WriteLine($"Item '{itemToRemove}' não encontrado!");
                    }
                break;

                case "3":
                    Console.WriteLine("\nItens na sua Lista de Compras: ");

                    if (shoopingList.Count == 0)
                    {
                        Console.WriteLine("Sua lista está vazia!");
                    }
                    else
                    {
                        for (int i = 0; i < shoopingList.Count; i++)
                        {
                            Console.WriteLine($"{i + 1}. {shoopingList[i]}");
                        }
                    }
                break;

                case "4":
                    File.WriteAllLines(filePath, shoopingList);
                    Console.WriteLine("Lista salva com sucesso! Saindo...");
                    return;

                default:
                    Console.WriteLine("Opção da Inválida. Tente novamente");
                break;
            }

        }
    }
}