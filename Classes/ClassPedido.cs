using System;
using System.Collections.Generic;

namespace ProvaPraticaPOO.Classes
{
    public class Pedido
    {
        public int Id { get; set; }
        public Cliente Cliente { get; set; }
        public List<ItemPedido> Itens { get; set; }
        public DateTime Data { get; set; }
        public decimal ValorTotal { get; set; }

        public Pedido(int id, Cliente cliente, List<ItemPedido> itens, DateTime data)
        {
            Id = id;
            Cliente = cliente ?? throw new ArgumentNullException(nameof(cliente));
            Itens = itens ?? throw new ArgumentNullException(nameof(itens));

            if (itens.Count == 0)
                throw new ArgumentException("Pedido deve conter pelo menos um item.");

            Data = data;
            ValorTotal = 0;
        }
        public void AtualizarValorTotal(decimal total)
        {
            ValorTotal = total;
        }
    }
}
