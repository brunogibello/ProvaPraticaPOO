using System.Collections.Generic;
using System.Linq;
using ProvaPraticaPOO.Classes;
using ProvaPraticaPOO.Repositories.Interfaces;

namespace ProvaPraticaPOO.Repositories
{
    public class ProdutoRepository : IRepository<Produto>
    {
        private readonly List<Produto> _produtos = new List<Produto>();

        public void Adicionar(Produto produto)
        {
            _produtos.Add(produto);
        }

        public Produto ObterPorId(int id)
        {
            return _produtos.FirstOrDefault(p => p.Id == id);
        }

        public List<Produto> ObterTodos()
        {
            return _produtos;
        }
    }
}