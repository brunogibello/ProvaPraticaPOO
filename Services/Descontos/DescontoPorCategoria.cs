namespace ProvaPraticaPOO.Services.Descontos
{
    using ProvaPraticaPOO.Classes;
    using System.Linq;

    public class DescontoPorCategoria : IDescontoStrategy
    {
        private readonly string _categoriaAlvo;
        private readonly decimal _percentual;


        public DescontoPorCategoria(string categoriaAlvo, decimal percentual)
        {
            _categoriaAlvo = categoriaAlvo;
            _percentual = percentual;
        }

        public decimal CalcularDesconto(Pedido pedido)
        {
            var totalCategoria = pedido.Itens
                .Where(item => item.Produto.Categoria == _categoriaAlvo)
                .Sum(item => item.Subtotal());

            return totalCategoria * _percentual;
        }
    }
}