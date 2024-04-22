using System.Runtime.ConstrainedExecution;
using exerciciosOO;

public class Program {
  public static void Main(string[] args){

    Carro carro1 = new Carro();
    carro1.marca = "Volkswagen";
    carro1.modelo = "Fusca";
    carro1.ano = 1974;

    carro1.exibirDetalhes();

    System.Console.WriteLine();
    System.Console.WriteLine();

    Livro livro1 = new Livro("A Revolução dos Bichos", "George Orwell");
    Livro livro2 = new Livro("Laranja Mecânica", "Anthony Burgess");

    Pessoa pessoa1 = new Pessoa("08048163950", "Jean Michel Marques");
    pessoa1.adicionarLivro(livro1);
    pessoa1.adicionarLivro(livro2);

    pessoa1.imprimirLivros();
    System.Console.WriteLine();
    System.Console.WriteLine();

    Estudante estudante1 = new Estudante("A101","Jean Michel Marques", 30);

    estudante1.exibirDetalhes();

    System.Console.WriteLine();
    System.Console.WriteLine();

    Cliente cliente1 = new Cliente("08048163950", "Jean Michel Marques");

    Pedido pedido1 = new Pedido("22/04/2024", cliente1);

    pedido1.exibirDetalhes();

  }
}