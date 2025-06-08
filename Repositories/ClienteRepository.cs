using System.Collections.Generic;
using System.Linq;
using ProvaPraticaPOO.Classes;
using ProvaPraticaPOO.Repositories.Interfaces;

namespace ProvaPraticaPOO.Repositories
{
    public class ClienteRepository : IRepository<Cliente>
    {
        private readonly List<Cliente> _clientes = new List<Cliente>();

        public void Adicionar(Cliente cliente)
        {
            _clientes.Add(cliente);
        }

        public Cliente ObterPorId(int id)
        {
            return _clientes.FirstOrDefault(c => c.Id == id);
        }

        public List<Cliente> ObterTodos()
        {
            return _clientes;
        }
    }
}
