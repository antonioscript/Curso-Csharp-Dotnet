namespace Aula26;

public class Program
{
    public static void Main()
    {
        //Instância da Classe
        Cake cake = new Cake();

        Console.WriteLine($"Sabor: {cake.Flavor}");
        Console.WriteLine($"Recheio: {cake.Filling}");
        Console.WriteLine($"Cobertura: {cake.Coverage}");
        Console.WriteLine($"Camadas: {cake.Layers}");
        Console.WriteLine($"Tamanho: {cake.Size}");

        
    }
}