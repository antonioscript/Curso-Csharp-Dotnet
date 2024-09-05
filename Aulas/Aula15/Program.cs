namespace Aula15;
public class Program
{
    public static void Main()
    {
        //Coleções (listas)
        List<int> numberList = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10};

        foreach (int number in numberList)
        {
            //Faça algo
            Console.WriteLine(number);
        }

    }
}