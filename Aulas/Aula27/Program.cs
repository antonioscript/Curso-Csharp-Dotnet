namespace Aula27;

public class Program
{
    public static void Main()
    {
        //Instância da Classe | Chocolate
        Cake cakeChocolate = new Cake("Chocolate", "Coco", "Chocolate", 3, "Médio");

        Console.WriteLine($"Sabor: {cakeChocolate.Flavor}");
        Console.WriteLine($"Recheio: {cakeChocolate.Filling}");
        Console.WriteLine($"Cobertura: {cakeChocolate.Coverage}");
        Console.WriteLine($"Camadas: {cakeChocolate.Layers}");
        Console.WriteLine($"Tamanho: {cakeChocolate.Size}");

        Console.WriteLine("--------------------");

        //Instância da Classe | Morango
        Cake cakeStrawberry = new Cake("Morango", "Moragno", "Chocolate", 1, "Pequeno");

        Console.WriteLine($"Sabor: {cakeStrawberry.Flavor}");
        Console.WriteLine($"Recheio: {cakeStrawberry.Filling}");
        Console.WriteLine($"Cobertura: {cakeStrawberry.Coverage}");
        Console.WriteLine($"Camadas: {cakeStrawberry.Layers}");
        Console.WriteLine($"Tamanho: {cakeStrawberry.Size}");

    }
}