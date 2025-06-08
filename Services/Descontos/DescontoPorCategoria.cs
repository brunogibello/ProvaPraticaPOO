namespace ProvaPraticaPOO.Services.Descontos
{
    using ProvaPraticaPOO.Classes;
    using System.Linq;

    public class DescontoPorCategoria : IDescontoStrategy
    {
        private string categoriaAlvo;
        private decimal percentualDesconto;

        public DescontoPorCategoria(string categoriaAlvo, decimal percentualDesconto)
        {
            this.categoriaAlvo = categoriaAlvo;
            this.percentualDesconto = percentualDesconto;
        }

        public decimal CalcularDesconto(Pedido pedido)
        {
            var totalCategoria = pedido.Itens
                .Where(item => item.Produto.Categoria == categoriaAlvo)
                .Sum(item => item.Subtotal());

            return totalCategoria * percentualDesconto;
        }
    }
}