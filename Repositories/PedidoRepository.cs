using System.Collections.Generic;
using System.Linq;
using ProvaPraticaPOO.Classes;
using ProvaPraticaPOO.Repositories.Interfaces;

namespace ProvaPraticaPOO.Repositories
{
    public class PedidoRepository : IRepository<Pedido>
    {
        private readonly List<Pedido> _pedidos = new List<Pedido>();

        public void Adicionar(Pedido pedido)
        {
            _pedidos.Add(pedido);
        }

        public Pedido ObterPorId(int id)
        {
            return _pedidos.FirstOrDefault(p => p.Id == id);
        }

        public List<Pedido> ObterTodos()
        {
            return _pedidos;
        }
    }
}