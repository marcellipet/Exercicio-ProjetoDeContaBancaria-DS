using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_ProjetoDeContaBancaria_DS
{
    internal class ContaCorrente : ContaGenerica
    {
        public double Limite { get; set; }

        public override void exibirConta()
        {
   
            Console.WriteLine("--------------------------------------");
            Console.WriteLine($"Banco: {Banco}\t Agência: {Agencia}\t Conta: {Conta}");
            Console.WriteLine($"Saldo: R$ {obterSaldo()} + Limite {Limite} = R$ {obterSaldo()+Limite}");
            Console.WriteLine("--------------------------------------");
        }

        public override void sacar(double valor)
        {
            if (valor <= obterSaldo() + Limite)
            {
                double novoSaldo = obterSaldo() - valor;
                definirSaldo(novoSaldo);
                Console.WriteLine($"Saque realizado com sucesso: R$ {valor}");
            }
            else
            {
                Console.WriteLine($"Valor inválido. O saque não foi realizado!");
            }
        }
    }
}
