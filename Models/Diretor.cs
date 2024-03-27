using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exemplo_poo.Models
{
    public class Diretor : Professor
    {
        //O metodo Apresentar() da classe Professor, foi sobrescrito para a classe Diretor, mas não pode ser sobrescrito devido a palavra reservada "sealed"
        //utilizada no metodo Apresentar() da classa Pessoa
        
        // public override void Apresentar()
        // {
        //     Console.WriteLine($"Diretor");
        //     Console.WriteLine($"e-mail: {Email}\n------------------------------------------");
        // }
    }
}