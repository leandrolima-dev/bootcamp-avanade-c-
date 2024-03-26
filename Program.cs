
using exemplo_poo.Models;

internal class Program
{
  private static void Main(string[] args)
  {
    ContaCorrente conta = new(123, 1117);
    conta.ExibirSaldo();
    conta.Sacar(1170);
    conta.ExibirSaldo();

    // Pessoa pessoa = new();
    // pessoa.Nome = "Leandro";
    // pessoa.Idade = 38;
    // pessoa.Apresentar();
  }
}