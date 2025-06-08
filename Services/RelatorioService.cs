using ProvaPraticaPOO.Classes;
using ProvaPraticaPOO.Logging;
using System;
using System.Collections.Generic;

namespace ProvaPraticaPOO.Services
{
    public class RelatorioService
    {
        private readonly ILogService _log;

        public RelatorioService(ILogService log)
        {
            _log = log;
        }

        public void ExibirRelatorio(List<Pedido> pedidos)
        {
            _log.LogInfo("RELATÓRIO DE PEDIDOS");

            foreach (var pedido in pedidos)
            {
                Console.WriteLine($"\nPedido ID: {pedido.Id}");
                Console.WriteLine($"Cliente: {pedido.Cliente.Nome} ({pedido.Cliente.Email})");
                Console.WriteLine($"Data: {pedido.Data.ToShortDateString()}");
                Console.WriteLine("Itens:");

                foreach (var item in pedido.Itens)
                {
                    Console.WriteLine($" - {item.Produto.Nome} x{item.Quantidade} - Subtotal: R$ {item.Subtotal():F2}");
                }

                Console.WriteLine($"Valor Total: R$ {pedido.ValorTotal:F2}");
                Console.WriteLine(new string('-', 40));
            }

            _log.LogInfo("FIM DO RELATÓRIO");
        }
    }
}