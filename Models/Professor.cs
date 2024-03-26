using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exemplo_poo.Models
{
    public class Professor : Pessoa
    {
        public decimal Salario {get; set;}
        //POO - Herança/ Polimorfismo
        public override void Apresentar()
        {
            Console.WriteLine($"Meu nome é {Nome}, e tenho {Idade} anos!\nSalario: {Salario.ToString("F2")}");
            Console.WriteLine($"e-mail: {Email}\n------------------------------------------");
        }
    }
}