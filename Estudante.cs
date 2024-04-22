using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exerciciosOO {
    public class Estudante {
        public string matricula { get; set; }
        public string nome { get; set; }
        public int idade { get; set; }

        public Estudante(string matricula, string nome, int idade) {
            this.matricula = matricula;
            this.nome = nome;
            this.idade = idade;
        }

       public void exibirDetalhes(){
        System.Console.WriteLine($"Matrícula: {matricula} - Nome: {nome} - Idade: {idade} anos.");
       }
    }
}