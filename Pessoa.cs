using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exerciciosOO{
    public class Pessoa{
        public string cpf { get; set; }
        public string nome { get; set;}

        List<Livro> livros { get; set; }

        public Pessoa(string cpf, string nome) {
            this.cpf = cpf;
            this.nome = nome;
            livros  = new List<Livro>();
        }

        public void adicionarLivro(Livro livro) {
            livros.Add(livro);
        }

        public void imprimirLivros(){
            System.Console.WriteLine($"Livros de {nome} (CPF: {cpf}): ");
            foreach (var livro in livros){
                System.Console.WriteLine(livro);
            }
        }
    }
}