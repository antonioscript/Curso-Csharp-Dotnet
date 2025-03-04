namespace Aula25
{
    public class BankTerminal
    {
        //Instância da classe BamkOperations
        BankOperations bank = new BankOperations();


        public void Start()
        {
            var inExecution = true;

            while (inExecution) 
            { 
                DisplayMenu();
                string option = Console.ReadLine();

                if(option == "1")
                {
                    bank.CheckBalance();
                }
                else if(option == "2") 
                {
                    bank.Deposit();
                }
                else if (option == "3")
                {
                    bank.WithDraw();
                }
                else
                {
                    Console.WriteLine("Saindo...");
                }

            }
        }


        public void DisplayMenu()
        {
            Console.WriteLine("======BANK======");
            Console.WriteLine("1- Checar Saldo");
            Console.WriteLine("2- Depósito");
            Console.WriteLine("3- Saque");
            Console.WriteLine("4- Sair");
        }
    }
}
