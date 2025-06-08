using ProvaPraticaPOO.Classes;
using ProvaPraticaPOO.Services;
using ProvaPraticaPOO.Services.Descontos;
using ProvaPraticaPOO.Logging;
using ProvaPraticaPOO.Factories;

class Program
{
    static void Main(string[] args)
    {
        var cliente = new Cliente(1, "Maria", "maria@email.com", "123.456.789-00");
        var cliente2 = new Cliente(2, "João", "joao@email.com", "987.654.321-00");

        var produto1 = new Produto(1, "Camisa", 100m, "Roupas");
        var produto2 = new Produto(2, "Calça", 200m, "Roupas");
        var produto3 = new Produto(3, "Caderno", 50m, "Papelaria");
        var produto4 = new Produto(4, "Livro", 60m, "Papelaria");
        var produto5 = new Produto(5, "Mochila", 120m, "Acessórios");

        var itens = new List<ItemPedido>
        {
            new ItemPedido(produto1, 1),
            new ItemPedido(produto2, 1),
            new ItemPedido(produto3, 2)
        };

        var itens2 = new List<ItemPedido>
        {
            new ItemPedido(produto4, 3),
            new ItemPedido(produto5, 1)
        };

        //factory
        IPedidoFactory factory = new PedidoFactory();
        var pedido = factory.CriarPedido(1, cliente, itens);
        var pedido2 = factory.CriarPedido(2, cliente2, itens2);

        //desconto
        var desconto = new DescontoPorCategoria("Roupas", 0.10m);
        var desconto2 = new DescontoPorQuantidade(3, 0.05m);
        //log
        ILogService logger = new ConsoleLogService();

        var pedidoService = new PedidoService(desconto, logger);
        pedidoService.ProcessarPedido(pedido);
        var pedidoService2 = new PedidoService(desconto2, logger);
        pedidoService2.ProcessarPedido(pedido2);

        Console.WriteLine($"Valor total com desconto: R$ {pedido.ValorTotal:F2}");

        //criando lista de pedidos
        var pedidos = new List<Pedido> { pedido };

        //exibindo relatório
        var relatorio = new RelatorioService(logger);
        relatorio.ExibirRelatorio(pedidos);
        
        pedidos.Add(pedido2);
        relatorio.ExibirRelatorio(pedidos);
    }
    


}

