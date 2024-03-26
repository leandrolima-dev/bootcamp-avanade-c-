
using exemplo_poo.Models;

internal class Program
{
  private static void Main(string[] args)
  {
    // Pessoa pessoa = new();
    // pessoa.Nome = "Leandro";
    // pessoa.Idade = 38;
    // pessoa.Apresentar();

    // ContaCorrente conta = new(123, 1117);
    // conta.ExibirSaldo();
    // conta.Sacar(1170);
    // conta.ExibirSaldo();

    Aluno aluno = new();
    aluno.Idade = 38;
    aluno.Nome = "Leandro";
    aluno.Email = "aluno@example.com";
    aluno.Apresentar();

    Professor professor = new();
    professor.Idade = 38;
    professor.Nome = "Leonardo";
    professor.Email = "professor@example.com";
    professor.Apresentar();
  }
}