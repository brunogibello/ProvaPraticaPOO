using ProvaPraticaPOO.Classes;

namespace ProvaPraticaPOO.Factories
{
    public interface IPedidoFactory
    {
        Pedido CriarPedido(int id, Cliente cliente, List<ItemPedido> itens);
    }
}