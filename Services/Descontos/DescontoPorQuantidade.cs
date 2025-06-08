namespace ProvaPraticaPOO.Services.Descontos
{
    using ProvaPraticaPOO.Classes;
    using System.Linq;

    public class DescontoPorQuantidade : IDescontoStrategy
    {
        private int quantidadeMinima;
        private decimal percentualDesconto;

        public DescontoPorQuantidade(int quantidadeMinima, decimal percentualDesconto)
        {
            this.quantidadeMinima = quantidadeMinima;
            this.percentualDesconto = percentualDesconto;
        }

        public decimal CalcularDesconto(Pedido pedido)
        {
            var totalItens = pedido.Itens.Sum(item => item.Quantidade);

            if (totalItens >= quantidadeMinima)
            {
                var total = pedido.Itens.Sum(item => item.Subtotal());
                return total * percentualDesconto;
            }

            return 0;
        }
    }
}