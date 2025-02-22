namespace Aula22;
public class Program
{
    //Aplicação de Console - Ela va começar aqui
    public static void Main()
    {
        //1. Instância(objeto) da Classe Cake - 'New'
        var cakeStrawberry = new Cake();

        //2. Setar as informações do nosso bolo de morango
        cakeStrawberry.Id = 472;
        cakeStrawberry.Name = "Bolo de Morango Recheado";
        cakeStrawberry.Description = "Intolerantes a lactose, não consumir";
        cakeStrawberry.Value = 30;
        cakeStrawberry.IsFilling = true;

        //3. Mostrar ao usuário

        Console.WriteLine("Id: " + cakeStrawberry.Id);
        Console.WriteLine("Nome: " + cakeStrawberry.Name);
        Console.WriteLine("Descrição: " + cakeStrawberry.Description);
        Console.WriteLine("Valor: R$ " + cakeStrawberry.Value);
        Console.WriteLine("É recheado?: " + cakeStrawberry.IsFilling);

        Console.WriteLine("--------------------------"); 

        //-------------------------------
        //4. Instância de Bolo de Chocolate
        var cakeChocolate = new Cake();

        cakeChocolate.Id = 556;
        cakeChocolate.Name = "Bolo de Chocolate";
        cakeChocolate.Description = "Cacau meio amargo 30%";
        cakeChocolate.Value = 45;
        cakeChocolate.IsFilling = false;

        Console.WriteLine("Id: " + cakeChocolate.Id);
        Console.WriteLine("Nome: " + cakeChocolate.Name);
        Console.WriteLine("Descrição: " + cakeChocolate.Description);
        Console.WriteLine("Valor: R$ " + cakeChocolate.Value);
        Console.WriteLine("É recheado?: " + cakeChocolate.IsFilling);


        //------------------------------
        //5. Listas de Bolos
        Console.WriteLine("========================");
        Console.WriteLine("Lista de Bolos - Criação de Lista");

        List<Cake> cakeList = new List<Cake>();
        cakeList.Add(cakeStrawberry);
        cakeList.Add(cakeChocolate);

        //6. Visualizar
        foreach (Cake cake in cakeList)
        {
            Console.WriteLine("Id: " + cake.Id);
            Console.WriteLine("Nome: " + cake.Name);
            Console.WriteLine("Descrição: " + cake.Description);
            Console.WriteLine("Valor: R$ " + cake.Value);
            Console.WriteLine("É recheado?: " + cake.IsFilling);
            Console.WriteLine("-----------------------");
        }



    }
}
