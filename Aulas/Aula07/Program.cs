namespace Aula07;
public class Program
{ 
    public static void Main()
    {
        Console.WriteLine("=======Operadores de Atribuição=======");

        //Incializar a variável
        int x = 10;
        Console.WriteLine("\nValor Inicial da Variável de x: " + x);

        //Operador de Atribuição Simples (=)
        x = 20;
        Console.WriteLine("\nAtribuição Simples (=)");
        Console.WriteLine("Novo Valor de x: " + x);

        //Atribuição Composta (incremento) (++)
        x++; //Equivale a x = x + 1

        Console.WriteLine("\nAtribuição Composta Incremento (++)");
        Console.WriteLine("Novo Valor de x: " + x);

        //Atribuição Composta  (+=)
        x += 10; //Equivale x = x + 10

        Console.WriteLine("\nAtribuição Composta (+=)");
        Console.WriteLine("Novo Valor de x: " + x);

        //Atribuição Composta  (-=)
        x -= 10; //Equivale x = x - 10

        Console.WriteLine("\nAtribuição Composta (-=)");
        Console.WriteLine("Novo Valor de x: " + x);

        //Atribuição Composta  (*=)
        x *= 10; //Equivale x = x * 10

        Console.WriteLine("\nAtribuição Composta (*=)");
        Console.WriteLine("Novo Valor de x: " + x);

        //Atribuição Composta  (/=)
        x /= 10; //Equivale x = / * 10

        Console.WriteLine("\nAtribuição Composta (/=)");
        Console.WriteLine("Novo Valor de x: " + x);



    }
}