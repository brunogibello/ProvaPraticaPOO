namespace ProvaPraticaPOO.Classes
{
    public interface IPedidoFactory
    {
        Pedido CriarPedido(int id, Cliente cliente, List<ItemPedido> itens);
    }
}