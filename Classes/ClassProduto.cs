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
            Id = id;
            Nome = nome;
            Preco = preco;
            Categoria = categoria;
        }
    }
}