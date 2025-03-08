using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_ProjetoDeContaBancaria_DS
{
    internal class ContaGenerica
    {
        //Propriedades da Classe
        public int Banco { get; set; }
        public string Agencia { get; set; }
        public string Conta { get; set; }
        private double Saldo { get; set; }

        //Métodos da Classe

        public void depositar(double valor)
        {
            if(valor >= 0)
            {
                Saldo += valor; //Saldo = Saldo + valor;
                Console.WriteLine($"Depósito realizado com sucesso: R$ {valor}");
            }
            else
            {
                Console.WriteLine($"Valor inválido. O depósito não foi realizado!");
            }
        }

        public virtual void sacar(double valor)
        {
            if (valor <= Saldo)
            {
                Saldo -= valor; // Saldo = Saldo - valor;
                Console.WriteLine($"Saque realizado com sucesso: R$ {valor}");
            }
            else
            {
                Console.WriteLine($"Valor inválido. O saque não foi realizado!");
            }
        }

        public virtual void exibirConta()
        {
            Console.WriteLine("--------------------------------------");
            Console.WriteLine($"Banco: {Banco}\t Agência: {Agencia}\t Conta: {Conta}");
            Console.WriteLine($"Saldo em conta: R$ {Saldo}");
            Console.WriteLine("--------------------------------------");
        }

        public double obterSaldo()
        {
            return Saldo;
        }

        public void definirSaldo(double valor)
        {
            Saldo = valor;
        }

    }
}
