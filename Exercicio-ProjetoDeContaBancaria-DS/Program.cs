using Exercicio_ProjetoDeContaBancaria_DS;


internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("******* Testando Contá Genérica ********");

        ContaGenerica conta1 = new ContaGenerica();
        conta1.Banco = 1;               // Banco do Brasil
        conta1.Agencia = "0896-6";      //Agência de Barra Bonita
        conta1.Conta = "16589-3";       //Número da conta
        conta1.depositar(200);
        conta1.exibirConta();
        conta1.depositar(-100);         // Tentando depositar valor inválido
        conta1.exibirConta();
        conta1.sacar(70);
        conta1.exibirConta();
        conta1.sacar(200);              //Tentando sacar mais dinheiro do que tem no saldo    
        conta1.exibirConta();

        ContaGenerica conta2 = new ContaGenerica();
        conta2.Banco = 237;
        conta2.Agencia = "6587-2";
        conta2.Conta = "17444-9";
        conta2.depositar(600);
        conta2.exibirConta();

        Console.WriteLine("\n\n****************** Testando Conta Corrente ******\n");

        ContaCorrente conta3 = new ContaCorrente();
        conta3.Banco = 341;
        conta3.Agencia = "0425";
        conta3.Conta = "36958-7";
        conta3.depositar(300);
        conta3.Limite = 500;
        conta3.exibirConta();
        conta3.sacar(500);
        conta3.exibirConta();

    }
}