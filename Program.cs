using ProvaPraticaPOO.Classes;
using ProvaPraticaPOO.Services;
using ProvaPraticaPOO.Services.Descontos;

class Program
{
    static void Main(string[] args)
    {
         var cliente = new Cliente(1, "Maria", "maria@email.com", "123.456.789-00");

        var produto1 = new Produto(1, "Camisa", 100m, "Roupas");
        var produto2 = new Produto(2, "Calça", 200m, "Roupas");
        var produto3 = new Produto(3, "Caderno", 50m, "Papelaria");

        var itens = new List<ItemPedido>
        {
            new ItemPedido(produto1, 1),
            new ItemPedido(produto2, 1),
            new ItemPedido(produto3, 2)
        };

        //factory
        IPedidoFactory factory = new PedidoFactory();
        var pedido = factory.CriarPedido(1, cliente, itens);

        //desconto
        var desconto = new DescontoPorCategoria("Roupas", 0.10m);
        var pedidoService = new PedidoService(desconto);

        pedidoService.ProcessarPedido(pedido);

        Console.WriteLine($"Valor total com desconto: R$ {pedido.ValorTotal:F2}");
    }
}

