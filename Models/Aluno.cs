using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

//POO - Herança
namespace exemplo_poo.Models
{
    public class Aluno : Pessoa
    {
        public decimal Nota {get; set;}
        //POO - Herança/ Polimorfismo
        public override void Apresentar()
        {
            Console.WriteLine($"Meu nome é {Nome}, e tenho {Idade} anos!\nNota: {Nota}");
            Console.WriteLine($"e-mail: {Email}\n------------------------------------------");
        }
    }
}