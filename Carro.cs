using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exerciciosOO {   
    public class Carro {
        public string marca {get; set;}
        public string modelo {get; set;}
        public int ano {get; set;}

        public void exibirDetalhes(){
            System.Console.WriteLine($"Marca: {marca} - Modelo: {modelo} - Ano: {ano}");
        }


    }
}