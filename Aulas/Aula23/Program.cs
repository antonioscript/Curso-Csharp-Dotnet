namespace Aula23;
public class Program
{
    public static void Main()
    {
        //1. Criar a instância bank
        var bankPraiano = new Bank();
        bankPraiano.Name = "Banco Praiano";
        bankPraiano.Id = 02545;


        //2. Chamando Método da instância da classe Bank
        bankPraiano.RequestNewCard();
    }
}
