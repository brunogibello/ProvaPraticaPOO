namespace ProvaPraticaPOO.Services
{
    using ProvaPraticaPOO.Classes;
    using ProvaPraticaPOO.Services.Descontos;
    using System.Linq;

    public class PedidoService
    {
        private readonly IDescontoStrategy _descontoStrategy;

        public PedidoService(IDescontoStrategy descontoStrategy)
        {
            _descontoStrategy = descontoStrategy;
        }

        public void ProcessarPedido(Pedido pedido)
        {
            decimal total = pedido.Itens.Sum(item => item.Subtotal());
            decimal desconto = _descontoStrategy.CalcularDesconto(pedido);

            decimal totalComDesconto = total - desconto;
            pedido.AtualizarValorTotal(totalComDesconto);
        }
    }
}