    public class Pedido
    {
        public int Id { get; set; }
        public Cliente Cliente { get; set; }
        public List<ItemPedido> Itens { get; set; }
        public DateTime Data { get; set; }
        public decimal ValorTotal { get; set; }

        public Pedido(int id, Cliente cliente, List<ItemPedido> itens, DateTime data)
        {
            Id = id;
            Cliente = cliente;
            Itens = itens;
            Data = data;
            ValorTotal = 0;
        }
    }
