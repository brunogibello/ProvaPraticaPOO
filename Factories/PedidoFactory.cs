using System;
using System.Collections.Generic;
using ProvaPraticaPOO.Classes;

namespace ProvaPraticaPOO.Factories
{
    public class PedidoFactory : IPedidoFactory
    {
        public Pedido CriarPedido(int id, Cliente cliente, List<ItemPedido> itens)
        {
            var pedido = new Pedido(id, cliente, itens, DateTime.Now);
            return pedido;
        }
    }
}