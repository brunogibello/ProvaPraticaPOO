namespace ProvaPraticaPOO.Services.Descontos
{
    using ProvaPraticaPOO.Classes;
    using System.Linq;

    public class DescontoPorQuantidade : IDescontoStrategy
    {
        private readonly int _quantidadeMinima;
        private readonly decimal _percentual;

        public DescontoPorQuantidade(int quantidadeMinima, decimal percentual)
        {
            _quantidadeMinima = quantidadeMinima;
            _percentual = percentual;
        }

        public decimal CalcularDesconto(Pedido pedido)
        {
           int quantidadeTotal = pedido.Itens.Sum(item => item.Quantidade);

            if (quantidadeTotal >= _quantidadeMinima)
            {
                return pedido.Itens.Sum(item => item.Subtotal()) * _percentual;
            }

            return 0;
        }
    }
}