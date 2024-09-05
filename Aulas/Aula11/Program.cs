namespace Aula11;
public class Program
{
    public static void Main()
    {
        //Ex:1
        //bool boolValue = true;

        //switch (boolValue) 
        //{
        //    case true:
        //        Console.WriteLine("O valor é true");
        //        break;

        //    case false:
        //        Console.WriteLine("O valor é false");
        //        break;
        //}

        //Ex:2
        //Console.WriteLine("========Dia da Semana========");
        //Console.WriteLine("Digite um número de 1 a 7:");
        //int dayOfWeek = Convert.ToInt32(Console.ReadLine());

        //switch (dayOfWeek) 
        //{
        //    case 1:
        //        Console.WriteLine("O dia da semana é: Domingo");
        //        break;

        //    case 2:
        //        Console.WriteLine("O dia da semana é: Segunda-feira");
        //        break;

        //    case 3:
        //        Console.WriteLine("O dia da semana é: Terça-Feira");
        //        break;

        //    case 4:
        //        Console.WriteLine("O dia da semana é: Quarta-Feira");
        //        break;

        //    case 5:
        //        Console.WriteLine("O dia da semana é: Quinta-Feira");
        //        break;

        //    case 6:
        //        Console.WriteLine("O dia da semana é: Sexta-Feira");
        //        break;

        //    case 7:
        //        Console.WriteLine("O dia da semana é: Sábado");
        //        break;

        //    default:
        //        Console.WriteLine("O Dia escolhido é inválido");
        //        break;
        //}


        //Ex3:
        Console.WriteLine("=======Desempenho Escolar=========");
        Console.WriteLine("Digite sua nota: ");
        int score = Convert.ToInt32(Console.ReadLine());

        switch (score) 
        {
            case 10:
            case 9:
                Console.WriteLine("Ótimo");
                break;

            case 8:
            case 7:
                Console.WriteLine("Bom");
                break;

            case 6:
                Console.WriteLine("Regular");
                break;

            case 5:
                Console.WriteLine("Ruim");
                break;

            default:
                Console.WriteLine("Horrível");
                break;
        }
    }
}