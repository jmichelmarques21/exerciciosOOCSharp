using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exerciciosOO{
    public class Pedido{
        public string data { get; set; }
        List<Cliente> clientes = new List<Cliente>();

        public Pedido(string data, Cliente cliente) {
            this.data = data;
            clientes.Add(cliente);
        }

        public void exibirDetalhes(){
            System.Console.Write($"Data do pedido: {data} - Cliente: ");
            foreach (var cliente in clientes){
                System.Console.Write(cliente);
            }
        }

    }
}