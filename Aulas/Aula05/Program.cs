namespace Aula05
{ 
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("==========Calculadora Bem Simples=========");
            Console.WriteLine("Digite o número 1: ");
            int number1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o número 2: ");
            int number2 = Convert.ToInt32(Console.ReadLine());

            int sum = number1 + number2;
            int subtraction = number2 - number1;
            int multiplication = number1 * number2;
            int division = number2 / number1;
            int module = number2 % number1;

            Console.WriteLine("O valor da soma é: " + sum);
            Console.WriteLine("O valor da subtração é: " + subtraction);
            Console.WriteLine("O valor da multiplicação é: " + multiplication);
            Console.WriteLine("O valor da divisão é: " + division);
            Console.WriteLine("O resto da divisão é: " + module);
        }
    }
}