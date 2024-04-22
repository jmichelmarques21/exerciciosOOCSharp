using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exerciciosOO{
    public class Cliente{
        public string cpf { get; set; }
        public string nome { get; set; }


        public Cliente(string cpf, string nome){
            this.cpf = cpf;
            this.nome = nome;
        }
 

        public void exibirDetalhes(){
            System.Console.WriteLine($"Nome: {nome} - CPF: {cpf}.");
        }

        public override string ToString(){
        return $"CPF: {cpf} - Nome: {nome}";
    }
    }
}