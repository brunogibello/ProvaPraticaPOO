 public class ItemPedido
    {
        public Produto Produto { get; set; }
        public int Quantidade { get; set; }

        public ItemPedido(Produto produto, int quantidade)
        {

            if (quantidade <= 0)
                throw new ArgumentException("Quantidade deve ser maior que zero.");

            Produto = produto ?? throw new ArgumentNullException(nameof(produto));
            Quantidade = quantidade;

            Produto = produto;
            Quantidade = quantidade;
        }

        public decimal Subtotal()
        {
            return Produto.Preco * Quantidade;
        }
    }
