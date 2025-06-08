    using ProvaPraticaPOO.Classes;
    using ProvaPraticaPOO.Services.Descontos;
    using ProvaPraticaPOO.Logging;
    using System.Linq;

namespace ProvaPraticaPOO.Services
{
    public class PedidoService
    {
        private readonly IDescontoStrategy _descontoStrategy;
        private readonly ILogService _log;

        public PedidoService(IDescontoStrategy descontoStrategy, ILogService log)
        {
            _descontoStrategy = descontoStrategy;
            _log = log;
            
        }

        public void ProcessarPedido(Pedido pedido)
        {
            _log.LogInfo($"Processando pedido ID {pedido.Id} para cliente {pedido.Cliente.Nome}");

            decimal total = pedido.Itens.Sum(item => item.Subtotal());
            _log.LogInfo($"Valor bruto do pedido: R$ {total:F2}");

            decimal desconto = _descontoStrategy.CalcularDesconto(pedido);
            _log.LogInfo($"Desconto aplicado: R$ {desconto:F2}");


            decimal totalComDesconto = total - desconto;
            pedido.AtualizarValorTotal(totalComDesconto);

             _log.LogInfo($"Valor final com desconto: R$ {pedido.ValorTotal:F2}");
        }
    }
}