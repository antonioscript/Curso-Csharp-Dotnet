
namespace Aula04;
public class Program
{ 
    public static void Main()
    {
        Console.WriteLine("--------CADASTRO DE USUÁRIO--------");

        //Solicitar o nome do Usuário
        Console.WriteLine("Digite Seu Nome: ");
        string name = Console.ReadLine();

        //Solicitar a Idade do Usuário
        Console.WriteLine("Digite Sua Idade: ");
        int age = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("-----------------------------");

        Console.WriteLine("Nome do Usuário: " + name);
        Console.WriteLine("Idade do Usuário: " + age);

    }
}