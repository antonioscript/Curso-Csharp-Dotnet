namespace Aula25
{
    public class BankOperations
    {
        decimal balance = 1000;

        public void CheckBalance()
        {
            Console.WriteLine($"\nSeu saldo é de R$ {balance}");
        }

        public void Deposit()
        {
            Console.WriteLine("informe o valor a ser depositado: R$ ");

            if ( decimal.TryParse(Console.ReadLine(), out decimal amount ) && amount > 0) 
            { 
                balance += amount;
            }
            else
            {
                Console.WriteLine("Valor Inválido. Tente novamente");
            }
        }

        public void WithDraw()
        {
            Console.WriteLine("informe o valor a ser retiado: R$ ");

            if (decimal.TryParse(Console.ReadLine(), out decimal amount) && amount > 0)
            {
                if (amount <= balance) 
                { 
                    balance = balance - amount;
                    Console.WriteLine($"Valor de R$ {amount} retirado com sucesso!");
                }
                else
                {
                    Console.WriteLine("Saldo inválido");
                }
            }
            else
            {
                Console.WriteLine("Valor Inválido. Tente novamente");
            }

        }
    }
}
