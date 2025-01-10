namespace Aula16;
public class Program
{
    public static void Main()
    {
        string separator = "----------------";

        //1. Declaração de Array inicializando com valores
        string[] fruits = { "Maçã", "Banana", "Caju", "Manga"};

        //2. Acessar os valores
        Console.WriteLine(fruits[0]);

        Console.WriteLine(separator);

        foreach (string fruit in fruits)
        {
            Console.WriteLine(fruit);
        }

        Console.WriteLine(separator);

        //3. Contagem de Índices
        Console.WriteLine("Quantidade de Índices: " + fruits.Length);

        Console.WriteLine(separator);

        //4. Alterar os valores
        Console.WriteLine("Valor antes da alteração: " + fruits[1]);

        fruits[1] = "Abacaxi";

        Console.WriteLine("Valor depois da alteração: " + fruits[1]);

        Console.WriteLine(separator);

        //5. Declaração sem inicializar
        int[] numbers = new int[4];
        numbers[0] = 10;
        numbers[1] = 20;
        numbers[2] = 30;
        numbers[3] = 40;

        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }

    }
}