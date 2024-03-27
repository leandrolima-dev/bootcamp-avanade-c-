using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exemplo_poo.Models
{
    //Abstract - classe abstrata, serve como um "molde", não pode ser instanciada "new()"
    public abstract class Conta
    {
        //Protected para que a classe filha possa acessar
        protected decimal saldo;
        public abstract void Creditar(decimal valor);

        public void ExibirSaldo()
        {
            Console.WriteLine($"Seu saldo atual é de R${saldo.ToString("F2")}.");
        }
    }
}