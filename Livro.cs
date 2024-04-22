using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exerciciosOO {
    public class Livro{
        public string titulo { get; set; }
        public string autor { get; set; }

        public Livro(string titulo, string autor){
            this.titulo = titulo;
            this.autor = autor;
        }

    public override string ToString(){
        return $"Título: {titulo} - Autor: {autor}";
    }
}

}