using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

//POO - Abstração
namespace exemplo_poo.Models
{
    public class Pessoa
    {
        //POO - Herança do construtor para as classes filhas
        // public Pessoa(string nome)
        // {
        //     Nome = nome;
        // }
        public string? Nome { get; set; }
        public int Idade { get; set; }
        public string? Email { get; set; }

//POO - Herança/ Polimorfismo
        public virtual void Apresentar()
        {
            Console.WriteLine($"Meu nome é {Nome}, e tenho {Idade} anos");
            Console.WriteLine($"e-mail: {Email}\n------------------------------------------");
        }
    }
}
