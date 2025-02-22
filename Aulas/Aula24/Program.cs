namespace Aula24;
public class Program
{
    public static void Main()
    {
        //1. Criar instância da classe Person
        Person person = new Person();
        person.Name = "João da Silva";

        //2. Métodos
        Console.WriteLine("Digite uma idade: ");
        int age = Convert.ToInt32(Console.ReadLine());

        //3.Chamando o método e guardando o resultado
        string response = person.IfLegalPersonRefactorName(age, person.Name);

        Console.WriteLine(response);

    }
}
