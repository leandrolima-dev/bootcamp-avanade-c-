using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exemplo_poo.Models
{
    //Sealed - Classe Professor herda de Pessoa, mas não pode ser herdada devido a palavra reservada "sealed"
    public sealed class Professor : Pessoa
    {
        //Construtor herdado da classe Pessoa

        // public Professor(string nome) : base(nome)
        // {
        // }

        public decimal Salario { get; set; }
        //POO - Herança/ Polimorfismo
        public override void Apresentar()
        {
            Console.WriteLine($"Meu nome é {Nome}, e tenho {Idade} anos!\nSalario: {Salario.ToString("F2")}");
            Console.WriteLine($"e-mail: {Email}\n------------------------------------------");
        }
    }
}