using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

//POO - Encapsulamento
namespace exemplo_poo.Models
{
    public class ContaCorrente
    {
        public ContaCorrente(int numeroConta, decimal saldoInicial)
        {
            NumeroConta = numeroConta;
            saldo = saldoInicial;
        }
        public int NumeroConta { get; set; }

        private decimal saldo;

        public void Sacar(decimal valor)
        {
            if (saldo >= valor)
            {
                saldo -= valor;
                Console.WriteLine($"Saque de R${valor.ToString("F2")} efetuado com sucesso");
            }
            else
            {
                Console.WriteLine($"Saldo insuficiente para o saque de R${valor.ToString("F2")}");
            }
        }
        public void ExibirSaldo()
        {
            Console.WriteLine($"Seu saldo atual é de R${saldo.ToString("F2")}.");
        }
    }
}