namespace ProvaPraticaPOO.Classes
{
      public class Produto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public decimal Preco { get; set; }
        public string Categoria { get; set; }

        public Produto(int id, string nome, decimal preco, string categoria)
        {
             if (string.IsNullOrWhiteSpace(nome))
                throw new ArgumentException("Nome do produto é obrigatório.");

            if (preco <= 0)
                throw new ArgumentException("Preço do produto deve ser maior que zero.");

            if (string.IsNullOrWhiteSpace(categoria))
                throw new ArgumentException("Categoria é obrigatória.");

            Id = id;
            Nome = nome;
            Preco = preco;
            Categoria = categoria;
        }
    }
}